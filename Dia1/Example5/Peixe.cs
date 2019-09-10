using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example5
{
    class Peixe : Animal
    {
        public string Raca { get; set; }
        public string Som { get; set; }
        public Peixe(string nome, int num, string cor, string genero, bool oviparo, string raca, string som)
            : base(nome, num, cor, genero, oviparo)
        {
            this.Nome = nome;
            this.NumeroDePatas = num;
            this.Cor = cor;
            this.Genero = genero;
            this.Oviparo = oviparo;
            this.Raca = raca;
            this.Som = som;
        }

        public override void ExecutarSom()
        {
            Console.WriteLine(this.Som);
        }
    }
}
