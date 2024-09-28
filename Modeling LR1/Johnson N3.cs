using System;
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
    public partial class Johnson_N3 : UserControl
    {
        private Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.OrangeRed, Color.Brown, Color.Yellow, Color.Orange };
        private int[] a_res;
        private int[] b_res;
        private int[] c_res;
        private int[] x_res;
        private int[] y_res;
        private int[] nums_res;
        private Label[,] lbs;
        private int size = 0;
        private int c_vals = 5;

        private List<PictureBox> picListInput = new List<PictureBox>();
        private List<PictureBox> picListOutput = new List<PictureBox>();
        public Johnson_N3()
        {
            InitializeComponent();
        }

        private void Johnson_N3_Load(object sender, EventArgs e)
        {
            Funs.SetSize("inputN3.txt", out size);
            Funs.InitGrid(grid_input, false, size);
            Funs.InitGrid(grid_output, false, size);

            Funs.FillGrid("inputN3.txt", false, grid_input, grid_output, size);

            a_res = new int[size];
            b_res = new int[size];
            c_res = new int[size];
            x_res = new int[size];
            y_res = new int[size];

            int[] nums = new int[size];
            nums_res = nums;


            InitLbs(nums);

            StartSit();
            FillOutputGrid(nums);
            DrawSolution(true, calc_panel, picListInput);
            if(!Cond())
            {
                t2_lb.Text = "Условие не выполняется!";
                return;
            }
            calc_bttn_Click(calc_bttn, null);
        }

        private void InitLbs(int[] nums)
        {
            lbs = new Label[2, size * c_vals];
            String[] str = { "a", "x", "b", "y", "c" };

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
            int[] c = new int[size];
            int[] x = new int[size];
            int[] y = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(grid_input.Rows[i].Cells[1].Value);
                b[i] = Convert.ToInt32(grid_input.Rows[i].Cells[2].Value);
                c[i] = Convert.ToInt32(grid_input.Rows[i].Cells[3].Value);
            }
            int c_sum = 0;
            int y_sum = 0;
            FindX(a, b, c, x, y, out c_sum, out y_sum);
            t1_lb.Text = "T = " + (c_sum + y_sum).ToString() + " | Y = " + y_sum;
            a_res = a;
            b_res = b;
            c_res = c;
            x_res = x;
            y_res = y;

        }
        
        private bool Cond()
        {
            int mina = a_res[0], maxb = b_res[0], minc = c_res[0];
            for (int i = 1; i < size; i++)
            {
                mina = Math.Min(mina, a_res[i]);
                maxb = Math.Max(maxb, b_res[i]);
                minc = Math.Min(minc, c_res[i]);
            }
            return (mina >= maxb || minc >= maxb); 
        }

        private void Johnson()
        {
            for (int i = 0; i < size; i++)
            {
                a_res[i] = Convert.ToInt32(grid_input.Rows[i].Cells[1].Value);
                b_res[i] = Convert.ToInt32(grid_input.Rows[i].Cells[2].Value);
                c_res[i] = Convert.ToInt32(grid_input.Rows[i].Cells[3].Value);
                a_res[i] += b_res[i];
                b_res[i] += c_res[i];
                nums_res[i] = i + 1;
            }

            bool[] vis = new bool[size];

            for (int i = 0; i < size; i++) vis[i] = false;

            for (int i = 0; i < size; i++)
            {
                Funs.Pair<int, int> minEl = MinElem(vis);
                if (minEl.First == -1) break;
                if (minEl.First == 1)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i != minEl.Second && !vis[i])
                        {
                            swap(a_res, b_res, c_res, nums_res, j, minEl.Second);
                            vis[i] = true;
                            break;
                        }
                    }
                }
                else if (minEl.First == 2)
                {
                    for (int j = size - 1; j >= 0; j--)
                    {
                        if (i != minEl.Second && !vis[i])
                        {
                            swap(a_res, b_res, c_res, nums_res, j, minEl.Second);
                            vis[i] = true;
                            break;
                        }
                    }
                }
            }
            int c_s, y_s;

            for (int i = 0; i < size; i++)
            {
                a_res[i] = Convert.ToInt32(grid_input.Rows[nums_res[i]-1].Cells[1].Value);
                b_res[i] = Convert.ToInt32(grid_input.Rows[nums_res[i]-1].Cells[2].Value);
                c_res[i] = Convert.ToInt32(grid_input.Rows[nums_res[i]-1].Cells[3].Value);
            }

            FindX(a_res, b_res, c_res, x_res, y_res, out c_s, out y_s);
            t2_lb.Text = "T = " + (c_s+y_s).ToString() + " | Y = " + y_s;
            FillOutputGrid(nums_res);
        }

        private Funs.Pair<int, int> MinElem(bool[] vis)
        {
            int index = -1;
            int sit = -1; //-1 - нет минимального, 1 - мин. эл. А, 2 - мин. эл. Б 

            for (int i = 0; i < size; i++)
            {
                if (!vis[i])
                {
                    index = i;
                    break;
                }
            }

            if (index == -1) return new Funs.Pair<int, int>(sit, index); //все элементы просмотрены

            int minEl = a_res[index];

            for (int i = 0; i < size; i++)
            {
                if (!vis[i])
                {
                    if (a_res[i] < minEl)
                    {
                        minEl = a_res[i];
                        index = i;
                        sit = 1;
                    }
                    if (b_res[i] < minEl)
                    {
                        minEl = b_res[i];
                        index = i;
                        sit = 2;
                    }
                }
            }
            return new Funs.Pair<int, int>(sit, index);
        }

        private void SolutionEnum()
        {
            int[] a = new int[size];
            int[] b = new int[size];
            int[] c = new int[size];
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(grid_input.Rows[i].Cells[1].Value);
                b[i] = Convert.ToInt32(grid_input.Rows[i].Cells[2].Value);
                c[i] = Convert.ToInt32(grid_input.Rows[i].Cells[3].Value);
                nums[i] = i + 1;
            }
            int[] x = new int[size];
            int[] y = new int[size];

            int min = int.MaxValue;
            int sum;
            int c_sum;
            int y_sum;
            int y_min = 0;
            do
            {
                FindX(a, b, c, x, y, out c_sum, out y_sum);
                sum = y_sum + c_sum;
                if (sum < min)
                {
                    y_min = y_sum;
                    for (int i = 0; i < size; i++)
                    {
                        a_res[i] = a[i];
                        b_res[i] = b[i];
                        c_res[i] = c[i];
                        x_res[i] = x[i];
                        y_res[i] = y[i];
                        nums_res[i] = nums[i];
                    }
                    min = sum;

                }
            } while (NextSet(a, b, c, nums, size));
            t2_lb.Text = "T = " + min.ToString() + " | Y = " + y_min;
            FillOutputGrid(nums_res);
        }

        private void FillOutputGrid(int[] nums_res)
        {
            for (int i = 0; i < size; i++)
            {
                grid_output.Rows[i].Cells[0].Value = nums_res[i];
                grid_output.Rows[i].Cells[1].Value = a_res[i];
                grid_output.Rows[i].Cells[2].Value = b_res[i];
                grid_output.Rows[i].Cells[3].Value = c_res[i];
            }

        }

        private void FindX(int[] a, int[] b, int[] c, int[] x, int[] y, out int c_sum, out int y_sum)
        {
            int b_sum = 0;
            int a_sum = a[0];
            x[0] = a[0];
            int x_sum = x[0];

            c_sum = 0;
            y[0] = x[0] + b[0];
            y_sum = y[0];
            for (int i = 1; i < size; i++)
            {
                x[i] = 0;
                y[i] = 0;
            }
            for (int i = 1; i < size; i++)
            {
                a_sum += a[i];
                b_sum += b[i - 1];
                c_sum += c[i - 1];
                x[i] = Math.Max(a_sum - x_sum - b_sum, 0);
                x_sum += x[i];

                y[i] = Math.Max(x_sum + b_sum + b[i] - y_sum - c_sum, 0);
                y_sum += y[i];
            }
            b_sum += b[size - 1];
            c_sum += c[size - 1];

        }
        void swap(int[] a, int[] b, int[] c, int[] nums, int i, int j)
        {
            int s = a[i];
            a[i] = a[j];
            a[j] = s;

            s = b[i];
            b[i] = b[j];
            b[j] = s;

            s = c[i];
            c[i] = c[j];
            c[j] = s;

            s = nums[i];
            nums[i] = nums[j];
            nums[j] = s;
        }
        bool NextSet(int[] a, int[] b, int[] c, int[] nums, int n)
        {
            int j = n - 2;
            while (j != -1 && nums[j] >= nums[j + 1]) j--;
            if (j == -1)
                return false; // больше перестановок нет 
            int k = n - 1;
            while (nums[j] >= nums[k]) k--;
            swap(a, b, c, nums, j, k);
            int l = j + 1, r = n - 1; // сортируем оставшуюся часть последовательности 
            while (l < r)
                swap(a, b, c, nums, l++, r--);
            return true;
        }

        private void DrawSolution(bool flag, Panel pn, List<PictureBox> picList)
        {
            VisibleOffForLb(flag);
            int sum_a = 0;
            int sum_b = 0;
            int sum_c = 0;
            int x_count = 0;
            int y_count = 0;
            int lb_id = flag ? 0 : 1;
            for (int i = 0; i < size; i++)
            {
                int num = nums_res[i] - 1;
                int a_size = Convert.ToInt32(grid_output.Rows[i].Cells[1].Value);
                int b_size = Convert.ToInt32(grid_output.Rows[i].Cells[2].Value);
                int c_size = Convert.ToInt32(grid_output.Rows[i].Cells[3].Value);
                int x_size = x_res[i];
                int y_size = y_res[i];

                int[] sizes = { a_size, x_size, b_size, y_size, c_size };

                for (int k = 0; k < c_vals; k++)
                {
                    int color_id = nums_res[i] - 1;
                    if (k == 1) color_id = 5;
                    else if (k == 3) color_id = 6;

                    int t_sum = sum_a;
                    int t_h = 29;
                    int t_num = num;
                    if (k == 1 || k == 2){
                        t_sum = sum_b;
                        t_h += 40;
                    }
                    else if (k > 2){
                        t_sum = sum_c;
                        t_h += 80;
                    }
                    if (k == 1){
                        if (sizes[k] > 0)
                            t_num = x_count;
                        else continue;
                    }
                    else if (k == 3){
                        if (sizes[k] > 0)
                            t_num = y_count;
                        else continue;
                    }

                    for (int j = 0; j < sizes[k]; j++){
                        if (sizes[k] < 2)
                            lbs[lb_id, t_num + k * size].Location = new Point(60 + i * 15 + t_sum, t_h - 25);
                        else if (j == (sizes[k] / 2) - 1)
                            lbs[lb_id, t_num + k * size].Location = new Point(60 + i * 15 + t_sum + 7, t_h-25);

                        Funs.DrawSquare(colors[color_id], new Point(60 + i * 15 + t_sum, t_h), pn, picList);

                        t_sum += 15;
                        if (j == sizes[k] - 1 && k != 1 && k != 3)
                        {
                            t_sum -= 15;
                        }
                    }
                    lbs[lb_id, t_num + k * size].Visible = true;

                    if (k == 1 && sizes[k] > 0) x_count++;
                    else if (k == 3 && sizes[k] > 0)  y_count++;

                    if (k == 0) sum_a = t_sum;
                    else if (k == 1 || k ==2) sum_b = t_sum;
                    else if (k > 2) sum_c = t_sum;
                }
            }
        }

        private void calc_bttn_Click(object sender, EventArgs e)
        {
            grid_input.ClearSelection();
            calc_bttn.Focus();
            for (int i = 0; i < size; i++)
            {
                if (grid_input.Rows[i].Cells[1].Value == null || grid_input.Rows[i].Cells[2].Value == null 
                    || grid_input.Rows[i].Cells[3].Value == null)
                {
                    MessageBox.Show("Не все данные введены!", "Внимание!");
                    return;
                }
            }
            VisibleOffForLb(false);

            if (!mode_TB.Checked) Johnson();
            else SolutionEnum();
            if (picListOutput.Count > 0) Funs.ClearPictureBoxes(picListOutput, res_panel);
            DrawSolution(false, res_panel, picListOutput);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mode_TB_CheckedChanged(object sender, EventArgs e)
        {
            if (!mode_TB.Checked)
            {
                mode_lb.Text = "Джонсон";
                if(!Cond())
                {
                    t2_lb.Text = "Условие не выполняется!";
                    return;
                }
            }
            else
            {
                mode_lb.Text = "Метод перебора";
            }
            calc_bttn_Click(calc_bttn, null);
        }

        private void update_data_bttn_Click(object sender, EventArgs e)
        {
            VisibleOffForLb(false);
            VisibleOffForLb(true);
            Funs.SetSize("inputN3.txt", out size);

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
            Funs.FillGrid("inputN3.txt", false, grid_input, grid_output, size);
            InitLbs(nums);

            StartSit();
            FillOutputGrid(nums);
            DrawSolution(true, calc_panel, picListInput);
            if (!Cond())
            {
                t2_lb.Text = "Условие не выполняется!";
                return;
            }
            calc_bttn_Click(calc_bttn, null);
        }
    }
}
