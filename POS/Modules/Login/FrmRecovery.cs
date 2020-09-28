using POS.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Modules.Login
{
    public partial class FrmRecovery : Form
    {
        private string _password = "";

        public FrmRecovery()
        {
            InitializeComponent();
            LoadEmails();
        }

        #region Utils
        private void LoadEmails()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();

                da = new SqlDataAdapter("select Correo from USUARIO2 where Estado='ACTIVO'", con);

                da.Fill(dt);
                cmbEmails.DisplayMember = "Correo";
                cmbEmails.ValueMember = "Correo";
                cmbEmails.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ShowUserByEmail()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                SqlCommand da = new SqlCommand("buscar_USUARIO_por_correo", con);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@correo", cmbEmails.Text);

                con.Open();
                _password = Convert.ToString(da.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        internal void SendEmail(string emisor, string password, string mensaje, string asunto, string destinatario, string ruta)
        {
            try
            {
                MailMessage correos = new MailMessage();
                SmtpClient envios = new SmtpClient();
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add((destinatario));
                correos.From = new MailAddress(emisor);
                envios.Credentials = new NetworkCredential(emisor, password);

                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;

                envios.Send(correos); 
                MessageBox.Show("Contraseña Enviada, revisa tu correo Electronico", "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, revisa tu correo Electronico", "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion

        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            ShowUserByEmail();
            richTemplate.Text = richTemplate.Text.Replace("@pass", _password);
            SendEmail("ada369.technical@gmail.com", "MAGbri2019", richTemplate.Text, "Solicitud de Contraseña", richTemplate.Text, "");
        }
    }
}
