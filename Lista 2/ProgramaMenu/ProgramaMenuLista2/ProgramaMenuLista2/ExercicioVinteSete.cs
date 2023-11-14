using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioVinteSete
    {
        public static void Executar()
        {
            //Declarando a variável
            int quantidade;
            
            //A quantidade de números que deverá ser processados
            Console.WriteLine("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            //Calcule e exiba  para cada número a ser processado o seu fatorial
            long[] numeros = new long[quantidade];
            for (int x = 0; x < numeros.Length; x++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[x] = long.Parse(Console.ReadLine());
            }
            for (int x = 0; x < numeros.Length; x++)
            {
                long resultado = 1;
                for (long y = numeros[x]; y > 0; y--)
                {
                    resultado = y * resultado;
                }
                //Mostrar o resultado na tela
                Console.WriteLine("O fatorial de " + numeros[x] + " é: " + resultado);
                Console.ReadLine();
            }
        }
    }
}
     

