using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using POS.Connections;
using System.IO;
using System.Text.RegularExpressions;
using POS.Utils;

namespace POS
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
         
        #region Imagen

        private void PibBarista_Click(object sender, EventArgs e)
        {
            pibAvatar.Image = pibBarista.Image;
            lblIconSelected.Text = "barista";
            flpAvatars.Visible = false;
            pnlUser.Visible = true;
            lblAvatar.Visible = false;
        }

        private void PibUser_Click(object sender, EventArgs e)
        {
            pibAvatar.Image = pibUser.Image;
            lblIconSelected.Text = "user";
            flpAvatars.Visible = false;
            pnlUser.Visible = true;
            lblAvatar.Visible = false;
        }

        private void PibAdmin_Click(object sender, EventArgs e)
        {
            pibAvatar.Image = pibAdmin.Image;
            lblIconSelected.Text = "admin";
            flpAvatars.Visible = false;
            pnlUser.Visible = true;
            lblAvatar.Visible = false;
        }

        private void PibCoder_Click(object sender, EventArgs e)
        {
            pibAvatar.Image = pibCoder.Image;
            lblIconSelected.Text = "coder";
            flpAvatars.Visible = false;
            pnlUser.Visible = true;
            lblAvatar.Visible = false;
        }

        private void LblAvatar_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = false;
            flpAvatars.Visible = true;

        }

        #endregion

        private void Users_Load(object sender, EventArgs e)
        {
            flpAvatars.Visible = false;
            pnlUser.Visible = false;
            pnlUser.Dock = DockStyle.Fill;
            flpAvatars.Dock = DockStyle.Fill;
            ShowDataSource();
            Clean();
        }

        private void PibAddUser_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = true;
            flpAvatars.Visible = false;
            dataUsers.Visible = false;
            tsmSave.Visible = true;
            tsmSaveChange.Visible = false;
            Clean();
        }

        #region Util

        private void ShowDataSource()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();

                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                dataUsers.DataSource = dt;
                con.Close();

                dataUsers.Columns[1].Visible = true;
                dataUsers.Columns[5].Visible = false;
                dataUsers.Columns[6].Visible = false;
                dataUsers.Columns[7].Visible = false;
                dataUsers.Columns[8].Visible = false;
                dataUsers.Visible = true;

                DataTableHelper.MultiLine(ref dataUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void Clean()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtUser.Text = "";
            cmbRol.Text = "";
            lblAvatar.Visible = true;
            pibAvatar.Image = null;
        }

        private bool IsEmailValid(string sMail)
        {
            return Regex.IsMatch(sMail, @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");
        }

        private void OnlyNumbers(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true; 
            }


        }

        private void LoadIconsState()
        {
            try
            {
                foreach (DataGridViewRow row in dataUsers.Rows)
                {
                    try
                    {

                        string Icono = Convert.ToString(row.Cells["Nombre_de_icono"].Value);

                        if (Icono == "coder")
                        {
                            pibCoder.Visible = false;
                        }
                        else if (Icono == "admin")
                        {
                            pibAdmin.Visible = false;
                        }
                        else if (Icono == "user")
                        {
                            pibCoder.Visible = false;
                        }
                        else if (Icono == "barista")
                        {
                            pibBarista.Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                    }


                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        private void DataUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dataUsers.SelectedCells[1].Value.ToString();
            txtName.Text = dataUsers.SelectedCells[2].Value.ToString();
            txtUser.Text = dataUsers.SelectedCells[3].Value.ToString();
            txtPassword.Text = dataUsers.SelectedCells[4].Value.ToString();

            pibAvatar.BackgroundImage = null;
            var b = (byte[])dataUsers.SelectedCells[5].Value;
            MemoryStream ms = new MemoryStream(b);
            pibAvatar.Image = Image.FromStream(ms);

            lblAvatar.Visible = false;

            lblIconSelected.Text = dataUsers.SelectedCells[6].Value.ToString();
            txtEmail.Text = dataUsers.SelectedCells[7].Value.ToString();
            cmbRol.Text = dataUsers.SelectedCells[8].Value.ToString();
            pnlUser.Visible = true;
            tsmSave.Visible = false;
            tsmSaveChange.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = false;
            dataUsers.Visible = true;
        }

        private void TsmSaveChange_Click(object sender, EventArgs e)
        {
            try
            {
                var con = new SqlConnection
                {
                    ConnectionString = Master.DB
                };
                con.Open();

                var cmd = new SqlCommand("editar_usuario", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@idUsuario", lblId.Text);
                cmd.Parameters.AddWithValue("@nombres", txtName.Text);
                cmd.Parameters.AddWithValue("@Login", txtUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                cmd.Parameters.AddWithValue("@Correo", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Rol", cmbRol.Text);
                var ms = new MemoryStream();
                pibAvatar.Image.Save(ms, pibAvatar.Image.RawFormat);


                cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer());
                cmd.Parameters.AddWithValue("@Nombre_de_icono", lblIconSelected.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                ShowDataSource();
                pnlUser.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void TsmSave_Click(object sender, EventArgs e)
        {

            if (IsEmailValid(txtEmail.Text) == false)
            {
                MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " + " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
            else
            {
                if (txtName.Text != "")
                {
                    try
                    {
                        var con = new SqlConnection
                        {
                            ConnectionString = Master.DB
                        };
                        con.Open();

                        var cmd = new SqlCommand("insertar_usuario", con)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.AddWithValue("@nombres", txtName.Text);
                        cmd.Parameters.AddWithValue("@Login", txtUser.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        cmd.Parameters.AddWithValue("@Correo", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Rol", cmbRol.Text);
                        var ms = new MemoryStream();
                        pibAvatar.Image.Save(ms, pibAvatar.Image.RawFormat);


                        cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer());
                        cmd.Parameters.AddWithValue("@Nombre_de_icono", lblIconSelected.Text);
                        cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ShowDataSource();
                        pnlUser.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            } 
        }

        private void PibAvatar_Click(object sender, EventArgs e)
        {
            LoadIconsState();
            flpAvatars.Visible = true;
            pnlUser.Visible = false;
            dataUsers.Visible = false;
            
        }

        private void DataUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataUsers.Columns["delete"].Index)
            {
                DialogResult result = MessageBox.Show("¿Realmente desea eliminar este Usuario?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in dataUsers.SelectedRows)
                        {

                            int onekey = Convert.ToInt32(row.Cells["idUsuario"].Value);
                            string usuario = Convert.ToString(row.Cells["Login"].Value);

                            try
                            { 
                                try
                                {
                                    SqlConnection con = new SqlConnection
                                    {
                                        ConnectionString = Master.DB
                                    };
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_usuario", con)
                                    {
                                        CommandType = CommandType.StoredProcedure
                                    };

                                    cmd.Parameters.AddWithValue("@idusuario", onekey);
                                    cmd.Parameters.AddWithValue("@login", usuario);
                                    cmd.ExecuteNonQuery();

                                    con.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }

                        }
                        ShowDataSource();
                    }

                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();

                da = new SqlDataAdapter("buscar_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtSearch.Text);
                da.Fill(dt);
                dataUsers.DataSource = dt;
                con.Close();

                dataUsers.Columns[1].Visible = false;
                dataUsers.Columns[5].Visible = false;
                dataUsers.Columns[6].Visible = false;
                dataUsers.Columns[7].Visible = false;
                dataUsers.Columns[8].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

            DataTableHelper.MultiLine(ref dataUsers);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }
    }
}
