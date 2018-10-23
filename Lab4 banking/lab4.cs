using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Saving_account
    {

       public int accountNumber;
       public string ownerName;
       public double currentBalance;
       public double monthlyDepositamount;

       static public double monthlyFee = 4.0;
       static public double minimumIntialBalance = 1000.00;
       static public double minimumMonthlyDeposit = 50.00;
       static public double monthlyInterestRate=0.0025;

       public Saving_account(string customerName, double intialDeposit)
       {
            this.ownerName = customerName;
            this.currentBalance = minimumIntialBalance;

            Random Account = new Random();
            this.accountNumber = Account.Next(90000, 99999);

       }//end of saving account

       public void Deposit (double increaseBalance)
       {
            this.currentBalance += increaseBalance;
       }//end of deposit

       public void Withdraw(double decreaseBalance)
       {
            this.currentBalance -= decreaseBalance;
       }
       
        public double monFee
        {
             get { return monthlyFee; }

            set
            {
                monthlyFee = value;
            }
        }

        public void monInterset()
        {
            double newAmount = this.currentBalance * ( monthlyInterestRate);
            this.Deposit(newAmount);
        }


        // public void monDeposit()
        //{
        // double newAmount3 = this.currentBalance + monthlyDepositamount;
        //this.Deposit(newAmount3);
        //}

    }
}
