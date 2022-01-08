using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Interface
{
    internal interface IMazeGeneration
    {
        void GenerationMatrix();
        void SetStart();
        void SetFinish();
        void SetCellType(int IndexRow, int IndexCol);
    }
}
