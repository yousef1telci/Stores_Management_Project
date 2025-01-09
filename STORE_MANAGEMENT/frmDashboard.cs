using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace STORE_MANAGEMENT
{
    public partial class frmDashboard : Form
    {

        // connection using config file
        static string strConn = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
        SqlConnection sqlConn = new SqlConnection(strConn);

        int Permission ;
        /*
            AllPersmissions = -1,
            ManageUsers = 1,
            ManageStores = 2,
            ManageClients = 3
         */

        int usersCount = 0, storesCount = 0, clientCount = 0;



        public frmDashboard()
        {
            InitializeComponent();
        }
        public frmDashboard(int permission)
        {
            InitializeComponent();
            this.Permission = permission;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            OpenSingleForm(new frmDshbrdMain(GetUsersCount() , GetStoresCount() , GetClientsCount()));
        }

        //function

        private Form activeForm = null; // متغير لتتبع الفورم المفتوح حالياً
        private void OpenSingleForm(Form formToOpen)
        {
            // إغلاق الفورم المفتوح حالياً إن وجد
            if (activeForm != null)
                activeForm.Close();

            // فتح الفورم الجديد وجعله النافذة النشطة
            activeForm = formToOpen;
            activeForm.MdiParent = this;
            activeForm.Show();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            //OpenSingleForm(new frmDshbrdMain());
            frmDashboard_Load( sender,  e);
        }


        public int GetUsersCount()
        {
            
            try
            {

                sqlConn.Open();


                SqlCommand sqlComm = new SqlCommand("SELECT COUNT(Id) FROM tbLogin", sqlConn);

                usersCount = (int)sqlComm.ExecuteScalar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            return usersCount;
        }
        public int GetStoresCount()
        {

            try
            {

                sqlConn.Open();


                SqlCommand sqlComm = new SqlCommand("SELECT COUNT(Store_Id) FROM tbStores", sqlConn);

                storesCount = (int)sqlComm.ExecuteScalar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            return storesCount;
        }

        public int GetClientsCount()
        {

            try
            {

                sqlConn.Open();


                SqlCommand sqlComm = new SqlCommand("SELECT COUNT(Client_Id) FROM tbClient", sqlConn);

                clientCount = (int)sqlComm.ExecuteScalar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            return clientCount;
        }

        //public void c(int Permission)
        //{
        //    //manage only users
        //    if (Permission ==1)
        //    {
        //        //navBarGroup2.Visible = false;
        //        //navBarGroup3.Visible = false;
        //        MessageBox.Show("you don't have access");
        //        return;
        //    }
        //    //manage only Stores
        //    if (Permission == 2)
        //    {
        //        navBarGroup1.Visible = false;
        //        navBarGroup3.Visible = false;
        //    }
        //    //manage only Stores
        //    if (Permission == 3)
        //    {
        //        navBarGroup1.Visible = false;
        //        navBarGroup2.Visible = false;
        //    }
        //}





        //MANAGE user
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission ==2 || Permission ==3)
            {
                MessageBox.Show("you don't have access");
                return;
            }
                
                OpenSingleForm(new frmUsers("add"));
        }

        private void btnDelete(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission == 2 || Permission == 3)
            {
                MessageBox.Show("you don't have access");
                return;
            }

            OpenSingleForm(new frmUsers("delete"));
        }

        private void btnUpdate(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission == 2 || Permission == 3)
            {
                MessageBox.Show("you don't have access");
                return;
            }

            OpenSingleForm(new frmUsers("update"));
        }

        private void btnLoginRegister(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission == 2 || Permission == 3)
            {
                MessageBox.Show("you don't have access");
                return;
            }

            OpenSingleForm(new frmUsers("LoginRegister"));
        }


        //////////

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        //MANAGE stores

        private void btnAddStore(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission ==1 || Permission ==3)
            {
                MessageBox.Show("you don't have access");
                return;
            }
            OpenSingleForm(new frmStores("AddStore"));
        }

        private void btnDeleteStore(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission == 1 || Permission == 3)
            {
                MessageBox.Show("you don't have access");
                return;
            }
            OpenSingleForm(new frmStores("DelelteStore"));
        }

        private void btnUpdateStore(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission == 1 || Permission == 3)
            {
                MessageBox.Show("you don't have access");
                return;
            }
            OpenSingleForm(new frmStores("UpdateStore"));
        }





        //Manage client
        private void btnAddClient(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission ==1 || Permission ==2)
            {
                MessageBox.Show("you don't have access");
                return;
            }
            OpenSingleForm(new frmClient("AddClient"));

        }

        private void btnDeleteClient(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission == 1 || Permission == 2)
            {
                MessageBox.Show("you don't have access");
                return;
            }
            OpenSingleForm(new frmClient("DeleteClient"));
        }

        private void btnUpdateClient(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission == 1 || Permission == 2)
            {
                MessageBox.Show("you don't have access");
                return;
            }
            OpenSingleForm(new frmClient("UpdateClient"));
        }

        private void btnClientsProperities(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Permission == 1 || Permission == 2)
            {
                MessageBox.Show("you don't have access");
                return;
            }
            OpenSingleForm(new frmClient("ClientsProperities"));

        }

       
    }
}
