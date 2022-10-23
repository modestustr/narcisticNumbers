using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarsistNumbers
{
    internal class Program
    {
        private static bool isShowDesc = true;

        static void Main(string[] args)
        {
        Start:
            var EndNumber = "0";
            List<int> narsistNumbers = new List<int>();
            double sum = 0;


            if (isShowDesc)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("A Narcissistic Number is a number of length l in which the sum of its digits to the power of l is equal to the original number\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Show narsistic Numbers to:\n");
            Console.Write("------------------------");
            Console.Write("\n");

            EndNumber = Console.ReadLine();
            var isNumeric = int.TryParse(EndNumber, out int outNumber);
            if (!isNumeric)
            {
                Console.WriteLine("Please enter number");
                isShowDesc = false;
                goto Start;
            }
            else
            {
                for (int i = 1; i <= outNumber; i++)
                {
                    sum = 0;
                    var iArray = i.ToString().ToArray();
                    var digitLength = iArray.Length;
                    foreach (var item in iArray)
                    {
                        long numbeer = int.Parse(item.ToString());
                        sum += Math.Pow(numbeer, digitLength);
                    }

                    if (i == sum)
                        narsistNumbers.Add(i);

                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Join(",", narsistNumbers) + "\n");

            isShowDesc = false;
            goto Start;
        }
    }
}

