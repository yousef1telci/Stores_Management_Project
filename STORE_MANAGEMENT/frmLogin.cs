using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace STORE_MANAGEMENT
{
    public partial class frmLogin : Form
    {
        // connection using config file
        static string strConn = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
        SqlConnection sqlConn = new SqlConnection(strConn);


        Form frmMAIN;  // for show

        int Permission = 0; //!!!!!!!!!!!!!!!!!!!!!!!!


        public frmLogin(Form frm)
        {
            InitializeComponent();
            this.frmMAIN = frm;
            txtBoxAdmin.SelectedText = "";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtBoxAdmin.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Close this
            this.Close();
            frmMAIN.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool Login = false;
            string User = txtBoxAdmin.Text;
            string Password = txtBoxPassword.Text;
            try
            {

                sqlConn.Open();


                SqlCommand sqlComm = new SqlCommand("SELECT * FROM tbLogin ", sqlConn);

                SqlDataReader dataReader = sqlComm.ExecuteReader();

                while (dataReader.Read())
                {
                    if (User == dataReader["User"].ToString() && Password == dataReader["password"].ToString())
                    {
                        Login = true;
                        Permission = Convert.ToInt32(dataReader["Permission"]); //!!!!!!!!!!!!!!!!!!!!!!!!
                        break;
                    }

                }

                /////////////////////////nottt
                //Login = true;

                // Is rigth Ifo?
                if (Login)
                {

                    this.Close();
                    MessageBox.Show("Giris basarili");

                    //Go to new Page
                    Form dashBoard = new frmDashboard(Permission);  //!!!!!!!!!!!!!!!!!!!!!!!!

                    

                    dashBoard.Show();
                }
                else
                {
                    MessageBox.Show("yanlis Admin veya password !!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            if (Login)
            {
                //FillLoginRegister(User, Password, Permission);
                try
                {

                    sqlConn.Open();

                    string command = "INSERT INTO tbLoginRegister (Date, User_Name , Password , permission )" +
                        " VALUES (@date, @user_name ,@password ,@Permission)";

                    string dateTime = DateTime.Now.ToString();

                    SqlCommand sqlComm = new SqlCommand(command, sqlConn);
                    sqlComm.Parameters.AddWithValue("@date", dateTime);
                    sqlComm.Parameters.AddWithValue("@user_name", User);
                    sqlComm.Parameters.AddWithValue("@password", Password);
                    sqlComm.Parameters.AddWithValue("@Permission", Permission);

                    sqlComm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("i am in FillLoginRegister function  ");
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                }
            }


        }


        // Enter
        private void txtBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

       


       
    }
}
