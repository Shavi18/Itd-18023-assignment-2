using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
             double t, reg, tax;
            Console.WriteLine("Enter Student's age ");
            string ab = Console.ReadLine();
            int y = int.Parse(ab);
            Console.WriteLine("International Student (or not) ");
            string x = Console.ReadLine();
            Console.WriteLine("Registration Semester ");
            string smtr = Console.ReadLine();

            if (x == "not")
            {
                if (y <= 18)
                {
                    t = 300 + (300 * 0.13);
                    Console.WriteLine("Base Tution " + t);
                }
                else if (y <= 49)
                {
                    t = 500 + (500 * 0.13);
                    Console.WriteLine("Base Tution " + t);
                }
                else
                {
                    t = 400 + (400 * 0.13);
                    Console.WriteLine("Base Tution " + t);
                }
            }
            else if (x == "yes")
            {
                if (y <= 18)
                {
                    t = 400 + (400 * 0.13);
                    Console.WriteLine("Base Tution " + t);
                }
                else if (y <= 49)
                {
                    t = 600 + (600 * 0.13);
                    Console.WriteLine("Base Tution " + t);
                }
                else
                {
                    t = 500 + (500 * 0.13);
                    Console.WriteLine("Base Tution " + t);
                }

            }
            switch (smtr)
            {
                case "fall":

                    reg = 250 + (250 * 0.13);
                    t = 500 + (500 * 0.13);
                    Console.WriteLine("Registration Fee " + reg);
                    tax = 250 * 0.13;
                    Console.WriteLine("HST " + tax);
                    double total = reg+t;
                    Console.WriteLine("TOTAL:" + total);
                    break;

                case "winter":

                    reg = 250 + (250 * 0.13);
                    t = 500 + (500 * 0.13);
                    Console.WriteLine("Registration Fee " + reg);
                    tax = 220 * 0.13;
                    Console.WriteLine("HST " + tax);
                    total = reg+t;
                    Console.WriteLine("TOTAL:" + total);
                    break;

                case "summer":

                    reg = 150 + (150 * 0.13);
                    t = 500 + (500 * 0.13);
                    Console.WriteLine("Registration Fee " + reg);
                    tax = 150 * 0.13;
                    Console.WriteLine("HST " + tax);
                    total = reg+t;
                    Console.WriteLine("TOTAL:" + total);
                    break;

                default:

                    Console.WriteLine("Invalid Entery");
                    break;
                }
        }
    }
}