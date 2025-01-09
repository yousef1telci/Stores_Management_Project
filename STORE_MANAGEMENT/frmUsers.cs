using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace STORE_MANAGEMENT
{
    public partial class frmUsers : Form
    {
        // connection with server
        static String strConn = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
        SqlConnection sqlConn = new SqlConnection(strConn);

        public frmUsers()
        {
            InitializeComponent();
            Listele();
        }
        public frmUsers(string type)
        {
            InitializeComponent();
            Listele();

            //buttons
            if (type == "add")
            {
                btnDeleteUser.Visible = false;
                btnUpdateUser.Visible = false;
                btnAddUser.Location = new Point(9 , 462);
            }
            if (type == "delete")
            {
                btnAddUser.Visible = false;
                btnUpdateUser.Visible = false;
                btnDeleteUser.Location = new Point(9, y: 462);

                //Label lbl = new Label
                //{
                //    Text = "SELECTE A CELL FOR DELETE USER",
                //    Location = new Point(30, 90),
                //    AutoSize = true, // يتيح للتسمية التكيف مع النص
                //    Font = new Font("Arial", 12, FontStyle.Bold), // تعيين خط مناسب
                //    ForeColor = Color.White // تغيير لون النص إذا أردت
                //};

                //// إضافة التسمية إلى النموذج
                //panel1.Controls.Add(lbl);

            }
            if (type == "update")
            {
                btnDeleteUser.Visible = false;
                btnAddUser.Visible = false;
                btnUpdateUser.Location = new Point(9, y: 462);

            }
            if (type == "LoginRegister")
            {
                panel1.Visible = false;
                gridViewUsers.Size = new Size(960, 380);
                gridViewUsers.Location = new Point(20, 56);
                txtBoxSearch.Location = new Point(20, 5);
                ListeleLoginRegister();
            }

        }


        public void Listele()
        {
            try
            {
                sqlConn.Open();

                string command = "SELECT * FROM tbLogin";
                SqlDataAdapter da = new SqlDataAdapter(command, sqlConn);


                DataTable dt = new DataTable();
                da.Fill(dt);

                gridViewUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata");
            }
            finally
            {
                sqlConn.Close();
            }

            // CLear
            ClearScreen();
        }
       
        public void ClearScreen()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        public void AddUser()
        {
            try
            {
                sqlConn.Open();

                string command = "INSERT INTO tbLogin ([User], [Password] , Permission) VALUES (@user, @password , @Permission)";

                SqlCommand sqlComm = new SqlCommand(command, sqlConn);
                sqlComm.Parameters.AddWithValue("@user", txtUserName.Text);
                sqlComm.Parameters.AddWithValue("@password", txtPassword.Text);
                sqlComm.Parameters.AddWithValue("@Permission", GetPermission());

                sqlComm.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                sqlConn.Close(); 
                Listele();
            }
        }

        public void DeleteUser()
        {
            DialogResult onay = MessageBox.Show("kaydi silmek istediginize eminmisiniz", "onay kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    sqlConn.Open();
                    string id = gridViewUsers.CurrentRow.Cells[0].Value.ToString();

                    SqlCommand sqlComm = new SqlCommand("DELETE FROM tbLogin WHERE Id ='" + id + "'", sqlConn);
                    sqlComm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConn.Close();
                    Listele();
                }
            }
        }

        public void FillInfo()
        {
            txtUserName.Text = gridViewUsers.CurrentRow.Cells [1].Value.ToString();
            txtPassword.Text = gridViewUsers.CurrentRow.Cells [2].Value.ToString();

            int permission = Convert.ToInt32(gridViewUsers.CurrentRow.Cells[3].Value);

            switch (permission) 
            {
                case -1: rdioBtnAll.Select(); 
                    break;
                case 1: rdioBtnUsers.Select();
                    break;
                case 2:
                    rdioBtnStores.Select();
                    break;
                case 3:
                    rdioBtnClients.Select();
                    break;
            }


            btnUpdateUser.Text = "Update Now";
            btnDeleteUser.Text = "DELETE NOW";
        }

        public void UpdateUser()
        {
            try
            {

                string id = gridViewUsers.CurrentRow.Cells[0].Value.ToString();
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tbLogin set [User]='" + txtUserName.Text + "' , Password='" + txtPassword.Text + "' WHERE Id='" + id + "'", sqlConn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close ();
                btnUpdateUser.Text = "Update";
            }

            Listele();
        }

        public int GetPermission()
        {
            if (rdioBtnAll.Checked)
            {
                return -1;
            }
            if (rdioBtnUsers.Checked)
            {
                return 1;

            }
            if (rdioBtnStores.Checked)
            {
                return 2;
            }
            if (rdioBtnClients.Checked)
            {
                return 3;
            }

            return 0;
        }

        public void ListeleLoginRegister()
        {
           
             try
            {
                sqlConn.Open();

                string command = "SELECT * FROM tbLoginRegister";
                SqlDataAdapter da = new SqlDataAdapter(command, sqlConn);


                DataTable dt = new DataTable();
                da.Fill(dt);

                gridViewUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata");
            }
            finally
            {
                sqlConn.Close();
            }

            //gridViewUsers.Columns[0].Width = (gridViewUsers.Width * 35) / 100;
            //gridViewUsers.Columns[1].Width = (gridViewUsers.Width * 20) / 100;
            //gridViewUsers.Columns[2].Width = (gridViewUsers.Width * 20) / 100;
            //gridViewUsers.Columns[3].Width = (gridViewUsers.Width * 10) / 100;

            // CLear
            ClearScreen();
        }

     

        //search box
        public void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtBoxSearch.Text))
                {
                    string command = "SELECT * FROM tbLogin WHERE " +
                    "Id LIKE @param OR " +
                    "[User] LIKE @param OR " +
                    "Password LIKE @param";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(command, sqlConn);

                    sqlDa.SelectCommand.Parameters.AddWithValue("@param", "%" + txtBoxSearch.Text + "%");
                    ///;
                    DataTable dt = new DataTable();
                    sqlDa.Fill(dt);
                    ///
                    gridViewUsers.DataSource = dt;
                    gridViewUsers.Columns[0].Width = (gridViewUsers.Width * 5) / 100;
                    gridViewUsers.Columns[1].Width = (gridViewUsers.Width * 15) / 100;
                    gridViewUsers.Columns[2].Width = (gridViewUsers.Width * 20) / 100;

                }
                else
                {
                    Listele();
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
        }

        private void txtBoxSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxSearch.SelectAll();
        }


        //////buttons

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (btnDeleteUser.Text == "Delete")
            {
                FillInfo();
                return;
            }

            if (btnDeleteUser.Text == "DELETE NOW")
            {
                DeleteUser();
                return;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (btnUpdateUser.Text == "Update")
            {
                FillInfo();
                return;
            }
            if (btnUpdateUser.Text == "Update Now")
            {
                UpdateUser();
                return;
            }
        }


    }
}
