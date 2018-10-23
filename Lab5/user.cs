using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class user
    {
      
        public  String primier;
        private String Name;
        private double initBalance;
        public checking checking;
        public savings savings;
       
        public user(String name,double initBalance) {
            this.Name = name;
            this.initBalance = initBalance;
            checking = new checking(getifPrimier());
            savings = new savings(initBalance,getifPrimier());
            if (savings.initialBalance > 2000) {
                primier = Enums.CustomerStatus.PREMIER.ToString();
            }
            else
            {
                primier = Enums.CustomerStatus.REGULAR.ToString();
            }
        }

        public String getifPrimier()
        {
            return this.primier;
        }

        public string getName() { return this.Name; }

        internal void doTransaction(Enums.TransactionType dEPOSIT)
        {
            
            switch (dEPOSIT)
            {
                case Enums.TransactionType.DEPOSIT:
                   int  x1 = selectAccount();
                    Console.Write("Enter Amount:");
                    int dAmount1 = int.Parse(Console.ReadLine());

                    if (x1 == 1)
                    {
                        checking.deposit(dAmount1);
                    }
                    else if(x1 == 2)
                    {
                        savings.deposit(dAmount1);
                    } 
                    break;
                case Enums.TransactionType.WITHDRAW:
                    int x2 = selectAccount();
                    Console.Write("Enter Amount:");
                    int dAmount2 = int.Parse(Console.ReadLine());

                    if (x2 == 1)
                    {
                        checking.withraw(dAmount2);
                    }
                    else if (x2 == 2)
                    {
                        savings.withraw(dAmount2);
                    }
                    break;
                case Enums.TransactionType.TRANSFER:
                    Console.Write("1 - From Checking to Saving, 2 - From Saving to Checking):");
                    int x3= int.Parse(Console.ReadLine());
                    Console.Write("Enter Amount:");
                    int dAmount3 = int.Parse(Console.ReadLine());
                    if (x3 == 1)
                    {
                        checking.transferOUT(dAmount3,savings);
                    }
                    else if (x3 == 2)
                    {
                        savings.transferOUT(dAmount3,checking);
                    }
                    break;
                case Enums.TransactionType.IN:
                    Console.Write("Current Balance:");
                    Console.WriteLine("     Amount         Balance");
                    Console.WriteLine("     ------         --------");
                    Console.WriteLine("     "+"checking"+"       "+checking.initialBalance);
                    Console.WriteLine("     " + "saving" + "          " + savings.initialBalance);
                    break;
            }
            }

        
        private int selectAccount()
        {
           Console.Write("Select account(1 - Checking Account, 2 - Saving Account):");
           return int.Parse(Console.ReadLine());
        }
    }
}
