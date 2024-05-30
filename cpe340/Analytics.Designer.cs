namespace oop_project
{
    partial class Analytics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblMonth = new Label();
            cbxMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            dgvItems = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pbUnclaimed = new Guna.UI2.WinForms.Guna2ProgressBar();
            pbPending = new Guna.UI2.WinForms.Guna2ProgressBar();
            pbApproved = new Guna.UI2.WinForms.Guna2ProgressBar();
            pbDenied = new Guna.UI2.WinForms.Guna2ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.BackColor = Color.Transparent;
            lblMonth.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMonth.ForeColor = Color.Maroon;
            lblMonth.Location = new Point(43, 155);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(67, 25);
            lblMonth.TabIndex = 79;
            lblMonth.Text = "Month:";
            // 
            // cbxMonth
            // 
            cbxMonth.BackColor = Color.Transparent;
            cbxMonth.BorderColor = Color.Goldenrod;
            cbxMonth.BorderRadius = 15;
            cbxMonth.BorderThickness = 2;
            cbxMonth.CustomizableEdges = customizableEdges1;
            cbxMonth.DrawMode = DrawMode.OwnerDrawFixed;
            cbxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMonth.FillColor = Color.Maroon;
            cbxMonth.FocusedColor = Color.FromArgb(94, 148, 255);
            cbxMonth.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbxMonth.Font = new Font("Segoe UI", 10F);
            cbxMonth.ForeColor = Color.White;
            cbxMonth.HoverState.BorderColor = Color.Goldenrod;
            cbxMonth.HoverState.FillColor = Color.Maroon;
            cbxMonth.HoverState.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMonth.HoverState.ForeColor = Color.White;
            cbxMonth.ItemHeight = 30;
            cbxMonth.Items.AddRange(new object[] { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" });
            cbxMonth.ItemsAppearance.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMonth.ItemsAppearance.ForeColor = Color.White;
            cbxMonth.ItemsAppearance.SelectedBackColor = Color.Goldenrod;
            cbxMonth.ItemsAppearance.SelectedFont = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMonth.ItemsAppearance.SelectedForeColor = Color.Maroon;
            cbxMonth.Location = new Point(116, 150);
            cbxMonth.Name = "cbxMonth";
            cbxMonth.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbxMonth.Size = new Size(344, 36);
            cbxMonth.TabIndex = 80;
            cbxMonth.SelectedIndexChanged += cbxMonth_SelectedIndexChanged;
            // 
            // dgvItems
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(251, 199, 195);
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(243, 67, 54);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.ColumnHeadersHeight = 51;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(252, 217, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(247, 129, 121);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvItems.GridColor = Color.FromArgb(250, 189, 184);
            dgvItems.Location = new Point(499, 112);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(1080, 505);
            dgvItems.TabIndex = 81;
            dgvItems.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            dgvItems.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(251, 199, 195);
            dgvItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvItems.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvItems.ThemeStyle.BackColor = Color.White;
            dgvItems.ThemeStyle.GridColor = Color.FromArgb(250, 189, 184);
            dgvItems.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(243, 67, 54);
            dgvItems.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvItems.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvItems.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvItems.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvItems.ThemeStyle.HeaderStyle.Height = 51;
            dgvItems.ThemeStyle.ReadOnly = false;
            dgvItems.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(252, 217, 215);
            dgvItems.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItems.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvItems.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvItems.ThemeStyle.RowsStyle.Height = 29;
            dgvItems.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(247, 129, 121);
            dgvItems.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = false;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(208, 212);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 86);
            lblTotal.TabIndex = 82;
            lblTotal.Text = "10";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(78, 91);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(382, 48);
            guna2HtmlLabel2.TabIndex = 83;
            guna2HtmlLabel2.Text = "Lost and Found Items ";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.TopCenter;
            guna2HtmlLabel2.Click += guna2HtmlLabel2_Click;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.AutoSize = false;
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(0, 34);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(1618, 51);
            guna2HtmlLabel3.TabIndex = 86;
            guna2HtmlLabel3.Text = "A N A L Y T I C S";
            guna2HtmlLabel3.TextAlignment = ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(54, 291);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(382, 48);
            guna2HtmlLabel1.TabIndex = 87;
            guna2HtmlLabel1.Text = "Monthly Report";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.TopCenter;
            // 
            // pbUnclaimed
            // 
            pbUnclaimed.AutoRoundedCorners = true;
            pbUnclaimed.BorderRadius = 13;
            pbUnclaimed.CustomizableEdges = customizableEdges3;
            pbUnclaimed.FillColor = Color.Maroon;
            pbUnclaimed.Location = new Point(141, 389);
            pbUnclaimed.Name = "pbUnclaimed";
            pbUnclaimed.ProgressColor = Color.Goldenrod;
            pbUnclaimed.ProgressColor2 = Color.Goldenrod;
            pbUnclaimed.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pbUnclaimed.Size = new Size(319, 29);
            pbUnclaimed.TabIndex = 88;
            pbUnclaimed.Text = "guna2ProgressBar1";
            pbUnclaimed.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pbPending
            // 
            pbPending.AutoRoundedCorners = true;
            pbPending.BorderRadius = 13;
            pbPending.CustomizableEdges = customizableEdges5;
            pbPending.FillColor = Color.Maroon;
            pbPending.Location = new Point(141, 447);
            pbPending.Name = "pbPending";
            pbPending.ProgressColor = Color.Goldenrod;
            pbPending.ProgressColor2 = Color.Goldenrod;
            pbPending.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pbPending.Size = new Size(319, 29);
            pbPending.TabIndex = 89;
            pbPending.Text = "guna2ProgressBar2";
            pbPending.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pbApproved
            // 
            pbApproved.AutoRoundedCorners = true;
            pbApproved.BorderRadius = 13;
            pbApproved.CustomizableEdges = customizableEdges7;
            pbApproved.FillColor = Color.Maroon;
            pbApproved.Location = new Point(141, 505);
            pbApproved.Name = "pbApproved";
            pbApproved.ProgressColor = Color.Goldenrod;
            pbApproved.ProgressColor2 = Color.Goldenrod;
            pbApproved.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pbApproved.Size = new Size(319, 29);
            pbApproved.TabIndex = 90;
            pbApproved.Text = "guna2ProgressBar3";
            pbApproved.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pbDenied
            // 
            pbDenied.AutoRoundedCorners = true;
            pbDenied.BorderRadius = 13;
            pbDenied.CustomizableEdges = customizableEdges9;
            pbDenied.FillColor = Color.Maroon;
            pbDenied.Location = new Point(141, 565);
            pbDenied.Name = "pbDenied";
            pbDenied.ProgressColor = Color.Goldenrod;
            pbDenied.ProgressColor2 = Color.Goldenrod;
            pbDenied.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pbDenied.Size = new Size(319, 29);
            pbDenied.TabIndex = 91;
            pbDenied.Text = "guna2ProgressBar4";
            pbDenied.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(35, 389);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 92;
            label1.Text = "Unclaimed:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(43, 505);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 93;
            label2.Text = "Approved:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(54, 447);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 94;
            label3.Text = "Pending:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(60, 565);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 95;
            label4.Text = "Denied:";
            // 
            // Analytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1618, 620);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbDenied);
            Controls.Add(pbApproved);
            Controls.Add(pbPending);
            Controls.Add(pbUnclaimed);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(lblTotal);
            Controls.Add(dgvItems);
            Controls.Add(cbxMonth);
            Controls.Add(lblMonth);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Analytics";
            Text = "Analytics";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonth;
        private Guna.UI2.WinForms.Guna2ComboBox cbxMonth;
        private Guna.UI2.WinForms.Guna2DataGridView dgvItems;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ProgressBar pbUnclaimed;
        private Guna.UI2.WinForms.Guna2ProgressBar pbPending;
        private Guna.UI2.WinForms.Guna2ProgressBar pbApproved;
        private Guna.UI2.WinForms.Guna2ProgressBar pbDenied;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}