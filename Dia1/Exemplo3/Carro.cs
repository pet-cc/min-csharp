using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example3
{
    class Carro
    {
        private string modelo;
        private string placa;
        private int    ano;
        private float  valor;

        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }

        public string Placa
        {
            get
            {
                return placa;
            }
            set
            {
                placa = value;
            }
        }

        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                ano = value;
            }
        }

        public float Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public override string ToString()
        {
            return this.Modelo + "(" + this.Ano + ")";
        }
    }
}
