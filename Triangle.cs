using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_practicum
{
    public class Triangle : IShape
    {
        private int side1;
        private int side2;
        private int side3;

        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        public int Side3 { get => side3; set => side3 = value; }

        public Triangle(int side1, int side2, int side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными.");
            }

            if (!(side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1))
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует.");
            }

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public double Area()
        {
            double p = (side1 + side2 + side3) / 2.0;
            double area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

            return area;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Треугольник: Стороны - {side1}, {side2}, {side3}");
            Console.WriteLine($"Периметр: {Perimeter()}");
            Console.WriteLine($"Площадь: {Area()}");
        }
    }
}
