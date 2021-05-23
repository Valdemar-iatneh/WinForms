using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCore
{
    public class Shape
    {
        protected int x;
        protected int y;

        public Drawer drawer;

        public Shape(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public virtual void Draw() { }

        public override string ToString()
        {
            return base.ToString() + $"X={x};Y={y}";
        }
    }

    public class Line : Shape
    {
        protected int x2;
        protected int y2;

        public Line(int newX, int newY, int newX2, int newY2) : base(newX, newY)
        {
            x2 = newX2;
            y2 = newY2;
        }

        public override void Draw()
        {
            drawer.DrawLine(x, y, x2, y2);
        }
        public override string ToString()
        {
            return base.ToString() + $"X2={x2};Y2={y2};";
        }
    }

    public class Circle : Shape
    {
        protected int r;

        public Circle(int newX, int newY, int newR) : base(newX, newY)
        {
            r = newR;
        }   

        public override void Draw()
        {
            drawer.DrawCircle(x, y, r);
        }
        public override string ToString()
        {
            return base.ToString() + $"R={r};";
        }
    }

    public class Rectagle : Shape
    {
        protected int x2;
        protected int y2;

        public Rectagle(int newX, int newY, int newX2, int newY2) : base(newX, newY)
        {
            x2 = newX2;
            y2 = newY2;
        }

        public override void Draw()
        {
            drawer.DrawRectagle(x, y, x2, y2);
        }
        public override string ToString()
        {
            return base.ToString() + $"X2 ={ x2}; Y2 ={ y2};";
        }
    }

    public class Triagle : Shape
    {
        protected int x2;
        protected int y2;
        protected int x3;
        protected int y3;

        protected Point point1;
        protected Point point2;
        protected Point point3;
        protected Point[] curvePoints;

        public Triagle(int newX, int newY, int newX2, int newY2, int newX3, int newY3) : base(newX, newY)
        {
            x2 = newX2;
            y2 = newY2;
            x3 = newX3;
            y3 = newY3;
            //point1 = new Point(x, y);
            //point2 = new Point(x2, y2);
            //point3 = new Point(x3, y3);
            //Point[] curvePoints =
            //{
            //    point1,
            //    point2,
            //    point3
            //};
        }

        public override void Draw()
        {
            //drawer.DrawPoligon(curvePoints);
            drawer.DrawLine(x, y, x2, y2);
            drawer.DrawLine(x2, y2, x3, y3);
            drawer.DrawLine(x3, y3, x, y);
        }
        public override string ToString()
        {
            return base.ToString() + $"X2={x2};Y2={y2};X3={x3};Y3={y3};";
        }
    }
}
