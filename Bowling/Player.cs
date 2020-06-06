using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Player
    {
        public string Name{ get; set; }
        public Player(string name)
        {
            Name = name;
        }
        public int Shoot(int pins,int fall)
        {
            return pins -= fall;
        }
    }
}
