using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example4
{
    class Aluno : Pessoa
    {
        public string Curso { get; set; }

        public string Matricula { get; set; }

        public override string ToString()
        {
            return "Aluno {\n\tNome: " + base.ToString() + "\n\tMatricula: " + this.Matricula + "\n\tCurso: " + this.Curso + "\n}";
        }
    }
}
