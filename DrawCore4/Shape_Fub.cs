using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCore
{
    public class ShapeData
    {
        public string Name;
        public Dictionary<string, int> Data;

        public override string ToString()
        {
            return Name;
        }
    }

    static public class ShapeFab 
    {
        public static Shape Make(ShapeData shData)
        {
            Shape sh = null;

            switch (shData.Name)
            {
                case "Line":
                    sh = new Line(shData.Data["X1"], shData.Data["Y1"], shData.Data["X2"], shData.Data["Y2"]);
                    break;
                case "Circle":
                    sh = new Circle(shData.Data["X"], shData.Data["Y"], shData.Data["R"]);
                    break;
                case "Rectagle":
                    sh = new Rectagle(shData.Data["X"], shData.Data["Y"], shData.Data["X2"], shData.Data["Y2"]);
                    break;
                case "Triagle":
                    sh = new Triagle(shData.Data["X1"], shData.Data["Y1"], shData.Data["X2"], shData.Data["Y2"], shData.Data["X3"], shData.Data["Y3"]);
                    break;
            }
            return sh;
        }

        public static List<ShapeData> InitFiguresData()
        {
            var shapesData = new List<ShapeData>();

            shapesData.Add(new ShapeData
            {
                Name = "Line",
                Data = new Dictionary<string, int>
                {
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 100 },
                    { "Y2", 100 }
                }
            });

            shapesData.Add(new ShapeData
            {
                Name = "Circle",
                Data = new Dictionary<string, int>
                {
                    { "X", 1 },
                    { "Y", 1 },
                    { "Radius", 100 },
                }
            });

            shapesData.Add(new ShapeData
            {
                Name = "Rectagle",
                Data = new Dictionary<string, int>
                {
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 100 },
                    { "Y2", 100 }
                }
            });

            shapesData.Add(new ShapeData
            {
                Name = "Triagle",
                Data = new Dictionary<string, int>
                {
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 100 },
                    { "Y2", 100 },
                    { "X3", 10 },
                    { "Y3", 10 }
                }
            });

            return shapesData;
        }
    }
}
