using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Do/While
            //2 - While
            //3 - For
            //4 - Foreach

            //5 - Tuplas (Avançado)

            //array é uma lista e o vetor é ponteiro que sempre começa em 0
            int[] arrayInteiro = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            int soma = 0;
            int contador = 0;
            do
            {
                /*No Do/While, sempre a operação entra ao menos uma vez dentro do escopo do do/while. 
                  E a condição da repetição é validada no final do escopo.*/

                soma += arrayInteiro[contador];

                contador++;
                //contador = contador + 1;

            } while (contador < arrayInteiro.Length);

            Console.WriteLine(soma);

            while (contador < arrayInteiro.Length)
            {
                soma += arrayInteiro[contador];

                contador++;

                /*No while, a condição de repetição é validada no início do escopo, 
                 portanto para entrar no while, deve-se satisfazer a condição.*/

                Console.WriteLine("Você NÃO ENTROU no escopo WHILE");
            }
            Console.ReadKey();
        }
    }
}
