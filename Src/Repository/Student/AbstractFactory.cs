using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Repository.Student
{
    /// <summary>
    /// MSSQL 的 具体工厂
    /// </summary>
    public class MSSQLDbProviderFactory : System.Data.Common.DbProviderFactory
    {
        static readonly string sqlConn = "数据库连接字符串";

        public override DbConnection CreateConnection()
        {
            return new SqlConnection(sqlConn);
        }

        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public override DbParameter CreateParameter()
        {
            return new SqlParameter();
        }
    }
}