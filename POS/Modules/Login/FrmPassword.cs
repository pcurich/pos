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
        public string _serialMachine = "";
        string _idCash = "";
        string _cash = "";

        DataGridView data = null;

        public FrmPassword()
        {
            InitializeComponent();
        } 

        private void KeyPanel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtPassword.Text + ((Button)sender).Tag;
        }

        private void OpenDetailsCash()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_DETALLE_cierre_de_caja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechaini", DateTime.Today);
                cmd.Parameters.AddWithValue("@fechafin", DateTime.Today);
                cmd.Parameters.AddWithValue("@fechacierre", DateTime.Today);
                cmd.Parameters.AddWithValue("@ingresos", "0.00");
                cmd.Parameters.AddWithValue("@egresos", "0.00");
                cmd.Parameters.AddWithValue("@saldo", "0.00");
                cmd.Parameters.AddWithValue("@idusuario", user);
                cmd.Parameters.AddWithValue("@totalcaluclado", "0.00");
                cmd.Parameters.AddWithValue("@totalreal", "0.00");

                cmd.Parameters.AddWithValue("@estado", "CAJA APERTURADA");
                cmd.Parameters.AddWithValue("@diferencia", "0.00");
                cmd.Parameters.AddWithValue("@id_caja", _cash);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                data = new DataGridView
                {
                    DataSource = dt
                };
                con.Close();

                if (data.Rows.Count > 0)
                {
                    ShowMovementsBySerial();
                    if (data.Rows.Count == 0 )
                    {
                        OpenDetailsCash();

                        FrmOpen cashOpen = new FrmOpen();
                        Hide();
                        cashOpen.ShowDialog();
                        Close();
                    }
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

        private void ShowMovementsBySerial()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();

                da = new SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", _serialMachine);
                da.Fill(dt);
                data = new DataGridView
                {
                    DataSource = dt
                };
                con.Close(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ShowMovementsBySerialAndUser()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();

                da = new SqlDataAdapter("MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@serial", _serialMachine);
                da.SelectCommand.Parameters.AddWithValue("@idusuario", user);
                da.Fill(dt);
                data = new DataGridView();
                data.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
    }
}
