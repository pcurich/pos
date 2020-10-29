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
    public partial class FrmDateTime : Form
    {
        public FrmDateTime()
        {
            InitializeComponent(); 
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            var dt = new DateTime(2020,04,05);
            lblDate.Text = dt.ToString();
            lblDate.Text += "\n";
            lblDate.Text += DateTime.Today;
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dtp.Value.ToString();
        }

        private void FrmDateTime_Load(object sender, EventArgs e)
        {
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd-yyyy-mm";
        }
    }
}
