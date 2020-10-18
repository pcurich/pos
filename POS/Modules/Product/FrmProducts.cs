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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void TsmSaveGroup_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_Grupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Grupo", txtGroup.Text);
                cmd.Parameters.AddWithValue("@Por_defecto", "NO");
                cmd.ExecuteNonQuery();
                con.Close();
                ShowGroup();

                //lblIdGrupo.Text = datalistadoGrupos.SelectedCells[2].Value.ToString();
                //txtgrupo.Text = datalistadoGrupos.SelectedCells[3].Value.ToString();

                //PanelGRUPOSSELECT.Visible = false;
                //btnGuardar_grupo.Visible = false;
                //BtnGuardarCambios.Visible = false;
                //BtnCancelar.Visible = false;
                //btnNuevoGrupo.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void ShowGroup()
        {
            //PanelGRUPOSSELECT.Visible = true;
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();

                da = new SqlDataAdapter("mostrar_grupos", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscar", txtGroup.Text);
                da.Fill(dt);
                //datalistadoGrupos.DataSource = dt;
                con.Close();

                //datalistadoGrupos.DataSource = dt;
                //datalistadoGrupos.Columns[2].Visible = false;
                //datalistadoGrupos.Columns[3].Width = 500;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //DataTableHelper.MultiLine(ref datalistado);
        }

        private void TsmiAdd_Click(object sender, EventArgs e)
        {
            if (!"".Equals(txtGroup.Text))
            {
                AddNewGroup();
            }
            else
            {
                MessageBox.Show("Ingrese el valor del grupo para poderlo crear", "Advertencia al crear el grupo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Util

        private void AddNewGroup()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Master.DB;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_Grupo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Grupo", txtGroup.Text);
                cmd.Parameters.AddWithValue("@Por_defecto", "NO");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Grupo creado correctamente", "Creación de grupo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TsmiView_Click(object sender, EventArgs e)
        {
            var form = new FrmGroups();
            form.ShowDialog();
        }

        #endregion


    }
}
