using BakuCard.Services;
using System;

namespace BakuCard
{
    class Program
    {     
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("=============Baku card=============");
                Console.WriteLine("1. Buy a card");
                Console.WriteLine("2. Add balance");
                Console.WriteLine("3. Pay for one ride");
                Console.WriteLine("4. Display all cards");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Select an option, please");
                string optionstr = Console.ReadLine();
                while (!int.TryParse(optionstr, out option))
                {
                    Console.WriteLine("Enter a number, please");
                    optionstr = Console.ReadLine();
                }
                switch (option)
                {
                    case 1:
                        MenuService.AddCardMenu();
                        break;
                    case 2:
                        MenuService.AddBalanceMenu();
                        break;
                    case 3:
                        MenuService.PayForOneRideMenu();
                        break;
                    case 4:
                        MenuService.AllCardsMenu();
                        break;
                    case 0:
                        Console.WriteLine("Shutting down...");
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }
            } while (option != 0);           
        }
    }
}
