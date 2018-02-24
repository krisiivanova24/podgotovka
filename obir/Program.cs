using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obir
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<string> inf = new List<string>();
            string str = Console.ReadLine();
            int sum1 = 0;
            int sum2 = 0;
            while (str != "Jail Time")
            {
                inf = str.Split(' ').ToList();
                //Console.WriteLine(inf[0]);
                int razhod = int.Parse(inf[1]);
                sum1 += razhod;
                int priceBiju = prices[0] * CountSymboll(inf[0], "%");
                int priceGold = prices[1] * CountSymboll(inf[0], "$");
                sum2 += priceBiju + priceGold;
                //Console.WriteLine(sum1);
                //Console.WriteLine(sum2);
                str = Console.ReadLine();

            }
            if (sum1 < sum2)
            {
                int sum = sum2 - sum1;
                Console.WriteLine($"Heists will continue. Total earnings: {sum}.");
            }
            else
            {
                int sum = sum1 - sum2;
                Console.WriteLine($"Have to find another job. Lost: {sum}.");
            }
        }
        static int CountSymboll(string s, string symbol)
        {
            int broi = 0;
            while (s.Contains(symbol))
            {
                broi++;
                s = s.Substring(s.IndexOf(symbol) + 1);
            }
            return broi;
        }
        //static int CountDollar(string s)
        //{
        //    int broi = 0;
        //    while (s.Contains("$"))
        //    {
        //        broi++;
        //        s = s.Substring(s.IndexOf("$") + 1);
        //    }
        //    return broi;
        //}


    }
}





