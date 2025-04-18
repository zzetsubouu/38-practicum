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
            Figures figures = new Figures();
            while (true)
            {
                Console.WriteLine("\nВыберите нужное Вам действие:");
                Console.WriteLine("1. Добавить в список треугольник;");
                Console.WriteLine("2. Добавить в список круг;");
                Console.WriteLine("3. Вывести все треугольники из списка;");
                Console.WriteLine("4. Вывести все круги из списка;");
                Console.WriteLine("5. Вывести все фигуры.");
                Console.WriteLine("6. Выход.");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        figures.AddFictionBook(Triangle.Create());
                        break;
                    case 2:
                        figures.AddNonFictionBook(Disk.Create());
                        break;
                    case 3:
                        figures.GetAllTriangles();
                        break;
                    case 4:
                        figures.GetAllDisks();
                        break;
                    case 5:
                        figures.GetAllFigures();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }
    }
}
