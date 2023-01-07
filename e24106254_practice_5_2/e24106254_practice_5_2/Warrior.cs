using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e24106254_practice_5_2
{
    class Warrior : Piece
    {
        public Warrior(string team)
        {
            character = "戰士";
            this.team = team;
            hp = 100;
            mp = 15;
            atk = 30;
            atkRange = 1;
            moveRange = 2;
        }

        public override void skill(ref Piece other)
        {
            mp -= 10;
            other.hp -= atk;
            hp += (atk / 2);
        }
    }
}
