using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversão implícita: quando não há perda de dados na conversão

            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);
            

            // Conversão explícita: quando há perda de dados na conversão e/ou precisa realizar um casting  para converter

            double a;
            float b;

            a = 5.1;
            b = (float)a;

        }
    }
}
