using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are your eyes on Teacher?");
            Console.WriteLine("Is your mouth closed?");
            Console.WriteLine("Are your ears listening?");
            Console.WriteLine("Are your hands and feet still? ");
            Console.WriteLine("Yes or No");
   
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes") 
            {
                // child typed typed "Yes" this code is executed.
                Console.WriteLine("You are a very good listener!");
                Console.ReadLine();
   

            }
            else
            {
                // child did not type "yes" this code is executed. 
                Console.WriteLine("Try again, you can do!");
                Console.ReadLine();

            }
        }
    }
}
