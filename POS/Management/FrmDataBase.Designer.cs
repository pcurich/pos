namespace POS.Management
{
    partial class FrmDataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataBase));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtData = new System.Windows.Forms.TextBox();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Una vez que estes listo dale a \"Generar cadena de conexion\", se creara un Archivo" +
    " que contendra tu conexion Encryptada. \r\nAhora tu conexion es mas Segura ante Po" +
    "sibles Hackers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(800, 229);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 90);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la cadena de conexion local";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.dataList);
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(800, 370);
            this.panel2.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerate.BorderRadius = 0;
            this.btnGenerate.ButtonText = "Generar cadena de conexión";
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Iconimage")));
            this.btnGenerate.Iconimage_right = null;
            this.btnGenerate.Iconimage_right_Selected = null;
            this.btnGenerate.Iconimage_Selected = null;
            this.btnGenerate.IconMarginLeft = 0;
            this.btnGenerate.IconMarginRight = 0;
            this.btnGenerate.IconRightVisible = true;
            this.btnGenerate.IconRightZoom = 0D;
            this.btnGenerate.IconVisible = true;
            this.btnGenerate.IconZoom = 90D;
            this.btnGenerate.IsTab = false;
            this.btnGenerate.Location = new System.Drawing.Point(20, 302);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenerate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGenerate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenerate.selected = false;
            this.btnGenerate.Size = new System.Drawing.Size(760, 48);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generar cadena de conexión";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Textcolor = System.Drawing.Color.White;
            this.btnGenerate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtData.Location = new System.Drawing.Point(20, 20);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(760, 125);
            this.txtData.TabIndex = 0;
            // 
            // dataList
            // 
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataList.Location = new System.Drawing.Point(20, 145);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(760, 205);
            this.dataList.TabIndex = 2;
            // 
            // FrmDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDataBase";
            this.Load += new System.EventHandler(this.FrmDataBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        //private Bunifu.Framework.UI.BunifuFlatButton btnGenerate;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.DataGridView dataList;
    }
}