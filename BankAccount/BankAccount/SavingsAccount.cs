using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccount
{
    class SavingsAccount : Account
    {
        double interest = 0.1;
        string interestDate = "01/01/2001";


        //methods

        public double MakeWithdraw(double withdraw, double savings)
        {
            Console.WriteLine("How much money would you like to withdraw? Please enter number only: ");
            withdraw = double.Parse(Console.ReadLine());
            savings = savings - withdraw;
            Console.WriteLine("You just withdrew ${0}. Your current balance is {1}", withdraw, savings);
            return savings;
        }

        public double MakeDeposit(double deposit, double savings)
        {
            Console.WriteLine("How much money would you like to deposit? Please enter number only: ");
            deposit = double.Parse(Console.ReadLine());
            savings = savings + deposit;
            Console.WriteLine("You just deposited ${0}. Your current balance is {1}", deposit, savings);
            return savings;
        }
        
        public double AddInterest(double savings)
        {
            DateTime dt = Convert.ToDateTime(interestDate);
            DateTime dt2 = DateTime.Now;
            if (dt.Date == dt2.Date) {
                savings = savings + (savings * interest);
            }

                return savings;
        }

        public void ShowBalance(double savings)
        {
            Console.WriteLine("Your current balance is ${0}", savings);
        }


    }
}
