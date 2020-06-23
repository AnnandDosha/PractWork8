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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            TimerForm timer = new TimerForm();
            timer.Show();
        }

        private void ImageformButton_Click(object sender, EventArgs e)
        {
            ImageForm image = new ImageForm();
            image.Show();
        }

        private void tadcontrolButton_Click(object sender, EventArgs e)
        {
            TabControlForm control = new TabControlForm();
            control.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm();
            game.Show();
        }
    }
}
