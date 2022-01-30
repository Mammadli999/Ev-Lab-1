using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class LabClass
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Gmail;

        public void GetInfo() 
        {
            Console.WriteLine($"{Name}\n" +
                $"{Surname}\n" +
                $"{Age}\n" +
                $"{Gmail}");
        }

    }
}
