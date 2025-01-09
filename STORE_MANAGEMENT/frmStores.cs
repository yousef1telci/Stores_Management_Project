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

namespace STORE_MANAGEMENT
{
    public partial class frmStores : Form
    {
        // connection with server
        static String strConn = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
        SqlConnection sqlConn = new SqlConnection(strConn);

        string operation = "";

        public frmStores()
        {
            InitializeComponent();
            Listele();
            FillCategory();
            ButtonsControll();
        }
        public frmStores(string operation)
        {
            InitializeComponent();
            this.operation = operation;

            Listele();
            FillCategory();
            ButtonsControll();
        }


        public void Listele()
        {
            try
            {
                sqlConn.Open();

                string command = "SELECT * FROM tbStores";
                SqlDataAdapter da = new SqlDataAdapter(command, sqlConn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                gridViewStores.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            txtStoreName.Text = "";
            txtPhone.Text = "";
            txtOwnerId.Text = "";
            txtEmail.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
            cmbCategory.Text = "";

            gridViewStores.Columns[0].Visible = false;
            gridViewStores.Columns[1].Width = (gridViewStores.Width * 18) / 100;
            gridViewStores.Columns[2].Width = (gridViewStores.Width * 20) / 100;
            gridViewStores.Columns[3].Width = (gridViewStores.Width * 20) / 100;
            gridViewStores.Columns[4].Width = (gridViewStores.Width * 30) / 100;
            gridViewStores.Columns[5].Width = (gridViewStores.Width * 30) / 100;
            gridViewStores.Columns[6].Width = (gridViewStores.Width * 30) / 100;

        }

        public void FillCategory()
        {
            try
            {
                string command = "SELECT* FROM tbCategory";
                SqlCommand sqlComm = new SqlCommand(command, sqlConn);

                sqlConn.Open();
                SqlDataReader dr = sqlComm.ExecuteReader();

                while (dr.Read())
                {
                    cmbCategory.Items.Add(dr["Category"]);
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

        public void ButtonsControll()
        {
            //buttons
            if (operation == "AddStore")
            {
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnAdd.Location = new Point(5, 490);
            }
            if (operation == "DelelteStore")
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Location = new Point(5, 490);

            }
            if (operation == "UpdateStore")
            {
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                btnUpdate.Location = new Point(5, 490);

            }
        }

        public void AddStore()
        {
            try
            {
                sqlConn.Open();

                string command = "INSERT INTO tbStores (Category, Store_Name ,City , email ,Phone , Address , Client_Id)" +
                    " VALUES (@category, @store_name , @city ,@email, @phone , @address ,@client_id)";

                SqlCommand sqlComm = new SqlCommand(command, sqlConn);

                int clientId = int.Parse(txtOwnerId.Text);

                sqlComm.Parameters.AddWithValue("@category", cmbCategory.SelectedItem);
                sqlComm.Parameters.AddWithValue("@store_name", txtStoreName.Text);
                sqlComm.Parameters.AddWithValue("@city", txtCity.Text);
                sqlComm.Parameters.AddWithValue("@email", txtEmail.Text);
                sqlComm.Parameters.AddWithValue("@phone", txtPhone.Text);
                sqlComm.Parameters.AddWithValue("@address", txtAddress.Text);
                sqlComm.Parameters.AddWithValue("@client_id", clientId);

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

        public void FillInfo()
        {
            cmbCategory.Text = gridViewStores.CurrentRow.Cells[1].Value.ToString();
            txtStoreName.Text = gridViewStores.CurrentRow.Cells[2].Value.ToString();
            txtCity.Text = gridViewStores.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = gridViewStores.CurrentRow.Cells[4].Value.ToString();
            txtPhone.Text = gridViewStores.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = gridViewStores.CurrentRow.Cells[6].Value.ToString();
            txtOwnerId.Text = gridViewStores.CurrentRow.Cells[7].Value.ToString();

            btnDelete.Text = "DELETE NOW";
            btnUpdate.Text = "Update Now";
        }

        public void CleanTextBoxs()
        {
            cmbCategory.Text = "";
            txtStoreName.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtOwnerId.Text = "";
        }

        public void DeleteStore()
        {
            DialogResult onay = MessageBox.Show("kaydi silmek istediginize eminmisiniz", "onay kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    sqlConn.Open();
                    string id = gridViewStores.CurrentRow.Cells[0].Value.ToString();

                    SqlCommand sqlComm = new SqlCommand("DELETE FROM tbStores WHERE Store_Id ='" + id + "'", sqlConn);
                    sqlComm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    btnDelete.Text = "Delete";
                    sqlConn.Close();
                }
                Listele();
            }
        }

        public void UpdateStore()
        {
            try
            {
                sqlConn.Open();

                string id = gridViewStores.CurrentRow.Cells[0].Value.ToString();

                string command = "UPDATE tbStores set" +
                    " Category='" + cmbCategory.Text +
                    "' , Store_Name='" + txtStoreName.Text +
                    "' , City='" + txtCity.Text +
                    "' , email='" + txtEmail.Text +
                    "' , Phone='" + txtPhone.Text +
                    "' , Address='" + txtAddress.Text +
                    "' , Client_Id='" + txtOwnerId.Text +
                    "' WHERE Store_Id='" + id + "'";

                SqlCommand cmd = new SqlCommand(command, sqlConn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
                btnUpdate.Text = "Update";
            }

            Listele();
        }


        //////////////////////////////////////BUTTONS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStore();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Black;
            try
            {
                if (!String.IsNullOrEmpty(txtSearch.Text))
                {
                    string command = "SELECT * FROM tbStores WHERE " +
                    "Store_Id LIKE @param OR " +
                    "Category LIKE @param OR " +
                    "Store_Name LIKE @param OR " +
                    "City LIKE @param OR " +
                    "email LIKE @param OR " +
                    "Phone LIKE @param OR " +
                    "Address LIKE @param OR " +
                    "Client_Id LIKE @param  ";

                    SqlDataAdapter sqlDa = new SqlDataAdapter(command, sqlConn);

                    sqlDa.SelectCommand.Parameters.AddWithValue("@param", "%" + txtSearch.Text + "%");
                    ///;
                    DataTable dt = new DataTable();
                    sqlDa.Fill(dt);
                    ///
                    gridViewStores.DataSource = dt;
                    //gridViewStores.Columns[0].Width = (gridViewStores.Width * 5) / 100;
                    //gridViewStores.Columns[1].Width = (gridViewStores.Width * 15) / 100;
                    //gridViewStores.Columns[2].Width = (gridViewStores.Width * 20) / 100;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Delete") 
            {
                FillInfo();
                return;
            }

            if (btnDelete.Text == "DELETE NOW")
            {
                DeleteStore();
                gridViewStores.ClearSelection();
                return;
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update") 
            {
               FillInfo();
                return;
            }
            if(btnUpdate.Text == "Update Now") 
            {
                UpdateStore();
                return;
            }
        }
        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.SelectAll();
        }

       
    }
}
