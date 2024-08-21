using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaSena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uma instância de classe Random
            Random random = new Random();
            //Para criar números únicos
            HashSet<int> numerosUnicos = new HashSet<int>();
            //Gera 6 números aleatórios entre 1 até 60
            while (numerosUnicos.Count < 6)
            {
                int numero = random.Next(1,61);
                //Impede de colocar número repetido
                numerosUnicos.Add(numero);
            }
            //Converte o HashSet para um array para exibir os números
            int[] numeros = new int[numerosUnicos.Count];
            numerosUnicos.CopyTo(numeros);
            //Mostrar na tela os números gerados 
            Console.WriteLine("A sequência de seis números é: ");
            foreach (int numero in numeros) //Exibe cada número em um array
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            
        }
    }
}
