using System;

namespace _1.Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var func = Join;
            // (textoA, textoB) => $"{textoA} {textoB}"

            Console.WriteLine(func("Hello", "World"));

        }

        static string Join(string textoA, string textoB)
        {
            return $"{textoA} {textoB}";
        }
    }
}