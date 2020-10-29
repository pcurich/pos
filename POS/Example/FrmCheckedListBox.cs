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
    public partial class FrmCheckedListBox : Form
    {
        public FrmCheckedListBox()
        {
            InitializeComponent();
        }

        private void FrmCheckedListBox_Load(object sender, EventArgs e)
        {
            clbFood.CheckOnClick = true;
            clbFood.Items.Add("Pescado");
            clbFood.Items.Add("Carne",true);
            lblSelected.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            clbFood.Items.Add(txtValue.Text);
            txtValue.Text = "";
        }

        private void ClbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((CheckedListBox)sender).SelectedIndex;
            if (index > -1)
            {
                lblSelected.Text = lblSelected.Text + " " +clbFood.Items[index].ToString();
                lblSelected.Text = lblSelected.Text.Trim();
            }
            if (!((CheckedListBox)sender).GetItemChecked(index))
            {
                lblSelected.Text= lblSelected.Text.Replace(clbFood.Items[index].ToString(), "");
                lblSelected.Text = lblSelected.Text.Trim();
            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
