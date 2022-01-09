using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maze.Classes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MazeTwoBase maze;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            maze = new MazeTwoBase();
            maze.RenderSpeed = (byte)nbSpeedRender.Value;
            maze.CountRow = (int)nbRows.Value;
            maze.CountCol = (int)nbCols.Value;
            maze.Init();
            maze.graphics = pictureBox1.CreateGraphics();

            maze.graphics.Clear(Color.White);
            //pictureBox1.Image = maze.bitmap;
            maze.Render();
            maze.Start(1, 1);
            //pictureBox1.Image = maze.bitmap;

            //pictureBox1.Image = maze.RenderBitmap();
            //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nbSpeedRender_ValueChanged(object sender, EventArgs e)
        {
            //maze.graphics = pictureBox1.CreateGraphics();
        }
    }
}
