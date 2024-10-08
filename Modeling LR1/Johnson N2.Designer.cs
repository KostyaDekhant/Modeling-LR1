﻿namespace Modeling_LR1
{
    partial class Johnson_N2
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
            line_lb2 = new Label();
            line_lb = new Label();
            a_b_lb = new Label();
            calc_bttn = new Time_Manager.RJControls.CustomButton();
            input_lb = new Label();
            grid_input = new DataGridView();
            grid_output = new DataGridView();
            label1 = new Label();
            res_panel = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mode_TB = new Time_Manager.RJControls.CustomToggleButton();
            mode_lb = new Label();
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
            calc_panel.BorderStyle = BorderStyle.FixedSingle;
            calc_panel.Controls.Add(line_lb2);
            calc_panel.Controls.Add(line_lb);
            calc_panel.Controls.Add(a_b_lb);
            calc_panel.Location = new Point(243, 67);
            calc_panel.Name = "calc_panel";
            calc_panel.Size = new Size(1451, 260);
            calc_panel.TabIndex = 9;
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
            calc_bttn.Location = new Point(1611, 333);
            calc_bttn.Name = "calc_bttn";
            calc_bttn.Size = new Size(83, 34);
            calc_bttn.TabIndex = 8;
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
            input_lb.TabIndex = 7;
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
            grid_input.TabIndex = 6;
            // 
            // grid_output
            // 
            grid_output.BackgroundColor = Color.FromArgb(1, 4, 9);
            grid_output.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_output.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_output.Location = new Point(1722, 67);
            grid_output.Name = "grid_output";
            grid_output.RowHeadersWidth = 51;
            grid_output.Size = new Size(175, 207);
            grid_output.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1722, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 12;
            label1.Text = "Решение";
            // 
            // res_panel
            // 
            res_panel.BorderStyle = BorderStyle.FixedSingle;
            res_panel.Controls.Add(label2);
            res_panel.Controls.Add(label3);
            res_panel.Controls.Add(label4);
            res_panel.Location = new Point(243, 373);
            res_panel.Name = "res_panel";
            res_panel.Size = new Size(1451, 260);
            res_panel.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 64);
            label2.Name = "label2";
            label2.Size = new Size(14, 20);
            label2.TabIndex = 2;
            label2.Text = "|";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 44);
            label3.Name = "label3";
            label3.Size = new Size(14, 20);
            label3.TabIndex = 1;
            label3.Text = "|";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 25);
            label4.Name = "label4";
            label4.Size = new Size(29, 60);
            label4.TabIndex = 0;
            label4.Text = "A |\r\n   \r\nB ";
            // 
            // mode_TB
            // 
            mode_TB.AutoSize = true;
            mode_TB.Location = new Point(1609, 698);
            mode_TB.MaximumSize = new Size(85, 40);
            mode_TB.MinimumSize = new Size(45, 40);
            mode_TB.Name = "mode_TB";
            mode_TB.OffBackColor = Color.Gray;
            mode_TB.OffToggleColor = Color.Gainsboro;
            mode_TB.OnBackColor = Color.MediumSlateBlue;
            mode_TB.OnToggleColor = Color.WhiteSmoke;
            mode_TB.Size = new Size(85, 40);
            mode_TB.TabIndex = 13;
            mode_TB.Text = "customToggleButton1";
            mode_TB.UseVisualStyleBackColor = true;
            mode_TB.CheckedChanged += mode_TB_CheckedChanged;
            // 
            // mode_lb
            // 
            mode_lb.AutoSize = true;
            mode_lb.ForeColor = Color.White;
            mode_lb.Location = new Point(1554, 662);
            mode_lb.MaximumSize = new Size(140, 20);
            mode_lb.MinimumSize = new Size(140, 20);
            mode_lb.Name = "mode_lb";
            mode_lb.Size = new Size(140, 20);
            mode_lb.TabIndex = 14;
            mode_lb.Text = "Джонсон";
            mode_lb.TextAlign = ContentAlignment.MiddleRight;
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
            update_data_bttn.TabIndex = 16;
            update_data_bttn.Text = "Обновить данные";
            update_data_bttn.TextColor = Color.FromArgb(233, 238, 245);
            update_data_bttn.Click += update_data_bttn_Click;
            // 
            // t2_lb
            // 
            t2_lb.AutoSize = true;
            t2_lb.Font = new Font("Segoe UI", 12F);
            t2_lb.ForeColor = Color.White;
            t2_lb.Location = new Point(243, 654);
            t2_lb.Name = "t2_lb";
            t2_lb.Size = new Size(46, 28);
            t2_lb.TabIndex = 22;
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
            t1_lb.TabIndex = 24;
            t1_lb.Text = "T = ";
            // 
            // Johnson_N2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 17, 23);
            Controls.Add(t1_lb);
            Controls.Add(t2_lb);
            Controls.Add(update_data_bttn);
            Controls.Add(mode_lb);
            Controls.Add(mode_TB);
            Controls.Add(res_panel);
            Controls.Add(label1);
            Controls.Add(calc_panel);
            Controls.Add(calc_bttn);
            Controls.Add(input_lb);
            Controls.Add(grid_input);
            Controls.Add(grid_output);
            Name = "Johnson_N2";
            Size = new Size(1902, 992);
            Load += Johnson_N2_Load;
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
        private Time_Manager.RJControls.CustomButton calc_bttn;
        private Label input_lb;
        private DataGridView grid_input;
        private DataGridView grid_output;
        private Label label1;
        private Panel res_panel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Time_Manager.RJControls.CustomToggleButton mode_TB;
        private Label mode_lb;
        private Time_Manager.RJControls.CustomButton update_data_bttn;
        private Label t2_lb;
        private Label t1_lb;
    }
}
