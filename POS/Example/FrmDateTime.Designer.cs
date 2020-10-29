namespace POS.Example
{
    partial class FrmDateTime
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
            this.lblDate = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(95, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label1";
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(223, 51);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(75, 23);
            this.btnOperation.TabIndex = 1;
            this.btnOperation.Text = "Operaciones";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(98, 132);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(273, 20);
            this.dtp.TabIndex = 2;
            this.dtp.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // FrmDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.lblDate);
            this.Name = "FrmDateTime";
            this.Text = "FrmDateTime";
            this.Load += new System.EventHandler(this.FrmDateTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}