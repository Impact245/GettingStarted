using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            String user = "", pass = "";
            int tries = 0;

            while (tries < 3 && (user != "root" && pass != "letmein"))
            {
                Console.WriteLine("Enter Username: ");
                user = Console.ReadLine();

                Console.WriteLine("Enter Password: ");
                pass = Console.ReadLine();
                tries++;
            }

            if (user == "root" && pass == "letmein")
            {
                Console.WriteLine("Congratulations, you pass!!");
            }
            else
            {
                Console.WriteLine("Mmmmmmmm try again");
            }
             

        }
    }
}
