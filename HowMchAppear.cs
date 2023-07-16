using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMchApear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 9, 5, 1, 5, 9};
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                
                if (numbers[i] == 5) 
                {
                    
                    a++;
                }
                else if (numbers[i] == 9)
                {
                    
                    b++;
                }
                else if (numbers[i] == 1)
                {
                    
                    c++;
                } 
            }

            Console.WriteLine("Number" +" "+ 5 +" "+ "appears"+" "+ a +" "+ "times");
            Console.WriteLine("Number" + " " + 9 + " " + "appears" + " " + b + " " + "times");
            Console.WriteLine("Number" + " " + 1 + " " + "appears" + " " + c + " " + "times");
        }
    }
}
