﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace exercise1.Factory
{
    public class OleDbFactory : DatabaseFactory
    {
        public override DbCommand CreateCommand()
        {
            return new OleDbCommand();
        }

        public override DbCommand CreateCommand(string cmdText)
        {
            return new OleDbCommand(cmdText);
        }

        public override DbCommand CreateCommand(string cmdText, DbConnection cn)
        {
            return new OleDbCommand(cmdText,(OleDbConnection) cn);
        }

        public override DbConnection CreateConnection()
        {
            return new OleDbConnection();
        }

        public override DbConnection CreateConnection(string cnString)
        {
            return new OleDbConnection(cnString);
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new OleDbDataAdapter();
        }

        public override DbDataAdapter CreateDataAdapter(DbCommand selectCmd)
        {
            return new OleDbDataAdapter((OleDbCommand)selectCmd);
        }

        public override DbDataReader CreateDataReader(DbCommand dbCmd)
        {
            return dbCmd.ExecuteReader();
        }

        public override DbParameter CreateParameter(string name, object value)
        {
            return new OleDbParameter(name, value);
        }
    }
}