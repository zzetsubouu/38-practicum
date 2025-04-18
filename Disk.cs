using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_practicum
{
    class Disk:IShape
    {
        private int radius;
        public int Radius { get => radius; set => radius = value; }
        public Disk(int radius)
        {
            Radius = radius;
        }
        public double Perimeter()
        {
            return Math.PI * 2 * radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Круг: Стороны - радиус = {Radius}");
            Console.WriteLine($"Периметр: {Perimeter():F2}");
            Console.WriteLine($"Площадь: {Area():F2}");
        }
        public static Disk Create()
        {
            Console.Clear();
            Console.Write("Введите радиус: ");
            int radius = int.Parse(Console.ReadLine());
            return new Disk(radius);
        }
    }
}
