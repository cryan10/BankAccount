using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        string userName;
        string password;
        double savings=10000;
        double checking=5000;
        double reserve=300;
        double withdraw;
        double deposit;

        public Account(string userName, string password, double savings, double checking, double reserve, double withdraw, double deposit)
        {
            this.userName = userName;
            this.password = password;
            this.savings = savings;
            this.checking = checking;
            this.reserve = reserve;
            this.withdraw = withdraw;
            this.deposit = deposit;
        }

        public Account()
        {
        }

        //collect user info (userName, password) with get/set
        public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public string GetUserPassword()
        {
            return password;
        }

        public void SetUserPassword(string password)
        {
            this.password = password;
        }

        public double GetSavings()
        {
            return savings;
        }

        public void SetSavings(double savings)
        {
            this.savings = savings;
        }

        public double GetChecking()
        {
            return checking;
        }


        public void SetChecking(double checking)
        {
            this.checking = checking;
        }

        public double GetReserve()
        {
            return reserve;
        }


        public void SetReserve(double reserve)
        {
            this.reserve= reserve;
        }

        public double GetWithdraw()
        {
            return withdraw;
        }


        public void SetWithdraw(double withdraw)
        {
            this.withdraw = withdraw;
        }

        public double GetDeposit()
        {
            return deposit;
        }


        public void Setdeposit(double deposit)
        {
            this.deposit = deposit;
        }


        //methods

        public void DisplayUserInfo(string userName, string password, double checking, double savings, double reserve)
        {
            Console.WriteLine("Username: {0}", userName);
            Console.WriteLine("Balance: ");
            Console.WriteLine("     Checking: ${0}", checking);
            Console.WriteLine("     Savings: ${0}", savings);
            Console.WriteLine("     Reserve: ${0}", reserve);
        }
        
        public string EditPassword(string password)
        {
            Console.WriteLine("What is your new password?");
            password = Console.ReadLine();
            Console.WriteLine("Your new password has been set!");
            return password;
        }

    }
}
