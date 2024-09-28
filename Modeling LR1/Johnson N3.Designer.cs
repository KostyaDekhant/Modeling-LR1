namespace Modeling_LR1
{
    partial class Johnson_N3
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            calc_panel = new Panel();
            label3 = new Label();
            label2 = new Label();
            line_lb2 = new Label();
            line_lb = new Label();
            a_b_lb = new Label();
            label1 = new Label();
            calc_bttn = new Time_Manager.RJControls.CustomButton();
            input_lb = new Label();
            grid_input = new DataGridView();
            grid_output = new DataGridView();
            res_panel = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            mode_lb = new Label();
            mode_TB = new Time_Manager.RJControls.CustomToggleButton();
            update_data_bttn = new Time_Manager.RJControls.CustomButton();
            t2_lb = new Label();
            t1_lb = new Label();
            calc_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_output).BeginInit();
            res_panel.SuspendLayout();
            SuspendLayout();
            // 
            // calc_panel
            // 
            calc_panel.AutoScroll = true;
            calc_panel.BorderStyle = BorderStyle.FixedSingle;
            calc_panel.Controls.Add(label3);
            calc_panel.Controls.Add(label2);
            calc_panel.Controls.Add(line_lb2);
            calc_panel.Controls.Add(line_lb);
            calc_panel.Controls.Add(a_b_lb);
            calc_panel.Location = new Point(243, 67);
            calc_panel.Name = "calc_panel";
            calc_panel.Size = new Size(1453, 260);
            calc_panel.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 105);
            label3.Name = "label3";
            label3.Size = new Size(14, 20);
            label3.TabIndex = 4;
            label3.Text = "|";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 84);
            label2.Name = "label2";
            label2.Size = new Size(14, 20);
            label2.TabIndex = 3;
            label2.Text = "|";
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
            a_b_lb.Size = new Size(29, 100);
            a_b_lb.TabIndex = 0;
            a_b_lb.Text = "A |\r\n   \r\nB \r\n   \r\nC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1725, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 18;
            label1.Text = "Решение";
            label1.Click += label1_Click;
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
            calc_bttn.Location = new Point(1613, 333);
            calc_bttn.Name = "calc_bttn";
            calc_bttn.Size = new Size(83, 34);
            calc_bttn.TabIndex = 15;
            calc_bttn.Text = "Построить";
            calc_bttn.TextColor = Color.FromArgb(233, 238, 245);
            calc_bttn.Click += calc_bttn_Click;
            // 
            // input_lb
            // 
            input_lb.AutoSize = true;
            input_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            input_lb.ForeColor = Color.White;
            input_lb.Location = new Point(26, 28);
            input_lb.Name = "input_lb";
            input_lb.Size = new Size(105, 20);
            input_lb.TabIndex = 14;
            input_lb.Text = "Ввод данных";
            // 
            // grid_input
            // 
            grid_input.BackgroundColor = Color.FromArgb(1, 4, 9);
            grid_input.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_input.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_input.Location = new Point(26, 67);
            grid_input.Name = "grid_input";
            grid_input.RowHeadersWidth = 51;
            grid_input.Size = new Size(175, 207);
            grid_input.TabIndex = 13;
            // 
            // grid_output
            // 
            grid_output.BackgroundColor = Color.FromArgb(1, 4, 9);
            grid_output.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_output.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_output.Location = new Point(1725, 67);
            grid_output.Name = "grid_output";
            grid_output.RowHeadersWidth = 51;
            grid_output.Size = new Size(175, 207);
            grid_output.TabIndex = 17;
            // 
            // res_panel
            // 
            res_panel.AutoScroll = true;
            res_panel.BorderStyle = BorderStyle.FixedSingle;
            res_panel.Controls.Add(label4);
            res_panel.Controls.Add(label5);
            res_panel.Controls.Add(label6);
            res_panel.Controls.Add(label7);
            res_panel.Controls.Add(label8);
            res_panel.Location = new Point(243, 373);
            res_panel.Name = "res_panel";
            res_panel.Size = new Size(1453, 260);
            res_panel.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 105);
            label4.Name = "label4";
            label4.Size = new Size(14, 20);
            label4.TabIndex = 4;
            label4.Text = "|";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 84);
            label5.Name = "label5";
            label5.Size = new Size(14, 20);
            label5.TabIndex = 3;
            label5.Text = "|";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 64);
            label6.Name = "label6";
            label6.Size = new Size(14, 20);
            label6.TabIndex = 2;
            label6.Text = "|";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.White;
            label7.Location = new Point(45, 44);
            label7.Name = "label7";
            label7.Size = new Size(14, 20);
            label7.TabIndex = 1;
            label7.Text = "|";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 25);
            label8.Name = "label8";
            label8.Size = new Size(29, 100);
            label8.TabIndex = 0;
            label8.Text = "A |\r\n   \r\nB \r\n   \r\nC";
            // 
            // mode_lb
            // 
            mode_lb.AutoSize = true;
            mode_lb.ForeColor = Color.White;
            mode_lb.Location = new Point(1556, 668);
            mode_lb.MaximumSize = new Size(140, 20);
            mode_lb.MinimumSize = new Size(140, 20);
            mode_lb.Name = "mode_lb";
            mode_lb.Size = new Size(140, 20);
            mode_lb.TabIndex = 16;
            mode_lb.Text = "Джонсон";
            mode_lb.TextAlign = ContentAlignment.MiddleRight;
            // 
            // mode_TB
            // 
            mode_TB.AutoSize = true;
            mode_TB.Location = new Point(1611, 701);
            mode_TB.MaximumSize = new Size(85, 40);
            mode_TB.MinimumSize = new Size(45, 40);
            mode_TB.Name = "mode_TB";
            mode_TB.OffBackColor = Color.Gray;
            mode_TB.OffToggleColor = Color.Gainsboro;
            mode_TB.OnBackColor = Color.MediumSlateBlue;
            mode_TB.OnToggleColor = Color.WhiteSmoke;
            mode_TB.Size = new Size(85, 40);
            mode_TB.TabIndex = 15;
            mode_TB.Text = "customToggleButton1";
            mode_TB.UseVisualStyleBackColor = true;
            mode_TB.CheckedChanged += mode_TB_CheckedChanged;
            // 
            // update_data_bttn
            // 
            update_data_bttn.BorderColor = Color.FromArgb(147, 154, 163);
            update_data_bttn.BorderThickness = 0;
            update_data_bttn.BorderVisible = true;
            update_data_bttn.ButtonColor = Color.FromArgb(33, 40, 48);
            update_data_bttn.ClickColor = Color.FromArgb(33, 40, 48);
            update_data_bttn.CornerRadius = 0;
            update_data_bttn.EnableAnimation = true;
            update_data_bttn.Font = new Font("Arial", 7F, FontStyle.Bold);
            update_data_bttn.HoverColor = Color.FromArgb(33, 40, 48);
            update_data_bttn.Location = new Point(243, 14);
            update_data_bttn.Name = "update_data_bttn";
            update_data_bttn.Size = new Size(130, 34);
            update_data_bttn.TabIndex = 20;
            update_data_bttn.Text = "Обновить данные";
            update_data_bttn.TextColor = Color.FromArgb(233, 238, 245);
            update_data_bttn.Click += update_data_bttn_Click;
            // 
            // t2_lb
            // 
            t2_lb.AutoSize = true;
            t2_lb.Font = new Font("Segoe UI", 12F);
            t2_lb.ForeColor = Color.White;
            t2_lb.Location = new Point(243, 649);
            t2_lb.Name = "t2_lb";
            t2_lb.Size = new Size(46, 28);
            t2_lb.TabIndex = 21;
            t2_lb.Text = "T = ";
            // 
            // t1_lb
            // 
            t1_lb.AutoSize = true;
            t1_lb.Font = new Font("Segoe UI", 12F);
            t1_lb.ForeColor = Color.White;
            t1_lb.Location = new Point(243, 333);
            t1_lb.Name = "t1_lb";
            t1_lb.Size = new Size(46, 28);
            t1_lb.TabIndex = 22;
            t1_lb.Text = "T = ";
            // 
            // Johnson_N3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            Controls.Add(t1_lb);
            Controls.Add(t2_lb);
            Controls.Add(update_data_bttn);
            Controls.Add(mode_lb);
            Controls.Add(res_panel);
            Controls.Add(mode_TB);
            Controls.Add(calc_panel);
            Controls.Add(label1);
            Controls.Add(calc_bttn);
            Controls.Add(input_lb);
            Controls.Add(grid_input);
            Controls.Add(grid_output);
            Name = "Johnson_N3";
            Size = new Size(1925, 992);
            Load += Johnson_N3_Load;
            calc_panel.ResumeLayout(false);
            calc_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_input).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_output).EndInit();
            res_panel.ResumeLayout(false);
            res_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel calc_panel;
        private Label line_lb2;
        private Label line_lb;
        private Label a_b_lb;
        private Label label1;
        private Time_Manager.RJControls.CustomButton calc_bttn;
        private Label input_lb;
        private DataGridView grid_input;
        private DataGridView grid_output;
        private Label label3;
        private Label label2;
        private Panel res_panel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label mode_lb;
        private Time_Manager.RJControls.CustomToggleButton mode_TB;
        private Time_Manager.RJControls.CustomButton update_data_bttn;
        private Label t2_lb;
        private Label t1_lb;
    }
}
