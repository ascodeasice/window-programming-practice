using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e24106254_practice_5_2
{
    class Piece
    {
        public string character;
        public string team;
        public int hp;
        public int mp;
        public int atk;
        public int atkRange;
        public int moveRange;
        // position on board
        public int row=-1;
        public int col=-1;
        public virtual void skill(ref Piece other) { }

        public bool isPlaced()
        {
            return row != -1 && col != -1;
        }

        public string getStateStr()
        {
            return $"HP: {hp}{Environment.NewLine}" +
                $"MP: {mp}{Environment.NewLine}" +
                $"ATK: {atk}{Environment.NewLine}" +
                $"ATK Range: {atkRange}{Environment.NewLine}" +
                $"MOVE Range: {moveRange}{Environment.NewLine}";
        }
        
        public void attack(ref Piece other)
        {
            // invalid case should be handled outside
            other.hp -= atk;
        }

        public bool outOfAttackRange(int row,int col)
        {
            return (row != this.row && col != this.col )
                || Math.Abs(row - this.row) > atkRange || Math.Abs(col - this.col )> atkRange;
        }

        public bool outOfMoveRange(int row,int col)
        {
            return (row != this.row && col != this.col)
                || Math.Abs(row - this.row) > moveRange || Math.Abs(col - this.col) > moveRange;
        }

        public virtual bool outOfSkillRange(int row,int col)
        {
            return outOfAttackRange(row,col);
        }
        
        public bool isDead()
        {
            return hp <= 0;
        }
    }
}
