using Microsoft.SqlServer.Server;
using POS.Connections;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

namespace POS.Utils
{
    public class DataTableHelper
    {
        public static void MultiLine(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //List.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            List.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            styCabeceras.BackColor = System.Drawing.Color.White;
            styCabeceras.ForeColor = System.Drawing.Color.Black;
            styCabeceras.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = styCabeceras;
        }

        public static DataTable LoadData()
        {
            var dt = new DataTable();
            SqlDataAdapter da;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Master.DB;
            con.Open();

            da = new SqlDataAdapter("select top 10 descripcion from producto1", con);
            da.Fill(dt);
            return dt;
        }

        public static AutoCompleteStringCollection LoadAutoComplete()
        {
            var dt = LoadData();
            var data = new AutoCompleteStringCollection();

            foreach(DataRow row in dt.Rows)
            {
                data.Add(Convert.ToString(row["descripcion"]));
            }
            return data ;

        }
    }
}
