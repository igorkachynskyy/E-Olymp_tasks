using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenviks_function
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(n, 2) + " " + Convert.ToString(n-1, 2) + " " + Convert.ToString(n&(n-1), 2));
            Console.WriteLine(n - (n & (n - 1)));
        }
    }
}
