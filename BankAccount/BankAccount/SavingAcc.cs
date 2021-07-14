using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class SavingAcc : BankAccount
    {
        double balance;

        /* public double Bbalance(double bal_ance)
          {
              balance = bal_ance;
              return balance;

          } */
        public SavingAcc()
        {
        }
        public double intrest(double addBalance)
        {
            double rate = 0.05;
            balance = addBalance;
            double intrest = rate * balance;

            Console.WriteLine("*****>>> intrest  = " + intrest);
            return intrest;
        }
        public double deposit(double amount)
        {


            var intreset = intrest(amount);
            balance -= intreset;
            Console.WriteLine("*****>>> You Deposit  = " + balance);
            return balance;
        }
        public double Withdraw(double amount)
        {
            double newBalance = balance - amount;
            balance = newBalance;
            return newBalance;
        }

        public void CardServices()
        {
            Console.WriteLine("- The user gets a check book. \n" +
                "- The user can open more than one sub-account in different currencies. " +
                "\n- A free account statement is issued to the user every six months.");
        }



    }
}
