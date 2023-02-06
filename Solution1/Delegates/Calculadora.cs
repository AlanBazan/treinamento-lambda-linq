using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Delegates
{
    public class Calculadora
    {
        private double numeroA;
        private double numeroB;

        //numeroA + numeroB = reuslt

        private OperacaoMatematica? operacao;

        public void SetValor(double valor)
        {
            if (operacao == null)
                numeroA = valor;
            else
                numeroB = valor;
        }

        public void Somar()
        {
            operacao = (a, b) => a + b;
        }

        public void Subtrair()
        {
            operacao = (a, b) => a - b;
        }

        public double EfetuarOperacao()
        {
            if (operacao == null)
                return numeroA;

            var resultado = operacao(numeroA, numeroB);

            numeroA = resultado;

            operacao = null;
            numeroA = 0;
            numeroB = 0;

            return resultado;

        }

    }
}
