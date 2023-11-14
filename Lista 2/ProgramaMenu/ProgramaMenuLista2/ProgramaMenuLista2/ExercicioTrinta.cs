using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTrinta
    {
        public static void Executar()
        {
            //Declarando a variável
            double numero;

            //Escolha um número para rodar o programa
            Console.WriteLine("Digite um número: ");
            numero = double.Parse(Console.ReadLine());
            Console.WriteLine();

            //Programa Tabuada
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 0; y <= 10; y++)
                {
                    //Mostrar resultado na tela
                    Console.WriteLine($" {x} x {y} = {x * y}");

                }
                 
            }
        }
    }
}
