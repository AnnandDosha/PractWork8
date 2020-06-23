using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_8
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.InitialDirectory = "Текстовый файл|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            int i = 0;
            int j = 0;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = openFileDialog.FileName;

                using(StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string stroka = "";
                    while((stroka = reader.ReadLine()) != null)
                    {
                        i = stroka.Split(' ').Length;
                        j++;

                        int cellSize = 30;
                        for (int x = 0; x <i; x++)
                        {
                            PictureBox cell = new PictureBox();
                            cell.Width = cellSize;
                            cell.Height = cellSize;
                            cell.Location = new Point(x * cellSize, j * cellSize);
                            cell.BorderStyle = BorderStyle.FixedSingle;
                            cell.SizeMode = PictureBoxSizeMode.Zoom;

                            if (stroka[x * 2] == 'X')
                            {
                                cell.Image = imageList.Images[0];
                            }
                            if (stroka[x * 2] == '.')
                            {
                                cell.Image = imageList.Images[1];
                            }
                            if (stroka[x * 2] == 'E')
                            {
                                cell.Image = imageList.Images[2];
                            }
                            this.Controls.Add(cell);
                        }
                    }

                }

            }
        }
    }
}
