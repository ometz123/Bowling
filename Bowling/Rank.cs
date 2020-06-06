using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Rank: IRank,IStrike,ISpare,IHole
    {
        public int Points { get; set; }
        public int CalculateRank()
        {
            throw new NotImplementedException();
        }
    }
}
