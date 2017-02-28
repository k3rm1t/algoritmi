using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace algoritmi // puolittais haku
{
    class Program
    {
        static void Main(string[] args)
        {   //Taulukon luonti
            int[] taul = new int[99999999];
            for (int i=0; i < 99999999; i ++)
            {
                taul[i] = i + 1;
            }
            Console.WriteLine("Enter number:");
            string j = Console.ReadLine();
            int j2 = Int32.Parse(j);
            var timer = System.Diagnostics.Stopwatch.StartNew(); //ajan ottaja alkaa
            // haku 
            for (int i = 0;i< 99999999; i++)
            {
                if (taul[i] == j2)
                {
                    Console.WriteLine("Search successful");
                    Console.WriteLine("Element {0} found at location {1}", j2, i + 1);
                }
                //else Console.WriteLine("Did not found");
            }
            var elapsed = timer.ElapsedMilliseconds.ToString(); // aika päättyy
            Console.WriteLine("time:"+ elapsed + " milliseconds");
        }
    }
}
