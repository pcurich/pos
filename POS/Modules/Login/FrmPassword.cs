using POS.Connections;
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

namespace POS.Modules.Login
{
    public partial class FrmPassword : Form
    {
        public string user;

        public FrmPassword()
        {
            InitializeComponent();
        } 

        private void KeyPanel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + ((Button)sender).Tag;
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();

                da = new SqlDataAdapter("validar_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@password", txtPassword.Text);
                da.SelectCommand.Parameters.AddWithValue("@login", user);
                da.Fill(dt);
                //dataUsers.DataSource = dt;
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    CashOpen cashOpen = new CashOpen();
                    Hide();
                    cashOpen.ShowDialog();
                    Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
