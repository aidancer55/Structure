using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Str str = new Str();
            str.k = Convert.ToInt32(Console.ReadLine());
            str.b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0 = k * x + b");
            Console.WriteLine("x = (0 - b) / k");
            str.Root();
            Console.ReadKey();
        }
        struct Str
        {
            public double x;
            public double k;
            public double b;
            public void Root()
            {
                x = (0 - b) / k;
                Console.WriteLine(x);
            }
        }
    }
}
