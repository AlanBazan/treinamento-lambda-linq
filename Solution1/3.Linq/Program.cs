using System;
using System.Data;
using System.Linq;

namespace _3.Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaDePessoas = new List<Pessoa> {
                new Pessoa{ Nome= "Rafael", Idade = 31},
                new Pessoa{ Nome= "Tamires", Idade = 31},
                new Pessoa{ Nome= "Pedro", Idade = 15},
                new Pessoa{ Nome= "Nenê", Idade = 1},
                new Pessoa{ Nome= "Márcia", Idade = 45},
                new Pessoa{ Nome= "Tânia", Idade = 80}
            };

            //Action<Pessoa> nomeMaiusculoAction = (pessoa) => pessoa.Nome = pessoa.Nome.ToUpper();
            //Func<Pessoa, string> nomeMinusculoFunction = (pessoa) => pessoa.Nome.ToLower();


            //TODO: Informar apenas Nomes em letras maiúsculas

            ImprimirTextos("nomes em letras maiúsculas", null);

            //TODO: Ordenar por Nome

            ImprimirLista("ordenado por nome", null);

            //TODO: Ordenar por Nome e Idade

            ImprimirLista("ordenado por nome e idade", null);

            //TODO: Menores de idade

            ImprimirLista("menores de idade", null);

            //TODO: Último da lista

            ImprimirPessoa("último da lista", null);

            //TODO: Agrupados por idade

            ImprimirTextos("agrupados por idade", null);
        }

        static void ImprimirLista(string nomeDaLista, List<Pessoa> pessoas)
        {
            Console.WriteLine(nomeDaLista.ToUpper());
            Console.WriteLine("================================================");
            pessoas.ForEach(pessoa => Console.WriteLine(pessoa.ToString()));
        }

        static void ImprimirTextos(string nomeDaLista, List<string> textos)
        {
            Console.WriteLine(nomeDaLista.ToUpper());
            Console.WriteLine("================================================");
            textos.ForEach(pessoa => Console.WriteLine(pessoa.ToString()));
        }

        static void ImprimirPessoa(string nomeDoContexto, Pessoa pessoa)
        {
            Console.WriteLine($"{nomeDoContexto.ToUpper()}: {pessoa.ToString()}");
        }

    }
}