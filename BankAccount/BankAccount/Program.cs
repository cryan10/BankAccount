using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
                //sign in screen
                Console.WriteLine("Welcome to Monopoly Bank! Please sign into your account by typing in your username: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Please type in your password: ");
                string password = Console.ReadLine();

            //creation of currency variables
            double checking = 5000;
            double savings = 10000;
            double reserve = 300;
            double withdraw = 0;
            double deposit = 0;

            //Welcome message
            Console.WriteLine("Welcome to your account, {0}! Please choose from the options below by typing in the corresponding number: ", userName);

            //Creation of switch to turn program on and off
            bool program = true;

            //Creation of objects
            Account account = new Account(userName, password, savings, checking, reserve, withdraw, deposit);
            SavingsAccount savingsAccount = new SavingsAccount();
            CheckingAccount checkingAccount = new CheckingAccount();
            ReserveAccount reserveAccount = new ReserveAccount();

            //Begin running actual program
            while (program == true)
            {
                //application menu
                Console.WriteLine("1.) User information");
                Console.WriteLine("2.) Check balance");
                Console.WriteLine("3.) Withdraw funds");
                Console.WriteLine("4.) Deposit funds");
                Console.WriteLine("5.) Exit");

                int userInput = int.Parse(Console.ReadLine());

                //User's choice from menu prompts corresponding methods
                switch (userInput)
                {
                    case 1:
                        //User info option
                        Console.WriteLine("What would you like to do? Enter a number to choose:");
                        Console.WriteLine("1.) View User Info:");
                        Console.WriteLine("2.) Edit Password:");
                        int infoChoice = int.Parse(Console.ReadLine());
                        //to view user info
                        if (infoChoice == 1)
                        {
                            account.DisplayUserInfo(userName, password, checking, savings, reserve);
                        }
                        //to change user password
                        if (infoChoice == 2)
                        {
                            account.EditPassword(password);
                        }
                        Console.WriteLine("What else would you like to do? Please choose from the following options: ");
                        break;
                    case 2:
                        //ask user if viewing checking savings, checking or reserve balance
                        Console.WriteLine("What balance would you like to check? Please choose from the numbers below:");
                        Console.WriteLine("1.) Checking:");
                        Console.WriteLine("2.) Savings:");
                        Console.WriteLine("3.) Reserve:");
                        int balanceChoice = int.Parse(Console.ReadLine());
                        if (balanceChoice == 1)
                        {   //view checking account balance
                            checkingAccount.ShowBalance(checking);
                        }
                        if (balanceChoice == 2)
                        {
                            //view savings account balance
                            savingsAccount.AddInterest(savings);
                            savingsAccount.ShowBalance(savings);
                        }
                        if (balanceChoice == 3)
                        {
                            //view reserve account balance
                            reserveAccount.ShowBalance(reserve);
                        }
                        Console.WriteLine("What else would you like to do? Please choose from the following options: ");
                        break;
                    case 3:
                        //Ask user where they would like to withdraw funds from 
                        Console.WriteLine("Where would you like to withdraw from? Please choose from the numbers below:");
                        Console.WriteLine("1.) Checking:");
                        Console.WriteLine("2.) Savings:");
                        Console.WriteLine("3.) Reserve:");
                        int withdrawChoice = int.Parse(Console.ReadLine());
                        if (withdrawChoice == 1)
                        {   //checking account withdraw
                            checking = checkingAccount.MakeWithdraw(withdraw, checking);
                        }
                        if (withdrawChoice == 2)
                        {
                            //savings account withdraw
                            savings = savingsAccount.AddInterest(savings);
                            savings = savingsAccount.MakeWithdraw(withdraw, savings);
                        }
                        if (withdrawChoice == 3)
                        {
                            //reserve account withdraw
                            reserve = reserveAccount.MakeWithdraw(withdraw, reserve);
                        }
                        Console.WriteLine("What else would you like to do? Please choose from the following options: ");
                        break;
                    case 4:
                        //ask user which account to deposit funds to
                        Console.WriteLine("Which account would you like to deposit into? Please choose from the numbers below:");
                        Console.WriteLine("1.) Checking:");
                        Console.WriteLine("2.) Savings:");
                        Console.WriteLine("3.) Reserve:");
                        int depositChoice = int.Parse(Console.ReadLine());
                        if (depositChoice == 1)
                        {   //checking account withdraw
                            checking = checkingAccount.MakeDeposit(deposit, checking);
                        }
                        if (depositChoice == 2)
                        {
                            //savings account witdraw
                            savings = savingsAccount.AddInterest(savings);
                            savings = savingsAccount.MakeDeposit(deposit, savings);
                        }
                        if (depositChoice == 3)
                        {
                            //reserve account withdraw
                            reserve = reserveAccount.MakeDeposit(deposit, reserve);
                        }
                        Console.WriteLine("What else would you like to do? Please choose from the following options: ");
                        break;
                    case 5:
                        //Exit program
                        Console.WriteLine("Thank you! Have a great day!");
                        program = false;
                        break;
                    default:
                        //Catches any user input that is NOT 1-5
                        Console.WriteLine("Oops! I didn't understand you. Please try again. Please choose from the list below: ");
                        break;
                }
            }
        }
    }
}
