using System;
using System.IO;

namespace AtmSimulator
{
    class Program
    {
        protected static bool menu = true;
        private static int AccountBalance = 500;

        static void Main(string[] args)
        {
            while(menu)
            {
                Console.WriteLine("Please Select Your Transaction: ");
                Console.WriteLine(" 1. Withdraw\n 2. Deposit\n 3. Check Balance\n 4. Exit");
                string input = Console.ReadLine();
                SelectTransaction(input);
            }

            Console.WriteLine("Thank you for choosing our Bank");
            Console.ReadLine();
        }
         

        private static void SelectTransaction(string input)
        {
            switch (input)
            {
                case "1":
                    Withdrawl withdrawl = new Withdrawl();
                    AccountBalance = withdrawl.SelectAmount(AccountBalance);
                    Console.WriteLine("Please take your money from the tray");
                    Console.WriteLine("Your new Total Balance is {0}", AccountBalance);
                    break;
                case "2":
                case "3":
                    if (input == "2")
                    {
                        Deposit deposit = new Deposit();
                        AccountBalance = deposit.SelectAmount(AccountBalance);
                        Console.WriteLine("Your new Total Balance is {0}", AccountBalance);
                        break;
                    }
                    Console.WriteLine("Your available balance: {0}", AccountBalance);
                    break;
                case "4":
                    ExitMenu();
                    break;
                default:
                    Console.WriteLine("Incorrect Selection");
                    break;
            }
        }

        private static void ExitMenu()
        {
            menu = false;
        }
    }
}
