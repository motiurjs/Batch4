using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class Account
    {
        private string AccountNumber;
        private string CustomerName;
        private int Balance;
        
        public void Create(string accountNumber,string customerName)
        {
            AccountNumber = "" + accountNumber;
            CustomerName = "" + customerName;
            Balance = 0;
        }
        public void Deposite(int amount)
        {
            Balance += amount;
        }
        public void Withdraw(int amount)
        {
            Balance -= amount;
        }
        public string GetReport()
        {
            return "Customer Name: "+CustomerName+"  Account Number: " + AccountNumber + " has Balance: " + Balance;
        }



    }
}
