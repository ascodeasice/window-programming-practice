using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e24106254_practice_5_2
{
    class Ranger:Piece
    {
        public Ranger(string team)
        {
            character = "遊俠";
            this.team = team;
            hp = 90;
            mp = 10;
            atk = 30;
            atkRange = 3;
            moveRange = 1;
        }

        public override bool outOfSkillRange(int row,int col)
        {
            // can Ranger reach if range+1
            return (row !=this.row && col != this.col)
                || Math.Abs(row - this.row) > (atkRange+1) || Math.Abs(col - this.col) > (atkRange+1);
        }

        public override void skill(ref Piece other)
        {
            mp -= 10;
            atkRange++;
            attack(ref other);
        }
    }
}
