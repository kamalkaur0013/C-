using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            String userInput;
            do
            {

                // prompting the user
                Console.Write("Enter an interger,please");
                // convert string to integer
                 userInput = Console.ReadLine();
                number1 = Convert.ToInt32(userInput);
            } while (!String.IsNullOrEmpty(userInput));

          
            {

            }



        }
    }
}
