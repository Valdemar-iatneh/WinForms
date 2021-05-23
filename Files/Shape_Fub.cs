using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCore
{
    public class ShapesData
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
        public static Shape Make(ShapesData shData)
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
                        
            }
            return sh;
        }
    }
}
