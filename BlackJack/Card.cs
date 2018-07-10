using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public string face { get; set; }
        public string suit { get; set; }
        
        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

      
    }
}
