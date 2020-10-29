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
    public partial class FrmPictureBox : Form
    {
        public FrmPictureBox()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var img = Image.FromFile("qr-code.png");
            picImagen.Image = img;
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
