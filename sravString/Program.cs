using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skachyai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sbor = masiv[0];
            int index = 0;
            int step = masiv[index];
            do
            {
                if (index + step < masiv.Length && index + step >= 0)
                {
                    index = index + step;                    
                    step = masiv[index];
                    sbor += masiv[index];
                   // Console.WriteLine(sbor);
                }
                else
                {
                    if ((index + step > masiv.Length || index - step < 0) || (index + step < 0 || index - step > masiv.Length))
                    {
                        break;
                    }
                    step = -step; //step = -1*step;
                }
            } while (true);
            Console.WriteLine(sbor);
            
        }
    }
}
