using System;

namespace Delegate_Event_Practice
{
    class Rectangle : Figure
    {
        public Rectangle(Point[] points)
        {
            Points = points;
        }

        public event Action GetArea;

        public event Action GetWidth;

        public double Width()
        {
            GetWidth?.Invoke();
            return Math.Round(Math.Sqrt(Distance(Points[0], Points[1])), 2);
        }

        public double Height()
            => Math.Round(Math.Sqrt(Distance(Points[1], Points[2])), 2);

        public override double Area()
        {
            GetArea?.Invoke();
            return Math.Round(Height() * Width(), 2);
        }
    }
}
