using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1;
            int input2;
            int input3;

            String abc, cba, bac;

            Console.Write("Enter a number: ");
            abc = Console.ReadLine();
            input1 = Convert.ToInt32(abc);

            Console.Write("Enter a number: ");
            cba = Console.ReadLine();
            input2 = Convert.ToInt32(cba);

            Console.Write("Enter a number: ");
            bac = Console.ReadLine();
            input3 = Convert.ToInt32(bac);

            if (input2 > input1 && input2 > input3)
            {
                Console.WriteLine(input2 + " is your largest number");
            }
            else if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine(input1 + " is your largest number");
            }
            else if (input3 > input1 && input3 > input2)
            {
                Console.WriteLine(input3 + " is your largest number");
            }



        }
    }
}
