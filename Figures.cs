using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_practicum
{
    class Figures
    {
        private List<Triangle> triangles = new List<Triangle>();
        private List<Disk> disks = new List<Disk>();

        public void AddFictionBook(Triangle fictionBook) => triangles.Add(fictionBook);
        public void AddNonFictionBook(Disk nonFictionBook) => disks.Add(nonFictionBook);

        public void GetAllTriangles()
        {
            Console.Clear();
            Console.WriteLine("Треугольники:");
            foreach (var f in triangles) f.PrintInfo();
        }
        public void GetAllDisks()
        {
            Console.Clear();
            Console.WriteLine("Круги:");
            foreach (var nf in disks) nf.PrintInfo();
        }
        public void GetAllFigures()
        {
            Console.Clear();
            var allFigures = new List<IShape>();
            allFigures.AddRange(triangles);
            allFigures.AddRange(disks);
            Console.WriteLine("Все книги:");
            foreach (var b in allFigures)
            {
                b.PrintInfo();
            }
        }
    }
}
