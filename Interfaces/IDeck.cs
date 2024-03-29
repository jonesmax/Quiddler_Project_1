﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Quiddler.Interfaces
{
    public interface IDeck
    {
        public string About { get; }
        public int CardCount { get; }
        //Throws ArguementOutOfRangeException if an attempt to assign a value outside the range 3-10
        public int CardsPerPlayer { get; set; }
        public string TopDiscard { get; }

        public IPlayer NewPlayer();
        public string ToString();
        
    }
}
