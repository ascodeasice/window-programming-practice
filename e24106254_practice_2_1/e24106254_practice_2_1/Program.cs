using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e24106254_practice_2_1
{
    class Program
    {
        static bool ClassExist(string className, string[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == className)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool Occupied(int startTime, int endTime, int day, string[,] table)
        {
            for (int i = startTime; i <= endTime; i++)
            {
                if (table[i, day] != null)
                {
                    return true;
                }
            }
            return false;
        }

        static int GetCredit(string[,] table)
        {
            int totalCredit = 0;
            for(int i = 0; i < table.GetLength(0); i++)
            {
                for(int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] != null)
                    {
                        totalCredit++;
                    }
                }
            }

            return totalCredit;
        }

        static void printTable(string[,] table)
        {
            // print days
            string[] days = { "", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            int[] indexOrder = { 6, 0, 1, 2, 3, 4, 5 };

            foreach (string day in days)
            {
                Console.Write(String.Format("{0,-6}", day));
            }
            Console.WriteLine("");

            for (int i = 0; i < table.GetLength(0); i++)
            {
                Console.Write(String.Format("{0,-6}",i + 1));
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,-6}", table[i,indexOrder[j]]));
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            string functionInput = "";
            string[,] table = new string[8, 7];

            // for case "1"(adding)
            string newClassStr = "";
            string newClassName = "";
            int newClassDay = -1;
            int newClassStartTime = -1;
            int newClassEndTime = -1;

            // for case "2"(deleting)
            string deleteClassName = "";

            bool end = false;

            while (!end)
            {
                Console.WriteLine("(1)新增課程 (2)刪除課程 (3)列印課表 (4)計算學分 (5)離開程式");
                Console.Write("請輸入數字選擇功能: ");
                functionInput = Console.ReadLine();

                switch (functionInput)
                {
                    case "1":
                        Console.WriteLine("請輸入要加入的課程，輸入的格式為:<課程代號 星期 開始節 結束節>");
                        newClassStr = Console.ReadLine();
                        newClassName = newClassStr.Substring(0, 5);
                        // change to 0-indexed
                        newClassDay = Convert.ToInt32(newClassStr.Substring(6, 1))-1;
                        newClassStartTime = Convert.ToInt32(newClassStr.Substring(8, 1))-1;
                        newClassEndTime = Convert.ToInt32(newClassStr.Substring(10, 1))-1;

                        if (ClassExist(newClassName, table))
                        {
                            Console.WriteLine("課程重複!\n");
                            break;
                        }

                        if (Occupied(newClassStartTime , newClassEndTime , newClassDay , table))
                        {
                            Console.WriteLine("課程衝堂!\n");
                            break;
                        }

                        for (int i = newClassStartTime ; i <= newClassEndTime ; i++)
                        {
                            table[i, newClassDay ] = newClassName;
                        }
                        Console.WriteLine("成功加入課程!\n");
                        break;
                    case "2":
                        Console.Write("請輸入要刪除的課程代號: ");
                        deleteClassName = Console.ReadLine();
                        if (!ClassExist(deleteClassName, table))
                        {
                            Console.WriteLine($"課程 {deleteClassName} 不在課表中\n");
                            break;
                        }

                        // delete class
                        for (int i = 0; i < table.GetLength(0); i++)
                        {
                            for (int j = 0; j < table.GetLength(1); j++)
                            {
                                if (table[i, j] == deleteClassName)
                                {
                                    table[i, j] = null;
                                }
                            }
                        }

                        Console.WriteLine($"成功刪除課程: {deleteClassName}\n");
                        break;
                    case "3":
                        printTable(table);
                        break;
                    case "4":
                        Console.WriteLine($"{GetCredit(table)}\n");
                        break;
                    case "5":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("不存在的功能\n");
                        break;

                }
            }
        }
    }
}
