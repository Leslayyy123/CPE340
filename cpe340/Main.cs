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

namespace oop_project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Leslie\\OneDrive - Cebu Institute of Technology University\\Desktop\\Database2.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet? ds;
        OleDbDataAdapter da = new OleDbDataAdapter();

        
       
        private bool IsStudentID(string id)
        {

            string query = "SELECT COUNT(*) FROM StudentInfo WHERE StudentID = @ID";
            return IDExists(query, id);
        }

        private bool IsAdminID(string id)
        {
            string query = "SELECT COUNT(*) FROM AdminInfo WHERE AdminID = @ID";
            return IDExists(query, id);
        }

        private bool IDExists(string query, string id)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Connection = myConn;
                myConn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                myConn.Close();
            }
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxIDD_TextChanged(object sender, EventArgs e)
        {
            if (tbxIDD.Text == "ID NUMBER")
            {
                tbxIDD.Text = "";
            }
        }

        private void tbxIDD_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxIDD.Text) || tbxIDD.Text == "ID NUMBER")
            {
                tbxIDD.Text = "ID NUMBER";
            }
        }

        private void tbxIDD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string enteredID = tbxIDD.Text.Trim();

                if (!string.IsNullOrWhiteSpace(enteredID) && enteredID != "ID NUMBER")
                {
                    if (IsStudentID(enteredID))
                    {
                        Student studentForm = new Student(enteredID);
                        studentForm.Show();
                        this.Hide();
                    }
                    else if (IsAdminID(enteredID))
                    {
                        Admin adminForm = new Admin();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID entered. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID.");
                }
            }
        }
    }
}
