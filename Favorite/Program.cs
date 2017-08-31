using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Favorite Food");
            String h = Console.ReadLine();

            if (h != "Pizza")
            {
                Console.WriteLine("You are terribly wrong sir! Your favorite should be pizza.");
            }
            else
            {
                Console.WriteLine("Look buddy, You're Terrific, Absolutely Stunning!");
            }
        }
    }
}
