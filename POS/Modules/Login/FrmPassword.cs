using POS.Connections;
using POS.Modules.Cash;
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
                    FrmOpen cashOpen = new FrmOpen();
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

        private void BtnForgot_Click(object sender, EventArgs e)
        {
            var form = new FrmRecovery();
            form.ShowDialog();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var length = 0;
                if (!"".Equals(txtPassword.Text))
                {
                    length = txtPassword.Text.Length;
                    txtPassword.Text = txtPassword.Text.Substring(0, length - 1);
                }
            }
            catch
            {

            }
        }

        private void TsmiShow_Click(object sender, EventArgs e)
        {
            ChangePasswordChart(false, true);
        }

        private void TsmiHidden_Click(object sender, EventArgs e)
        {
            ChangePasswordChart(true,false);
        }

        private void ChangePasswordChart(bool show, bool hidden)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            tsmiShow.Visible = show;
            tsmiHidden.Visible = hidden;
        }
    }
}
