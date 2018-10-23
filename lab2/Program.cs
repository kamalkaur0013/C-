using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace lab2
{

    class Program
    {

        static void Main(string[] args)
        {





            int numInput = 0;

            string userInput;



            int maxNum = int.MinValue;

            int minNum = int.MaxValue;

            int sumEven = 0;

            int totalEven = 0;

            double avgEven = 0.0;

            int sumOdd = 0;

            int totalOdd = 0;

            double avgOdd = 0.0;
            int count = 0;
            while (true)
            {

                // prompting the user

                Console.Write("Enter an interger,please:- ");

                //userInput = Int16.Parse(Console.ReadLine());

                // convert string to integer

                userInput = Console.ReadLine();

                if (userInput == "" && count == 0)
                {
                    Console.WriteLine("You haven't entered a number yet");
                    break;
                }
                else if (userInput != "")
                {

                    numInput = int.Parse(userInput);
                    count++;

                }
                else
                {
                    break;
                }





                if (numInput > maxNum)
                {

                    maxNum = numInput;
                    // Console.WriteLine("The maximum valuse is:- {0}", maxNum);
                }

                if (numInput < minNum)
                {

                    minNum = numInput;

                    //Console.WriteLine("The minimum valuse is:- {0}", minNum);

                }

                if (numInput % 2 == 0)
                {

                    sumEven += numInput;

                      totalEven++;
                    //Console.WriteLine("The sum of even integers: {0}", sumEven);

                }
                else
                {

                    sumOdd += numInput;

                    totalOdd++;
                    //Console.WriteLine("The sum of odd integers: {0} ", sumOdd);

                }



                if (totalOdd != 0)
                {

                    avgOdd = (Convert.ToDouble(sumOdd)) / totalOdd;
                    //Console.WriteLine("The average of even integers: {0}", avgEven);

                }
                else
                {

                    avgOdd = 0.0;

                }

                if (totalEven != 0)
                {

                    avgEven = (Convert.ToDouble(sumEven)) / totalEven;
                    //Console.WriteLine("The average of odd integers: {0}", avgOdd);
                }
                else
                {

                    avgEven = 0.0;

                }
            }


                if (count != 0)



                {


                    Console.WriteLine("The maximum valuse is:- {0}", maxNum);



                    Console.WriteLine("The minimum valuse is:- {0}", minNum);

                    Console.WriteLine("The sum of even integers: {0}", sumEven);

                    Console.WriteLine("The sum of odd integers: {0} ", sumOdd);

                    Console.WriteLine("The average of even integers: {0}", avgEven);

                    Console.WriteLine("The average of odd integers: {0}", avgOdd);

                }

                
                

                    Console.WriteLine("Do you want to play again?(yes/No) ");

                    string replayGame = Console.ReadLine();



                    if (replayGame == "yes")
                    {

                        Main(null);



                    }
                    else
                    {

                        Console.WriteLine("Thank you for playing");

                        Console.Read();

                    }

            Console.ReadLine();

            



        }//End Main

    }//End of Class

}// End of Na