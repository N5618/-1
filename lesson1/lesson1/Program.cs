using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shape;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangular[] triangulars = new triangular[4];
            squre[] squres = new squre[4];
            foreach (triangular i in triangulars)
            {
                if (i.hieght > 4)
                    Console.WriteLine(i.hieght);
            }


            var squre1= from item in squres
                        where item.width==1
                        select item;

        }
    }
}
