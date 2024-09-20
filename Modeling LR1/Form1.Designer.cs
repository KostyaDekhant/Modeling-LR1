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
            grid_input = new DataGridView();
            input_lb = new Label();
            calc_bttn = new Time_Manager.RJControls.CustomButton();
            calc_panel = new Panel();
            line_lb2 = new Label();
            line_lb = new Label();
            a_b_lb = new Label();
            solve_lb = new Label();
            grid_output = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid_input).BeginInit();
            calc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_output).BeginInit();
            SuspendLayout();
            // 
            // grid_input
            // 
            grid_input.BackgroundColor = Color.FromArgb(1, 4, 9);
            grid_input.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_input.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_input.Location = new Point(53, 82);
            grid_input.Name = "grid_input";
            grid_input.RowHeadersWidth = 51;
            grid_input.Size = new Size(175, 207);
            grid_input.TabIndex = 0;
            // 
            // input_lb
            // 
            input_lb.AutoSize = true;
            input_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            input_lb.ForeColor = Color.White;
            input_lb.Location = new Point(53, 43);
            input_lb.Name = "input_lb";
            input_lb.Size = new Size(105, 20);
            input_lb.TabIndex = 1;
            input_lb.Text = "Ввод данных";
            // 
            // calc_bttn
            // 
            calc_bttn.BorderColor = Color.FromArgb(147, 154, 163);
            calc_bttn.BorderThickness = 0;
            calc_bttn.BorderVisible = true;
            calc_bttn.ButtonColor = Color.FromArgb(33, 40, 48);
            calc_bttn.ClickColor = Color.FromArgb(33, 40, 48);
            calc_bttn.CornerRadius = 0;
            calc_bttn.EnableAnimation = true;
            calc_bttn.Font = new Font("Arial", 7F, FontStyle.Bold);
            calc_bttn.HoverColor = Color.FromArgb(33, 40, 48);
            calc_bttn.Location = new Point(145, 295);
            calc_bttn.Name = "calc_bttn";
            calc_bttn.Size = new Size(83, 34);
            calc_bttn.TabIndex = 2;
            calc_bttn.Text = "Построить";
            calc_bttn.TextColor = Color.FromArgb(233, 238, 245);
            calc_bttn.Click += calc_bttn_Click;
            // 
            // calc_panel
            // 
            calc_panel.BorderStyle = BorderStyle.FixedSingle;
            calc_panel.Controls.Add(line_lb2);
            calc_panel.Controls.Add(line_lb);
            calc_panel.Controls.Add(a_b_lb);
            calc_panel.Location = new Point(270, 82);
            calc_panel.Name = "calc_panel";
            calc_panel.Size = new Size(783, 207);
            calc_panel.TabIndex = 3;
            // 
            // line_lb2
            // 
            line_lb2.AutoSize = true;
            line_lb2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            line_lb2.ForeColor = Color.White;
            line_lb2.Location = new Point(45, 64);
            line_lb2.Name = "line_lb2";
            line_lb2.Size = new Size(14, 20);
            line_lb2.TabIndex = 2;
            line_lb2.Text = "|";
            // 
            // line_lb
            // 
            line_lb.AutoSize = true;
            line_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            line_lb.ForeColor = Color.White;
            line_lb.Location = new Point(45, 44);
            line_lb.Name = "line_lb";
            line_lb.Size = new Size(14, 20);
            line_lb.TabIndex = 1;
            line_lb.Text = "|";
            // 
            // a_b_lb
            // 
            a_b_lb.AutoSize = true;
            a_b_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            a_b_lb.ForeColor = Color.White;
            a_b_lb.Location = new Point(30, 25);
            a_b_lb.Name = "a_b_lb";
            a_b_lb.Size = new Size(29, 60);
            a_b_lb.TabIndex = 0;
            a_b_lb.Text = "A |\r\n   \r\nB ";
            // 
            // solve_lb
            // 
            solve_lb.AutoSize = true;
            solve_lb.ForeColor = Color.White;
            solve_lb.Location = new Point(304, 319);
            solve_lb.MinimumSize = new Size(700, 250);
            solve_lb.Name = "solve_lb";
            solve_lb.Size = new Size(700, 250);
            solve_lb.TabIndex = 4;
            // 
            // grid_output
            // 
            grid_output.BackgroundColor = Color.FromArgb(1, 4, 9);
            grid_output.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_output.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_output.Location = new Point(53, 348);
            grid_output.Name = "grid_output";
            grid_output.RowHeadersWidth = 51;
            grid_output.Size = new Size(175, 207);
            grid_output.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(1059, 567);
            Controls.Add(grid_output);
            Controls.Add(solve_lb);
            Controls.Add(calc_panel);
            Controls.Add(calc_bttn);
            Controls.Add(input_lb);
            Controls.Add(grid_input);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grid_input).EndInit();
            calc_panel.ResumeLayout(false);
            calc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_output).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grid_input;
        private Label input_lb;
        private Time_Manager.RJControls.CustomButton calc_bttn;
        private Panel calc_panel;
        private Label line_lb2;
        private Label line_lb;
        private Label a_b_lb;
        private Label solve_lb;
        private DataGridView grid_output;
    }
}
