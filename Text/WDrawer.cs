using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawCore;


namespace DrawMain
{
    class WDrawer
    {
        private Pen pen;
        private Graphics canvas;

        public WDrawer(Pen newPen, Graphics newCanvas)
        {
            pen = newPen;
            canvas = newCanvas;
        }

        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            canvas.DrawLine(pen, x1, y1, x2, y2);
        }

        public void DrawCircle(int x, int y, int r)
        {
            canvas.DrawEllipse(pen, x, y, r*2, r*2);
        }

        public void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            canvas.DrawRectangle(pen, x1, y1, x2, y2);
        }

        public void DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            canvas.DrawLine(pen, x1, y1, x2, y2);
            canvas.DrawLine(pen, x2, y2, x3, y3);
            canvas.DrawLine(pen, x3, y3, x1, y1);
        }
    }
}
