using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            String loud;

            Console.WriteLine("Enter a phrase: ");
            loud = Console.ReadLine();

            char[] b = loud.ToCharArray();
            b.Reverse();

            String v = new String(b);

            if (loud == v)
            {
                Console.WriteLine(loud + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(loud + " is not a palindrome.");
            }






        }
    }
}
