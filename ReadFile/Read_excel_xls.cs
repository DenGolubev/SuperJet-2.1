using System;
using System.Data;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using SuperJet_2._1.Forms;

namespace SuperJet_2._1.ReadFile
{
    class Read_excel_xls
    {
        private static OleDbConnection con_xls = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileDownload.FilePath + "Extended Properties='Excel 8.0;HDR=Yes;'");
        private static OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select * from [TaskList$]", con_xls);
        private static OleDbCommand command = new OleDbCommand();
        //private static OleDbDataReader dataReader = command.ExecuteReader();
        private static System.Data.DataTable dataTable = new System.Data.DataTable();
        
        public static void Read_excel()
        {
            con_xls.Open();
            dataAdapter.Fill(dataTable);
            


        }
        
    }
}
