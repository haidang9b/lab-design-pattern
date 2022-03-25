using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace exercise1.Factory
{
    public class MySQLDbFactory : DatabaseFactory
    {
        public override DbCommand CreateCommand()
        {
            return new MySqlCommand();
        }

        public override DbCommand CreateCommand(string cmdText)
        {
            return new MySqlCommand(cmdText);
        }

        public override DbCommand CreateCommand(string cmdText, DbConnection cn)
        {
            return new MySqlCommand(cmdText, (MySqlConnection)cn);
        }

        public override DbConnection CreateConnection()
        {

            return new MySqlConnection();
        }

        public override DbConnection CreateConnection(string cnString)
        {
            return new MySqlConnection(cnString);
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new MySqlDataAdapter();
        }

        public override DbDataAdapter CreateDataAdapter(DbCommand selectCmd)
        {
            return new MySqlDataAdapter((MySqlCommand)selectCmd);
        }

        public override DbDataReader CreateDataReader(DbCommand dbCmd)
        {
            return dbCmd.ExecuteReader();
        }

        public override DbParameter CreateParameter(string name, object value)
        {
            return new MySqlParameter(name, value);
        }
    }
}