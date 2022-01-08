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
using Maze.Classes.vartwo; // Generation;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MazeTwoBase maze;

        public Form1()
        {
            InitializeComponent();
            //maze = new MazeTwoBase();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            maze = new MazeTwoBase();
            maze.RenderSpeed = (byte)nbSpeedRender.Value;
            maze.graphics = pictureBox1.CreateGraphics();

            maze.graphics.Clear(Color.White);
            //maze.GenerationMatrix();

            maze.Render();
            maze.Start(10, 10);
            //gr.DrawEllipse(new Pen(Color.Red, 20), new Rectangle(10, 10, 20, 20)) ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nbSpeedRender_ValueChanged(object sender, EventArgs e)
        {
            maze.graphics = pictureBox1.CreateGraphics();
        }
    }
}
