using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LabClass lab1 = new LabClass();
            lab1.Name = "Abbas";
            lab1.Surname = "Mammadli";
            lab1.Age = 22;
            lab1.Gmail = "abbas.memmedli.1990@mail.ru";

            LabClass lab2 = new LabClass();
            lab2.Name = "Abbas";
            lab2.Surname = "Mammadli";
            lab2.Age = 22;
            lab2.Gmail = "abbas.memmedli.1990@mail.ru";

            LabClass[] labClasses = new LabClass[2];
            labClasses[0] = lab1;
            labClasses[1] = lab2;

            foreach (LabClass item in labClasses)
            {
                item.GetInfo();
            }



        }
    }
}
