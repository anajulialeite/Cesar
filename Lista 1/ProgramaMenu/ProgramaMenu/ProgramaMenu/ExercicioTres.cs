using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioTres
    {
        public static void Executar()
        {
            //Descobrir se o número é par ou ímpar
            Console.WriteLine("Exercicio 03");
            Console.WriteLine("Par ou Impar");

            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            if
                (n1 % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            Console.ReadKey();
            Console.Clear();    
        }
    } 
}
    

