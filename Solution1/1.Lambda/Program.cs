using System;

namespace _1.Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var func = Join;

            var result = func("textoA", "TextoB");

            Console.WriteLine(func("Hello", "World"));

        }

        static string Join(string textoA, string textoB)
        {
            textoA += ",";
            return $"{textoA} {textoB}";
        }
    }
}