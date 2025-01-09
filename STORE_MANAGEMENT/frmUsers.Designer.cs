namespace STORE_MANAGEMENT
{
    partial class frmUsers
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
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteUser = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdioBtnClients = new System.Windows.Forms.RadioButton();
            this.rdioBtnStores = new System.Windows.Forms.RadioButton();
            this.rdioBtnAll = new System.Windows.Forms.RadioButton();
            this.rdioBtnUsers = new System.Windows.Forms.RadioButton();
            this.btnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewUsers = new System.Windows.Forms.DataGridView();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.Location = new System.Drawing.Point(21, 39);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(108, 24);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User name";
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 156);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 24);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(21, 87);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(206, 30);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(21, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.btnUpdateUser);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 569);
            this.panel1.TabIndex = 4;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateUser.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateUser.Appearance.Options.UseBackColor = true;
            this.btnUpdateUser.Appearance.Options.UseFont = true;
            this.btnUpdateUser.Location = new System.Drawing.Point(12, 527);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(225, 39);
            this.btnUpdateUser.TabIndex = 9;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Appearance.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteUser.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteUser.Appearance.Options.UseBackColor = true;
            this.btnDeleteUser.Appearance.Options.UseFont = true;
            this.btnDeleteUser.Location = new System.Drawing.Point(14, 490);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(225, 39);
            this.btnDeleteUser.TabIndex = 10;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioBtnClients);
            this.groupBox1.Controls.Add(this.rdioBtnStores);
            this.groupBox1.Controls.Add(this.rdioBtnAll);
            this.groupBox1.Controls.Add(this.rdioBtnUsers);
            this.groupBox1.Location = new System.Drawing.Point(21, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // rdioBtnClients
            // 
            this.rdioBtnClients.AutoSize = true;
            this.rdioBtnClients.Location = new System.Drawing.Point(18, 139);
            this.rdioBtnClients.Name = "rdioBtnClients";
            this.rdioBtnClients.Size = new System.Drawing.Size(170, 29);
            this.rdioBtnClients.TabIndex = 14;
            this.rdioBtnClients.TabStop = true;
            this.rdioBtnClients.Text = "Manage Clients";
            this.rdioBtnClients.UseVisualStyleBackColor = true;
            // 
            // rdioBtnStores
            // 
            this.rdioBtnStores.AutoSize = true;
            this.rdioBtnStores.Location = new System.Drawing.Point(18, 104);
            this.rdioBtnStores.Name = "rdioBtnStores";
            this.rdioBtnStores.Size = new System.Drawing.Size(167, 29);
            this.rdioBtnStores.TabIndex = 13;
            this.rdioBtnStores.TabStop = true;
            this.rdioBtnStores.Text = "Manage Stores";
            this.rdioBtnStores.UseVisualStyleBackColor = true;
            // 
            // rdioBtnAll
            // 
            this.rdioBtnAll.AutoSize = true;
            this.rdioBtnAll.Location = new System.Drawing.Point(18, 33);
            this.rdioBtnAll.Name = "rdioBtnAll";
            this.rdioBtnAll.Size = new System.Drawing.Size(164, 29);
            this.rdioBtnAll.TabIndex = 11;
            this.rdioBtnAll.TabStop = true;
            this.rdioBtnAll.Text = "All permissions";
            this.rdioBtnAll.UseVisualStyleBackColor = true;
            // 
            // rdioBtnUsers
            // 
            this.rdioBtnUsers.AutoSize = true;
            this.rdioBtnUsers.Location = new System.Drawing.Point(18, 69);
            this.rdioBtnUsers.Name = "rdioBtnUsers";
            this.rdioBtnUsers.Size = new System.Drawing.Size(161, 29);
            this.rdioBtnUsers.TabIndex = 12;
            this.rdioBtnUsers.TabStop = true;
            this.rdioBtnUsers.Text = "Manage Users";
            this.rdioBtnUsers.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Appearance.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddUser.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddUser.Appearance.Options.UseBackColor = true;
            this.btnAddUser.Appearance.Options.UseFont = true;
            this.btnAddUser.Location = new System.Drawing.Point(12, 445);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(225, 39);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewUsers.EnableHeadersVisualStyles = false;
            this.gridViewUsers.Location = new System.Drawing.Point(311, 50);
            this.gridViewUsers.Name = "gridViewUsers";
            this.gridViewUsers.ReadOnly = true;
            this.gridViewUsers.RowHeadersWidth = 51;
            this.gridViewUsers.RowTemplate.Height = 24;
            this.gridViewUsers.Size = new System.Drawing.Size(562, 389);
            this.gridViewUsers.TabIndex = 5;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxSearch.Location = new System.Drawing.Point(311, 0);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(277, 30);
            this.txtBoxSearch.TabIndex = 6;
            this.txtBoxSearch.Text = "search";
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            this.txtBoxSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBoxSearch_MouseDown);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(992, 569);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.gridViewUsers);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsers";
            this.Text = "Users";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridViewUsers;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private DevExpress.XtraEditors.SimpleButton btnAddUser;
        private DevExpress.XtraEditors.SimpleButton btnUpdateUser;
        private DevExpress.XtraEditors.SimpleButton btnDeleteUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdioBtnClients;
        private System.Windows.Forms.RadioButton rdioBtnStores;
        private System.Windows.Forms.RadioButton rdioBtnAll;
        private System.Windows.Forms.RadioButton rdioBtnUsers;
    }
}