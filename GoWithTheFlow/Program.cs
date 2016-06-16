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
            while (true)
            { 


            Console.WriteLine("Are your eyes on the teacher?");
            Console.WriteLine("Is your mouth closed?");
            Console.WriteLine("Are your ears listening?");
            Console.WriteLine("Are your hands and feet still? ");
            Console.WriteLine("Type yes or no");  //Changed to type yes or no
   
            string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    // child typed typed "Yes" this code is executed.
                    Console.WriteLine("You are a very good listener!");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();


                }
                else
                {
                    // child did not type "yes" this code is executed. 
                    Console.WriteLine("Try again, you can do!");

                    /*Console.ReadLine();*/

                    // added Console.ReadKey and commented out Console.ReadLine

                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
        }
    }
}
