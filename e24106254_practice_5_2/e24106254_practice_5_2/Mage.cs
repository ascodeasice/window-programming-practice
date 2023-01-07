using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e24106254_practice_5_2
{
    class Mage:Piece
    {
        public Mage(string team)
        {
            character = "法師";
            this.team = team;
            hp = 70;
            mp = 25;
            atk = 20;
            atkRange = 2;
            moveRange = 2;
        }

        public override void skill(ref Piece other)
        {
            mp -= 10;
            other.hp -= (2 * atk);
        }
    }
}
