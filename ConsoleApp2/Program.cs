using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores de atribuição

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);


            // Operadores aritméticos

            int b = 10;

            b++;
            Console.WriteLine(b);

            b--;
            Console.WriteLine(b);

            int x = 10;

            int c = ++x;
            int d = x++;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
