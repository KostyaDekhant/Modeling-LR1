﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeling_LR1
{
    public partial class Johnson_N2 : UserControl
    {
        public Johnson_N2()
        {
            InitializeComponent();
        }

        private Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Brown, Color.Yellow };
        private int[] a_res;
        private int[] b_res;
        private int[] x_res;
        private int[] nums_res;

        private Label[,] lbs;

        private int size = 0;
        private int c_vals = 3;

        private List<PictureBox> picListInput = new List<PictureBox>();
        private List<PictureBox> picListOutput = new List<PictureBox>();
        private void Johnson_N2_Load(object sender, EventArgs e)
        {
            Funs.SetSize("inputN2.txt", out size);
            Funs.InitGrid(grid_input, true, size);
            Funs.InitGrid(grid_output, true, size);
            Funs.FillGrid("inputN2.txt", true, grid_input, grid_output, size);

            grid_output.ReadOnly = true;

            a_res = new int[size];
            b_res = new int[size];
            x_res = new int[size];

            int[] nums = new int[size];
            nums_res = nums;

            InitLbs(nums);

            StartSit();
            FillOutputGrid(nums);
            DrawSolution(true, calc_panel, picListInput);
            calc_bttn_Click(calc_bttn, null);
        }

        private void InitLbs(int[] nums)
        {
            lbs = new Label[2, size * c_vals];
            String[] str = { "a", "x", "b" };

            for (int i = 0; i < size; i++)
            {
                nums[i] = i + 1;

                for (int j = 0; j < c_vals; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Label lb = new Label();
                        int width = j == 2 ? 26 : 25;
                        Funs.InitLb(lb, str[j] + (i + 1).ToString(), width);
                        if (k == 0) calc_panel.Controls.Add(lb);
                        else res_panel.Controls.Add(lb);
                        lbs[k, i + j * size] = (lb);
                    }
                }
            }
        }


        private void VisibleOffForLb(bool flag)
        {
            int id = flag ? 0 : 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < c_vals; j++)
                    lbs[id, i * c_vals + j].Visible = false;
            }
        }


        private void StartSit()
        {
            int[] a = new int[size];
            int[] b = new int[size];
            int[] x = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(grid_input.Rows[i].Cells[1].Value);
                b[i] = Convert.ToInt32(grid_input.Rows[i].Cells[2].Value);
            }
            int b_sum = 0;
            int x_sum = 0;
            FindX(a, b, x, out b_sum, out x_sum);
            t1_lb.Text = "T = " + (b_sum + x_sum).ToString() + " | X = " + x_sum;
            a_res = a;
            b_res = b;
            x_res = x;
        }

        

        private void Johnson()
        {
            for (int i = 0; i < size; i++)
            {
                a_res[i] = Convert.ToInt32(grid_input.Rows[i].Cells[1].Value);
                b_res[i] = Convert.ToInt32(grid_input.Rows[i].Cells[2].Value);
                nums_res[i] = i + 1;
            }

            bool[] vis = new bool[size];

            for (int i = 0; i < size; i++) vis[i] = false;

            for (int i = 0; i < size; i++)
            {
                Funs.Pair<int, int> minEl = MinElem(vis);
                if (minEl.First == -1) break;
                if(minEl.First == 1){
                    for (int j = 0; j < size; j++)
                    {
                        if (j != minEl.Second && !vis[j]) { 
                            swap(a_res, b_res, nums_res, j, minEl.Second);
                            vis[j] = true;
                            vis[minEl.Second] = true;
                            break;
                        }
                    }
                }
                else if(minEl.First == 2) {
                    for (int j = size-1; j >= 0; j--)
                    {
                        if (j != minEl.Second && !vis[j])
                        {
                            swap(a_res, b_res, nums_res, j, minEl.Second);
                            vis[j] = true;
                            vis[minEl.Second] = true;
                            break;
                        }
                    }
                }
            }
            int b_s, x_s;
            FindX(a_res, b_res, x_res, out b_s, out x_s);
            t2_lb.Text = "T = " + (b_s + x_s).ToString() + " | X = " + x_s;
            FillOutputGrid(nums_res);
        }

        private Funs.Pair<int, int> MinElem(bool[] vis)
        {
            int index = -1;
            int sit = -1; //-1 - нет минимального, 1 - мин. эл. А, 2 - мин. эл. Б 

            for (int i = 0; i < size; i++){
                if (!vis[i]){
                    index = i;
                    break;
                }
            }

            if (index == -1) return new Funs.Pair<int, int>(sit, index); //все элементы просмотрены

            int minEl = a_res[index];
            index = 0;
            sit = 1;
            for (int i = 0; i < size; i++){
                if (!vis[i]){
                    if (a_res[i] <= minEl)
                    {
                        minEl = a_res[i];
                        index = i;
                        sit = 1;
                    }
                    if (b_res[i] <= minEl)
                    {
                        minEl = b_res[i];
                        index = i;
                        sit = 2;
                    }
                }
            }
            return new Funs.Pair<int, int>( sit, index );
        }


        private void SolutionEnum()
        {
            int[] a = new int[size];
            int[] b = new int[size];
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(grid_input.Rows[i].Cells[1].Value);
                b[i] = Convert.ToInt32(grid_input.Rows[i].Cells[2].Value);
                nums[i] = i + 1;
            }
            int[] x = new int[size];

            int min = int.MaxValue;
            int sum;
            int b_sum;
            int x_sum;
            int x_min = 0;
            do
            {
                sum = 0;
                FindX(a, b, x, out b_sum, out x_sum);
                sum = x_sum + b_sum;
                //Если общее время меньше минимального, то присваиваем все переменные в результат
                if (sum < min)
                {
                    x_min = x_sum;
                    for (int i = 0; i < size; i++)
                    {
                        a_res[i] = a[i];
                        b_res[i] = b[i];
                        x_res[i] = x[i];
                        nums_res[i] = nums[i];
                    }
                    min = sum;

                }
            } while (NextSet(a, b, nums, size));
            t2_lb.Text = "T = " + min.ToString() + " | X = " + x_min; 
            FillOutputGrid(nums_res);
        }

        private void FillOutputGrid(int[] nums_res)
        {
            for (int i = 0; i < size; i++)
            {
                grid_output.Rows[i].Cells[0].Value = nums_res[i];
                grid_output.Rows[i].Cells[1].Value = a_res[i];
                grid_output.Rows[i].Cells[2].Value = b_res[i];
            }

        }

        private void FindX(int[] a, int[] b, int[] x, out int b_sum, out int x_sum)
        {
            b_sum = 0;
            int a_sum = a[0];
            x[0] = a[0];
            x_sum = x[0];
            for (int i = 1; i < size; i++)
                x[i] = 0;
            for (int i = 1; i < size; i++)
            {
                a_sum += a[i];
                b_sum += b[i - 1];
                x[i] = Math.Max(a_sum - x_sum - b_sum, 0);
                x_sum += x[i];
            }
            b_sum += b[size - 1];
        }
        void swap(int[] a, int[] b, int[] nums, int i, int j)
        {
            int s = a[i];
            a[i] = a[j];
            a[j] = s;

            s = b[i];
            b[i] = b[j];
            b[j] = s;

            s = nums[i];
            nums[i] = nums[j];
            nums[j] = s;
        }
        bool NextSet(int[] a, int[] b, int[] nums, int n)
        {
            int j = n - 2;
            while (j != -1 && nums[j] >= nums[j + 1]) j--;
            if (j == -1)
                return false; // больше перестановок нет 
            int k = n - 1;
            while (nums[j] >= nums[k]) k--;
            swap(a, b, nums, j, k);
            int l = j + 1, r = n - 1; // сортируем оставшуюся часть последовательности 
            while (l < r)
                swap(a, b, nums, l++, r--);
            return true;
        }

        private void DrawSolution(bool flag, Panel pn, List<PictureBox> picList)
        {
            VisibleOffForLb(flag);
            int sum_a = 0;
            int sum_b = 0;
            int x_count = 0;
            int lb_id = flag ? 0 : 1;
            for (int i = 0; i < size; i++)
            {
                int num = nums_res[i] - 1;
                int a_size = Convert.ToInt32(grid_output.Rows[i].Cells[1].Value);
                int b_size = Convert.ToInt32(grid_output.Rows[i].Cells[2].Value);
                int x_size = x_res[i];

                int[] sizes = { a_size, x_size, b_size};

                for (int k = 0; k < c_vals; k++)
                {
                    int color_id = nums_res[i] - 1;
                    if (k == 1) color_id = 5;

                    int t_sum = sum_a;
                    int t_h = 29;
                    int t_num = num;
                    if (k > 0)
                    {
                        t_sum = sum_b;
                        t_h += 40;
                    }
                    if (k == 1)
                    {
                        if (sizes[k] > 0)
                            t_num = x_count;
                        else continue;
                    }

                    for (int j = 0; j < sizes[k]; j++)
                    {
                        if (sizes[k] < 2)
                            lbs[lb_id, t_num + k * size].Location = new Point(60 + i * 15 + t_sum, t_h - 25);
                        else if (j == (sizes[k] / 2) - 1)
                            lbs[lb_id, t_num + k * size].Location = new Point(60 + i * 15 + t_sum + 7, t_h - 25);

                        Funs.DrawSquare(colors[color_id], new Point(60 + i * 15 + t_sum, t_h), pn, picList);

                        t_sum += 15;
                        if (j == sizes[k] - 1 && k != 1)
                        {
                            t_sum -= 15;
                        }
                    }
                    lbs[lb_id, t_num + k * size].Visible = true;

                    if (k == 1 && sizes[k] > 0) x_count++;

                    if (k == 0) sum_a = t_sum;
                    else  sum_b = t_sum;
                }
            }
        }

        private void mode_TB_CheckedChanged(object sender, EventArgs e)
        {
            if (!mode_TB.Checked)
            {
                mode_lb.Text = "Джонсон";
            }
            else
            {
                mode_lb.Text = "Метод перебора";
            }
            calc_bttn_Click(calc_bttn, null);
        }

        private void calc_bttn_Click(object sender, EventArgs e)
        {
            grid_input.ClearSelection();
            calc_bttn.Focus();
            for (int i = 0; i < size; i++)
            {
                if (grid_input.Rows[i].Cells[1].Value == null || grid_input.Rows[i].Cells[2].Value == null)
                {
                    MessageBox.Show("Не все данные введены!", "Внимание!");
                    return;
                }
            }
            VisibleOffForLb(false);

            if (!mode_TB.Checked) Johnson();
            else SolutionEnum();
            if(picListOutput.Count > 0) Funs.ClearPictureBoxes(picListOutput, res_panel);
            DrawSolution(false, res_panel, picListOutput);
        }
        private void update_data_bttn_Click(object sender, EventArgs e)
        {
            VisibleOffForLb(false);
            VisibleOffForLb(true);
            Funs.SetSize("inputN2.txt", out size);

            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                nums[i] = i + 1;
            }
            nums_res = nums;

            Funs.ClearPictureBoxes(picListInput, calc_panel);
            Funs.ClearPictureBoxes(picListOutput, res_panel);
            Funs.SetRows(grid_input, size);
            Funs.SetRows(grid_output, size);
            Funs.FillGrid("inputN2.txt", true, grid_input, grid_output, size);
            InitLbs(nums);

            StartSit();
            FillOutputGrid(nums);
            DrawSolution(true, calc_panel, picListInput);
            calc_bttn_Click(calc_bttn, null);
        }
    }
}
