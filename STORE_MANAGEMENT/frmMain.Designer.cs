namespace STORE_MANAGEMENT
{
    partial class frmMain
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
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnAboutMe = new DevExpress.XtraEditors.SimpleButton();
            this.btnContact = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.AppearanceHovered.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.AppearanceHovered.Options.UseBackColor = true;
            this.btnLogin.Location = new System.Drawing.Point(1105, 26);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 61);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAboutMe.Appearance.Options.UseFont = true;
            this.btnAboutMe.AppearanceHovered.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAboutMe.AppearanceHovered.Options.UseBackColor = true;
            this.btnAboutMe.Location = new System.Drawing.Point(780, 26);
            this.btnAboutMe.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Size = new System.Drawing.Size(152, 61);
            this.btnAboutMe.TabIndex = 1;
            this.btnAboutMe.Text = "ABOUT ME";
            this.btnAboutMe.Click += new System.EventHandler(this.btnAboutMe_Click);
            // 
            // btnContact
            // 
            this.btnContact.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContact.Appearance.Options.UseFont = true;
            this.btnContact.AppearanceHovered.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnContact.AppearanceHovered.Options.UseBackColor = true;
            this.btnContact.Location = new System.Drawing.Point(957, 26);
            this.btnContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(140, 61);
            this.btnContact.TabIndex = 2;
            this.btnContact.Text = "CONTACT";
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STORE_MANAGEMENT.Properties.Resources.MianUI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1243, 573);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnAboutMe);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnAboutMe;
        private DevExpress.XtraEditors.SimpleButton btnContact;
    }
}

