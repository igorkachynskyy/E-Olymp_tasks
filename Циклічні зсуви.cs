using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_change
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string s = Convert.ToString(Int32.Parse(n), 2);
            //Console.WriteLine(n +" " + s);
            StringBuilder s1 = new StringBuilder(s);
            for (int i = 1; i < s.Length; i++)
            {
                s1[i - 1] = s[i];
            }
            s1[s1.Length - 1] = s[0];
            StringBuilder s2 = new StringBuilder(s1.ToString());
            //Console.WriteLine(Convert.ToInt32(s1.ToString(), 2) + " " + s1.ToString());
            int max = Math.Max(Convert.ToInt32(s, 2), Convert.ToInt32(s1.ToString(), 2));
            while (s1.ToString() != s)
            {
                for (int i = 1; i < s1.Length; i++)
                {
                    s2[i - 1] = s1[i];
                }
                s2[s2.Length - 1] = s1[0];
                //Console.WriteLine(Convert.ToInt32(s2.ToString(), 2) + " " + s2.ToString());
                max = Math.Max(Math.Max(Convert.ToInt32(s2.ToString(), 2), Convert.ToInt32(s1.ToString(), 2)), max);
                s1 = new StringBuilder(s2.ToString());
            }
            Console.WriteLine(max);
        }
    }
}
