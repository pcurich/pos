using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Example
{
    public partial class FrmListView : Form
    {
        ListViewGroup fruits = new ListViewGroup("fruits", HorizontalAlignment.Left);
        ListViewGroup protein = new ListViewGroup("protein", HorizontalAlignment.Left);

        public FrmListView()
        {
            InitializeComponent();
        }

        private void FrmListView_Load(object sender, EventArgs e)
        {
            lwProducts.View = View.SmallIcon;

            //creamos un imagenList
            var imgList = new ImageList();
            imgList.ImageSize = new Size(150,150);

            //cargar imagenes

            var files = Directory.GetFiles(Directory.GetCurrentDirectory(),"*.png");

            try
            {
                foreach (var file in files)
                {
                    imgList.Images.Add(Image.FromFile(file));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

            lwProducts.SmallImageList = imgList;
            lwProducts.View = View.SmallIcon;

            lwProducts.Items.Add(new ListViewItem("Manzana", 0, fruits));
            lwProducts.Items.Add(new ListViewItem("Platano", 1, fruits));
            lwProducts.Items.Add(new ListViewItem("Melon", 2, fruits));
            lwProducts.Items.Add(new ListViewItem("Papaya", 3,  fruits));

            lwProducts.Items.Add(new ListViewItem("Pollo", protein));
            lwProducts.Items.Add(new ListViewItem("Pavo", protein));
            lwProducts.Items.Add(new ListViewItem("Pezcado", protein));
            lwProducts.Items.Add(new ListViewItem("Chancho", protein));

            lwProducts.Groups.Add(fruits);
            lwProducts.Groups.Add(protein);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (rdbFruits.Checked)
            {
                lwProducts.Items.Add(new ListViewItem(txtElement.Text, fruits));
                rdbFruits.Checked = false;
            }
            if (rdbProtein.Checked)
            {
                lwProducts.Items.Add(new ListViewItem(txtElement.Text, protein));
                rdbProtein.Checked = false;
            }

            txtElement.Text = "";
        }

        private void LwProducts_MouseClick(object sender, MouseEventArgs e)
        {
            lblSelected.Text = lwProducts.SelectedItems[0].SubItems[0].Text;
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            lwProducts.Items.Clear();
            lblSelected.Text = "";
            txtElement.Text = "";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            lwProducts.SelectedItems[0].SubItems[0].Text = txtElement.Text;
            lwProducts.SelectedItems[0].ImageIndex = int.Parse(txtIndex.Text);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lwProducts.Items.RemoveAt(lwProducts.SelectedIndices[0]);
        }
    }
}
