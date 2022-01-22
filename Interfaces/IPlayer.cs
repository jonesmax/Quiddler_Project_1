using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Quiddler.Interfaces
{
    public interface IPlayer
    {
        int CardCount { get; }
        int TotalPoints { get; }

        string DrawCard();
        bool Discard(string card);
        string PickupTopDiscard();
        int PlayWord(string word);
        int TestWord(string word);
        string ToString();
    }
}
