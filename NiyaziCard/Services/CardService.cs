using BakuCard.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuCard.Services
{
    public class CardService : Card
    {
        public List<Card> Cards { get; set; }
        public CardService()
        {
            Cards = new();
        }
        public void AddCard(int money)
        {
            if (money != 3)
                throw new ArgumentOutOfRangeException("The inserted money should account for 3 AZN!");
            Card card = new();
            card.Balance = 0;
            Cards.Add(card);
        }
        public void AddBalance(int id, double money)
        {
            if (id < 100000000)
                throw new KeyNotFoundException("There is no such card with the given ID");
            if (money <= 0)
                throw new ArgumentOutOfRangeException("Money can not be less than 0");
;            var card = Cards.Find(s => s.ID == id);
            if (card == null)
                throw new KeyNotFoundException("There is no such card");
            card.Balance += money;
        }
        public void PayForOneRide(int id)
        {
            if (id < 100000000)
                throw new KeyNotFoundException("There is no such card with the given ID");
            var card = Cards.Find(s => s.ID == id);
            if (card == null)
                throw new KeyNotFoundException("There is no such card");
            if (card.Balance < 0.3)
                throw new ArgumentOutOfRangeException($"There is not enough balance on your card. Current balance : {card.Balance}");
            card.Balance -= 0.3;
        }
        public List<Card> AllCards()
        {
            if (Cards.Count <=0)
                throw new ArgumentNullException("There are no cards in the data base!");
            return Cards;            
        }
    }
}
