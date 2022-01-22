using Project_1_Quiddler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Quiddler
{
    public class Player : IPlayer
    {
        int IPlayer.CardCount => throw new NotImplementedException();

        int IPlayer.TotalPoints => throw new NotImplementedException();

        bool IPlayer.Discard(string card)
        {
            throw new NotImplementedException();
        }

        string IPlayer.DrawCard()
        {
            throw new NotImplementedException();
        }

        string IPlayer.PickupTopDiscard()
        {
            throw new NotImplementedException();
        }

        int IPlayer.PlayWord(string word)
        {
            throw new NotImplementedException();
        }

        int IPlayer.TestWord(string word)
        {
            throw new NotImplementedException();
        }

        string IPlayer.ToString()
        {
            throw new NotImplementedException();
        }
    }
}
