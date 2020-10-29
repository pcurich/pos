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
    public partial class FrmTimer : Form
    {
        int count = 0;
        public FrmTimer()
        {
            InitializeComponent();
            count = 0;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            count++;
            blbCount.Text = count.ToString();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            tmr.Enabled = true;
        }

        private void FrmTimer_Load(object sender, EventArgs e)
        {
            tmr.Enabled = false;
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            tmr.Enabled = false;
            trbInterval.Value = trbInterval.Minimum;
        }

        private void FrmTimer_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmr.Enabled = false;
        }

        private void TrbInterval_Scroll(object sender, EventArgs e)
        {
            tmr.Interval = trbInterval.Value;
        }
    }
}
