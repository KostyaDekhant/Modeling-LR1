using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Modeling_LR1
{
    internal interface Funs
    {
        public class Pair<T, U>
        {
            public Pair()
            {
            }

            public Pair(T first, U second)
            {
                this.First = first;
                this.Second = second;
            }

            public T First { get; set; }
            public U Second { get; set; }
        };

        static public void SetSize(String filename, out int size)
        {
            string[] nums = File.ReadAllLines(filename);//"inputN2.txt"
            size = nums.Length;
        }

        static public void InitGrid(DataGridView Grid, bool flag, int size)
        {
            Grid.Rows.Clear();
            Grid.Columns.Clear();
            Grid.Columns.Add("№", "№");
            Grid.Columns.Add("Ai", "ai");
            Grid.Columns.Add("Bi", "bi");
            if(!flag)
                Grid.Columns.Add("Ci", "ci");

            for (int i = 0; i < size; i++)
            {
                Grid.Rows.Add();
                Grid.Rows[i].Cells[0].Value = (i + 1).ToString();
                Grid.Rows[i].Cells[0].ReadOnly = true;
            }

            Grid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            if(!flag)
                Grid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            Grid.ScrollBars = ScrollBars.None;
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
            Grid.Height = height;
        }


        static public void FillGrid(String filename, bool flag, DataGridView Grid1, DataGridView Grid2, int size)
        {
            string[] nums = File.ReadAllLines(filename);
            for (int i = 0; i < nums.Length; i++)
            {
                string[] num = nums[i].Split(' ');
                int row = Convert.ToInt32(num[0]) - 1;
                Grid1.Rows[row].Cells[1].Value = num[1];
                Grid1.Rows[row].Cells[2].Value = num[2];
                if (!flag)
                    Grid1.Rows[row].Cells[3].Value = num[3];
            }
            Grid1.RowCount = size;
            Grid2.RowCount = size;
        }

        static public void DrawSquare(Color color, Point loc, Panel pn, List<PictureBox> picList)
        {
            PictureBox pb = new PictureBox();
            pn.Controls.Add(pb);

            pb.BackColor = color;
            pb.Location = loc;
            pb.Size = new Size(14, 14);

            picList.Add(pb);
        }
        static public void ClearPictureBoxes(List<PictureBox> picList, Panel pn)
        {
            foreach (PictureBox pb in picList)
            {
                pn.Controls.Remove(pb);
                pb.Dispose();
            }
            picList.Clear();
        }
        static public void InitLb(Label destination, String str, int width)
        {
            destination.Text = str;
            destination.Size = new Size(width, 20);
            destination.ForeColor = Color.White;
            destination.Visible = false;
        }
        static public void SetRows(DataGridView Grid, int size)
        {
            Grid.Rows.Clear();
            for (int i = 0; i < size; i++)
            {
                Grid.Rows.Add();
                Grid.Rows[i].Cells[0].Value = (i + 1).ToString();
                Grid.Rows[i].Cells[0].ReadOnly = true;
            }
            int height = Grid.Rows.Count * Grid.Rows[0].Height + Grid.ColumnHeadersHeight + 2;
            Grid.Height = height;
        }

    }
}
