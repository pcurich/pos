namespace POS.Example
{
    partial class FrmHelpProvider
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.helpProvider.SetHelpString(this.btnShow, "Permite mostrar el mensaje");
            this.btnShow.Location = new System.Drawing.Point(200, 35);
            this.btnShow.Name = "btnShow";
            this.helpProvider.SetShowHelp(this.btnShow, true);
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(48, 93);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "label1";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(51, 35);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 3;
            this.txtData.ValidatingType = typeof(System.DateTime);
            this.txtData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtData_MaskInputRejected);
            // 
            // FrmHelpProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 189);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnShow);
            this.Name = "FrmHelpProvider";
            this.Text = "FrmHelpProvider";
            this.Load += new System.EventHandler(this.FrmHelpProvider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}