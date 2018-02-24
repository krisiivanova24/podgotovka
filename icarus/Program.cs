using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
                     
            int start = num;
            string danni = Console.ReadLine();
            int damaged = 1;

            while (danni != "Supernova")
            {                 
                List<string> danniArr= danni.Split(' ').ToList();
                string command = danniArr[0];
                int step = int.Parse(danniArr[1]);
                if (command=="left")
                {
                    for (int i = 0; i < step; i++)
                    {
                        start--;
                        if (start<0)
                        {
                            start = numbers.Length - 1;
                            damaged++;
                        }
                        numbers[start] = numbers[start] - damaged;
                    }
                }
                else
                {
                    for (int i = 0; i < step; i++)
                    {
                        start++;
                        if (start > (numbers.Length-1))
                        {
                            start = 0;
                            damaged++;
                        }
                        numbers[start] = numbers[start] - damaged;

                    }
                }
                //Console.WriteLine(string.Join(" >>> ", numbers));
                danni = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
