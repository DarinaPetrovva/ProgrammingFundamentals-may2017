﻿using System;

namespace P05_CalculateTriangleArea
{
    class P05_CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double HeightA = double.Parse(Console.ReadLine());
            double triangleArea = GetTriangleArea(sideA, HeightA);
            Console.WriteLine(triangleArea);
        }

        static double GetTriangleArea(double sideA, double heightA)
        {
            return sideA * heightA / 2;
        }
    }
}
