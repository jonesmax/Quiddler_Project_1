using Project_1_Quiddler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Quiddler
{
    public class Deck : IDeck
    {
        private int _cardsPerPlayer;

        public Deck() { 
            
        }

        string IDeck.About
        {
            get { return "about test"; }
        }

        int IDeck.CardCount
        {
            get { return 0; }
        }

        int IDeck.CardsPerPlayer 
        {
            get { return 4; }
            set { _cardsPerPlayer = 4; }
        }

        string IDeck.TopDiscard
        {
            get { return "top discard test"; }
        }

        IPlayer IDeck.NewPlayer()
        {
            Player p = new Player();
            return p;
        }

        string IDeck.ToString()
        {
            return "to string test";
        }
    }
}
