using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maze.Classes.vartwo
{

    public class MazeTwoBase
    {
        private Random _random;
        private Graphics _graphics;
        Colors colors = new Colors();

        private int _visitedCells = 0;
        public int CellWidth { get; set; } = 20;
        public int CellHeight { get; set; } = 20;
        public int CountRow { get; set; } = 20;
        public int CountCol { get; set; } = 20;
        public Cell[,] Matrix { get; set; }
        public Graphics graphics 
        {
            get
            {
                return _graphics;
            }

            set
            {
                _graphics = value; 
                for (int i = 0; i < CountRow; i++)
                    for (int j = 0; j < CountCol; j++)
                        Matrix[i, j].graphics = value;
            }
        }
        public byte RenderSpeed { get; set; } = 255;

        public MazeTwoBase()
        {
            _random = new Random();
            CellWidth = 20;
            CellHeight = 20;
            Init();
        }

        public void Init()
        {
            Matrix = new Cell[CountRow, CountCol];
            for (int i = 0; i < CountRow; i++)
            {
                for (int j = 0; j < CountCol; j++)
                {
                    int x = i * CellWidth;
                    int y = j * CellHeight;
                    Matrix[i, j] = new Cell();

                    Matrix[i, j].random = _random;
                    Matrix[i, j].SetDiractionList();

                    Matrix[i, j].X = i * CellWidth;
                    Matrix[i, j].Y = j * CellHeight;
                    Matrix[i, j].Width = CellWidth;
                    Matrix[i, j].Height = CellHeight;
                }
            }
            InitBorder();
        }

        public void InitBorder()
        {
            for (int i = 0; i < CountRow; i++)
            {
                Matrix[i, 0].UpWall.Valid = false;
                Matrix[i, 0].UpWall.Wall = true;

                Matrix[i, CountCol - 1].DownWall.Valid = false;
                Matrix[i, CountCol - 1].DownWall.Wall = true;
            }

            for (int i = 0; i < CountCol; i++)
            {
                Matrix[0, i].LeftWall.Valid = false;
                Matrix[0, i].LeftWall.Wall = true;

                Matrix[CountRow - 1, i].RightWall.Valid = false;
                Matrix[CountRow - 1, i].RightWall.Wall = true;
            }
        }

        public void Render()
        {
            for (int i = 0; i < CountRow; i++)
            {
                for (int j = 0; j < CountCol; j++)
                {
                    Matrix[i, j].Render(colors.NoVisited);
                }
            }
        }

        public void Start(int x, int y) => StepByStep(x, y);

        private void StepByStep(int x, int y)
        {
            _visitedCells++;
            if (_visitedCells <= (CountRow * CountCol))
            {
                Matrix[x, y].Visited = true;
                Matrix[x, y].Render(colors.VisitNow);
                Thread.Sleep(20);
                Step(x, y);
                Thread.Sleep(20);
                Matrix[x, y].Render(colors.Visited);
            }
        }

        private void Step(int x, int y)
        {
            foreach (var diractions in Matrix[x, y].Diractions)
            {
                switch (diractions)
                {
                    case Diraction.Up:
                        {
                            StepUp(x, y);
                            break;
                        }
                    case Diraction.Down:
                        {
                            StepDown(x, y);
                            break;
                        }
                    case Diraction.Left:
                        {
                            StepLeft(x, y);
                            break;
                        }
                    case Diraction.Right:
                        {
                            StepRight(x, y);
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void StepRight(int x, int y)
        {
            if (Matrix[x, y].RightWall.Valid && !Matrix[x + 1, y].Visited)
            {
                Matrix[x, y].RightWall.Wall = false;
                Matrix[x + 1, y].LeftWall.Wall = false;
                StepByStep(x + 1, y);
            }
        }

        private void StepLeft(int x, int y)
        {
            if (Matrix[x, y].LeftWall.Valid && !Matrix[x - 1, y].Visited)
            {
                Matrix[x, y].LeftWall.Wall = false;
                Matrix[x - 1, y].RightWall.Wall = false;
                StepByStep(x - 1, y);
            }
        }

        private void StepUp(int x, int y)
        {
            if (Matrix[x, y].UpWall.Valid && !Matrix[x, y - 1].Visited)
            {
                Matrix[x, y].UpWall.Wall = false;
                Matrix[x, y - 1].DownWall.Wall = false;
                StepByStep(x, y -1);
            }
        }

        private void StepDown(int x, int y)
        {
            if (Matrix[x, y].DownWall.Valid && !Matrix[x, y + 1].Visited)
            {
                Matrix[x, y].DownWall.Wall = false;
                Matrix[x, y + 1].UpWall.Wall = false;
                StepByStep(x, y + 1);
            }
        }

    }
}
