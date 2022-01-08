using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maze.Classes.Helpers;

namespace Maze.Interface
{
    internal interface IMazeBase
    {
        CellColor Colors { get; set; }
        CellSettings Settings { get; set; }
        int Rows { get; set; }
        int Cols { get; set; }
        void Render(Graphics graphics);
    }
}
