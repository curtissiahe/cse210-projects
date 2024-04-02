using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public void SetArea(double radius)
        {
            area = Math.PI * radius * radius;
        }

        public override double GetArea()
        {
            return area;
        }

        public override string GetColor()
        {
            return "Red"; // Example color
        }
    }
}
