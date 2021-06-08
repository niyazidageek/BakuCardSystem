using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuCard.Services
{
    public class MenuService
    {
        static CardService card = new();
        public static void AddCardMenu()
        {
            int money = 0;
            Console.WriteLine("Pay for the card, please | Charge: 3 AZN");
            string moneystr = Console.ReadLine();
            while (!int.TryParse(moneystr, out money))
            {
                Console.WriteLine("Insert the number, please");
                moneystr = Console.ReadLine();
            }
            try
            {
                card.AddCard(money);
                var table = new ConsoleTable("Card ID", "Date of creation");
                foreach (var item in card.Cards)
                {
                    table.AddRow(item.ID, item.Date);
                }
                table.Write();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message); 
            }          
        }
        public static void AddBalanceMenu()
        {
            int id = 0;
            double money = 0;
            Console.WriteLine("Insert the number of the card, please");
            string idstr = Console.ReadLine();
            while (!int.TryParse(idstr, out id))
            {
                Console.WriteLine("Insert a number, please");
                idstr = Console.ReadLine();
            }
            Console.WriteLine("Insert the money, please");
            string moneystr = Console.ReadLine();
            while (!double.TryParse(moneystr, out money))
            {
                Console.WriteLine("Insert a number, please");
                moneystr = Console.ReadLine();
            }
            try
            {
                card.AddBalance(id, money);
                var table = new ConsoleTable("Card ID", "Current balance");
                foreach (var item in card.Cards)
                {
                    table.AddRow(item.ID, item.Balance);
                }
                table.Write();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message);
            }                      
        }
        public static void PayForOneRideMenu()
        {
            int id = 0;
            Console.WriteLine("Insert the number of the card, please");
            string idstr = Console.ReadLine();
            while (!int.TryParse(idstr, out id))
            {
                Console.WriteLine("Enter a number, please");
                idstr = Console.ReadLine();
            }
            try
            {
                card.PayForOneRide(id);
                var table = new ConsoleTable("Card ID", "Current balance");
                foreach (var item in card.Cards)
                {
                    table.AddRow(item.ID, item.Balance);
                }
                table.Write();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message);
            }            
        }
        public static void AllCardsMenu()
        {
            var table = new ConsoleTable("Card ID", "Current balance", "Date of creation");
            try
            {
                foreach (var item in card.AllCards())
                {
                    table.AddRow(item.ID, item.Balance, item.Date);
                }
                table.Write();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message);
            }            
        }
    }
}
