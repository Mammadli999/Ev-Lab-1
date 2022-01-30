using System;

namespace Ev
{
    class Program
    {
        static void Main(string[] args)
        {
            Ev ev1 = new Ev();
            ev1.Category = "Villa";
            ev1.Area = 400;
            ev1.NumbersOfRoom = 4;
            ev1.Price = 700000;

            Ev ev2 = new Ev();
            ev2.Category = "Float";
            ev2.Area = 110;
            ev2.NumbersOfRoom = 3;
            ev2.Price = 170000;

            Ev ev3 = new Ev();
            ev3.Category = "Float";
            ev3.Area = 120;
            ev3.NumbersOfRoom = 3;
            ev3.Price = 180000;

            Ev ev4 = new Ev();
            ev4.Category = "Villa";
            ev4.Area = 380;
            ev4.NumbersOfRoom = 6;
            ev4.Price = 480000;

            Ev ev5 = new Ev();
            ev5.Category = "Villa";
            ev5.Area = 1400;
            ev5.NumbersOfRoom = 11;
            ev5.Price = 1874000;

            Ev[] evs = new Ev[5];
            evs[0] = ev1;
            evs[1] = ev2;
            evs[2] = ev3;
            evs[3] = ev4;
            evs[4] = ev5;

            try
            {
                Console.WriteLine("Bu Evin Sifresini Daxil Et");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine(Ev.GetInfo(x, y, c, d, evs)); 
            }
            catch (Exception)
            {

                Console.WriteLine("Bele Ev Movcud Deyildir");
            }
        }
    }
}
