using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DBLayer
{
    public class DatabaseParameter
    {
        public string ParameterName { get; set; }
        public Object ParameterType { get; set; }
        public Object ParameterValue { get; set; }
        public ParameterDirection ParameterDirection { get; set; }
        public int ParameterSize { get; set; }

        public DatabaseParameter(string pParameterName, Object pParameterType, Object pParameterValue, ParameterDirection pParameterDirection) {
            this.ParameterName = pParameterName;
            this.ParameterType = pParameterType;
            this.ParameterValue = pParameterValue;
            this.ParameterDirection = pParameterDirection;
        }

        public DatabaseParameter(string pParameterName, Object pParameterType, Object pParameterValue, ParameterDirection pParameterDirection, int pParameterSize)
        {
            this.ParameterName = pParameterName;
            this.ParameterType = pParameterType;
            this.ParameterValue = pParameterValue;
            this.ParameterDirection = pParameterDirection;
            this.ParameterSize = pParameterSize;
        }
    }
}
