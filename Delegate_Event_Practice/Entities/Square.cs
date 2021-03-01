using System;

namespace Delegate_Event_Practice
{
    public class Square : Figure
    {
        public Square(Point[] points)
        {
            Points = points;
        }

        public double Width()
            => Math.Round(Math.Sqrt(Distance(Points[0], Points[1])), 2);

        public override double Area()
            => Math.Round(Width() * Width(), 2);
    }
}
