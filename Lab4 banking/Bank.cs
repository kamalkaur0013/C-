using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Bank
    {

        
       // int count = 0;
        static void Main(string[] args)
        {
            string customerName;
            double intialDeposit = 0.0;
            double monthlyDeposit = 0.0;

            List<Saving_account> ownerList = new List<Saving_account>();

            while (true)
            {

                Console.Write("Enter the customer's name:");
                customerName = Console.ReadLine();

                if (customerName == "")
                {

                    break;
                }

                Console.Write("Enter {0}'s Intial Deposit Amount (minimum $1000.00):", customerName);
                intialDeposit = int.Parse(Console.ReadLine());

                Console.Write("Enter {0} Monthly Deposit Amount (minimum $50.00) :", customerName);
                monthlyDeposit = int.Parse(Console.ReadLine());

                Saving_account firstAccount = new Saving_account(customerName, intialDeposit);
                firstAccount.monthlyDepositamount = monthlyDeposit;

                ownerList.Add(firstAccount);

                Console.Write("\n");

            }//end of while

            foreach(Saving_account firstAccount in ownerList)
            {
                for ( int index = 0; index <= 6; index++)
                {
                    firstAccount.Withdraw(firstAccount.monFee);
                    //Console.Write("the amount after deducting monthly fee {0}", firstAccount.currentBalance);
                    //Console.ReadLine();

                    firstAccount.monInterset();
                    //Console.Write("the amount after adding interset {0}", firstAccount.currentBalance);
                    //Console.ReadLine();

                    firstAccount.Deposit(firstAccount.monthlyDepositamount);
                    //Console.Write("the amount after depositing {0}", firstAccount.currentBalance);
                    //Console.ReadLine();
                }

                Console.Write("After 6 months, {0}'s account (#{1}), has a Balance of: ${2} \n", firstAccount.ownerName,firstAccount.accountNumber, firstAccount.currentBalance);

            }//ending of foreach

            Console.Write("\n");

            Console.Write("Press Enter to Complete");

            Console.ReadLine();

           

        } // end of main

    }//end of class
    
}//end of namespace
