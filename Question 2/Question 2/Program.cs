using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A2sahilpreetsinghP2
{
    class Program
    {
        static double volume(double r)
        {
            double ert = 4 / 3 * 3.14 * r * r * r;
            Console.WriteLine("volume of sphere = " + ert);
            return ert;
        }
        static double volume(double radi, double h)
        {
            double bc = 3.14 * radi * radi * h;
            Console.WriteLine("volume of cylinder = " + bc);
            return bc;
        }
        static double volume(double l, double w, double he)
        {
            double pq = l * w * he;
            Console.WriteLine("volume of rectangular prism = " + pq);
            return pq;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("ENTER :");
            Console.WriteLine("1.Volume of sphere");
            Console.WriteLine("2.Volume of cylinder");
            Console.WriteLine("3.Volume of rectangular prism");
            string cc = Console.ReadLine();
            int ch = int.Parse(cc);

            switch (ch)
            {
                case 1:
                    Console.WriteLine("volume of sphere");
                    Console.WriteLine("enter radius:");
                    string rs = Console.ReadLine();
                    double po = double.Parse(rs);
                    volume(po);
                    break;
                case 2:
                    Console.WriteLine("volume of cylinder");
                    Console.WriteLine("enter radius:");
                    string r = Console.ReadLine();
                    double rad = double.Parse(r);
                    Console.WriteLine("enter height:");
                    string h = Console.ReadLine();
                    double heit = double.Parse(h);
                    volume(rad, heit);
                    break;
                case 3:
                    Console.WriteLine("volume of rectangular prism");
                    Console.WriteLine("enter lenght:");
                    string l = Console.ReadLine();
                    double len = double.Parse(l);
                    Console.WriteLine("enter width:");
                    string w = Console.ReadLine();
                    double wid = double.Parse(w);
                    Console.WriteLine("enter height:");
                    string H = Console.ReadLine();
                    double k = double.Parse(H);
                    volume(len, wid, k);
                    break;
                default:
                    Console.WriteLine("invalid entry");
                    break;
            }
        }
    }
}