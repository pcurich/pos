namespace POS.Modules.Product
{
    partial class FrmGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGroups));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.pnlSearchBox = new System.Windows.Forms.Panel();
            this.pnlTxtSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlBtnSearch = new System.Windows.Forms.Panel();
            this.msSearch = new System.Windows.Forms.MenuStrip();
            this.tsmSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlPaging = new System.Windows.Forms.Panel();
            this.msPaging = new System.Windows.Forms.MenuStrip();
            this.tsmLast = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNext = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPresentPage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPage = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            this.pnlSearchBox.SuspendLayout();
            this.pnlTxtSearch.SuspendLayout();
            this.pnlBtnSearch.SuspendLayout();
            this.msSearch.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlPaging.SuspendLayout();
            this.msPaging.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1056, 112);
            this.pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1056, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.BackColor = System.Drawing.Color.Silver;
            this.pnlSearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchBar.Controls.Add(this.pnlSearchBox);
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlSearchBar.Location = new System.Drawing.Point(0, 112);
            this.pnlSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.pnlSearchBar.Size = new System.Drawing.Size(1056, 65);
            this.pnlSearchBar.TabIndex = 2;
            // 
            // pnlSearchBox
            // 
            this.pnlSearchBox.BackColor = System.Drawing.Color.White;
            this.pnlSearchBox.Controls.Add(this.pnlTxtSearch);
            this.pnlSearchBox.Controls.Add(this.pnlBtnSearch);
            this.pnlSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchBox.Location = new System.Drawing.Point(9, 8);
            this.pnlSearchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.pnlSearchBox.Size = new System.Drawing.Size(1036, 47);
            this.pnlSearchBox.TabIndex = 3;
            // 
            // pnlTxtSearch
            // 
            this.pnlTxtSearch.Controls.Add(this.txtSearch);
            this.pnlTxtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTxtSearch.Location = new System.Drawing.Point(9, 8);
            this.pnlTxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTxtSearch.Name = "pnlTxtSearch";
            this.pnlTxtSearch.Size = new System.Drawing.Size(989, 31);
            this.pnlTxtSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 15, 4, 5);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(989, 31);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlBtnSearch
            // 
            this.pnlBtnSearch.BackColor = System.Drawing.Color.Silver;
            this.pnlBtnSearch.Controls.Add(this.msSearch);
            this.pnlBtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBtnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBtnSearch.Location = new System.Drawing.Point(998, 8);
            this.pnlBtnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBtnSearch.Name = "pnlBtnSearch";
            this.pnlBtnSearch.Size = new System.Drawing.Size(29, 31);
            this.pnlBtnSearch.TabIndex = 3;
            // 
            // msSearch
            // 
            this.msSearch.AutoSize = false;
            this.msSearch.BackColor = System.Drawing.Color.LightGray;
            this.msSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.msSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msSearch.GripMargin = new System.Windows.Forms.Padding(0);
            this.msSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSearch});
            this.msSearch.Location = new System.Drawing.Point(0, 0);
            this.msSearch.Name = "msSearch";
            this.msSearch.Padding = new System.Windows.Forms.Padding(0);
            this.msSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msSearch.Size = new System.Drawing.Size(29, 31);
            this.msSearch.TabIndex = 1;
            this.msSearch.Text = "menuStrip1";
            // 
            // tsmSearch
            // 
            this.tsmSearch.BackColor = System.Drawing.Color.Transparent;
            this.tsmSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsmSearch.Image")));
            this.tsmSearch.Name = "tsmSearch";
            this.tsmSearch.Size = new System.Drawing.Size(28, 31);
            // 
            // pnlGridView
            // 
            this.pnlGridView.BackColor = System.Drawing.Color.Orange;
            this.pnlGridView.Controls.Add(this.dataGV);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(0, 177);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(1056, 487);
            this.pnlGridView.TabIndex = 3;
            // 
            // dataGV
            // 
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.add,
            this.Delete});
            this.dataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV.Location = new System.Drawing.Point(0, 0);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(1056, 487);
            this.dataGV.TabIndex = 0;
            this.dataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_CellClick);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Silver;
            this.pnlFooter.Controls.Add(this.pnlPaging);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 664);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(10);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1056, 28);
            this.pnlFooter.TabIndex = 4;
            // 
            // pnlPaging
            // 
            this.pnlPaging.BackColor = System.Drawing.Color.White;
            this.pnlPaging.Controls.Add(this.msPaging);
            this.pnlPaging.Controls.Add(this.label2);
            this.pnlPaging.Controls.Add(this.comboBox1);
            this.pnlPaging.Controls.Add(this.pnlLeft);
            this.pnlPaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaging.Location = new System.Drawing.Point(0, 0);
            this.pnlPaging.Margin = new System.Windows.Forms.Padding(10);
            this.pnlPaging.Name = "pnlPaging";
            this.pnlPaging.Size = new System.Drawing.Size(1056, 28);
            this.pnlPaging.TabIndex = 2;
            // 
            // msPaging
            // 
            this.msPaging.AutoSize = false;
            this.msPaging.BackColor = System.Drawing.Color.White;
            this.msPaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msPaging.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.msPaging.GripMargin = new System.Windows.Forms.Padding(0);
            this.msPaging.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.msPaging.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLast,
            this.tsmNext,
            this.tsmPrevious,
            this.tsmFirst});
            this.msPaging.Location = new System.Drawing.Point(0, 0);
            this.msPaging.Name = "msPaging";
            this.msPaging.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.msPaging.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msPaging.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msPaging.Size = new System.Drawing.Size(578, 28);
            this.msPaging.TabIndex = 0;
            // 
            // tsmLast
            // 
            this.tsmLast.AutoSize = false;
            this.tsmLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsmLast.BackgroundImage")));
            this.tsmLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmLast.Margin = new System.Windows.Forms.Padding(10);
            this.tsmLast.Name = "tsmLast";
            this.tsmLast.Padding = new System.Windows.Forms.Padding(10);
            this.tsmLast.Size = new System.Drawing.Size(32, 24);
            // 
            // tsmNext
            // 
            this.tsmNext.AutoSize = false;
            this.tsmNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsmNext.BackgroundImage")));
            this.tsmNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmNext.Margin = new System.Windows.Forms.Padding(10);
            this.tsmNext.Name = "tsmNext";
            this.tsmNext.Padding = new System.Windows.Forms.Padding(10);
            this.tsmNext.Size = new System.Drawing.Size(32, 24);
            // 
            // tsmPrevious
            // 
            this.tsmPrevious.AutoSize = false;
            this.tsmPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsmPrevious.BackgroundImage")));
            this.tsmPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmPrevious.Margin = new System.Windows.Forms.Padding(10);
            this.tsmPrevious.Name = "tsmPrevious";
            this.tsmPrevious.Padding = new System.Windows.Forms.Padding(10);
            this.tsmPrevious.Size = new System.Drawing.Size(32, 24);
            // 
            // tsmFirst
            // 
            this.tsmFirst.AutoSize = false;
            this.tsmFirst.BackColor = System.Drawing.Color.White;
            this.tsmFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsmFirst.BackgroundImage")));
            this.tsmFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsmFirst.Margin = new System.Windows.Forms.Padding(10);
            this.tsmFirst.Name = "tsmFirst";
            this.tsmFirst.Padding = new System.Windows.Forms.Padding(10);
            this.tsmFirst.Size = new System.Drawing.Size(32, 24);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(578, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño de página";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "25",
            "50",
            "75",
            "100",
            "Todos"});
            this.comboBox1.Location = new System.Drawing.Point(739, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.lblPresentPage);
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.lblTotalPage);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLeft.Location = new System.Drawing.Point(823, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(233, 28);
            this.pnlLeft.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Página";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPresentPage
            // 
            this.lblPresentPage.BackColor = System.Drawing.Color.White;
            this.lblPresentPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPresentPage.Location = new System.Drawing.Point(66, 0);
            this.lblPresentPage.Name = "lblPresentPage";
            this.lblPresentPage.Size = new System.Drawing.Size(56, 28);
            this.lblPresentPage.TabIndex = 3;
            this.lblPresentPage.Text = "1";
            this.lblPresentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(122, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "de";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.BackColor = System.Drawing.Color.White;
            this.lblTotalPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalPage.Location = new System.Drawing.Point(156, 0);
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.Size = new System.Drawing.Size(77, 28);
            this.lblTotalPage.TabIndex = 0;
            this.lblTotalPage.Text = "250";
            this.lblTotalPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add
            // 
            this.add.HeaderText = "Asignar";
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.add.Name = "add";
            this.add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            // 
            // FrmGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1056, 692);
            this.Controls.Add(this.pnlGridView);
            this.Controls.Add(this.pnlSearchBar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msPaging;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGroups";
            this.Load += new System.EventHandler(this.FrmGroups_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBox.ResumeLayout(false);
            this.pnlTxtSearch.ResumeLayout(false);
            this.pnlTxtSearch.PerformLayout();
            this.pnlBtnSearch.ResumeLayout(false);
            this.msSearch.ResumeLayout(false);
            this.msSearch.PerformLayout();
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlPaging.ResumeLayout(false);
            this.msPaging.ResumeLayout(false);
            this.msPaging.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Panel pnlSearchBox;
        private System.Windows.Forms.Panel pnlTxtSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlBtnSearch;
        private System.Windows.Forms.MenuStrip msSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmSearch;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ToolStripMenuItem tsmFirst;
        private System.Windows.Forms.ToolStripMenuItem tsmPrevious;
        private System.Windows.Forms.ToolStripMenuItem tsmNext;
        private System.Windows.Forms.MenuStrip msPaging;
        private System.Windows.Forms.ToolStripMenuItem tsmLast;
        private System.Windows.Forms.Panel pnlPaging;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPresentPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPage;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.DataGridViewImageColumn add;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}