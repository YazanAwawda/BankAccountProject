using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public interface BankAccount
    {
        double deposit(double amount);
        //   double Bbalance(double balance);
        double Withdraw(double num);
        void CardServices();

    }
}
