namespace STORE_MANAGEMENT
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblExit = new DevExpress.XtraEditors.LabelControl();
            this.lblHome = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem14 = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.lblExit);
            this.panelControl1.Controls.Add(this.lblHome);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1232, 103);
            this.panelControl1.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblExit.AppearanceHovered.Options.UseBackColor = true;
            this.lblExit.ImageOptions.Image = global::STORE_MANAGEMENT.Properties.Resources.cancel_32x321;
            this.lblExit.Location = new System.Drawing.Point(1193, 7);
            this.lblExit.Margin = new System.Windows.Forms.Padding(5);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(32, 32);
            this.lblExit.TabIndex = 2;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblHome
            // 
            this.lblHome.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHome.Appearance.Options.UseFont = true;
            this.lblHome.AppearanceHovered.BackColor = System.Drawing.Color.LightGray;
            this.lblHome.AppearanceHovered.Options.UseBackColor = true;
            this.lblHome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHome.ImageOptions.Image = global::STORE_MANAGEMENT.Properties.Resources.home_32x32;
            this.lblHome.Location = new System.Drawing.Point(241, 0);
            this.lblHome.Margin = new System.Windows.Forms.Padding(8);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(59, 48);
            this.lblHome.TabIndex = 1;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(225, 54);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stores Management\r\nSystem";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem11,
            this.navBarItem12,
            this.navBarItem13,
            this.navBarItem14});
            this.navBarControl1.Location = new System.Drawing.Point(0, 103);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 241;
            this.navBarControl1.Size = new System.Drawing.Size(241, 600);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Manage Users";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ImageOptions.SvgImage = global::STORE_MANAGEMENT.Properties.Resources.bo_lead;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Add User";
            this.navBarItem1.ImageOptions.LargeImage = global::STORE_MANAGEMENT.Properties.Resources.add_32x32;
            this.navBarItem1.ImageOptions.SmallImage = global::STORE_MANAGEMENT.Properties.Resources.add_16x16;
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Delete User";
            this.navBarItem2.ImageOptions.LargeImage = global::STORE_MANAGEMENT.Properties.Resources.remove_32x32;
            this.navBarItem2.ImageOptions.SmallImage = global::STORE_MANAGEMENT.Properties.Resources.remove_16x16;
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnDelete);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Update Users";
            this.navBarItem3.ImageOptions.LargeImage = global::STORE_MANAGEMENT.Properties.Resources.updatetableofcontents_32x32;
            this.navBarItem3.ImageOptions.SmallImage = global::STORE_MANAGEMENT.Properties.Resources.updatetableofcontents_16x16;
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnUpdate);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Login Register";
            this.navBarItem5.ImageOptions.LargeImage = global::STORE_MANAGEMENT.Properties.Resources.listbox_32x32;
            this.navBarItem5.ImageOptions.SmallImage = global::STORE_MANAGEMENT.Properties.Resources.listbox_16x16;
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnLoginRegister);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Manage Stores";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.ImageOptions.LargeImage")));
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Add Store";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAddStore);
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Delete Store";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnDeleteStore);
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Update Store";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnUpdateStore);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Manage Clients";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ImageOptions.LargeImage = global::STORE_MANAGEMENT.Properties.Resources.team_32x32;
            this.navBarGroup3.ImageOptions.SmallImage = global::STORE_MANAGEMENT.Properties.Resources.team_16x16;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem12),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem14)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "Add Client";
            this.navBarItem11.Name = "navBarItem11";
            this.navBarItem11.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAddClient);
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "Delete Client";
            this.navBarItem12.Name = "navBarItem12";
            this.navBarItem12.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnDeleteClient);
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "Upadate Client";
            this.navBarItem13.Name = "navBarItem13";
            this.navBarItem13.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnUpdateClient);
            // 
            // navBarItem14
            // 
            this.navBarItem14.Caption = "Client_Store_Details";
            this.navBarItem14.Name = "navBarItem14";
            this.navBarItem14.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnClientsProperities);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.EnableBonusSkins = true;
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Dark Side";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem12;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
        private DevExpress.XtraNavBar.NavBarItem navBarItem14;
        private DevExpress.XtraEditors.LabelControl lblHome;
        private DevExpress.XtraEditors.LabelControl lblExit;
    }
}