﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example5
{
    class Boi : Animal, ISom, IMamifero
    {
        public string Raca { get; set; }
        public string Som { get; set; }
        public bool Castrado { get ; set; }

        public Boi(string nome, int num, string cor, string genero, bool oviparo, string raca, bool castrado, string som)
            : base(nome, num, cor, genero, oviparo)
        {
            this.Nome = nome;
            this.NumeroDePatas = num;
            this.Cor = cor;
            this.Genero = genero;
            this.Oviparo = oviparo;
            this.Raca = raca;
            this.Castrado = castrado;
            this.Som = som;
        }

        public override void ExecutarSom()
        {
            Console.WriteLine(Som);
        }

        public void Acao()
        {
            Console.WriteLine("O boi pastou.");
        }
    }
}
