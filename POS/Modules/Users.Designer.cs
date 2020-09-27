namespace POS
{
    partial class Users
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pibAddUser = new System.Windows.Forms.PictureBox();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblIconSelected = new System.Windows.Forms.Label();
            this.pibAvatar = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveChange = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpAvatars = new System.Windows.Forms.FlowLayoutPanel();
            this.pibBarista = new System.Windows.Forms.PictureBox();
            this.pibAdmin = new System.Windows.Forms.PictureBox();
            this.pibCoder = new System.Windows.Forms.PictureBox();
            this.pibUser = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.flpAvatars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibBarista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCoder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibUser)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 77);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(753, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 77);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.menuStrip1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 77);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(800, 70);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(53, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(454, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(9, 22);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(41, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pibAddUser);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtons.Location = new System.Drawing.Point(743, 147);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(57, 303);
            this.pnlButtons.TabIndex = 2;
            // 
            // pibAddUser
            // 
            this.pibAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pibAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pibAddUser.Image = ((System.Drawing.Image)(resources.GetObject("pibAddUser.Image")));
            this.pibAddUser.Location = new System.Drawing.Point(0, 0);
            this.pibAddUser.Name = "pibAddUser";
            this.pibAddUser.Size = new System.Drawing.Size(57, 303);
            this.pibAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibAddUser.TabIndex = 0;
            this.pibAddUser.TabStop = false;
            this.pibAddUser.Click += new System.EventHandler(this.PibAddUser_Click);
            // 
            // dataUsers
            // 
            this.dataUsers.AllowUserToAddRows = false;
            this.dataUsers.AllowUserToResizeRows = false;
            this.dataUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete});
            this.dataUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataUsers.EnableHeadersVisualStyles = false;
            this.dataUsers.Location = new System.Drawing.Point(0, 0);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.ReadOnly = true;
            this.dataUsers.RowHeadersVisible = false;
            this.dataUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataUsers.RowTemplate.Height = 30;
            this.dataUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUsers.Size = new System.Drawing.Size(743, 303);
            this.dataUsers.TabIndex = 3;
            this.dataUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUsers_CellClick);
            this.dataUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUsers_CellContentClick);
            this.dataUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUsers_CellDoubleClick);
            // 
            // delete
            // 
            this.delete.Frozen = true;
            this.delete.HeaderText = "Borrar";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.Controls.Add(this.lblId);
            this.pnlUser.Controls.Add(this.lblAvatar);
            this.pnlUser.Controls.Add(this.lblIconSelected);
            this.pnlUser.Controls.Add(this.pibAvatar);
            this.pnlUser.Controls.Add(this.btnBack);
            this.pnlUser.Controls.Add(this.menuStrip2);
            this.pnlUser.Controls.Add(this.cmbRol);
            this.pnlUser.Controls.Add(this.txtEmail);
            this.pnlUser.Controls.Add(this.txtPassword);
            this.pnlUser.Controls.Add(this.txtUser);
            this.pnlUser.Controls.Add(this.txtName);
            this.pnlUser.Controls.Add(this.label6);
            this.pnlUser.Controls.Add(this.label5);
            this.pnlUser.Controls.Add(this.label4);
            this.pnlUser.Controls.Add(this.label3);
            this.pnlUser.Controls.Add(this.label2);
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(737, 303);
            this.pnlUser.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(556, 207);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 13);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "lblId";
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.BackColor = System.Drawing.Color.DimGray;
            this.lblAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar.ForeColor = System.Drawing.Color.White;
            this.lblAvatar.Location = new System.Drawing.Point(556, 172);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(116, 20);
            this.lblAvatar.TabIndex = 11;
            this.lblAvatar.Text = "Elija un icono";
            this.lblAvatar.Click += new System.EventHandler(this.LblAvatar_Click);
            // 
            // lblIconSelected
            // 
            this.lblIconSelected.AutoSize = true;
            this.lblIconSelected.Location = new System.Drawing.Point(556, 227);
            this.lblIconSelected.Name = "lblIconSelected";
            this.lblIconSelected.Size = new System.Drawing.Size(80, 13);
            this.lblIconSelected.TabIndex = 13;
            this.lblIconSelected.Text = "lblIconSelected";
            // 
            // pibAvatar
            // 
            this.pibAvatar.Location = new System.Drawing.Point(554, 25);
            this.pibAvatar.Name = "pibAvatar";
            this.pibAvatar.Size = new System.Drawing.Size(162, 147);
            this.pibAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibAvatar.TabIndex = 12;
            this.pibAvatar.TabStop = false;
            this.pibAvatar.Click += new System.EventHandler(this.PibAvatar_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(476, 210);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 37);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSave,
            this.tsmSaveChange});
            this.menuStrip2.Location = new System.Drawing.Point(192, 210);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(244, 29);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsmSave
            // 
            this.tsmSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(83, 25);
            this.tsmSave.Text = "Guardar";
            this.tsmSave.Click += new System.EventHandler(this.TsmSave_Click);
            // 
            // tsmSaveChange
            // 
            this.tsmSaveChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tsmSaveChange.Name = "tsmSaveChange";
            this.tsmSaveChange.Size = new System.Drawing.Size(153, 25);
            this.tsmSaveChange.Text = "Guardar Cambios";
            this.tsmSaveChange.Click += new System.EventHandler(this.TsmSaveChange_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Vendedor (No maneja dinero)",
            "Cajero (Si esta autorizado para manejar dinero)",
            "Administrador (Control total)"});
            this.cmbRol.Location = new System.Drawing.Point(188, 141);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(349, 21);
            this.cmbRol.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(188, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(187, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(350, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(188, 56);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(350, 20);
            this.txtUser.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 20);
            this.txtName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Correo Electrónico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre y Apellidos:";
            // 
            // flpAvatars
            // 
            this.flpAvatars.Controls.Add(this.pibBarista);
            this.flpAvatars.Controls.Add(this.pibAdmin);
            this.flpAvatars.Controls.Add(this.pibCoder);
            this.flpAvatars.Controls.Add(this.pibUser);
            this.flpAvatars.Location = new System.Drawing.Point(12, 3);
            this.flpAvatars.Name = "flpAvatars";
            this.flpAvatars.Size = new System.Drawing.Size(481, 62);
            this.flpAvatars.TabIndex = 0;
            // 
            // pibBarista
            // 
            this.pibBarista.Image = ((System.Drawing.Image)(resources.GetObject("pibBarista.Image")));
            this.pibBarista.Location = new System.Drawing.Point(3, 3);
            this.pibBarista.Name = "pibBarista";
            this.pibBarista.Size = new System.Drawing.Size(100, 50);
            this.pibBarista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibBarista.TabIndex = 0;
            this.pibBarista.TabStop = false;
            this.pibBarista.Click += new System.EventHandler(this.PibBarista_Click);
            // 
            // pibAdmin
            // 
            this.pibAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pibAdmin.Image")));
            this.pibAdmin.Location = new System.Drawing.Point(109, 3);
            this.pibAdmin.Name = "pibAdmin";
            this.pibAdmin.Size = new System.Drawing.Size(100, 50);
            this.pibAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibAdmin.TabIndex = 1;
            this.pibAdmin.TabStop = false;
            this.pibAdmin.Click += new System.EventHandler(this.PibAdmin_Click);
            // 
            // pibCoder
            // 
            this.pibCoder.Image = ((System.Drawing.Image)(resources.GetObject("pibCoder.Image")));
            this.pibCoder.Location = new System.Drawing.Point(215, 3);
            this.pibCoder.Name = "pibCoder";
            this.pibCoder.Size = new System.Drawing.Size(100, 50);
            this.pibCoder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibCoder.TabIndex = 2;
            this.pibCoder.TabStop = false;
            this.pibCoder.Click += new System.EventHandler(this.PibCoder_Click);
            // 
            // pibUser
            // 
            this.pibUser.Image = ((System.Drawing.Image)(resources.GetObject("pibUser.Image")));
            this.pibUser.Location = new System.Drawing.Point(321, 3);
            this.pibUser.Name = "pibUser";
            this.pibUser.Size = new System.Drawing.Size(100, 50);
            this.pibUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibUser.TabIndex = 3;
            this.pibUser.TabStop = false;
            this.pibUser.Click += new System.EventHandler(this.PibUser_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlUser);
            this.pnlBody.Controls.Add(this.dataUsers);
            this.pnlBody.Controls.Add(this.flpAvatars);
            this.pnlBody.Location = new System.Drawing.Point(0, 147);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(743, 303);
            this.pnlBody.TabIndex = 6;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Users_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.flpAvatars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibBarista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCoder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibUser)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.PictureBox pibAddUser;
        private System.Windows.Forms.DataGridView dataUsers;
        private System.Windows.Forms.FlowLayoutPanel flpAvatars;
        private System.Windows.Forms.PictureBox pibBarista;
        private System.Windows.Forms.PictureBox pibAdmin;
        private System.Windows.Forms.PictureBox pibCoder;
        private System.Windows.Forms.PictureBox pibUser;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.PictureBox pibAvatar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveChange;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblIconSelected;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label lblId;
    }
}

