using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e24106254_practice_1_2
{
    class Program
    {
        static bool StringIsInt(string str)
        {
            try
            {
                int result = Convert.ToInt32(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static bool Include(string[] arr, string value)
        {
            return Array.IndexOf(arr, value) != -1;
        }

        // NOTE shift things back
        static void Delete(ref string[] arr, int deleteIndex, int count)
        {
            // delete and shift element in type name array
            arr[deleteIndex] = null;
            for (int i = deleteIndex; i < count; i++)
            {
                // out of index
                if (i + 1 >= 5)
                {
                    arr[i] = null;
                }
                else
                {
                    arr[i] = arr[i + 1];
                }
            }

        }

        // NOTE shift things back
        static void Delete(ref double[] arr,int deleteIndex, int count)
        {
            arr[deleteIndex] = 0;
            for (int i = deleteIndex; i < count; i++)
            {
                // out of index
                if (i + 1 >= 5)
                {
                    arr[i] = 0;
                }
                else
                {
                    arr[i] = arr[i + 1];
                }
            }

        }

        static void Main(string[] args)
        {
            int income = 0;
            int totalExpense = 0;

            double[] expenseArr = new double[5];
            string[] expenseTypeNameArr = new string[5];
            int expenseTypeCount = 0;

            string moneyInput = "";
            string expenseTypeInput = "";
            string expenseTypeNameInput = "";
            string deleteExepenseTypeNameInput = "";

            int money = 0;
            bool end = false;

            while (!end)
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式");
                Console.Write("輸入數字選擇功能: ");

                string featureInput = Console.ReadLine();
                if (!StringIsInt(featureInput))
                {
                    Console.WriteLine("請輸入數字\n");
                    continue;
                }

                switch (featureInput)
                {
                    case "1":
                        Console.Write("輸入金額: ");
                        moneyInput = Console.ReadLine();

                        // SECTION input validation
                        if (!StringIsInt(moneyInput))
                        {
                            Console.WriteLine("請輸入數字\n");
                            break;
                        }

                        money = Convert.ToInt32(moneyInput);
                        if (money<0)
                        {
                            Console.WriteLine("收入不可為負數\n");
                            break;
                        }

                        // SECTION calculation
                        income += Convert.ToInt32(moneyInput);
                        Console.WriteLine("");
                        break;
                    case "2":
                        if (expenseTypeCount == 0)
                        {
                            Console.WriteLine("請新增支出項目\n");
                            break;
                        }

                        for (int i = 0; i < 5; i++)
                        {
                            if (expenseTypeNameArr[i] != null)
                            {
                                Console.WriteLine("({0}){1}", i + 1, expenseTypeNameArr[i]);
                            }
                        }

                        // validate expense type
                        Console.Write("輸入數字選擇支出項目: ");
                        expenseTypeInput = Console.ReadLine();
                        if (!StringIsInt(expenseTypeInput))
                        {
                            Console.WriteLine("請輸入數字\n");
                            break;
                        }

                        int expenseType = Convert.ToInt32(expenseTypeInput);
                        if (expenseType <= 0 || expenseType > expenseTypeCount)
                        {
                            Console.WriteLine("此數字不在範圍中\n");
                            break;
                        }

                        Console.Write("輸入支出金額: ");
                        moneyInput = Console.ReadLine();

                        // SECTION input validation
                        if (!StringIsInt(moneyInput))
                        {
                            Console.WriteLine("請輸入數字\n");
                            break;
                        }

                        money = Convert.ToInt32(moneyInput);
                        if (money<0)
                        {
                            Console.WriteLine("支出不可為負數\n");
                            break;
                        }

                        if (money+totalExpense > income)
                        {
                            Console.WriteLine("存款不足\n");
                            break;
                        }

                        expenseArr[expenseType - 1] += money;
                        totalExpense += money;

                        Console.WriteLine("");
                        break;
                    case "3":
                        // out of space
                        if (expenseTypeCount >= 5)
                        {
                            Console.WriteLine("已無法再新增支出項目\n");
                            break;
                        }

                        Console.Write("輸入項目名稱: ");
                        expenseTypeNameInput = Console.ReadLine();

                        // already in array
                        if (Include(expenseTypeNameArr, expenseTypeNameInput))
                        {
                            Console.WriteLine("支出項目已存在\n");
                            break;
                        }

                        Console.WriteLine("");

                        // initialize
                        expenseTypeNameArr[expenseTypeCount] = expenseTypeNameInput;
                        expenseArr[expenseTypeCount] = 0;
                        expenseTypeCount++;
                        break;
                    case "4":
                        // nothing to delete
                        if (expenseTypeCount == 0)
                        {
                            Console.WriteLine("已無法再刪除支出項目\n");
                            break;
                        }

                        Console.Write("輸入項目名稱: ");
                        deleteExepenseTypeNameInput = Console.ReadLine();
                        if (!Include(expenseTypeNameArr, deleteExepenseTypeNameInput))
                        {
                            Console.WriteLine("此項目不存在\n");
                            break;
                        }

                        int deleteIndex = Array.IndexOf(expenseTypeNameArr, deleteExepenseTypeNameInput);
                        totalExpense -= Convert.ToInt32(expenseArr[deleteIndex]);
                        Delete(ref expenseTypeNameArr, deleteIndex, expenseTypeCount);
                        Delete(ref expenseArr, deleteIndex, expenseTypeCount);

                        expenseTypeCount--;
                        Console.WriteLine("");
                        break;
                    case "5":
                        for (int i = 0; i < 5; i++)
                        {
                            if (expenseTypeNameArr[i] == null)
                            {
                                continue;
                            }

                            double percentage = 0;
                            if (totalExpense != 0)
                            {
                                percentage = expenseArr[i] / totalExpense * 100;
                            }
                            Console.WriteLine("({0}){1}: {2}%",i+1, expenseTypeNameArr[i], percentage);
                        }
                        Console.WriteLine("");
                        break;
                    case "6":
                        Console.WriteLine("目前總支出: {0}", totalExpense);
                        Console.Write("輸入要查詢的項目: ");
                        expenseTypeInput = Console.ReadLine();
                        
                        if (!Include(expenseTypeNameArr, expenseTypeInput))
                        {
                            Console.WriteLine("此項目不存在\n");
                            break;
                        }

                        int checkIndex = Array.IndexOf(expenseTypeNameArr, expenseTypeInput);
                        Console.WriteLine("{0}: {1}\n",expenseTypeInput, expenseArr[checkIndex]);
                        break;
                    case "7":
                        Console.WriteLine("剩餘金額為: {0}\n", income - totalExpense);
                        break;
                    case "8":
                        end = true;
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("不存在的功能(請輸入1~5)\n");
                        break;
                }
            }
        }
    }
}
