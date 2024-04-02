using System;

namespace Shapes
{
    public class Rectangle :Shape
    {
        public void SetArea(double length, double width)
        {
            area = length * width;
        }

        public override double GetArea()
        {
            return area;
        }

        public override string GetColor()
        {
            return "Blue"; // Example color
        }
    }
}
