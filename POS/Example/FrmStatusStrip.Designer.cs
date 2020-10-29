namespace POS.Example
{
    partial class FrmStatusStrip
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
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tssLblValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblValue});
            this.ss.Location = new System.Drawing.Point(0, 428);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(800, 22);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
            // 
            // tssLblValue
            // 
            this.tssLblValue.Name = "tssLblValue";
            this.tssLblValue.Size = new System.Drawing.Size(118, 17);
            this.tssLblValue.Text = "toolStripStatusLabel1";
            // 
            // FrmStatusStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ss);
            this.Name = "FrmStatusStrip";
            this.Text = "FrmStatusStrip";
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel tssLblValue;
    }
}