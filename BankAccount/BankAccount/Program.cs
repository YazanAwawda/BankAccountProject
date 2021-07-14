using System;
using System.Collections.Generic;

namespace BankAccount

//An interface contains definitions for a group of related functionalities that a class or a struct can implement
//The same as contract
//interface defines what part of the contract
//deriving classes define the how part of the contract


// ***** Project Bank Account ***** //
{
    class Program
    {
        #region Tester 
        static void Main(string[] args)
        {


            SavingAcc st = new SavingAcc();
            person std10 = new person(st);
            Console.WriteLine("Your age and your name Plz : ");
            std10.checkAge(20, "Ahmad");
            Console.WriteLine("Overview of services saving account in bank account : ");
            st.CardServices();
            Console.WriteLine("Your Deposit  : "+ st.deposit(1500));
            Console.WriteLine("Your Withdraw : "+ st.Withdraw(2500));
            Console.WriteLine("**************************************");
            currentAcc ts = new currentAcc();
            person ts10 = new person(ts);
            Console.WriteLine("Your age and your name Plz : ");
            ts10.checkAge(24, "Osama");
            Console.WriteLine("Overview of services current account in bank account : ");
            ts.CardServices();
            Console.WriteLine("Your Deposit  : " + ts.deposit(4500));
            Console.WriteLine("Your Withdraw : " + ts.Withdraw(2800));
            Console.WriteLine("**************************************");





        }
        #endregion
    }


   
}

