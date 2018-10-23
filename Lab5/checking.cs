using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class checking
    {
        //when new generated bal will be $0
        public double initialBalance=0;
        public Transactions transactions;
        String primier;
        user user;
        public checking(String primier) {
            transactions = new Transactions();
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
            if (primier == Enums.CustomerStatus.PREMIER.ToString())
            {
                if (val > initialBalance)
                {
                    Console.WriteLine("Withraw cancelled: " + Enums.TransactionResult.INSUFFICIENT_FUND);

                }
                else
                {
                    transactions.addTransaction(Enums.TransactionType.WITHDRAW, DateTime.Now.Date, val);
                    this.initialBalance -= val;
                    Console.WriteLine("Withraw complete, account current balance:" + initialBalance);
                }
            
        }else
            {
                if (val< 300)
                {
                    this.initialBalance -= val;
                    transactions.addTransaction(Enums.TransactionType.WITHDRAW, DateTime.Now.Date, val);
                    Console.WriteLine("Withraw complete, account current balance:" + initialBalance);
                }
                else
                {
                    Console.WriteLine("Withraw cancelled: " + Enums.TransactionResult.INSUFFICIENT_FUND);
                }
            }
        }



        public void transferOUT(int dAmount3,savings savings)
        {
            if (this.initialBalance > dAmount3)
            {
                this.initialBalance -= dAmount3;
                savings.initialBalance += dAmount3;
                savings.transactions.addTransaction(Enums.TransactionType.TRANSFER, DateTime.Now.Date, dAmount3);
                transactions.addTransaction(Enums.TransactionType.TRANSFER_OUT, DateTime.Now.Date, dAmount3);
            }
            else
            {
                Console.WriteLine("Withraw cancelled: " + Enums.TransactionResult.INSUFFICIENT_FUND);
            }
        }
    }
}
