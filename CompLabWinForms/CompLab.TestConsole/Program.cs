using CompLab.Models.Collections;
using CompLab.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLab.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ComputerList();
            var comp1 = new Computer() { Id = Guid.NewGuid(), Price = 1 };
            var comp2 = new Computer() { Id = Guid.NewGuid(), Price = 2 };
            var comp3 = new Computer() { Id = Guid.NewGuid(), Price = 3 };
            var comp4 = new Computer() { Id = Guid.NewGuid(), Price = 4 };

            list.Push(comp1);
            list.Push(comp2);
            list.Push(comp3);
            list.Push(comp4);

            foreach (var item in list)
                Console.WriteLine(((Computer)item).Price);
            Console.WriteLine();

            list.Remove(comp4);

            foreach (var item in list)
                Console.WriteLine(((Computer)item).Price);
        }
    }
}
