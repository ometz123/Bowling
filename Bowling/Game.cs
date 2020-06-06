using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Game
    {
        Frame[] frames = new Frame[10];
        Player player = new Player("Omer");
        int tempRank1 = 0;
        int tempRank2 = 0;
        public void start()
        {
            for (int i = 0; i < frames.Length; i++)
            {
                if (frames[i].Play() is IStrike)
                {
                    if (i > 1 && i < 8)
                    {
                        frames[i - 2].Rank.Bonus(-2);
                    }
                }
            }
        }
    }
}
