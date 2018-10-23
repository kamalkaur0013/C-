using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Saving_account
    {
        int accountNumber;
        string ownerName;
        double currentBalance;
        double monthlyDepositamount;

        static double monthlyFee;
        static double monthlyInterestRate;
        static double minimumIntialBalance;
        static double minimumMonthlyDeposit;

        public Saving_account(string customerName, double intialDeposit)
        {
            this.ownerName = customerName;
            this.currentBalance = intialDeposit;

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

    }
}
