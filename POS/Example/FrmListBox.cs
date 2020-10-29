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
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
        }

        private void FrmListBox_Load(object sender, EventArgs e)
        {
            lstProducts.Items.Add("Banana");
            lstProducts.Items.Add("Pera");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lstProducts.Items.Add(txtProduct.Text);
            txtProduct.Text = "";
        }

        private void LstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                lblSelected.Text = lstProducts.SelectedItem.ToString();
            }
            else
            {
                lblSelected.Text = "";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                lstProducts.Items.RemoveAt(lstProducts.SelectedIndex);
            }
        }
    }
}
