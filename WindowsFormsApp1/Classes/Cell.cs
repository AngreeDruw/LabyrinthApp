using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Classes
{
    public class Cell
    {
        private Random _random = new Random();
        public Random random { get { return _random; } set { _random = value; } }
        public Graphics graphics { get; set; }

        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;

        public CellMod LeftWall { get; set; } = new CellMod();
        public CellMod RightWall { get; set; } = new CellMod();
        public CellMod UpWall { get; set; } = new CellMod();
        public CellMod DownWall { get; set; } = new CellMod();
        public bool Visited { get; set; } = false;
        public List<Diraction> Diractions { get; set; }
        public Cell()
        {
            Visited = false;
            SetDiractionList();
        }

        public void SetDiractionList()
        {
            var HelpList = new List<Diraction>();
            HelpList.Add(Diraction.Up);
            HelpList.Add(Diraction.Down);
            HelpList.Add(Diraction.Left);
            HelpList.Add(Diraction.Right);

            Diractions = new List<Diraction>();

            while (HelpList.Count > 0)
            {
                int index = _random.Next(HelpList.Count);
                Diractions.Add(HelpList[index]);
                HelpList.RemoveAt(index);
            }

        }

        public void Render(Color colorFill)
        {
            if (graphics is null)
                return;

            var pen = new Pen(Color.Black);
            var brush = new SolidBrush(colorFill);

            graphics.FillRectangle(brush, X, Y, Width, Height);
            RenderLeftWall();
            RenderRightWall();
            RenderUpWall();
            RenderDownWall();
        }

        private void RenderLeftWall()
        {
            if (LeftWall.Wall)
                graphics.DrawLine(new Pen(Color.Black), X, Y, X, Y + Height);
        }

        private void RenderRightWall()
        {
            if (RightWall.Wall)
                graphics.DrawLine(new Pen(Color.Black), X + Width, Y, X + Width, Y + Height);
        }

        private void RenderUpWall()
        {
            if (UpWall.Wall)
                graphics.DrawLine(new Pen(Color.Black), X, Y, X + Width, Y);
        }

        private void RenderDownWall()
        {
            if (DownWall.Wall)
                graphics.DrawLine(new Pen(Color.Black), X, Y + Height, X + Width, Y + Height);
        }
    }

}
