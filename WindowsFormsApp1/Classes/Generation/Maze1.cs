using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze.Classes;
using Maze.Interface;
using Maze.Classes.Helpers;

namespace Maze.Classes.Generation
{
    public class Maze1: MazeBase, IMazeGeneration
    {
        private Random rand = new Random();
        public new void GenerationMatrix()
        {
            Matrix = new CellType[Rows, Cols];
            SetBorder();
            SetStart();
            SetFinish();
            StepByStep(1, 1);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    SetCellType(i, j);
                    RenderCell(i, j);
                }
            }
        }

        private void StepByStep(int IndexRow, int IndexCol)
        {
            var direction = (Direction)rand.Next(0, 4);
            switch (direction)
            {
                case Direction.Up:
                    {
                        SetCellType(IndexRow - 1, IndexCol);
                        break;
                    }
                case Direction.Right:
                    {
                        SetCellType(IndexRow, IndexCol + 1);
                        break;
                    }
                case Direction.Down:
                    {
                        SetCellType(IndexRow + 1, IndexCol);
                        break;
                    }
                case Direction.Left:
                    {
                        SetCellType(IndexRow, IndexCol - 1);
                        break;
                    }
                default:
                    break;
            }
            RenderCell(IndexRow, IndexCol);
        }

        public void SetCellType(int IndexRow, int IndexCol)
        {
            if (Matrix[IndexRow, IndexCol] == CellType.NotSet)
            {
                switch ((CellType)rand.Next((int)CellType.CrissCorss, (int)CellType.Start))
                {
                    case CellType.CrissCorss:
                        {
                            SetCross(IndexRow, IndexCol);
                            break;
                        }
/*                    case CellType.Wall:
                        {
                            SetWall(IndexRow, IndexCol);
                            break;
                        }*/
/*                    case CellType.Passage:
                        {
                            SetPassage(IndexRow, IndexCol);
                            break;
                        }*/
                    case CellType.Impasse:
                        {
                            SetImpasse(IndexRow, IndexCol);
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void SetCross(int IndexRow, int IndexCol)
        {
            if (Matrix[IndexRow, IndexCol] == CellType.NotSet)
            {
                Matrix[IndexRow, IndexCol] = CellType.CrissCorss;

                bool Up = Convert.ToBoolean(rand.Next(0, 2));
                bool Down = Convert.ToBoolean(rand.Next(0, 2));
                bool Left = Convert.ToBoolean(rand.Next(0, 2));
                bool Right = Convert.ToBoolean(rand.Next(0, 2));

                if (Up) SetPassage(IndexRow - 1, IndexCol, Direction.Up); else SetWall(IndexRow - 1, IndexCol);
                if (Down) SetPassage(IndexRow + 1, IndexCol, Direction.Down); else SetWall(IndexRow + 1, IndexCol);
                if (Left) SetPassage(IndexRow, IndexCol - 1, Direction.Left); else SetWall(IndexRow, IndexCol - 1);
                if (Right) SetPassage(IndexRow, IndexCol + 1, Direction.Right); else SetWall(IndexRow, IndexCol + 1);

                SetWall(IndexRow - 1, IndexCol - 1);
                SetWall(IndexRow - 1, IndexCol + 1);
                SetWall(IndexRow + 1, IndexCol - 1);
                SetWall(IndexRow + 1, IndexCol + 1);

                StepByStep(IndexRow, IndexCol);
            }
        }

        private void SetPassage(int IndexRow, int IndexCol, Direction direction)
        {
            if (Matrix[IndexRow, IndexCol] == CellType.NotSet)
            {
                if (direction == Direction.Up || direction == Direction.Down)
                {
                    SetWall(IndexRow, IndexCol - 1);
                    SetWall(IndexRow, IndexCol + 1);
                }
                else
                if (direction == Direction.Left || direction == Direction.Right)
                {
                    SetWall(IndexRow - 1, IndexCol);
                    SetWall(IndexRow + 1, IndexCol);
                }

                Matrix[IndexRow, IndexCol] = CellType.Passage;
                StepByStep(IndexRow, IndexCol);
            }
        }

        private void SetWall(int IndexRow, int IndexCol)
        {
            if (Matrix[IndexRow, IndexCol] == CellType.NotSet)
            {
                Matrix[IndexRow, IndexCol] = CellType.Wall;
            }
        }
        private void SetImpasse(int IndexRow, int IndexCol)
        {
            if (Matrix[IndexRow, IndexCol] == CellType.NotSet)
            {
                Matrix[IndexRow, IndexCol] = CellType.Impasse;
                StepByStep(IndexRow, IndexCol);
            }
        }

        public void SetFinish()
        {
            Matrix[Rows - 2, Cols - 2] = CellType.Finish;
        }

        public void SetStart()
        {
            Matrix[1, 1] = CellType.Start;
        }

        private void SetBorder()
        {
            for (int i = 0; i < Rows; i++)
            {
                Matrix[i, 0] = CellType.Wall;
                Matrix[i, Rows - 1] = CellType.Wall;
            }

            for (int i = 0; i < Cols; i++)
            {
                Matrix[0, i] = CellType.Wall;
                Matrix[Cols - 1, i] = CellType.Wall;
            }
        }

    }
}
