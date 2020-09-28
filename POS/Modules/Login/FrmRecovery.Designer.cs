namespace POS.Modules.Login
{
    partial class FrmRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecovery));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.cmbEmails = new System.Windows.Forms.ComboBox();
            this.richTemplate = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "Restablecer contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correo electrónico";
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.White;
            this.pnlLine.Location = new System.Drawing.Point(258, 97);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(260, 1);
            this.pnlLine.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(257, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Con el que registro su cuenta";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.Red;
            this.btnSendEmail.FlatAppearance.BorderSize = 0;
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.White;
            this.btnSendEmail.Location = new System.Drawing.Point(257, 131);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(261, 29);
            this.btnSendEmail.TabIndex = 16;
            this.btnSendEmail.Text = "Enviar";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.BtnSendEmail_Click);
            // 
            // cmbEmails
            // 
            this.cmbEmails.FormattingEnabled = true;
            this.cmbEmails.ItemHeight = 13;
            this.cmbEmails.Location = new System.Drawing.Point(257, 71);
            this.cmbEmails.Name = "cmbEmails";
            this.cmbEmails.Size = new System.Drawing.Size(261, 21);
            this.cmbEmails.TabIndex = 17;
            // 
            // richTemplate
            // 
            this.richTemplate.Location = new System.Drawing.Point(67, 97);
            this.richTemplate.Name = "richTemplate";
            this.richTemplate.Size = new System.Drawing.Size(185, 187);
            this.richTemplate.TabIndex = 18;
            this.richTemplate.Text = resources.GetString("richTemplate.Text");
            // 
            // FrmRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(622, 296);
            this.Controls.Add(this.richTemplate);
            this.Controls.Add(this.cmbEmails);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecovery";
            this.Text = "FrmRecoverPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.ComboBox cmbEmails;
        private System.Windows.Forms.RichTextBox richTemplate;
    }
}