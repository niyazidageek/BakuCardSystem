using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuCard.Entities.Common
{
    public class Card
    {
        private static int id = 100000000;
        public double Balance { get; set; }
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Card()
        {
            Date = DateTime.Now;
            ID = id;
            id++;
        }
    }
}
