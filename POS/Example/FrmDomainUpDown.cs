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
    public partial class FrmDomainUpDown : Form
    {
        public FrmDomainUpDown()
        {
            InitializeComponent();
        }

        private void FrmDomainUpDown_Load(object sender, EventArgs e)
        {
            dudProducts.Items.Add("Melon");
            dudProducts.Items.Add("Manzana");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dudProducts.Items.Add(txtName.Text);
            txtName.Text = "";
        }

        private void dudProducts_SelectedItemChanged(object sender, EventArgs e)
        {
            lblSelected.Text = dudProducts.SelectedItem.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            dudProducts.Items.RemoveAt(dudProducts.SelectedIndex);
            dudProducts.SelectedIndex = 0;
        }
    }
}
