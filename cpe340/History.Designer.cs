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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvItems = new DataGridView();
            btnBack = new Button();
            panelAnalytics = new Guna.UI2.WinForms.Guna2Panel();
            lblHis = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            cbxStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            lblStat = new Label();
            btnAnalytics = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panelAnalytics.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.MistyRose;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(499, 112);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(1080, 509);
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
            // panelAnalytics
            // 
            panelAnalytics.BackColor = Color.Transparent;
            panelAnalytics.Controls.Add(dgvItems);
            panelAnalytics.Controls.Add(lblHis);
            panelAnalytics.Controls.Add(txtSearch);
            panelAnalytics.Controls.Add(cbxStatus);
            panelAnalytics.Controls.Add(lblStat);
            panelAnalytics.Controls.Add(btnAnalytics);
            panelAnalytics.CustomizableEdges = customizableEdges7;
            panelAnalytics.Location = new Point(-1, -1);
            panelAnalytics.Name = "panelAnalytics";
            panelAnalytics.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelAnalytics.Size = new Size(1619, 634);
            panelAnalytics.TabIndex = 77;
            // 
            // lblHis
            // 
            lblHis.AutoSize = false;
            lblHis.BackColor = Color.Transparent;
            lblHis.Font = new Font("Perpetua Titling MT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHis.Location = new Point(0, 34);
            lblHis.Name = "lblHis";
            lblHis.Size = new Size(1619, 51);
            lblHis.TabIndex = 90;
            lblHis.Text = "H   I   S   T   O   R   Y";
            lblHis.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 25;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FillColor = Color.Maroon;
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = Properties.Resources.loupe__3_;
            txtSearch.IconLeftOffset = new Point(20, 0);
            txtSearch.Location = new Point(44, 145);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(433, 54);
            txtSearch.TabIndex = 89;
            txtSearch.TextOffset = new Point(10, 0);
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cbxStatus
            // 
            cbxStatus.BackColor = Color.Transparent;
            cbxStatus.BorderColor = Color.Goldenrod;
            cbxStatus.BorderRadius = 15;
            cbxStatus.BorderThickness = 2;
            cbxStatus.CustomizableEdges = customizableEdges3;
            cbxStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FillColor = Color.Maroon;
            cbxStatus.FocusedColor = Color.Goldenrod;
            cbxStatus.FocusedState.BorderColor = Color.Goldenrod;
            cbxStatus.Font = new Font("Segoe UI", 10F);
            cbxStatus.ForeColor = Color.White;
            cbxStatus.HoverState.BorderColor = Color.Goldenrod;
            cbxStatus.HoverState.FillColor = Color.Maroon;
            cbxStatus.HoverState.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxStatus.HoverState.ForeColor = Color.White;
            cbxStatus.ItemHeight = 30;
            cbxStatus.Items.AddRange(new object[] { "UNCLAIMED", "APPROVED", "DENIED", "PENDING" });
            cbxStatus.ItemsAppearance.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxStatus.ItemsAppearance.ForeColor = Color.White;
            cbxStatus.ItemsAppearance.SelectedBackColor = Color.Goldenrod;
            cbxStatus.ItemsAppearance.SelectedFont = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxStatus.ItemsAppearance.SelectedForeColor = Color.Maroon;
            cbxStatus.Location = new Point(117, 222);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbxStatus.Size = new Size(344, 36);
            cbxStatus.TabIndex = 88;
            cbxStatus.SelectedIndexChanged += cbxMonth_SelectedIndexChanged;
            // 
            // lblStat
            // 
            lblStat.AutoSize = true;
            lblStat.BackColor = Color.Transparent;
            lblStat.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStat.ForeColor = Color.Maroon;
            lblStat.Location = new Point(44, 227);
            lblStat.Name = "lblStat";
            lblStat.Size = new Size(64, 25);
            lblStat.TabIndex = 87;
            lblStat.Text = "Status:";
            // 
            // btnAnalytics
            // 
            btnAnalytics.Animated = true;
            btnAnalytics.BorderRadius = 20;
            btnAnalytics.CustomizableEdges = customizableEdges5;
            btnAnalytics.DisabledState.BorderColor = Color.DarkGray;
            btnAnalytics.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAnalytics.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAnalytics.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAnalytics.FillColor = Color.Maroon;
            btnAnalytics.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnalytics.ForeColor = Color.White;
            btnAnalytics.Location = new Point(153, 310);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAnalytics.Size = new Size(225, 56);
            btnAnalytics.TabIndex = 78;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.Click += guna2Button1_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1618, 699);
            Controls.Add(btnBack);
            Controls.Add(panelAnalytics);
            FormBorderStyle = FormBorderStyle.None;
            Name = "History";
            Text = "History";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panelAnalytics.ResumeLayout(false);
            panelAnalytics.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvItems;
        private Button btnBack;
        private Guna.UI2.WinForms.Guna2Panel panelAnalytics;
        private Guna.UI2.WinForms.Guna2Button btnAnalytics;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHis;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbxStatus;
        private Label lblStat;
    }
}