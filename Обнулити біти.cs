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
            
            // 🤦‍♂️
           
            Console.WriteLine(Convert.ToInt32(n & ~(1 << k))); 
        }
    }
}
