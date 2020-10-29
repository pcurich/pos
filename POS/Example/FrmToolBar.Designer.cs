namespace POS.Example
{
    partial class FrmToolBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmToolBar));
            this.tsOperations = new System.Windows.Forms.ToolStrip();
            this.tsBtnSum = new System.Windows.Forms.ToolStripButton();
            this.tsBtnMin = new System.Windows.Forms.ToolStripButton();
            this.tsBtnMul = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDiv = new System.Windows.Forms.ToolStripButton();
            this.tsOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsOperations
            // 
            this.tsOperations.BackColor = System.Drawing.Color.Navy;
            this.tsOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSum,
            this.tsBtnMin,
            this.tsBtnMul,
            this.tsBtnDiv});
            this.tsOperations.Location = new System.Drawing.Point(0, 0);
            this.tsOperations.Name = "tsOperations";
            this.tsOperations.Size = new System.Drawing.Size(800, 25);
            this.tsOperations.TabIndex = 0;
            this.tsOperations.Text = "toolStrip1";
            // 
            // tsBtnSum
            // 
            this.tsBtnSum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSum.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSum.Image")));
            this.tsBtnSum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSum.Name = "tsBtnSum";
            this.tsBtnSum.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSum.Text = "Suma";
            // 
            // tsBtnMin
            // 
            this.tsBtnMin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnMin.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMin.Image")));
            this.tsBtnMin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMin.Name = "tsBtnMin";
            this.tsBtnMin.Size = new System.Drawing.Size(23, 22);
            this.tsBtnMin.Text = "toolStripButton1";
            // 
            // tsBtnMul
            // 
            this.tsBtnMul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnMul.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMul.Image")));
            this.tsBtnMul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMul.Name = "tsBtnMul";
            this.tsBtnMul.Size = new System.Drawing.Size(23, 22);
            this.tsBtnMul.Text = "toolStripButton2";
            // 
            // tsBtnDiv
            // 
            this.tsBtnDiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDiv.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDiv.Image")));
            this.tsBtnDiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDiv.Name = "tsBtnDiv";
            this.tsBtnDiv.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDiv.Text = "toolStripButton3";
            // 
            // FrmToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsOperations);
            this.Name = "FrmToolBar";
            this.Text = "FrmToolBar";
            this.tsOperations.ResumeLayout(false);
            this.tsOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsOperations;
        private System.Windows.Forms.ToolStripButton tsBtnSum;
        private System.Windows.Forms.ToolStripButton tsBtnMin;
        private System.Windows.Forms.ToolStripButton tsBtnMul;
        private System.Windows.Forms.ToolStripButton tsBtnDiv;
    }
}