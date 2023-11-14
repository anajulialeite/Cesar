using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTrintaSeis
    {
        public static void Executar()
        {
            //Declarando a variável
            int QuantNumeros = 10;
            double media = 0;
            int[] numeros = new int[QuantNumeros];

            for (int x = 0; x < QuantNumeros; x++)
            {
                //Um programa que leia 10 valores inteiros positivos
                Console.WriteLine("Digite o " + (x + 1) + "° número: ");
                numeros[x] = int.Parse(Console.ReadLine());
                media += numeros[x];
            }
            //Fórmula
            media = media / QuantNumeros;
            Array.Sort(numeros);

            //Motrar na tela os números encontrados
            //Encontre o menor valor
            Console.WriteLine("\nO menor número é: " + numeros[0]);
            //Encontre o maior valor
            Console.WriteLine("O maior número é: " + numeros[QuantNumeros - 1]);
            //Calcule a mádia dos números lidos
            Console.WriteLine("A média dos números é: " + media);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
