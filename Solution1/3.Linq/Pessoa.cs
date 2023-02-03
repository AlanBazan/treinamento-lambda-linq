using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Linq
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"{Nome}, {Idade} {(Idade == 1 ? "ano" : "anos")}";
        }
    }
}
