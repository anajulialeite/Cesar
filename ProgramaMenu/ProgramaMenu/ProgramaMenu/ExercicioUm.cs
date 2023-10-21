using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioUm
    {
        public static void Executar()
        {
            //Receba as Variáveis A, B e C
            Console.WriteLine("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C ");
            int c = int.Parse(Console.ReadLine());

            int soma = a + b;

            //verificar qual é maior A + B ou C
            if (soma > c)
            {
                Console.WriteLine("A + B é maior do que C.");
            }
            else
            {
                Console.WriteLine("C é maior que A + B");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
