using Maze.Classes;
using Maze.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze.Classes.Helpers;

namespace WindowsFormsApp1.Classes.Generation
{
    internal class Maze2 : MazeBase
    {
        public new void GenerationMatrix()
        {
            throw new NotImplementedException();
        }

        private void StepByStep(int IndexRow, int IndexCol)
        {
            if (Matrix[IndexRow, IndexCol] == CellType.NotSet)
            {
                
            }
        }

        public bool SetCellType(int IndexRow, int IndexCol)
        {
            throw new NotImplementedException();
        }

        public void SetFinish()
        {
            throw new NotImplementedException();
        }

        public void SetStart()
        {
            throw new NotImplementedException();
        }
    }
}
