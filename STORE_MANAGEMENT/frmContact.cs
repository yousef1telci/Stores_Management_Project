using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace STORE_MANAGEMENT
{
    public partial class frmContact : Form
    {
        Form frmMAIN;  // for show

        public frmContact(Form frm)
        {
            InitializeComponent();
            this.frmMAIN = frm;
        }
        public frmContact(Form frm , string aboutMe)
        {
            InitializeComponent();
            this.frmMAIN = frm;
           

            //aboutme
            AboutMe();
        }

        public void AboutMe()
        {
            label1.Text = "About Me";
            lblGithub.Visible = false;
            lblLinkedin.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            Label me = new Label()
            {
                Text = "Software Engineering Student, passionate \nabout technology and programming.",
                Location = new Point(2, 85),
                AutoSize = true,
                Font = new Font("Andalus", 13, FontStyle.Regular),  
                ForeColor = Color.DarkSlateGray,  
                BackColor = Color.White,  
                TextAlign = ContentAlignment.MiddleLeft, 
                Padding = new Padding(5),  
            };


            Controls.Add(me);

        }

        private void lblLinkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/feed/");

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMAIN.Show();
        }

        private void lblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yousef1telci");
        }
    }
}
