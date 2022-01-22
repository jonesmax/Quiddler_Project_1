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
        public Deck() { 
            
        }

        string IDeck.About => throw new NotImplementedException();

        int IDeck.CardCount => throw new NotImplementedException();

        int IDeck.CardsPerPlayer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string IDeck.TopDiscard => throw new NotImplementedException();

        IPlayer IDeck.NewPlayer()
        {
            throw new NotImplementedException();
        }

        string IDeck.ToString()
        {
            throw new NotImplementedException();
        }
    }
}
