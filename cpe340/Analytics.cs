using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_project
{
    public partial class Analytics : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        public Analytics()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

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
                string query = "SELECT * FROM HistoryItems";



                dataAdapter = new OleDbDataAdapter(query, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvItems.Columns.Clear();

                dgvItems.DataSource = dataTable;

                if (!dgvItems.Columns.Contains("btnShowPhoto"))
                {
                    DataGridViewButtonColumn showPhotoButtonColumn = new DataGridViewButtonColumn();
                    showPhotoButtonColumn.HeaderText = "Photo";
                    showPhotoButtonColumn.Name = "btnShowPhoto";
                    showPhotoButtonColumn.Text = "Show Photo";
                    showPhotoButtonColumn.UseColumnTextForButtonValue = true;
                    dgvItems.Columns.Add(showPhotoButtonColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private bool isPhotoFormOpen = false;
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
        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvItems.Columns["btnShowPhoto"].Index)
            {
                DataRowView selectedRow = (DataRowView)dgvItems.Rows[e.RowIndex].DataBoundItem;
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

        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMonth.SelectedIndex > -1)
            {
                string selectedMonth = cbxMonth.SelectedItem.ToString();
                LoadDataBySelectedMonth(selectedMonth);
                CountItemsByStatus(selectedMonth);
            }
        }

        private void LoadDataBySelectedMonth(string selectedMonth)
        {
            try
            {
                if (selectedMonth == "Search by Month")
                {
                    dataTable.DefaultView.RowFilter = string.Empty;
                    dgvItems.DataSource = dataTable;
                }
                else
                {
                    string query = $"SELECT * FROM FoundItem WHERE Format(DateFound, 'mmmm') = '{selectedMonth}'";
                    dataAdapter = new OleDbDataAdapter(query, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvItems.DataSource = dataTable;
                    dgvItems.Columns.Remove("Photo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        // Helper method to get the month number based on its name
        private int GetMonthNumber(string monthName)
        {
            return DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month;
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void CountItemsByStatus(string selectedMonth)
        {
            try
            {
                int totalItems = dataTable.Rows.Count;
                lblTotal.Text = $"{totalItems}";

                int unclaimedCount = dataTable.AsEnumerable().Count(row => row["Status"].ToString() == "UNCLAIMED");
                int approvedCount = dataTable.AsEnumerable().Count(row => row["Status"].ToString() == "APPROVED");
                int deniedCount = dataTable.AsEnumerable().Count(row => row["Status"].ToString() == "DENIED");
                int pendingCount = dataTable.AsEnumerable().Count(row => row["Status"].ToString() == "PENDING");

                pbUnclaimed.Value = (int)Math.Round((double)unclaimedCount / totalItems * 100);
                pbApproved.Value = (int)Math.Round((double)approvedCount / totalItems * 100);
                pbDenied.Value = (int)Math.Round((double)deniedCount / totalItems * 100);
                pbPending.Value = (int)Math.Round((double)pendingCount / totalItems * 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting items: " + ex.Message);
            }
        }
        }
}
