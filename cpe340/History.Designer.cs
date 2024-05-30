namespace oop_project
{
    partial class History
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
            cbxMonth = new ComboBox();
            tbxSearch = new TextBox();
            dgvItems = new DataGridView();
            btnBack = new Button();
            cbxFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // cbxMonth
            // 
            cbxMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMonth.FormattingEnabled = true;
            cbxMonth.Items.AddRange(new object[] { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY ", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER ", "NOVEMBER", "DECEMBER" });
            cbxMonth.Location = new Point(30, 90);
            cbxMonth.Name = "cbxMonth";
            cbxMonth.Size = new Size(236, 36);
            cbxMonth.TabIndex = 75;
            cbxMonth.Text = "Search by Month";
            cbxMonth.SelectedIndexChanged += cbxMonth_SelectedIndexChanged;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Maroon;
            tbxSearch.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.ForeColor = Color.White;
            tbxSearch.Location = new Point(30, 14);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(1559, 54);
            tbxSearch.TabIndex = 74;
            tbxSearch.Text = "Search";
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // dgvItems
            // 
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.MistyRose;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(289, 90);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(1289, 529);
            dgvItems.TabIndex = 73;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.Maroon;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1459, 639);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 45);
            btnBack.TabIndex = 72;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cbxFilter
            // 
            cbxFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxFilter.FormattingEnabled = true;
            cbxFilter.Items.AddRange(new object[] { "CLAIMED", "UNCLAIMED", "DENIED", "PENDING", "APPROVED" });
            cbxFilter.Location = new Point(30, 152);
            cbxFilter.Name = "cbxFilter";
            cbxFilter.Size = new Size(236, 36);
            cbxFilter.TabIndex = 76;
            cbxFilter.Text = "Search by Status";
            cbxFilter.SelectedIndexChanged += cbxFilter_SelectedIndexChanged;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1618, 699);
            Controls.Add(cbxFilter);
            Controls.Add(cbxMonth);
            Controls.Add(tbxSearch);
            Controls.Add(dgvItems);
            Controls.Add(btnBack);
            Name = "History";
            Text = "History";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxMonth;
        private TextBox tbxSearch;
        private DataGridView dgvItems;
        private Button btnBack;
        private ComboBox cbxFilter;
    }
}