using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example2
{
    class Program
    {
        static void Outro()
        {
            Divisao divisao = new Divisao();
            divisao.Num1 = 10;
            divisao.Num2 = 5;

            Console.WriteLine("A divisão {0}/{1} é {2}", divisao.Num1, divisao.Num2, divisao.Dividir());
        }
    }
}
