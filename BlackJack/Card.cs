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
        public int rank { get; set; }

        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
            switch(cardFace)
            {
                case "Two":
                    rank = 2;
                    break;
                case "Three":
                    rank = 3;
                    break;
                case "Four":
                    rank = 4;
                    break;
                case "Five":
                    rank = 5;
                    break;
                case "Six":
                    rank = 6;
                    break;
                case "Seven":
                    rank = 7;
                    break;
                case "Eight":
                    rank = 8;
                    break;
                case "Nine":
                    rank = 9;
                    break;
                case "Ten":
                    rank = 10;
                    break;
                case "Jack":
                    rank = 10;
                    break;
                case "Queen":
                    rank = 10;
                    break;
                case "King":
                    rank = 10;
                    break;
                case "Ace":   //need to make condition where rank can be 11 for user
                    rank = 1;
                    break;
                default:
                    break;

            }
        }

      
    }
}
