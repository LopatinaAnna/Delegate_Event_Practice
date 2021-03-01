﻿using System;

namespace Delegate_Event_Practice
{
    public static class Validation
    {
        private static double Distance(Point a, Point b)
            => Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2);

        public static bool IsSquare(Point[] points)
            => points.Length == 4 &&
            Distance(points[0], points[1]) == Distance(points[1], points[2]) &&
            Distance(points[1], points[2]) == Distance(points[2], points[3]) &&
            Distance(points[2], points[3]) == Distance(points[3], points[0]);


        public static bool IsRectangle(Point[] points)
            => points.Length == 4 
            && Distance(points[0], points[1]) == Distance(points[2], points[3]) &&
            Distance(points[1], points[2]) == Distance(points[3], points[0]);

        public static bool IsTriangle(Point[] points)
            => points.Length == 3 &&
            Distance(points[0], points[1]) > 0 &&
            Distance(points[1], points[2]) > 0 &&
            Distance(points[2], points[0]) > 0;
    }
}
