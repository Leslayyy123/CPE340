namespace oop_project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbxClose = new PictureBox();
            pbxMin = new PictureBox();
            pbxMax = new PictureBox();
            tbxIDD = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).BeginInit();
            SuspendLayout();
            // 
            // pbxClose
            // 
            pbxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxClose.BackColor = Color.Transparent;
            pbxClose.BackgroundImage = (Image)resources.GetObject("pbxClose.BackgroundImage");
            pbxClose.BackgroundImageLayout = ImageLayout.Zoom;
            pbxClose.Location = new Point(1598, 11);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(28, 35);
            pbxClose.TabIndex = 6;
            pbxClose.TabStop = false;
            pbxClose.Click += pbxClose_Click;
            // 
            // pbxMin
            // 
            pbxMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxMin.BackColor = Color.Transparent;
            pbxMin.BackgroundImage = (Image)resources.GetObject("pbxMin.BackgroundImage");
            pbxMin.BackgroundImageLayout = ImageLayout.Zoom;
            pbxMin.Location = new Point(1496, 12);
            pbxMin.Name = "pbxMin";
            pbxMin.Size = new Size(34, 34);
            pbxMin.TabIndex = 11;
            pbxMin.TabStop = false;
            pbxMin.Click += pbxMin_Click;
            // 
            // pbxMax
            // 
            pbxMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxMax.BackColor = Color.Transparent;
            pbxMax.BackgroundImage = (Image)resources.GetObject("pbxMax.BackgroundImage");
            pbxMax.BackgroundImageLayout = ImageLayout.Zoom;
            pbxMax.Location = new Point(1549, 12);
            pbxMax.Name = "pbxMax";
            pbxMax.Size = new Size(33, 34);
            pbxMax.TabIndex = 10;
            pbxMax.TabStop = false;
            pbxMax.Click += pbxMax_Click;
            // 
            // tbxIDD
            // 
            tbxIDD.BackColor = Color.Transparent;
            tbxIDD.BorderColor = Color.White;
            tbxIDD.BorderRadius = 25;
            tbxIDD.BorderThickness = 4;
            tbxIDD.CustomizableEdges = customizableEdges1;
            tbxIDD.DefaultText = "";
            tbxIDD.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxIDD.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxIDD.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxIDD.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxIDD.FillColor = Color.Maroon;
            tbxIDD.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxIDD.Font = new Font("Segoe UI", 9F);
            tbxIDD.ForeColor = Color.White;
            tbxIDD.HoverState.BorderColor = Color.White;
            tbxIDD.Location = new Point(902, 640);
            tbxIDD.Margin = new Padding(3, 4, 3, 4);
            tbxIDD.Name = "tbxIDD";
            tbxIDD.PasswordChar = '\0';
            tbxIDD.PlaceholderForeColor = Color.White;
            tbxIDD.PlaceholderText = "ID NUMBER";
            tbxIDD.SelectedText = "";
            tbxIDD.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbxIDD.Size = new Size(628, 60);
            tbxIDD.TabIndex = 16;
            tbxIDD.TextAlign = HorizontalAlignment.Center;
            tbxIDD.TextChanged += tbxIDD_TextChanged;
            tbxIDD.KeyDown += tbxIDD_KeyDown;
            tbxIDD.Leave += tbxIDD_Leave;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Are_you__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1636, 1055);
            Controls.Add(tbxIDD);
            Controls.Add(pbxMin);
            Controls.Add(pbxMax);
            Controls.Add(pbxClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbxClose;
        private PictureBox pbxMin;
        private PictureBox pbxMax;
        private Guna.UI2.WinForms.Guna2TextBox tbxIDD;
    }
}