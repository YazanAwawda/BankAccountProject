using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class person
    {
        BankAccount type_acc;
        int age;
        string name;
        BankAccount account;

        public person(BankAccount acc)
        {

            this.type_acc = acc;
            if (type_acc is currentAcc)
            {
                type_acc = type_acc as currentAcc;
                if (type_acc == null)
                {
                    Console.WriteLine("You are not available");
                }
                account = type_acc;



            }
            else if (type_acc is SavingAcc)
            {
                type_acc = type_acc as SavingAcc;
                if (type_acc == null)
                {
                    Console.WriteLine("You are not available");

                }
                account = type_acc;


            }
            else
            {
                Console.WriteLine("You don't have account");
            }
        }

        public person()
        {

        }

        public BankAccount getAccount()
        {
            if (account is currentAcc)
            {
                return account as currentAcc;
            }
            else
            {
                return account as SavingAcc;
            }
        }

        public void checkAge(int Ag_E, string na_me)
        {
            name = na_me;
            age = Ag_E;
            Console.WriteLine("Name : " + name + "\nAge : " + age);
            if (age > 18)
            {
                Console.WriteLine("Pass " + name);
            }
            else if (age < 18)
            {
                Console.WriteLine($" Can not pass good luck {name} :) ");
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
