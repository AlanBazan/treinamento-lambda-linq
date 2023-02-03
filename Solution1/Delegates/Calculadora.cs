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
        private double resultadoAcumulado;
        private double valorOperacao;

        private OperacaoMatematica? operacao;

        public void SetValor(double valor)
        {

        }

        public void Somar()
        {

        }

        public void Subtrair()
        {

        }

        public double EfetuarOperacao()
        {
            throw new NotImplementedException();
        }

    }
}
