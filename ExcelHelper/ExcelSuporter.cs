using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Data;

namespace ExcelHelper
{
    public static class ExcelSuporter
    {
        public static System.Data.DataTable readExcel()
        {
            string connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=YES\";", @"C:\testData.xlsx");

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    //while (dr.Read())
                    //{
                    //    var row1Col0 = dr[0];
                    //    Console.WriteLine(row1Col0);
                    //}
                    System.Data.DataTable firstTable = new System.Data.DataTable();
                    firstTable.Load(dr);
                    return firstTable;
                }
            }
        }
    }
}
