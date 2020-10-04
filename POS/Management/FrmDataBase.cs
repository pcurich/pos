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
using System.Xml;

namespace POS.Management
{
    public partial class FrmDataBase : Form
    {
        private EncryptAes _encAES = new EncryptAes();
        string dbcnString;

        public FrmDataBase()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            SavetoXML(_encAES.Encrypt(txtData.Text, DecryptAes.appPwdUnique, int.Parse("256")));
            ShowData();
        }

        #region Util

        internal void SavetoXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }

        internal void ShowData()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection
                {
                    ConnectionString = Master.DB
                };
                con.Open();

                da = new SqlDataAdapter("mostrar_usuario", con);

                da.Fill(dt);
                dataList.DataSource = dt;
                con.Close();
                MessageBox.Show("Coneccion realizada correctamente", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sin conexion a la Base de datos", "Conexion fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            DataTableHelper.MultiLine(ref dataList);

        }

        internal void ReadfromXML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                txtData.Text = (_encAES.Decrypt(dbcnString, DecryptAes.appPwdUnique, int.Parse("256")));

            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {
            }
        }

        #endregion

        private void FrmDataBase_Load(object sender, EventArgs e)
        {
            ReadfromXML();
        }
    }
}
