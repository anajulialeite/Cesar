using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioSeis
    {
        public static void Executar()
        {
            //Variável
            int n1 = 0;
            int n2 = 0;

            //Valores Booleanos
            Console.WriteLine("Digite 0 para falso e 1 para verdadeiro");

            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            //Verdadeiro ou falso
            if (n1 == 0)
                Console.WriteLine("Número 1: Falso");
            else if (n1 == 1)
                Console.WriteLine("Número 1: Verdadeiro");
            else
                Console.WriteLine("Número 1: Inválido");

            if (n2 == 0)
                Console.WriteLine("Numero 2: Falso");
            else if (n2 == 1)
                Console.WriteLine("Numero 2: Verdadeiro");
            else
                Console.WriteLine("Número 2 inválido!");

            Console.ReadKey();
            Console.Clear();
        }
    }    
}
