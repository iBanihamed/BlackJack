using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        public int Money { get; set; }
        public string PlayerName { get; set; }

        public Player(string playerName, int money)
        {
            PlayerName = playerName;
            Money = money;
        }
    }
}
