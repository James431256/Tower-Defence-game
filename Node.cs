using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    class Node
    {
        int wallX;
        int wallY;
        int wallHeight;
        int wallWidth;

        public void setWallX(int wallX1)
        {
            wallX = wallX1;
        }
        public void setWallY(int wallY1)
        {
            wallY = wallY1;
        }
        public void SetHeightWidth(int height1, int width1)
        {
            wallHeight = height1;
            wallWidth = width1;
        }
    }
}
