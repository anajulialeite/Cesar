using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuarentaSeis
    {
        public static void Executar()
        {
            //Declarando a variável
            int quantidade;

            //Quantos número serão lidos
            Console.Write("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            int[] vetorx = new int[quantidade];
            int[] vetory = new int[quantidade];

            for (int x = 0; x < quantidade; x++)
            {
                //Quantidade de número lidos em x
                Console.WriteLine("Digite o " + (x + 1) + "° número do vetor x: ");
                vetorx[x] = int.Parse(Console.ReadLine());
            }
            for (int y = 0; y < quantidade; y++)
            {
                //Quantidade de números lidos em y
                Console.WriteLine("Digite o " + (y + 1) + "° número do vetor y: ");
                vetorx[y] = int.Parse(Console.ReadLine());
            }

            //Somar o vetor x em z e somar o vetor de y em z
            //Mostrar o resultado na tela
            Console.WriteLine("A multiplicação dos vetores é: \n");
            for (int z = 0; z < quantidade; z++)
            {
                Console.WriteLine(vetorx[z] + " * " + vetory[z] + " = " + (vetory[z] * vetorx[z]));
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
