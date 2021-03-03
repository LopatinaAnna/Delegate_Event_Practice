using System;

namespace Delegate_Event_Practice
{
    class Triangle : Figure
    {
        public Triangle(Point[] points)
        {
            Points = points;
        }

        public delegate void AreaDelegate();
        public event AreaDelegate GetArea;

        public override double Area()
        {
            GetArea?.Invoke();
            return Math.Abs((Points[0].X - Points[2].X) * (Points[1].Y - Points[2].Y) -
                (Points[1].X - Points[2].X) * (Points[0].Y - Points[2].Y)) / 2;
        }
    }
}
