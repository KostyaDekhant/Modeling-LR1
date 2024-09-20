using System;
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
        private Label[] a_lbs;
        private Label[] b_lbs;
        private Label[] x_lbs;
        private int size = 0;
        private void Johnson_N2_Load(object sender, EventArgs e)
        {
            SetSize();
            InitGrid(grid_input);
            InitGrid(grid_output);
            FillGrid();

            a_res = new int[size];
            b_res = new int[size];
            x_res = new int[size];

            a_lbs = new Label[size];
            b_lbs = new Label[size];
            x_lbs = new Label[size];

            int[] nums = new int[size];
            nums_res = nums;
            for (int i = 0; i < size; i++)
            {
                nums[i] = i + 1;
                Label a_lb = new Label();
                a_lb.Text = "a" + (i + 1).ToString();
                a_lb.ForeColor = Color.White;
                a_lb.Size = new Size(25, 20);
                a_lb.Visible = false;
                calc_panel.Controls.Add(a_lb);
                a_lbs[i] = (a_lb);

                Label b_lb = new Label();
                b_lb.Text = "b" + (i + 1).ToString();
                b_lb.ForeColor = Color.White;
                b_lb.Size = new Size(26, 20);
                b_lb.Visible = false;
                calc_panel.Controls.Add(b_lb);
                b_lbs[i] = (b_lb);

                Label x_lb = new Label();
                x_lb.Text = "x" + (i + 1).ToString();
                x_lb.ForeColor = Color.White;
                x_lb.Size = new Size(25, 20);
                x_lb.Visible = false;
                calc_panel.Controls.Add(x_lb);
                x_lbs[i] = (x_lb);
            }


            StartSit();
            FillOutputGrid(nums);
            DrawSolution();
        }

        private void SetSize()
        {
            string[] nums = File.ReadAllLines("input.txt");
            size = nums.Length;
        }

        private void VisibleOffForLb()
        {
            for (int i = 0; i < size; i++)
            {
                x_lbs[i].Visible = false;
                a_lbs[i].Visible = false;
                b_lbs[i].Visible = false;
            }
        }

        private void FillGrid()
        {
            string[] nums = File.ReadAllLines("input.txt");
            for (int i = 0; i < nums.Length; i++)
            {
                string[] num = nums[i].Split(' ');
                int row = Convert.ToInt32(num[0]) - 1;
                grid_input.Rows[row].Cells[1].Value = num[1];
                grid_input.Rows[row].Cells[2].Value = num[2];
            }
            //if(nums.Length < size)
            //size = nums.Length;
            grid_input.RowCount = size;
            grid_output.RowCount = size;
            //grid_input.RowCount = size;
            //grid_input.Rows[0].Cells[1].Value = 
        }
        void InitGrid(DataGridView Grid)
        {
            Grid.Rows.Clear();
            Grid.Columns.Clear();
            Grid.Columns.Add("№", "№");
            Grid.Columns.Add("Ai", "ai");
            Grid.Columns.Add("Bi", "bi");

            for (int i = 0; i < size; i++)
            {
                Grid.Rows.Add();
                Grid.Rows[i].Cells[0].Value = (i + 1).ToString();
                Grid.Rows[i].Cells[0].ReadOnly = true;
            }

            Grid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;


            Grid.ScrollBars = ScrollBars.None;
            //Grid.ScrollBars = ScrollBars.Vertical;
            Grid.RowHeadersVisible = false;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid.AllowUserToAddRows = false;
            Grid.AllowUserToDeleteRows = false;
            Grid.MultiSelect = false;
            Grid.AllowUserToResizeRows = false;
            Grid.AllowUserToResizeColumns = false;
            Grid.AllowUserToOrderColumns = false;

            Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 22, 27, 34);
            Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 109, 117, 128);
            Grid.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 13, 17, 23);
            Grid.RowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 237, 241, 244);
            Grid.BackgroundColor = Color.FromArgb(255, 1, 4, 9);

            Grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 33, 37, 45);

            Grid.EnableHeadersVisualStyles = false;
            int height = Grid.Rows.Count * Grid.Rows[0].Height + Grid.ColumnHeadersHeight + 2;
            int max_h = 5 * Grid.Rows[0].Height + Grid.ColumnHeadersHeight + 2;
            Grid.Height = height <= max_h ? height : max_h;
        }

        private List<PictureBox> picList = new List<PictureBox>();
        private void DrawSquare(Color color, Point loc)
        {
            PictureBox pb = new PictureBox();
            calc_panel.Controls.Add(pb);
            pb.BackColor = color;
            pb.Location = loc;
            pb.Size = new Size(14, 14);
            picList.Add(pb);
        }

        private void ClearPictureBoxes()
        {
            foreach (PictureBox pb in picList)
            {
                calc_panel.Controls.Remove(pb);
                pb.Dispose();
            }
            picList.Clear();
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
            //int a_sum = 0;
            int b_sum = 0;
            int x_sum = 0;
            FindX(a, b, x, out b_sum, out x_sum);
            a_res = a;
            b_res = b;
            x_res = x;
        }

        private void Solution()
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
            int sum = 0;
            int a_sum = 0;
            int b_sum = 0;
            int x_sum = 0;

            //Переделать логику
            do
            {
                sum = 0;
                FindX(a, b, x, out b_sum, out x_sum);
                sum = x_sum + b_sum;
                if (sum < min)
                {
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

            solve_lb.Text += min + "\n";
            for (int i = 0; i < size; i++)
            {
                FillOutputGrid(nums_res);

                solve_lb.Text += nums_res[i] + " " + a_res[i] + " " + b_res[i];
                solve_lb.Text += " " + x_res[i];
                solve_lb.Text += "\n";
            }
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

        private void PrintInfo(int[] a, int[] b, int[] nums)
        {
            for (int i = 0; i < a.Length; i++)
            {
                solve_lb.Text += nums[i] + " " + a[i] + " " + b[i] + " | ";
            }

        }

        private void DrawSolution()
        {
            VisibleOffForLb();
            int sum_a = 0;
            int sum_b = 0;
            int x_count = 0;
            for (int i = 0; i < size; i++)
            {
                int num = nums_res[i] - 1;
                int a_size = Convert.ToInt32(grid_output.Rows[i].Cells[1].Value);

                for (int j = 0; j < a_size; j++)
                {
                    if (j == (a_size / 2) - 1)
                        a_lbs[num].Location = new Point(60 + i * 15 + sum_a + 7, 29 - 25);
                    else if (a_size < 2)
                        a_lbs[num].Location = new Point(60 + i * 15 + sum_a, 29 - 25);
                    a_lbs[num].Visible = true;
                    DrawSquare(colors[nums_res[i] - 1], new Point(60 + i * 15 + sum_a, 29));
                    if (j != a_size - 1)
                        sum_a += 15;
                }

                if (x_res[i] != 0)
                {

                    int X_size = x_res[i];

                    for (int j = 0; j < X_size; j++)
                    {
                        if (j == (X_size / 2) - 1)
                        {
                            x_lbs[x_count].Location = new Point(60 + i * 15 + sum_b + 7, 29 + 40 - 25);
                            x_lbs[x_count++].Visible = true;
                        }
                        else if (X_size < 2)
                        {
                            x_lbs[x_count].Location = new Point(60 + i * 15 + sum_b, 29 + 40 - 25);
                            x_lbs[x_count++].Visible = true;
                        }
                        DrawSquare(colors[5], new Point(60 + i * 15 + sum_b, 29 + 40));
                        sum_b += 15;
                    }
                }

                int b_size = Convert.ToInt32(grid_output.Rows[i].Cells[2].Value);

                for (int j = 0; j < b_size; j++)
                {
                    if (j == (b_size / 2) - 1)
                        b_lbs[num].Location = new Point(60 + i * 15 + sum_b + 7, 29 + 40 - 25);
                    else if (b_size < 2)
                        b_lbs[num].Location = new Point(60 + i * 15 + sum_b, 29 + 40 - 25);
                    b_lbs[num].Visible = true;
                    DrawSquare(colors[nums_res[i] - 1], new Point(60 + i * 15 + sum_b, 29 + 40));
                    if (j != b_size - 1)
                        sum_b += 15;
                }

            }
        }

        private void calc_bttn_Click(object sender, EventArgs e)
        {
            grid_input.ClearSelection();
            calc_bttn.Focus();
            ClearPictureBoxes();
            for (int i = 0; i < size; i++)
            {
                if (grid_input.Rows[i].Cells[1].Value == null || grid_input.Rows[i].Cells[2].Value == null)
                {
                    MessageBox.Show("Не все данные введены!", "Внимание!");
                    return;
                }
            }
            Solution();
            DrawSolution();
        }
    }
}
