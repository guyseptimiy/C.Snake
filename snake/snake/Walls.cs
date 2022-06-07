using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Walls
    {
        private List<Figure> wallList;
        private readonly char sym = '+';
        
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, sym);
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, sym);
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 1, sym);
            VerticalLine rightLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, sym);

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
