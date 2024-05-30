﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_project
{

    public partial class History : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        public History()
        {
            InitializeComponent();
            InitializeDatabaseConnection();

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

                if (cbxStatus.SelectedItem != null && cbxStatus.SelectedItem.ToString() != "Search by Status")
                {
                    string status = cbxStatus.SelectedItem.ToString();
                    query += $" WHERE Status = '{status}'";
                }

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



        private void OpenChildFormInPanel()
        {
            Analytics childForm = new Analytics();
            childForm.TopLevel = false;
            panelAnalytics.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = Application.OpenForms.OfType<Admin>().FirstOrDefault();
            if (admin != null)
            {
                admin.Close();
            }

            Main main = new Main();
            main.Show();

            this.Close();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dgvItems.Visible = false;
            txtSearch.Visible = false;
            panelAnalytics.Visible = true;
            dgvItems.Visible = false;
            cbxStatus.Visible = false;
            btnAnalytics.Visible = false;
            lblHis.Visible = false;
            lblStat.Visible = false;
            OpenChildFormInPanel();
        }

        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            try
            {
                if (cbxStatus.SelectedIndex != null)
                {
                    string status = cbxStatus.Text;
                    {
                        for (int i = dgvItems.Rows.Count - 1; i >= 0; i--)
                        {
                            DataGridViewCell statusCell = dgvItems.Rows[i].Cells["Status"];

                            if (statusCell != null && statusCell.Value != null)
                            {
                                string statusrow = statusCell.Value.ToString();

                                if (statusrow != $"{status}")
                                {
                                    dgvItems.Rows.RemoveAt(i);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error!!!!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (cbxStatus.SelectedItem != null)
            {
                string status = cbxStatus.SelectedItem.ToString();
                DataView dataView = dataTable.DefaultView;

                // Check if the DataTable contains the column "Description"
                if (dataTable.Columns.Contains("ItemDescription"))
                {
                    // Filter based on status and search text
                    dataView.RowFilter = $"Status = '{status}' AND (ItemName LIKE '%{searchText}%' OR ItemDescription LIKE '%{searchText}%' OR ItemType LIKE '%{searchText}%' OR LocationFound LIKE '%{searchText}%' OR LocationLost LIKE '%{searchText}%')";
                }
                else
                {
                    // Filter based on status only (without Description)
                    dataView.RowFilter = $"Status = '{status}'";
                }

                // Rebind the DataGridView to the filtered DataView
                dgvItems.DataSource = dataView.ToTable();
            }
            else
            {
                // No status selected, filter based on search text only
                (dgvItems.DataSource as DataTable).DefaultView.RowFilter = $"ItemName LIKE '%{searchText}%'";
            }
        }
    }
}
