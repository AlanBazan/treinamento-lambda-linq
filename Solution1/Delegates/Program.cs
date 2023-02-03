using System;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            double resultado;

            calculadora.SetValor(100);
            calculadora.Somar();
            calculadora.SetValor(50);
            resultado = calculadora.EfetuarOperacao();

            Console.WriteLine($"100 + 50 = {resultado}");

            calculadora.SetValor(50);
            calculadora.Subtrair();
            calculadora.SetValor(15);
            resultado = calculadora.EfetuarOperacao();

            Console.WriteLine($"50 - 15 = {resultado}");

        }

    }
}