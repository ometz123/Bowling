using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Frame
    {
        Pin pins = new Pin(10);
        Player player;
        Random random;
        Shot shots = new Shot(2);
        public Rank rank { get; set; }
        public Frame(Player p)
        {
            player = p;
        }
        public IRank Play()
        {
            while (shots.Counter-- > 0)
            {
                int fall = random.Next(0, pins.Count);
                pins = new Pin(player.Shoot(pins.Count, fall));
                if (shots.Counter == 1 && pins.Count == 0)
                {
                    rank.Points += new Strike(fall);
                    return new Strike(fall);
                }
                else if (shots.Counter == 0 && pins.Count == 0)
                {
                    rank.Spare.Counter++;
                }
                //else if (shots.Counter == 0 && pins.Count > 0)
                //{
                //    rank.Hole.Counter++;
                //}
            }
        }
    }
}
