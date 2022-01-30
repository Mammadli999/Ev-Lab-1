using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev
{
    class Ev
    {
        public string Category;
        public int Area;
        public int NumbersOfRoom;
        public double Price;

        public static string GetInfo(int x, int y, int c, int d, Ev[] array ) 
        {
            return($"{array[x].Category}\n" +
                $"{array[y].Area}\n" +
                $"{array[c].NumbersOfRoom}\n" +
                $"{array[d].Price}");
        }
    }
}
