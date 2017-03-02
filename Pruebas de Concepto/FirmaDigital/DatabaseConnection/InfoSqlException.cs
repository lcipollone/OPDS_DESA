using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace DBLayer
{
    public class InfoSqlException: Exception
    {
        public InfoSqlException(string message)
            : base(message.Replace("50000 = ", ""))
        {
        }
    }
}
