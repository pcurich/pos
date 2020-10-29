namespace POS.Example
{
    partial class FrmMonthCalendar
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
            this.mCal = new System.Windows.Forms.MonthCalendar();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnSelected = new System.Windows.Forms.Button();
            this.lblRange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mCal
            // 
            this.mCal.Location = new System.Drawing.Point(33, 18);
            this.mCal.Name = "mCal";
            this.mCal.TabIndex = 0;
            this.mCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MCal_DateChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(322, 18);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(35, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "label1";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(322, 167);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(35, 13);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "label1";
            // 
            // btnSelected
            // 
            this.btnSelected.Location = new System.Drawing.Point(325, 98);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(75, 23);
            this.btnSelected.TabIndex = 3;
            this.btnSelected.Text = "Seleccionar";
            this.btnSelected.UseVisualStyleBackColor = true;
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(425, 103);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(35, 13);
            this.lblRange.TabIndex = 4;
            this.lblRange.Text = "label1";
            // 
            // FrmMonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.btnSelected);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.mCal);
            this.Name = "FrmMonthCalendar";
            this.Text = "FrmMonthCalendar";
            this.Load += new System.EventHandler(this.FrmMonthCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCal;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnSelected;
        private System.Windows.Forms.Label lblRange;
    }
}