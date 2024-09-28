using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Manager.RJControls
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class CustomTabControl : UserControl
    {
        private List<Control> _tabPages = new List<Control>();
        private List<CustomButton> _tabButtons = new List<CustomButton>();
        private int _selectedIndex = 0;

        public CustomTabControl()
        {
            InitializeComponent();

        }
        public event EventHandler SelectedIndexChanged;

        protected virtual void OnSelectedIndexChanged(EventArgs e)
        {
            SelectedIndexChanged?.Invoke(this, e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Name = "CustomTabControl";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
        }

        public void AddTabPage(Control tabPage)
        {
            _tabPages.Add(tabPage);
            tabPage.Dock = DockStyle.Fill;
            tabPage.Visible = false;
            this.Controls.Add(tabPage);
        }

        public void AddTabButton(CustomButton button)
        {
            _tabButtons.Add(button);
            button.Click += TabButton_Click;
        }

        private void TabButton_Click(object sender, EventArgs e)
        {
            int index = _tabButtons.IndexOf((CustomButton)sender);
            if (index != -1)
            {
                SelectedIndex = index;
            }
            SelectedIndexChanged?.Invoke(this, e);
        }

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                if (value >= 0 && value < _tabPages.Count)
                {
                    _selectedIndex = value;
                    foreach (Control tabPage in _tabPages)
                    {
                        tabPage.Visible = false;
                    }
                    _tabPages[_selectedIndex].Visible = true;
                    this.MinimumSize = _tabPages[_selectedIndex].MinimumSize;
                }
            }
        }

        public Control GetTabPage(int index)
        {
            if (index >= 0 && index < _tabPages.Count)
            {
                return _tabPages[index];
            }
            return null;
        }
    }
}
