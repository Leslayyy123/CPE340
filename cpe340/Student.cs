using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_project
{
    public partial class Student : Form
    {
        private string studentId;
        public Student(string enteredId)
        {
            InitializeComponent();
            studentId = enteredId;
        }

        public void Loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private Guna2Button currentButton;

        private void ChangeButtonColor(Guna2Button clickedButton)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Maroon;
            }
 
            clickedButton.BackColor = Color.Goldenrod;

            currentButton = clickedButton;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search for the item first before making a request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        public void EnableRequestButton()
        {
            btnReq.Enabled = true;
        }

        public void DisableRequestButton()
        {
            btnReq.Enabled = false;
        }

        private void s_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(s);
            mainpanel.Show();
            ReportFoundItem reportItemForm = new ReportFoundItem(studentId);
            Loadform(reportItemForm);
        }

        private void btnSearchs_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnSearchs);
            mainpanel.Show();
            SearchItem searchItemForm = new SearchItem(this, studentId);
            Loadform(searchItemForm);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search for the item first before making a request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}