namespace POS.Example
{
    partial class FrmListView
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
            this.lwProducts = new System.Windows.Forms.ListView();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.rdbProtein = new System.Windows.Forms.RadioButton();
            this.rdbFruits = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lwProducts
            // 
            this.lwProducts.HideSelection = false;
            this.lwProducts.Location = new System.Drawing.Point(12, 150);
            this.lwProducts.Name = "lwProducts";
            this.lwProducts.Size = new System.Drawing.Size(687, 163);
            this.lwProducts.TabIndex = 0;
            this.lwProducts.UseCompatibleStateImageBehavior = false;
            this.lwProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LwProducts_MouseClick);
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(98, 36);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(156, 20);
            this.txtElement.TabIndex = 2;
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.rdbProtein);
            this.gbCategory.Controls.Add(this.rdbFruits);
            this.gbCategory.Location = new System.Drawing.Point(287, 22);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(85, 87);
            this.gbCategory.TabIndex = 3;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Grupos";
            // 
            // rdbProtein
            // 
            this.rdbProtein.AutoSize = true;
            this.rdbProtein.Location = new System.Drawing.Point(6, 52);
            this.rdbProtein.Name = "rdbProtein";
            this.rdbProtein.Size = new System.Drawing.Size(64, 17);
            this.rdbProtein.TabIndex = 1;
            this.rdbProtein.TabStop = true;
            this.rdbProtein.Text = "Proteina";
            this.rdbProtein.UseVisualStyleBackColor = true;
            // 
            // rdbFruits
            // 
            this.rdbFruits.AutoSize = true;
            this.rdbFruits.Location = new System.Drawing.Point(6, 29);
            this.rdbFruits.Name = "rdbFruits";
            this.rdbFruits.Size = new System.Drawing.Size(54, 17);
            this.rdbFruits.TabIndex = 0;
            this.rdbFruits.TabStop = true;
            this.rdbFruits.Text = "Frutas";
            this.rdbFruits.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(397, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(397, 65);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(13, 122);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(28, 13);
            this.lblSelected.TabIndex = 6;
            this.lblSelected.Text = ".......";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Indice";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(98, 65);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(156, 20);
            this.txtIndex.TabIndex = 9;
            this.txtIndex.Text = "0";
            this.txtIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(98, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(179, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.lwProducts);
            this.Name = "FrmListView";
            this.Text = "FrmListView";
            this.Load += new System.EventHandler(this.FrmListView_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwProducts;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.RadioButton rdbProtein;
        private System.Windows.Forms.RadioButton rdbFruits;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}