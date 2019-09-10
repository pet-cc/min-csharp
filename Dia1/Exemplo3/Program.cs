using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example3
{
    class Program
    {
        static void Outro()
        {
            Carro carro = new Carro();
            carro.Modelo = "Ford Ka";
            carro.Placa  = "BRA2F8A";
            carro.Ano    = 2019;
            carro.Valor  = 45590;

            Pessoa pessoa = new Pessoa();
            pessoa.Nome     = "José";
            pessoa.Endereco = "Rua X";
            pessoa.Telefone = "999999999";
            pessoa.Carro    = carro;

            Console.WriteLine("{0} possui um {1}", pessoa.Nome, pessoa.Carro.ToString());
        }
    }
}
