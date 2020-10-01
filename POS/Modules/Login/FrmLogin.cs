using POS.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Modules.Login
{
    public partial class FrmLogin : Form
    {
        string _serialMachine = "";
        string _idCash = "";
        string _cash = "";

        DataGridView data = null;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public void GetUsers()
        {
            SqlConnection con = new SqlConnection
            {
                ConnectionString = Master.DB
            };
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from USUARIO2 WHERE Estado = 'ACTIVO'", con);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Label _label = new Label();
                Panel _panel = new Panel();
                PictureBox _picture = new PictureBox();

                _label.Text = rdr["Login"].ToString();
                _label.Name = rdr["idUsuario"].ToString();
                _label.Size = new Size(150, 20);
                _label.Font = new Font("Microsoft Sans Serif", 13);
                _label.BackColor = Color.Black;
                _label.ForeColor = Color.White;
                _label.Dock = DockStyle.Bottom;
                _label.TextAlign = ContentAlignment.TopCenter;
                _label.Cursor = Cursors.Hand;

                _panel.Size = new Size(150, 220);
                _panel.BorderStyle = BorderStyle.None;
                _panel.BackColor = Color.Black;
                
                _picture.Dock = DockStyle.Top;
                _picture.BackgroundImage = null;
                byte[] bi = (byte[])rdr["Icono"];

                MemoryStream ms = new MemoryStream(bi);
                _picture.Image = Image.FromStream(ms);
                _picture.SizeMode = PictureBoxSizeMode.Zoom;
                _picture.Tag = rdr["Login"].ToString();
                _picture.Cursor = Cursors.Hand;
                _picture.Size = new Size(150, 200);

                _panel.Controls.Add(_label);
                _panel.Controls.Add(_picture);
                _label.BringToFront();
                flowLayoutPanel1.Controls.Add(_panel);

                _label.Click += new EventHandler(EventLabel);
                _picture.Click += new EventHandler(EventImagen);
            }
            con.Close();


        }

        private void EventImagen(object sender, EventArgs e)
        {
            var formPassword = new FrmPassword
            {
                user = ((PictureBox)sender).Tag.ToString(),
                _serialMachine = _serialMachine
            };
            //lblLogin.Text = ((PictureBox)sender).Tag.ToString();
            Hide();
            formPassword.ShowDialog();
            Close();
            //flpKeyBoard.Visible = true;
            //pnlBodySelected.Visible = false;
            //MOSTRAR_PERMISOS();
        }

        private void EventLabel(object sender, EventArgs e)
        {
            var formPassword = new FrmPassword
            {
                user = ((Label)sender).Text,
                _serialMachine = _serialMachine
            };
            Hide();
            formPassword.ShowDialog();
            Close();
            //lblLogin.Text = ((Label)sender).Text;
            //flpKeyBoard.Visible = true;
            //pnlBodySelected.Visible = false;
            //MOSTRAR_PERMISOS();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            GetUsers();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            try
            {
                ManagementObjectSearcher management = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
                foreach (ManagementObject getserial in management.Get())
                {
                    _serialMachine = getserial.Properties["SerialNumber"].Value.ToString();
                    ShowCashBySerial(); 
                    try
                    {
                        _idCash= data.SelectedCells[1].Value.ToString();
                        _cash= data.SelectedCells[2].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowCashBySerial()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();

                da = new SqlDataAdapter("mostrar_cajas_por_Serial_de_DiscoDuro", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Serial", _serialMachine);
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

    }
}
