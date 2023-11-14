using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioVinte
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int[] valores = new int[3];

            //Ler um valor maior que zero para cada variável
            //Se o valor for inválido pedir para ler novamente
            for (int x = 0; x < 3; x++)
            {

                Console.WriteLine("Verificador de variaveis");

                for (x = 0; x < 3; x++)
                {
                    Console.WriteLine("Digite o valor: " + (x + 1) + ": ");
                    valores[x] = int.Parse(Console.ReadLine());
                    while (valores[x] <= 0)
                    {
                        Console.WriteLine("Digite um valor válido: " + (x + 1) + ": ");
                        valores[x] = int.Parse(Console.ReadLine());
                    }
                }
                //Exiba o menor valor lido multiplicado pelo maior e o maior valor dividido pelo menor
                Array.Sort(valores);
                Console.WriteLine("Mostre o menor valor multiplicado pelo maior: " + (valores[0] * valores[2]) + "  E o maior valor dividido pelo menor: " + (valores[2] / valores[0]));
                valores[x] = int.Parse(Console.ReadLine());
                while (valores[x] <= 0)
                {
                    Console.WriteLine("Digite um valor válido no valor " + (x + 1) + ": ");
                    valores[x] = int.Parse(Console.ReadLine());
                }
            }
            //Mostrar resultado na tela
            Array.Sort(valores);
            Console.WriteLine("Mostre o menor valor multiplicado pelo maior: " + (valores[0] * valores[2]) + "  E o maior valor dividido pelo menor: " + (valores[2] / valores[0]));
            Console.ReadKey();
            Console.Clear();
        }
    }
}
