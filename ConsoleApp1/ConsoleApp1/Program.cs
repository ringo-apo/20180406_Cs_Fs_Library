using Library1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string astr;
            string bstr;
            int a;
            int b;
            int c;
            int d;

            Console.WriteLine("数字を2つ入力してください");

            astr = Console.ReadLine();
            bstr = Console.ReadLine();

            a = int.Parse(astr);
            b = int.Parse(bstr);

            c = Enzan.Tass(a, b);
            d = Enzan.Hiku(a, b);

            Console.WriteLine("{0}+{1}={2}", a, b, c);
            Console.WriteLine("{0}-{1}={2}", a, b, d);

        }
    }
}
