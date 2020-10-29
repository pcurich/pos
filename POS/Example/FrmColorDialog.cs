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
    public partial class FrmColorDialog : Form
    {
        public FrmColorDialog()
        {
            InitializeComponent();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
           if (cd.ShowDialog() == DialogResult.OK)
           {
                lblMessage.ForeColor = cd.Color;
           }
        }

        private void FrmColorDialog_Load(object sender, EventArgs e)
        {
            cd.Color = Color.FromArgb(120, 54, 67);
        }
    }
}
