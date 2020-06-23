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
    public partial class ImageForm : Form
    {
        int xSpeed = 5;
        int currentFrame = 0;

        private void ChangeHeroImage()
        {
            hero.Image = heroImageList.Images[currentFrame];
            if (xSpeed > 0)
            {
                hero.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
        }
        public ImageForm()
        {
            InitializeComponent();
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            ChangeHeroImage();
            heroTimer.Start();

        }

        private void heroTimer_Tick(object sender, EventArgs e)
        {
            if (hero.Location.X + xSpeed < 0 || hero.Location.X + xSpeed + hero.Width > this.Width)
            {
                xSpeed = -xSpeed;
            }
            hero.Location = new Point(hero.Location.X + xSpeed, hero.Location.Y);
            currentFrame = currentFrame != 1 ? 1 : 2;
            ChangeHeroImage();
        }
    }
}
