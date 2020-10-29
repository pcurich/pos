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
    public partial class FrmDataGridView : Form
    {
        int index = 0;
        public FrmDataGridView()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var n = dgvProducts.Rows.Add();

            dgvProducts.Rows[n].Cells[0].Value = txtCode.Text;
            dgvProducts.Rows[n].Cells[1].Value = txtName.Text;
            dgvProducts.Rows[n].Cells[2].Value = txtPrice.Text;

            txtCode.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }

        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index != -1)
            {
                lblInfo.Text = dgvProducts.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                dgvProducts.Rows.RemoveAt(index);
            }
        }
    }
}
