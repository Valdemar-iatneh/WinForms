using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCore
{
    abstract public class Drawer
    {
        public abstract void DrawLine(int x1, int y1, int x2, int y2);
        public abstract void DrawCircle(int x, int y, int r);
        public abstract void DrawRectagle(int x1, int y1, int x2, int y2);
        //public abstract void DrawPoligon(int x1, int y1, int x2, int y2, int x3, int y3);
    }
}
