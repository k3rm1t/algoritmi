using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace algoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taul = new int[10000000];
            for (int i=0; i < 10000000; i ++)
            {
                taul[i] = i + 1;
            }
            Console.WriteLine("Enter number:");
            string j = Console.ReadLine();
            int j2 = Int32.Parse(j);
            var timer = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0;i<10000000; i++)
            {
                if (taul[i] == j2)
                {
                    Console.WriteLine("Search successful");
                    Console.WriteLine("Element {0} found at location {1}", j2,i+1);
                }
            }
            var elapsed = timer.ElapsedMilliseconds.ToString();
            Console.WriteLine(elapsed);
        }
    }
}
