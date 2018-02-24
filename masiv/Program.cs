using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masiv
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            
            char[] resultCh = new char[10];
            char[] resultCh2 = new char[10];
            while (input != "stop")
            {
                resultCh = input.ToCharArray();
                
                Array.Reverse(resultCh);
                Console.WriteLine($"input >>>> {input} \nresult >>>> {string.Join("", resultCh)}");

                string result = string.Join("", resultCh);
                Console.WriteLine(result);
                if(string.Equals(input, result))//if (string.Compare(input, result, true)==0)    //if (input == result)
                {
                    Console.WriteLine("truee");
                }
                result = input.Substring(1, 5);
                Console.WriteLine(result);

                resultCh.CopyTo(resultCh2, 3);
                Array.Sort(resultCh);
                Console.WriteLine($"sorted >>>> {string.Join("", resultCh)}");
                Array.Clear(resultCh, 2, 1);
                Console.WriteLine($"cleared >>>> {string.Join("", resultCh)}");

                Console.WriteLine($"copied >>>> {string.Join("", resultCh2)}");


                input = Console.ReadLine();
            }
        }
    }
}
