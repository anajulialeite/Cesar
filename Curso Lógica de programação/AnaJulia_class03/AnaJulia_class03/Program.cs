using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaJulia_class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa de pagamento-----");
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            //int.Parse é uma conversão de string para int
            Console.WriteLine();

            //concatenação
            Console.WriteLine("resultados:");
            Console.WriteLine("nome " + nome);
            Console.WriteLine("idade " + idade);
            Console.ReadLine();
        }
    }
}
