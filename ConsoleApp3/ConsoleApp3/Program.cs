using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            String Jellyfish;

            Console.WriteLine("Enter an expression: ");
            Jellyfish = Console.ReadLine();

            String[] Jelly = Jellyfish.Split();

            int campfire;
            int song;
            int song2 = 0;
            String loser;

            campfire = Convert.ToInt32(Jelly[0]);
            song = Convert.ToInt32(Jelly[2]);
            loser = Jelly[1];

            if (loser == "+")
            {
                Console.WriteLine("Result: " + campfire + " + " + song + " = " + (campfire + song));
            }

            if (loser == "-")
            {
                Console.WriteLine("Result: " + campfire + " - " + song + " = " + (campfire - song));
            }

            if (loser == "*")
            {
                Console.WriteLine("Result: " + campfire + " * " + song + " = " + (campfire * song));
            }

            if (loser == "/")
            {
                Console.WriteLine("Result: " + campfire + " / " + song + " = " + (campfire / song));
            }
        }
    }
}
