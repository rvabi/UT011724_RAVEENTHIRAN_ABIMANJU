using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    internal class Account
    {
        public string BankName = "RV TIC BANK";
        public string AccountHolderName;
        public int AccountNumber;
        public decimal AccountBalance = 0;

        public void Deposit( decimal balance)
        {
            if (balance > 0) {

                AccountBalance += balance;
                AccountBalance = Math.Round(AccountBalance, 2);

                Console.WriteLine("Amount Deposited Successfully!");
                Console.WriteLine($"Updated Balance : {AccountBalance:F2}");
            }
            else
            {
                Console.WriteLine("Invalid Deposite...");
            }
            
        }

        public void Withdraw( decimal balance )
        {
            if (balance > 0)
            {
                if (balance < AccountBalance)
                {
                    AccountBalance -= balance;

                    Console.WriteLine("Withdrawal Successful!");
                    Console.WriteLine($"Remaining Balance : {AccountBalance:F2}");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance.... ");
                }
            }
            else
            {
                Console.WriteLine("Invalid Withdraw Amount...");
            }

            
        }
    }
}
