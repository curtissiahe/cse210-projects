using System;

namespace Shapes
{
    public class Square : Shape
    {
        public void SetArea(double side)
        {
            area = side * side;
        }

        public override double GetArea()
        {
            return area;
        }

        public override string GetColor()
        {
            return "Green"; // Example color
        }
    }
}
