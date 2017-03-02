using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DBLayer
{
    public static class DatabaseConnection
    {
        private static InfoSqlException _sqlInfoEx;

        public static string GetClientDatabaseConnection() 
        {
            try
            {
                return ConfigurationManager.ConnectionStrings["ClientDB"].ConnectionString.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectar a la base de datos:" + Environment.NewLine + ex.InnerException);
            }
        }

        public static DataSet GetRecordSet(string pStoredProcedure, SqlParameter[] pParameters, string pConnectionString = "")
        {
            DataSet ds = new DataSet();
            SqlDataAdapter dr = null;

            try
            {
                using ( SqlConnection pConnection = new SqlConnection(pConnectionString == "" ? GetClientDatabaseConnection().ToString() : pConnectionString))
                {
                    SqlCommand cmd = null;
                    
                    pConnection.Open();
                    cmd = new SqlCommand(pStoredProcedure, pConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (pParameters != null)
                    {
                        cmd.Parameters.AddRange(pParameters);
                    }
                    dr = new SqlDataAdapter(cmd);
                    ds.Clear();
                    dr.Fill(ds, pStoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el Stored Procedure " + pStoredProcedure + ":" + Environment.NewLine + ex.Message + Environment.NewLine + ex.InnerException);
            }

            return ds;
        }

        public static DataSet GetDataSet(string pStoredProcedure, SqlParameter[] pParameters)
        {
            DataSet ds = new DataSet();
            SqlDataReader dr = null;

            try
            {
                using (SqlConnection pConnection = new SqlConnection(GetClientDatabaseConnection().ToString()))
                {
                    SqlCommand cmd = null;
                    DataTable dt = new DataTable();

                    pConnection.Open();
                    cmd = new SqlCommand(pStoredProcedure, pConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (pParameters != null)
                    {
                        cmd.Parameters.AddRange(pParameters);
                    }
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    dt.Load(dr);

                    ds.Tables.Add(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el Stored Procedure " + pStoredProcedure + ":" + Environment.NewLine + ex.InnerException);
            }

            return ds;
        }

        public static int ExecuteSP(string pStoredProcedure, ref SqlParameter[] pParameters)
        {
            int result = 0;

            try
            {
                using (SqlConnection pConnection = new SqlConnection(GetClientDatabaseConnection().ToString()))
                {
                    pConnection.InfoMessage += new SqlInfoMessageEventHandler(OnSqlInfoMessageEventHandler);

                    _sqlInfoEx = null;

                    SqlCommand cmd = new SqlCommand();
                    SqlParameter pResult = new SqlParameter("Return", -1);
                    pResult.Direction = System.Data.ParameterDirection.ReturnValue;
                    pConnection.Open();
                    cmd.Connection = pConnection;
                    cmd.Parameters.Add(pResult);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = pStoredProcedure;
                    cmd.Parameters.AddRange(pParameters);
                    result = cmd.ExecuteNonQuery();
                    result = Convert.ToInt32(cmd.Parameters["Return"].SqlValue.ToString());

                    //checking for exception
                    if (_sqlInfoEx != null)
                    {
                        throw _sqlInfoEx;
                    }
                }
            }
            catch (InfoSqlException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el Stored Procedure " + pStoredProcedure + ":" + Environment.NewLine + ex.Message);
            }
            return result;
        }

        private static void OnSqlInfoMessageEventHandler(object sender, SqlInfoMessageEventArgs e)
        {
            //checks for any errors.
            if (e.Errors.Count > 0)
            {
                StringBuilder _sbError = new StringBuilder();
                foreach (SqlError _error in e.Errors)
                {
                    _sbError.AppendLine(_error.Number.ToString() + " = " + _error.Message);
                }
                _sqlInfoEx = new InfoSqlException(_sbError.ToString());
            }
        }

        public static SqlParameter[] SetearParametros(params DatabaseParameter[] pParameters)
        {
            SqlParameter p;
            List<SqlParameter> colParams = new List<SqlParameter>();

            foreach (DatabaseParameter o in pParameters)
            {
                p = new SqlParameter(o.ParameterName, o.ParameterValue);
                if (o.ParameterDirection != System.Data.ParameterDirection.Input && o.ParameterType.GetType() == SqlDbType.VarChar.GetType())
                {
                    p.Size = 1024;
                }
                p.Direction = o.ParameterDirection;             
                colParams.Add(p);
            }

            return colParams.ToArray();
        }
    }
}
