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
    public partial class frmDshbrdMain : Form
    {

        int usersCount, storesCount, clientCount;

       

        public frmDshbrdMain()
        {
            InitializeComponent();
        }
        public frmDshbrdMain(int usersCount , int storesCount , int clientCount)
        {
            InitializeComponent();
            this.usersCount = usersCount;
            this.storesCount = storesCount;
            this.clientCount = clientCount;
        }


        private void frmDshbrdMain_Load(object sender, EventArgs e)
        {
            lblUsersCount.Text = usersCount.ToString();
            lblStoresCount.Text = storesCount.ToString();
            lblClientsCount.Text = clientCount.ToString();
        }


    }
}
