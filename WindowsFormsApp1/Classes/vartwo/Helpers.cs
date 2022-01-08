using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Classes.vartwo
{
    public enum Diraction { Up, Down, Left, Right, Statrt }

    public class Colors
    {
        public Color NoVisited { get; set; } = Color.Gray;
        public Color Visited { get; set; } = Color.White;
        public Color VisitNow { get; set; } = Color.LightPink;
    }

    public class CellMod
    {
        public bool Valid = true;
        public bool Wall = true;
    }

}
