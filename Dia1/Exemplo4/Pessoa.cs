using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example4
{
    class Pessoa
    {
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public override string ToString()
        {
            return this.Nome + "(" + this.Endereco + ")";
        }
    }
}
