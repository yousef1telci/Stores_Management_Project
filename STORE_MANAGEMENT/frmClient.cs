using DevExpress.Emf;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Drawing.Printing.Internal.DXPageSizeInfo;
using static DevExpress.XtraEditors.Mask.Design.MaskSettingsForm.DesignInfo.MaskManagerInfo;
using iTextSharp.text;
using iTextSharp.text.pdf; // to export Info to pdf

namespace STORE_MANAGEMENT
{
    public partial class frmClient : Form
    {
        // connection with server
        static String strConn = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
        SqlConnection sqlConn = new SqlConnection(strConn);

        string operation = "";



        public frmClient()
        {
            InitializeComponent();

            Listele();
            ButtonsControll();
        }
        public frmClient(string operation)
        {
            InitializeComponent();
            this.operation = operation;

            if (operation != "ClientsProperities")
                Listele();
            else
                JoinTbStoreAndTbClient();

            ButtonsControll();
        }


        //Functions
        public void Listele()
        {
            try
            {
                sqlConn.Open();

                string command = "SELECT * FROM tbClient";
                SqlDataAdapter da = new SqlDataAdapter(command, sqlConn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                gridViewClient.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            txtFullName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";

            gridViewClient.Columns[0].Width = (gridViewClient.Width * 14) / 100;
            gridViewClient.Columns[1].Width = (gridViewClient.Width * 18) / 100;
            gridViewClient.Columns[2].Width = (gridViewClient.Width * 20) / 100;
            gridViewClient.Columns[3].Width = (gridViewClient.Width * 40) / 100;

        }

        public void ButtonsControll()
        {
            //buttons
            if (operation == "AddClient")
            {
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnAdd.Location = new Point(5, 390);
                btnExportToPdf.Visible = false;
            }
            if (operation == "DeleteClient")
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Location = new Point(5, 390);
                btnExportToPdf.Visible = false;
            }
            if (operation == "UpdateClient")
            {
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                btnUpdate.Location = new Point(5, 390);
                btnExportToPdf.Visible = false;
            }
            if (operation == "ClientsProperities")
            {
                panelControl1.Visible = false;
                gridViewClient.Size = new Size(960, 380);
                gridViewClient.Location = new Point(20, 56);
                txtSearch.Location = new Point(20, 5);
                btnExportToPdf.Location = new Point(249 ,488);
            }
        }

        public void AddClient()
        {
            try
            {
                sqlConn.Open();

                string command = "INSERT INTO tbClient (Client_Name, Client_Phone ,Client_Address )" +
                    " VALUES (@name, @phone , @address )";

                SqlCommand sqlComm = new SqlCommand(command, sqlConn);


                sqlComm.Parameters.AddWithValue("@name", txtFullName.Text);
                sqlComm.Parameters.AddWithValue("@phone", txtPhone.Text);
                sqlComm.Parameters.AddWithValue("@address", txtAddress.Text);

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
            txtFullName.Text = gridViewClient.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = gridViewClient.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = gridViewClient.CurrentRow.Cells[3].Value.ToString();

            btnDelete.Text = "DELETE NOW";
            btnUpdate.Text = "Update Now";
        }

        public void DeleteClient()
        {
            DialogResult onay = MessageBox.Show("kaydi silmek istediginize eminmisiniz", "onay kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    sqlConn.Open();
                    string id = gridViewClient.CurrentRow.Cells[0].Value.ToString();

                    SqlCommand sqlComm = new SqlCommand("DELETE FROM tbClient WHERE Client_Id ='" + id + "'", sqlConn);
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

        public void UpateClient()
        {
            try
            {
                sqlConn.Open();

                string id = gridViewClient.CurrentRow.Cells[0].Value.ToString();

                string command = "UPDATE tbClient set" +
                    " Client_Name='" + txtFullName.Text +
                    "' , Client_Phone='" + txtPhone.Text +
                    "' , Client_Address='" + txtAddress.Text +
                    "' WHERE Client_Id = '" + id + "'";

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

        public void JoinTbStoreAndTbClient()
        {
            try
            {
                sqlConn.Open();
                string command = "SELECT Client_Name , Client_Phone ,Category , Store_Name , Store_Id" +
                    " FROM tbClient c join tbStores s " +
                    "on c.Client_Id = s.Client_Id";

                SqlDataAdapter da = new SqlDataAdapter(command, sqlConn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                gridViewClient.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close() ;
            }

            gridViewClient.Columns[0].Width = (gridViewClient.Width * 18) / 100;
            gridViewClient.Columns[1].Width = (gridViewClient.Width * 18) / 100;
            gridViewClient.Columns[2].Width = (gridViewClient.Width * 15) / 100;
            gridViewClient.Columns[3].Width = (gridViewClient.Width * 22) / 100;
            gridViewClient.Columns[4].Width = (gridViewClient.Width * 12) / 100;
        }


        ///button

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClient();
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
                DeleteClient();
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
            if (btnUpdate.Text == "Update Now")
            {
                UpateClient();
                return;
            }
        }


        //Search textbox
        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Black;
            try
            {
                if (!String.IsNullOrEmpty(txtSearch.Text))
                {
                    string command = "SELECT * FROM tbClient WHERE " +
                    "Client_Id LIKE @param OR " +
                    "Client_Name LIKE @param OR " +
                    "Client_Phone LIKE @param OR " +
                    "Client_Address LIKE @param ";


                    SqlDataAdapter sqlDa = new SqlDataAdapter(command, sqlConn);

                    sqlDa.SelectCommand.Parameters.AddWithValue("@param", "%" + txtSearch.Text + "%");
                    ///;
                    DataTable dt = new DataTable();
                    sqlDa.Fill(dt);
                    ///
                    gridViewClient.DataSource = dt;
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

        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            if (gridViewClient.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "Result.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(gridViewClient.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;


                            foreach (DataGridViewColumn col in gridViewClient.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in gridViewClient.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    //pTable.AddCell(dcell.Value.ToString());
                                    if (dcell.Value != null)
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                    else
                                    {
                                        pTable.AddCell(""); 
                                    }


                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(iTextSharp.text.PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Data Export Successfully", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }
        }
    }
}
