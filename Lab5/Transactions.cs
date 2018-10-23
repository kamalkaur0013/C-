using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Transactions
    {

        public List<Enums.TransactionType> activity;
        public List<string> date;
        public List<double> amount;
        public Transactions() {
            activity = new List<Enums.TransactionType>();
            date = new List<string>();
            amount = new List<double>();
        }

        public void addTransaction(Enums.TransactionType transactionType,DateTime date,double amount)    
        {
            String format = "MM/dd/yy";
            
            this.activity.Add(transactionType);
            this.date.Add(date.ToString(format));
            this.amount.Add(amount);
        }
       

    }
}
