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
    public partial class FrmProgressBar : Form
    {
        int count = 0;
        public FrmProgressBar()
        {
            InitializeComponent();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (prb.Value<100)
            {
                count++;
                prb.Value = count;
            }
            if (prb.Value == 100) {
                tmr.Enabled = !tmr.Enabled; 
            }

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            tmr.Enabled = !tmr.Enabled;
            count = 0;
            prb.Value = count;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            tmr.Enabled = !tmr.Enabled;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<10000; i++)
            {
                //algo hace
                if (i % 1000 == 0)
                {
                    prb.PerformStep();
                }
            }
        }
    }
}
