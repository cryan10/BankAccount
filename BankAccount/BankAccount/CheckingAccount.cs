using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        int overdraft = 15;
        string overdraftWarning = "Be careful! You are close to overdrawing your account!";

        //method to withdraw money from checking account
        public double MakeWithdraw(double withdraw, double checking)
        {
            Console.WriteLine("How much money would you like to withdraw? Please enter number only: ");
            withdraw = double.Parse(Console.ReadLine());
            checking = checking - withdraw;
            if (checking > 0)
            {
                Console.WriteLine("You just withdrew ${0}. Your current balance is ${1}", withdraw, checking);

                if (checking <= 100 && checking > 0)
                {
                    Console.WriteLine(overdraftWarning);
                }
            }
            else
            {
                checking = checking - overdraft;
                Console.WriteLine("You have overdrawn your account. You've just been fined $15. Your balance is now ${0}", checking);
            }

            return checking;
        }

        public double MakeDeposit(double deposit, double checking)
        {
            Console.WriteLine("How much money would you like to deposit? Please enter number only: ");
            deposit = double.Parse(Console.ReadLine());
            checking = checking + deposit;
            Console.WriteLine("You just deposited ${0}. Your current balance is ${1}", deposit, checking);
            return checking;
        }

        public void ShowBalance(double checking)
        {
            Console.WriteLine("Your current balance is ${0}", checking);
        }
    }
}

