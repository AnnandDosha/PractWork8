using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_8
{
    public partial class TabControlForm : Form
    {
        public TabControlForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 2;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
        }
    }
}
