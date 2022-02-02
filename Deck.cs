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

        string IDeck.About => "Quiddler (TM) Library, Copyright 2022 M. Jones and T. Magwood";

        int IDeck.CardCount => 0;

        int IDeck.CardsPerPlayer 
        {
            get { return 4; }
            set { _cardsPerPlayer = 4; }
        }

        string IDeck.TopDiscard => "top discard test";

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
