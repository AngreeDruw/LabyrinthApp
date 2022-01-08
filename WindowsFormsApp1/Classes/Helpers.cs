using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Maze.Classes.Helpers
{
    public class CellColor
    {
        public Color NotSet = Color.Black; //Color.Cornsilk;
        public Color CrissCorss = Color.Gray;
        public Color Wall = Color.Green;
        public Color Passage = Color.Gray;//Color.Blue;
        public Color Impasse = Color.Gray;//Color.Red;

        public Color GetColor(CellType cellType)
        {
            switch (cellType)
            {
                case CellType.NotSet:
                    return NotSet;
                case CellType.CrissCorss:
                    return CrissCorss;
                case CellType.Wall:
                    return Wall;
                case CellType.Passage:
                    return Passage;
                case CellType.Impasse:
                    return Impasse;
                default:
                    return NotSet;
            }
        }
    }

    public class CellSettings
    {
        public int Width = 50;
        public int Height = 50;
        public int Zoom = 1;
    }

    public enum CellType { NotSet, CrissCorss, Wall, Passage, Impasse, Start, Finish }
    public enum Direction { Up, Right, Down, Left }

}
