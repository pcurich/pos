using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Example
{
    public partial class FrmHelpProvider : Form
    {
        public FrmHelpProvider()
        {
            InitializeComponent();
        }

        private void FrmHelpProvider_Load(object sender, EventArgs e)
        {
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            lblData.Text = txtData.Text;
        }

        private void TxtData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblData.Text = "Caracter invalido";
        }
    }
}
