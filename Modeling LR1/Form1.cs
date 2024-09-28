using System.Drawing;
using System.Security.Policy;
using static System.Windows.Forms.AxHost;

namespace Modeling_LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cTC1.AddTabPage(new Johnson_N2());

            cTC1.AddTabPage(new Johnson_N3());

            cTC1.AddTabButton(page_bttn1);
            cTC1.AddTabButton(page_bttn2);
            cTC1.SelectedIndex = 0;

            cTC1.SelectedIndexChanged += SelectedIndexChanged;
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            picBox_underline.Location = new Point(35 + cTC1.SelectedIndex * 105, 86);
            this.MinimumSize = cTC1.MinimumSize;
            //MessageBox.Show(selectedIndex.ToString());
        }

        private void cTC1_Load(object sender, EventArgs e)
        {

        }
    }
}
