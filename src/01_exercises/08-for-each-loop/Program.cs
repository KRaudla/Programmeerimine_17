using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_for_each_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] excuses = new[] { "esimene", "teine", "kolmas", "neljas" };

            int eCnt = 0;
            foreach(string element in excuses)
            {
                Console.WriteLine($"{eCnt+1}.{element}"); 
                eCnt++;
            }
            Console.ReadLine();
        }
    }
}
