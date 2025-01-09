using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STORE_MANAGEMENT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new frmLogin(this);
            login.ShowDialog();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new frmContact(this);
            login.ShowDialog();
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new frmContact(this , "AboutMe");
            login.ShowDialog();
        }
    }
}
