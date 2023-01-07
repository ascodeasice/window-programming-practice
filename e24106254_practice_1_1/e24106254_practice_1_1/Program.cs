using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e24106254_practice_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int income = 0;
            int totalExpense = 0;
            double[] expenseArr = { 0, 0, 0, 0, 0 };
            string[] expenseTypeNameArr = { "食", "衣", "住", "行", "育樂" };
            string moneyInput = "";
            string expenseTypeInput = "";
            bool end = false;

            while (!end)
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)計算比例 (4)剩餘金額 (5)退出程式");
                Console.Write("輸入數字選擇功能: ");

                // 功能
                string featureInput = Console.ReadLine();
                switch (featureInput)
                {
                    case "1":
                        Console.Write("輸入金額: ");
                        moneyInput = Console.ReadLine();
                        income += Convert.ToInt32(moneyInput);
                        Console.WriteLine("");
                        break;
                    case "2":

                        Console.WriteLine("(1)食 (2)衣 (3)住 (4)行 (5)育樂 ");
                        Console.Write("輸入數字選擇支出項目: ");
                        expenseTypeInput = Console.ReadLine();
                        int expenseType = Convert.ToInt32(expenseTypeInput);

                        Console.Write("輸入金額: ");
                        moneyInput = Console.ReadLine();
                        int money = Convert.ToInt32(moneyInput);

                        expenseArr[expenseType - 1] += money;
                        totalExpense += money;

                        Console.WriteLine("");
                        break;
                    case "3":
                        for (int i = 0; i < 5; i++)
                        {
                            double percentage = 0;
                            if (totalExpense != 0)
                            {
                                percentage = expenseArr[i] / totalExpense * 100;
                            }
                            Console.WriteLine("{0}: {1}%", expenseTypeNameArr[i], percentage);
                        }
                        Console.WriteLine("");
                        break;
                    case "4":
                        Console.WriteLine("剩餘金額為: {0}", income - totalExpense);
                        Console.WriteLine("");
                        break;
                    case "5":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("不存在的功能(請輸入1~5)");
                        Console.WriteLine("");
                        break;
                }
            }
            Console.Read();
        }
    }
}
