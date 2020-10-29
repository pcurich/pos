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
    public partial class FrmImageList : Form
    {
        int index = 0;
        public FrmImageList()
        {
            InitializeComponent();
            index = 0;
        }

        private void FrmImageList_Load(object sender, EventArgs e)
        {
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            imgList.ImageSize = new Size(256, 256); //limite 

            for (int i=1; i<6;i++)
            {
                imgList.Images.Add(Image.FromFile(i + ".png")); 
            }

            lblPhoto.AutoSize = false;
            lblPhoto.Size = new Size(256, 256); //limite
            lblPhoto.ImageList = imgList;

            picPhoto.Image = Image.FromFile("1.png");
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            lblPhoto.ImageIndex = index;

            picPhoto.Image = imgList.Images[index];

            index++;
            if (index > imgList.Images.Count)
            {
                index = 0;
            }
            
        }
    }
}
