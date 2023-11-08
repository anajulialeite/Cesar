using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuarentaNove
    {
        public static void Executar()
        {
            //Declarando a variável
            int qtd;

            //Digitar quantos números serão rodados na posição 1 e 2
            Console.WriteLine("Quantos números deseja inserir?: ");
            qtd = Convert.ToInt32(Console.ReadLine());



            int[] v1 = new int[qtd];
            int[] v2 = new int[qtd];

            //Digita os números na posição 1
            for (int x = 0; x < qtd; x++)
            {
                Console.Write($"Digite um valor para a posição {x + 1} do vetor 1: ");
                v1[x] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            //Digite os números na posilção 2
            for (int x = 0; x < qtd; x++)
            {
                Console.Write($"Digite um valor para a posição {x + 1} do vetor 2: ");
                v2[x] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            //Mostrar na tela se os números são iguais ou não
            for (int x = 0; x < qtd; x++)
            {
                if (v1[x] == v2[x])
                {
                    Console.WriteLine($"Valores das Posições {x + 1} dos vetores é igual.");
                }
                else
                {
                    Console.WriteLine($" Valores das Posições {x + 1} dos vetores não são iguais");
                }
                Console.ReadKey();
                Console.Clear();
            }   
        }
    }
}
