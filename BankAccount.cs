using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class BankAccount
    {
        private String accountNumber;
        private decimal balance;

        public BankAccount(String accountNumber)
        {
            this.accountNumber = accountNumber; 
            this.balance = 0;
        }
        public void Deposite(decimal amount)
        {
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }
        public decimal getBalance()
        {
            return balance;
        }

    }
}
