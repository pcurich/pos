using POS.Connections;
using POS.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Modules.Product
{
    public partial class FrmGroups : Form
    {
        public FrmGroups()
        {
            InitializeComponent();
        }



        private void ShowData()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();

                da = new SqlDataAdapter("mostrar_grupos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscar", txtSearch.Text);
                da.Fill(dt);
                dataGV.DataSource = dt;
                con.Close(); 
                dataGV.Columns[2].Visible = false;
                dataGV.Columns[3].Width = 500;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataTableHelper.MultiLine(ref dataGV);
        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex < 2)
            {
                var idGroup = dataGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (e.ColumnIndex == 0)
                {
                    //ADD
                }
                if (e.ColumnIndex == 1)
                {
                    //DELETE
                }
            }
                

            //dataGV.SelectedCells[2].Value.ToString();
            //dataGV.SelectedCells[3].Value.ToString();

        }

        private void FrmGroups_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
