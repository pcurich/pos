namespace POS.Example
{
    partial class FrmTimer
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
            this.components = new System.ComponentModel.Container();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.blbCount = new System.Windows.Forms.Label();
            this.trbInterval = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(200, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Inicio";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(200, 60);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "Detener";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // blbCount
            // 
            this.blbCount.AutoSize = true;
            this.blbCount.Location = new System.Drawing.Point(39, 46);
            this.blbCount.Name = "blbCount";
            this.blbCount.Size = new System.Drawing.Size(35, 13);
            this.blbCount.TabIndex = 2;
            this.blbCount.Text = "label1";
            // 
            // trbInterval
            // 
            this.trbInterval.Location = new System.Drawing.Point(12, 94);
            this.trbInterval.Maximum = 1000;
            this.trbInterval.Minimum = 100;
            this.trbInterval.Name = "trbInterval";
            this.trbInterval.Size = new System.Drawing.Size(263, 45);
            this.trbInterval.TabIndex = 3;
            this.trbInterval.TickFrequency = 100;
            this.trbInterval.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbInterval.Value = 100;
            this.trbInterval.Scroll += new System.EventHandler(this.TrbInterval_Scroll);
            // 
            // FrmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 190);
            this.Controls.Add(this.trbInterval);
            this.Controls.Add(this.blbCount);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmTimer";
            this.Text = "FrmTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTimer_FormClosing);
            this.Load += new System.EventHandler(this.FrmTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label blbCount;
        private System.Windows.Forms.TrackBar trbInterval;
    }
}