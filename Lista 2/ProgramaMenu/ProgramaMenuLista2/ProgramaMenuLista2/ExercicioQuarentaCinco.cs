using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuarentaCinco
    {
        public static void Executar()
        {
            //Declrando a variável
            int quantidade;

            //Digite a quantidade de números que querira mostrar na tela
            Console.WriteLine("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            int[] Numeros = new int[quantidade];

            //Mostra na tela a ordem inversa que foi realizada a leitura
            for (int x = 0; x < quantidade; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + "° Número: ");
                Numeros[x] = int.Parse(Console.ReadLine());
            }
            //Mostrar o resultado na tela
            Console.WriteLine("\nA ordem contrária é:\n");
            for (int y = quantidade -1; y >= 0; y--)
            {
                Console.WriteLine(Numeros[y]);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
