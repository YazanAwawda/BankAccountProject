using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class currentAcc : BankAccount
    {
        double balance;
        //  List<cources> courses = new List<cources>();

        /*  public double Bbalance(double bal_ance)
          {
              balance = bal_ance;
              return balance;

          }*/
        public currentAcc()
        {

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
            Console.WriteLine("- The authorized person is not given a check book and checks may not be drawn on this type of account \n " +
                "- A free account statement is issued to the user every six months. " +
                "\n- The account is granted all self-services provided by the bank as an approved request and according to the terms of each service");
        }

        public double intrest(double addBalance)
        {
            double rate = 0.25;
            balance = addBalance;
            double intrest = rate * balance;

            Console.WriteLine("*****>>> intrest  = " + intrest);
            return intrest;
        }
    }
}
