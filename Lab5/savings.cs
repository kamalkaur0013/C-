using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class savings
    {
        public double initialBalance;
        public Transactions transactions;
        String primier;
        public savings(double bal,String primier)
        {
            transactions = new Transactions();
            this.initialBalance = bal;
            this.primier = primier;
        }

        public void deposit(double val)
        {
            this.initialBalance += val;
            transactions.addTransaction(Enums.TransactionType.DEPOSIT, DateTime.Now.Date, val);
            Console.WriteLine("Deposit complete, account current balance:" + initialBalance);
        }

        public void withraw(double val)
        {
            if(primier == Enums.CustomerStatus.PREMIER.ToString())
            {
                if (val > initialBalance)
                {
                    Console.WriteLine("Withraw cancelled: " + Enums.TransactionResult.INSUFFICIENT_FUND);
                }
                else
                {
                    this.initialBalance -= val;
                    transactions.addTransaction(Enums.TransactionType.WITHDRAW, DateTime.Now.Date, val);
                    Console.WriteLine("Withraw complete, account current balance:" + initialBalance);
                }
            }
            else
            {
                if (val > initialBalance)
                {
                    Console.WriteLine("Withraw cancelled: " + Enums.TransactionResult.INSUFFICIENT_FUND);
                }
                else
                {
                    this.initialBalance -= val;
                    this.initialBalance -= 10;
                    transactions.addTransaction(Enums.TransactionType.PENALTY, DateTime.Now.Date, val);
                    transactions.addTransaction(Enums.TransactionType.WITHDRAW, DateTime.Now.Date, val);

                    Console.WriteLine("Withraw complete, account current balance:" + initialBalance);
                }
            }
               
            

        }

        public void transferOUT(int dAmount3, checking checking)
        {
            if (this.initialBalance > dAmount3)
            {
                this.initialBalance -= dAmount3;
                checking.initialBalance += dAmount3;
                checking.transactions.addTransaction(Enums.TransactionType.TRANSFER, DateTime.Now.Date, dAmount3);
                transactions.addTransaction(Enums.TransactionType.TRANSFER_OUT, DateTime.Now.Date, dAmount3);
                Console.WriteLine("Transfer"+ Enums.TransactionResult.SUCCESS+".");
            }
            else
            {
                Console.WriteLine("Withraw cancelled: " + Enums.TransactionResult.INSUFFICIENT_FUND);
            }
        }
    }
}
