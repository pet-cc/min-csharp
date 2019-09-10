using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example5
{
    abstract class Animal
    {
        public string Nome { get; set; }
        public int NumeroDePatas { get; set; }
        public string Cor { get; set; }
        public string Genero { get; set; }
        public bool Oviparo { get; set; }

        public Animal(string nome, int num, string cor, string genero, bool oviparo)
        {
            this.Nome = nome;
            this.NumeroDePatas = num;
            this.Cor = cor;
            this.Genero = genero;
            this.Oviparo = oviparo;
        }

        public virtual void ExecutarSom()
        {
        }
    }
}
