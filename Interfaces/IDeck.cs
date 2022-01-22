using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Quiddler.Interfaces
{
    public interface IDeck
    {
        string About { get; }
        int CardCount { get; }
        //Throws ArguementOutOfRangeException if an attempt to assign a value outside the range 3-10
        int CardsPerPlayer { get; set; }
        string TopDiscard { get; }

        IPlayer NewPlayer();
        string ToString();
        
    }
}
