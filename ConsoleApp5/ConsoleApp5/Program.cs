using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
        

            for (int r = 1; r < 1000000001; r++)
            {
                int sum = 0;

                for (int j = 1; j < r; j++)
                {
                   if (r % j == 0)
                    {
                        sum += j;
                    }

                }

                if (sum == r)
                {
                    Console.WriteLine(r + " is a perfnum.");
                }

            }
        }
    }
}
