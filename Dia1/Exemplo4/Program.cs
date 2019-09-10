using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            aluno1.Nome      = "José";
            aluno1.Endereco  = "Rua X";
            aluno1.Telefone  = "999999999";
            aluno1.Matricula = "201909090";
            aluno1.Curso     = "Ciência da Comptuação";

            Aluno aluno2 = new Aluno();
            aluno2.Nome      = "Maria";
            aluno2.Endereco  = "Rua Y";
            aluno2.Telefone  = "988888888";
            aluno2.Matricula = "201908080";
            aluno2.Curso     = "Ciências da Computação";

            Funcionario funcionario1 = new Funcionario();
            funcionario1.Nome      = "João";
            funcionario1.Endereco  = "Rua Z";
            funcionario1.Telefone  = "977777777";
            funcionario1.Matricula = "201907070";
            funcionario1.Salario   = 101010;

            Funcionario funcionario2 = new Funcionario();
            funcionario2.Nome      = "Ana";
            funcionario2.Endereco  = "Rua W";
            funcionario2.Telefone  = "900000000";
            funcionario2.Matricula = "201906060";
            funcionario2.Salario  = 202020;

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(aluno1);
            lista.Add(aluno2);
            lista.Add(funcionario1);
            lista.Add(funcionario2);

            foreach(Pessoa p in lista)
            {
                Console.WriteLine(p.ToString() + "\n");
            }
        }
    }
}
