using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_zero_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            int n = Int32.Parse(s[0]);
            int k = Int32.Parse(s[1]);  
            StringBuilder s1 = new StringBuilder(Convert.ToString(n, 2));
            //Console.WriteLine(s1.ToString());
            if (k >= s1.Length)
            {
                s1 = s1.Replace('1', '0');
                Console.WriteLine(Convert.ToInt32(s1.ToString(), 2));
            }
            else
            {
                s1 = s1.Replace('1', '0', s1.Length - k, k);
                //Console.WriteLine(s1.ToString());
                Console.WriteLine(Convert.ToInt32(s1.ToString(), 2));
            }
        }
    }
}
