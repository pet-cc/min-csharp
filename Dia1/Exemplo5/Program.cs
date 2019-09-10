using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example5
{
    class Program
    {
        static void Main()
        {
            List<Animal> animais = new List<Animal>();
            Gato garfield = new Gato
            (
                "Garfield",
                4,
                "branco",
                "Macho",
                false,
                "Siamês",
                true,
                "Miau"
            );

            Boi bandido = new Boi
            (
                "Bandido",
                4,
                "preto",
                "Macho",
                false,
                "Angus",
                false,
                "Muuu"
            );

            Peixe nemo = new Peixe
            (
                "Nemo",
                2,
                "laranja",
                "Macho",
                true,
                "Peixe-Palhaço",
                "Glub glub"
            );

            animais.Add(garfield);
            animais.Add(bandido);
            animais.Add(nemo);
            int i = 1;

            foreach(Animal animal in animais)
            {
                Console.WriteLine($"O animal número {i} é um {animal.GetType().Name} chamado {animal.Nome}. Ele faz o seguinte som:");
                Console.ReadKey();
                animal.ExecutarSom();
                i++;
            }

            Console.WriteLine("Vamos observar o que eles fazem a seguir:");
            Console.ReadKey();
            garfield.Acao();
            Console.ReadKey();
            bandido.Acao();

        }
    }
}
