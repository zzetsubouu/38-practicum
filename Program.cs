using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Triangle(3, 4, 5));
            shapes.Add(new Disk(10));
            foreach (var figure in shapes)
            {
                figure.PrintInfo();
            }
            Console.ReadKey();
        }
    }
}
