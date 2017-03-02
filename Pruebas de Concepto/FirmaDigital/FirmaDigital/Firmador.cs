using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDigital
{
    static class Firmador
    {
        internal static bool ChequearFirma(string pLogUsuario, string pIdTramite)
        {
            SqlParameter[] parameters = DatabaseConnection.SetearParametros(new DatabaseParameter("LogUsuario", pLogUsuario.GetType(), pLogUsuario, System.Data.ParameterDirection.Input),
                                                                            new DatabaseParameter("IdTramite", pIdTramite.GetType(), pIdTramite, System.Data.ParameterDirection.Input));
            int result = DatabaseConnection.ExecuteSP("ChequearFirma", ref parameters);
            return result == 1;
        }

        internal static void IniciarFirma(string pLogUsuario, string pIdTramite)
        {
            SqlParameter[] parameters = DatabaseConnection.SetearParametros(new DatabaseParameter("LogUsuario", pLogUsuario.GetType(), pLogUsuario, System.Data.ParameterDirection.Input),
                                                                            new DatabaseParameter("IdTramite", pIdTramite.GetType(), pIdTramite, System.Data.ParameterDirection.Input));
            int result = DatabaseConnection.ExecuteSP("IniciarFirma", ref parameters);
        }

        internal static void ConfirmarFirma(string pLogUsuario, string pIdTramite)
        {
            SqlParameter[] parameters = DatabaseConnection.SetearParametros(new DatabaseParameter("LogUsuario", pLogUsuario.GetType(), pLogUsuario, System.Data.ParameterDirection.Input),
                                                                            new DatabaseParameter("IdTramite", pIdTramite.GetType(), pIdTramite, System.Data.ParameterDirection.Input));
            int result = DatabaseConnection.ExecuteSP("ConfirmarFirma", ref parameters);
        }
    }
}
