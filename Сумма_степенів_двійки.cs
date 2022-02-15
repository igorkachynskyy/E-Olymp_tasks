using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_pows_of_two
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            //Console.WriteLine(Int32.Parse(s[0]) - 1 + " " + (2<<(Int32.Parse(s[0]) - 1)));
            //Console.WriteLine(Int32.Parse(s[1]) - 1 + " " + (2 << (Int32.Parse(s[1]) - 1)));
            int m = 0;
            int n = 0;
            if (Int32.Parse(s[0]) - 1 > 0)
            {
                m = 2 << (Int32.Parse(s[0]) - 1);
            }
            else
            {
                m = 2 >> (Math.Abs((Int32.Parse(s[0]) - 1)));
            }
            if(Int32.Parse(s[1]) - 1 > 0)
            {
                n = 2 << (Int32.Parse(s[1]) - 1);
            }
            else
            {
                n = 2 >> (Math.Abs(Int32.Parse(s[1]) - 1));
            }
            Console.WriteLine(n + m);
        }
    }
}
