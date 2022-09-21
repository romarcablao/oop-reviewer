using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace crud_app
{
    class Connection
    {
        protected OleDbConnection con = new OleDbConnection();
        protected OleDbCommand cmd = new OleDbCommand();
        protected OleDbDataReader reader;
        string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DICT\crud-app\database\crud-db.mdb";

        protected Connection()
        {
            con.ConnectionString = connectionString;
            cmd.Connection = con;
        }
 
    }
}
