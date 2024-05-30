using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;

namespace oop_project
{
    public partial class RetrievalRequests : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        private string currentTableName = "";
        private string AdminID;
        public RetrievalRequests()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadDataIntoDataGridView();
        }

        private void InitializeDatabaseConnection()
        {
            try
            {

                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Leslie\\OneDrive - Cebu Institute of Technology University\\Desktop\\Database2.mdb";
                

                connection = new OleDbConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                string query = $"SELECT * FROM LostItem";

                dataAdapter = new OleDbDataAdapter(query, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvRequest.DataSource = dataTable;
                ;
                dgvRequest.Columns.Remove("Course");
                dgvRequest.Columns.Remove("YearLevel");
                dgvRequest.Columns.Remove("ContactNumber");
                dgvRequest.Columns.Remove("ItemType");

                if (dgvRequest.Columns.Contains("btnShowPhoto"))
                {
                    dgvRequest.Columns.Remove("btnShowPhoto");
                }

                if (dgvRequest.Columns.Contains("Photo"))
                {
                    dgvRequest.Columns.Remove("Photo");
                }

                DataGridViewButtonColumn showPhotoButtonColumn = new DataGridViewButtonColumn();
                showPhotoButtonColumn.HeaderText = "Photo";
                showPhotoButtonColumn.Name = "btnShowPhoto";
                showPhotoButtonColumn.Text = "Show Photo";
                showPhotoButtonColumn.UseColumnTextForButtonValue = true;
                dgvRequest.Columns.Add(showPhotoButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin adminForm = Application.OpenForms.OfType<Admin>().FirstOrDefault();
            if (adminForm != null)
            {
                adminForm.Close();
            }

            Main main = new Main();
            main.Show();

            this.Close();
        }

        private void RetrievalRequests_Load(object sender, EventArgs e)
        {

        }

        private void UpdateLostItemStatus(string itemName, string status)
        {
            try
            {
                connection.Open();

                string updateQuery = "UPDATE FoundItem SET Status = @Status WHERE ItemName = @ItemName";
                OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection);

                updateCommand.Parameters.AddWithValue("@Status", status);
                updateCommand.Parameters.AddWithValue("@ItemName", itemName);

                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvRequest.SelectedRows.Count > 0)
            {
                string itemName = dgvRequest.SelectedRows[0].Cells["ItemName"].Value.ToString();

                UpdateLostItemStatus(itemName, "APPROVED");

                if (DeleteAcceptedRequestFromRetrievalRequests(itemName))
                {
                    MessageBox.Show("Item has been successfully accepted and removed from the requests.");

                    LoadDataIntoDataGridView();

                    UpdateStatusInViewForm(itemName, "APPROVED");
                }
                else
                {
                    MessageBox.Show("Failed to delete the request from RetrievalRequests table.");
                }
            }
            else
            {
                MessageBox.Show("Please select a request to accept.");
            }
        }
        
        private bool DeleteAcceptedRequestFromRetrievalRequests(string itemName)
        {
            try
            {
                connection.Open();

                string deleteQuery = "DELETE FROM LostItem WHERE ItemName = @ItemName";
                OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@ItemName", itemName);

                int rowsAffected = deleteCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting request from RequestRetrieval table: " + ex.Message);
                return false;
            }
        }


        private void UpdateStatusInViewForm(string itemName, string status)
        {
            View viewForm = Application.OpenForms.OfType<View>().FirstOrDefault();
            if (viewForm != null)
            {
                viewForm.UpdateItemStatus(itemName, status);
            }
        }
        
        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (dgvRequest.SelectedRows.Count > 0)
            {
                string itemName = dgvRequest.SelectedRows[0].Cells["ItemName"].Value.ToString();

                UpdateLostItemStatus(itemName, "DENIED");

                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a request to accept.");
            }
        }



        private bool isPhotoFormOpen = false;
        public void AddtoHistory()
        {
            try
            {
                string studName = string.Empty, itemName = string.Empty, Event, eventDate;

                if (dgvRequest.SelectedRows.Count > 0)
                {

                    DataGridViewRow selectedRow = dgvRequest.SelectedRows[0];


                     studName = selectedRow.Cells["StudentName"].Value.ToString();
                     itemName = selectedRow.Cells["ItemName"].Value.ToString();


                    
                }
                else
                {
                    MessageBox.Show("No row is selected.");
                }
                
           
                Event = "Report Found Item";
                eventDate = dtpRequest.Value.ToString("dd/MM/yyyy");
                using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Leslie\\OneDrive - Cebu Institute of Technology University\\Desktop\\Database2.mdb"))
                {
                    myConn.Open();

                    string query = "INSERT INTO HistoryItems (UserID, StudentName, Event, EventDate,ItemName) " +
                                "VALUES (@studentID, @studentName, @event, @eventDate, @itemName)";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", AdminID);
                        cmd.Parameters.AddWithValue("@studentName", studName);
                        cmd.Parameters.AddWithValue("@event", Event);
                        cmd.Parameters.AddWithValue("@eventDate", eventDate);
                        cmd.Parameters.AddWithValue("@itemName", itemName);

                        cmd.ExecuteNonQuery();
                        myConn.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvRequest.Columns["btnShowPhoto"].Index)
            {
                DataRowView selectedRow = (DataRowView)dgvRequest.Rows[e.RowIndex].DataBoundItem;
                byte[] photoBytes = (byte[])selectedRow["Photo"];

                if (photoBytes != null && photoBytes.Length > 0)
                {
                    ShowPhotoPopup(photoBytes);
                }
                else
                {
                    MessageBox.Show("No photo available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ShowPhotoPopup(byte[] photoBytes)
        {
            Form photoForm = new Form();
            photoForm.Text = "Photo";
            photoForm.Size = new Size(400, 400);
            photoForm.StartPosition = FormStartPosition.CenterScreen;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            using (MemoryStream ms = new MemoryStream(photoBytes))
            {
                pictureBox.Image = Image.FromStream(ms);
            }

            photoForm.Controls.Add(pictureBox);

            photoForm.FormClosed += (sender, e) =>
            {
                pictureBox.Dispose();
                photoForm.Dispose();
                isPhotoFormOpen = false;
            };

            photoForm.Show();

            isPhotoFormOpen = true;
        }
        private void ApplyFilter()
        {
            try
            {
                if (dgvRequest.DataSource is DataTable dataTable)
                {
                    if (!string.IsNullOrWhiteSpace(tbxSearch.Text) && tbxSearch.Text != "Search")
                    {
                        string keyword = tbxSearch.Text.Trim(); 

                        dataTable.DefaultView.RowFilter =
                            $"ItemName LIKE '%{keyword}%' OR " +
                            $"LocationLost  LIKE '%{keyword}%' OR " +
                            $"Course LIKE '%{keyword}%' OR " +
                            $"StudentName LIKE '%{keyword}%' OR " +
                             $"YearLevel LIKE '%{keyword}%' OR " +
                            $"ItemDescription LIKE '%{keyword}%' OR " +
                            $"ItemType LIKE '%{keyword}%' OR " +
                            $"Status LIKE '%{keyword}%'";
                    }
                    else
                    {
                        dataTable.DefaultView.RowFilter = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "Search")
            {
                tbxSearch.Text = "";
            }

            tbxSearch.ForeColor = Color.White;

            ApplyFilter();
        }

        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearch.Text) || tbxSearch.Text == "Search")
            {
                tbxSearch.Text = "Search";
            }
        }

        private void tbxSearch_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
        }
    }
}
