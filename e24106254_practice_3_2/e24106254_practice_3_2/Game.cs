using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e24106254_practice_3_2
{
    class Game
    {

        private List<List<int>> stacks = new List<List<int>> { };

        public Game(string[] inputs)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                List<int> stack = new List<int>();
                string[] nums = inputs[i].Split(' ');

                for (int j = nums.Length - 1; j >= 0; j--)
                {
                    if (nums[j] == "")
                    {
                        break;
                    }

                    stack.Add(Convert.ToInt32(nums[j]));
                }

                stacks.Add(stack);
            }
        }

        public string getStackStr(int index)
        {
            if (index < 0 || index >= 4)
            {
                return "";
            }

            List<int> stack = stacks[index];
            string result = "";

            for (int i = 0; i < stack.Count; i++)
            {
                result += Convert.ToString(stack[i]);
                if (i != stack.Count - 1)
                {
                    result += Environment.NewLine;
                }
            }

            return result;
        }

        public bool canTake(int index)
        {
            if (index < 0 || index >= 4)
            {
                return false;
            }

            return stacks[index].Count>0;

        }

        public bool canPlace(int index)
        {
            if (index < 0 || index >= 4)
            {
                return false;
            }

            return stacks[index].Count<4;
        }

        public void move(int from,int to)
        {
            if (from < 0 || from >= 4 || to < 0 || to >= 4)
            {
                return;
            }

            int item = stacks[from][0];
            stacks[from].RemoveAt(0);

            stacks[to].Insert(0,item);
        }

        public bool hasWon()
        {
            // everything in a stack is the same, and stack size is either 0 or 3
            for(int i = 0; i < stacks.Count; i++)
            {
                if (stacks[i].Count == 0)
                {
                    continue;
                }

                if (stacks[i].Count != 3)
                {
                    return false;
                }

                int val = stacks[i][0];

                for(int j = 1; j < stacks[i].Count; j++)
                {
                    if (stacks[i][j] != val)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

}
