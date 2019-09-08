using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example4
{
    class Funcionario : Pessoa
    {
        public int Salario { get; set; }

        public string Matricula { get; set; }

        public override string ToString()
        {
            return "Funcionário {\n\tNome: " + base.ToString() + "\n\tMatricula: " + this.Matricula + "\n\tSalário: " + this.Salario + "\n}";
        }
    }
}
