using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace units1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<int> a = new List<int>();
            for(int i = 0; i <= n; i++)
            {
                a.Add(i);
            }
            for(int i = 1; i <= n; i++)
            {
                for(int j = 0, k; (k = i + j) <= n; j++)
                {
                    a[k] = Math.Min(a[k], a[i] + a[j]);
                }
                for (int j = 0, k; (k = i * j) <= n; j++)
                {
                    a[k] = Math.Min(a[k], a[i] + a[j]);
                }
            }
            Console.WriteLine(a[n]);
        }
    }
}
