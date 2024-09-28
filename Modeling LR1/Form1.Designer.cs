namespace Modeling_LR1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cTC1 = new Time_Manager.RJControls.CustomTabControl();
            panel1 = new Panel();
            picBox_underline = new PictureBox();
            page_bttn2 = new Time_Manager.RJControls.CustomButton();
            page_bttn1 = new Time_Manager.RJControls.CustomButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox_underline).BeginInit();
            SuspendLayout();
            // 
            // cTC1
            // 
            cTC1.BackColor = Color.FromArgb(13, 17, 23);
            cTC1.Location = new Point(0, 86);
            cTC1.Name = "cTC1";
            cTC1.SelectedIndex = 0;
            cTC1.Size = new Size(1920, 951);
            cTC1.TabIndex = 0;
            cTC1.Load += cTC1_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 4, 9);
            panel1.Controls.Add(picBox_underline);
            panel1.Controls.Add(page_bttn2);
            panel1.Controls.Add(page_bttn1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 88);
            panel1.TabIndex = 1;
            // 
            // picBox_underline
            // 
            picBox_underline.BackColor = Color.FromArgb(255, 137, 109);
            picBox_underline.Location = new Point(35, 86);
            picBox_underline.Name = "picBox_underline";
            picBox_underline.Size = new Size(70, 2);
            picBox_underline.TabIndex = 15;
            picBox_underline.TabStop = false;
            // 
            // page_bttn2
            // 
            page_bttn2.BorderColor = Color.FromArgb(147, 154, 163);
            page_bttn2.BorderThickness = 0;
            page_bttn2.BorderVisible = false;
            page_bttn2.ButtonColor = Color.FromArgb(1, 4, 9);
            page_bttn2.ClickColor = Color.FromArgb(8, 13, 18);
            page_bttn2.CornerRadius = 9;
            page_bttn2.EnableAnimation = true;
            page_bttn2.Font = new Font("Arial", 8F, FontStyle.Bold);
            page_bttn2.HoverColor = Color.FromArgb(33, 40, 48);
            page_bttn2.Location = new Point(125, 40);
            page_bttn2.Name = "page_bttn2";
            page_bttn2.Size = new Size(100, 45);
            page_bttn2.TabIndex = 14;
            page_bttn2.Text = "N3";
            page_bttn2.TextColor = Color.FromArgb(233, 238, 245);
            // 
            // page_bttn1
            // 
            page_bttn1.BorderColor = Color.FromArgb(147, 154, 163);
            page_bttn1.BorderThickness = 0;
            page_bttn1.BorderVisible = false;
            page_bttn1.ButtonColor = Color.FromArgb(1, 4, 9);
            page_bttn1.ClickColor = Color.FromArgb(8, 13, 18);
            page_bttn1.CornerRadius = 9;
            page_bttn1.EnableAnimation = true;
            page_bttn1.Font = new Font("Arial", 8F, FontStyle.Bold);
            page_bttn1.HoverColor = Color.FromArgb(33, 40, 48);
            page_bttn1.Location = new Point(20, 40);
            page_bttn1.Name = "page_bttn1";
            page_bttn1.Size = new Size(100, 45);
            page_bttn1.TabIndex = 13;
            page_bttn1.Text = "N2";
            page_bttn1.TextColor = Color.FromArgb(233, 238, 245);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel1);
            Controls.Add(cTC1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox_underline).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Time_Manager.RJControls.CustomTabControl cTC1;
        private Panel panel1;
        private PictureBox picBox_underline;
        private Time_Manager.RJControls.CustomButton page_bttn2;
        private Time_Manager.RJControls.CustomButton page_bttn1;
    }
}
