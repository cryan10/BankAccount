using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class ReserveAccount
    {
        double interest = 0.5;
        string interestDate = "01/01/2001";

        //methods

        public double MakeWithdraw(double withdraw, double reserve)
        {
            Console.WriteLine("How much money would you like to withdraw? Please enter number only: ");
            withdraw = double.Parse(Console.ReadLine());
            reserve = reserve - withdraw;
            Console.WriteLine("You just withdrew ${0}. Your current balance is {1}", withdraw, reserve);
            return reserve;
        }

        public double MakeDeposit(double deposit, double reserve)
        {
            Console.WriteLine("How much money would you like to deposit? Please enter number only: ");
            deposit = double.Parse(Console.ReadLine());
            reserve = reserve + deposit;
            Console.WriteLine("You just deposited ${0}. Your current balance is {1}", deposit, reserve);
            return reserve;
        }

        public double AddInterest(double reserve)
        {
            DateTime dt = Convert.ToDateTime(interestDate);
            DateTime dt2 = DateTime.Now;
            if (dt.Date == dt2.Date)
            {
                reserve = reserve + (reserve * interest);
            }
            return reserve;
        }

        public void ShowBalance(double reserve)
        {
            Console.WriteLine("Your current balance is ${0}", reserve);
        }
    }
}
