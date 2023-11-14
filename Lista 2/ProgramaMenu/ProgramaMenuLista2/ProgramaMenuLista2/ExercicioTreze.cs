using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTreze
    {
        public static void Executar()
        {
            //Declarando a variavel
            int Quantidade = 3;
            int[] Numeros = new int[Quantidade];

            //Ordenar numeros
            for (int x = 0; x < Quantidade; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + " Numero: ");
                Numeros[x] = int.Parse(Console.ReadLine());
            }

            Array.Sort(Numeros);
            Array.Reverse(Numeros);
            Console.WriteLine("Os números em ordem decrescente são: ");

            //Mostrar na tela 
            foreach (int x in Numeros) Console.WriteLine(x);
            Console.ReadKey();
            Console.Clear();
        }    

    }
}
