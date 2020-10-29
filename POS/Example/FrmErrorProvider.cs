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
    public partial class FrmErrorProvider : Form
    {
        public FrmErrorProvider()
        {
            InitializeComponent();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            CheckError();
        }

        void CheckError()
        {
            bool error = false;

            foreach (char caracter in txtData.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }

            if (error)
            {
                err.SetError(txtData, " No se admite numeros");
            }
            else
            {
                err.Clear();
            }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            CheckError();
        }
    }
}
