using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze.Classes.Helpers;
using Maze.Interface;
using System.Threading;

namespace Maze.Classes
{
    public class MazeBase: IMazeBase
    {
        public CellColor Colors { get; set; }
        public CellSettings Settings { get; set; }
        public int Rows { get; set; } = 20;
        public int Cols { get; set; } = 20;
        public CellType[,] Matrix { get; set; }
        public Graphics graphics { get; set; }
        public byte RenderSpeed { get; set; } = 255;


        public MazeBase()
        {
            Init();
        }

        public void GenerationStartThread()
        {
            Thread thread = new Thread(new ThreadStart(GenerationMatrix));
            thread.Start();
        }

        public void GenerationMatrix()
        {
            var rand = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Matrix[i, j] = (CellType)rand.Next(1, 3);
                }
            }
        }

        private protected void Init()
        {
            Colors = new CellColor();
            Settings = new CellSettings();

            Matrix = new CellType[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Matrix[i, j] = CellType.NotSet;
                }
            }
        }

        public void Render(Graphics graphics)
        {
            //graphics.DrawEllipse(new Pen(Color.Red, 20), new Rectangle(10, 10, 20, 20));
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    RenderCell(graphics, i, j);
                }
            }
        }

        private protected void RenderCell(Graphics graphics, int IndexRow, int IndexCol)
        {
            var rect = new Rectangle();
            rect.X = IndexRow * Settings.Width * Settings.Zoom;
            rect.Y = IndexCol * Settings.Height * Settings.Zoom;
            rect.Width = Settings.Width * Settings.Zoom;
            rect.Height = Settings.Height * Settings.Zoom;

            var brush = new SolidBrush(Colors.GetColor(Matrix[IndexRow, IndexCol]));
            graphics.FillRectangle(brush, rect);
        }

        private protected void RenderCell(int IndexRow, int IndexCol)
        {
            if (!(graphics is null))
            {
                RenderCell(graphics, IndexRow, IndexCol);
                if (RenderSpeed < 255)
                    Thread.Sleep(255 - RenderSpeed);
            }
        }

    }
}
