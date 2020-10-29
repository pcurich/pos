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
    public partial class FrmFileDialog : Form
    {
        public FrmFileDialog()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblFile.Text = openFileDialog.FileName;
            }
        }

        private void FrmFileDialog_Load(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Archivos PNG (.png)|*.png|Archivos de texto (.txt)|*.txt";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblFile.Text = saveFileDialog.FileName;
            }
        }
    }
}
