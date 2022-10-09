using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Db.Helper.Database
{
    public class DatabaseRepo : IDatabaseRepo
    {
        private readonly IConfiguration configuration;
        public DatabaseRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GetSchema(string objectName, DbObjectTypes dbObjectType = DbObjectTypes.Table)
        {
            string conStr = configuration.GetConnectionString("SqlDb");
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                DataTable databasesSchemaTable = con.GetSchema("Tables");


                foreach(DataRow dRow in databasesSchemaTable.Rows)
                {
                    string tblName = dRow["TABLE_NAME"]?.ToString();
                    String[] tableRestrictions = new String[4];
                    tableRestrictions[2] = "tblEmployees";
                    DataTable tblEmployeesSchema = con.GetSchema("Columns", tableRestrictions);
                }


                string test = "";
            }

            return "";
        }

        private static void ShowDataTable(DataTable table, Int32 length)
        {
            foreach (DataColumn col in table.Columns)
            {
                Console.Write("{0,-" + length + "}", col.ColumnName);
            }
            Console.WriteLine();

            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    if (col.DataType.Equals(typeof(DateTime)))
                        Console.Write("{0,-" + length + ":d}", row[col]);
                    else if (col.DataType.Equals(typeof(Decimal)))
                        Console.Write("{0,-" + length + ":C}", row[col]);
                    else
                        Console.Write("{0,-" + length + "}", row[col]);
                }
                Console.WriteLine();
            }
        }

        private static void ShowDataTable(DataTable table)
        {
            ShowDataTable(table, 14);
        }
    }
}
