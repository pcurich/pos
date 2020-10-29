using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Example
{
    public partial class FrmComboBox : Form
    {
        public FrmComboBox()
        {
            InitializeComponent();
        }

        private void FrmComboBox_Load(object sender, EventArgs e)
        {
            cmbFood.Items.Add("Pescado");
            cmbFood.Items.Add("Carne");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            cmbFood.Items.Add(txtValue.Text);
            txtValue.Text = "";
        }

        private void CmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIndex.Text = ((ComboBox)sender).SelectedIndex.ToString();
            lblText.Text = ((ComboBox)sender).Items[((ComboBox)sender).SelectedIndex].ToString();
        }
    }
}
