using System;
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
                new Pessoa{ Nome= "Pedro", Idade = 9},
                new Pessoa{ Nome= "Nenê", Idade = 1},
                new Pessoa{ Nome= "Márcia", Idade = 45},
                new Pessoa{ Nome= "Tânia", Idade = 80}
            };

            //Action<Pessoa> nomeMaiusculoAction = (pessoa) => pessoa.Nome = pessoa.Nome.ToUpper();
            //Func<Pessoa, string> nomeMinusculoFunction = (pessoa) => pessoa.Nome.ToLower();


            //TODO: Informar apenas Nomes em letras maiúsculas
            var nomesEmMaiuscula = listaDePessoas
                .Select(x => x.Nome?.ToUpper())
                .ToList();


            ImprimirTextos("nomes em letras maiúsculas", nomesEmMaiuscula);

            ////TODO: Ordenar por Nome
            var ordenadoPorNome = listaDePessoas
                .OrderBy(p => p.Nome)
                .ToList();


            ImprimirLista("ordenado por nome", ordenadoPorNome);

            ////TODO: Ordenar por Nome e Idade
            var ordenadoNomeIdade = listaDePessoas
                .OrderByDescending(p => p.Nome)
                .ThenBy(p => p.Idade)
                .ToList();

            ImprimirLista("ordenado por nome e idade", ordenadoNomeIdade);

            ////TODO: Menores de idade

            var menoresDeIdade = listaDePessoas
                .Where(p => p.Idade < 18)
                .ToList();

            ImprimirLista("menores de idade", menoresDeIdade);

            ////TODO: Último da lista

            ImprimirPessoa("último da lista", listaDePessoas.Last());

            ////TODO: Agrupados por idade
            ///
            var agrupado = listaDePessoas
                .GroupBy(p => p.Idade, p => p)
                .Select(g => $"{g.Key}: {string.Join(", ", g.ToList().Select(x => x.Nome))}")
                .ToList();

            ImprimirTextos("agrupados por idade", agrupado);
        }

        static void ImprimirLista(string nomeDaLista, List<Pessoa> pessoas)
        {
            Console.WriteLine(nomeDaLista.ToUpper());
            Console.WriteLine("================================================");
            pessoas.ForEach(pessoa => Console.WriteLine(pessoa.ToString()));
            Console.WriteLine("");
        }

        static void ImprimirTextos(string nomeDaLista, List<string> textos)
        {
            Console.WriteLine(nomeDaLista.ToUpper());
            Console.WriteLine("================================================");
            textos.ForEach(pessoa => Console.WriteLine(pessoa.ToString()));
            Console.WriteLine("");
        }

        static void ImprimirPessoa(string nomeDoContexto, Pessoa pessoa)
        {
            Console.WriteLine($"{nomeDoContexto.ToUpper()}: {pessoa.ToString()}");
        }

    }
}