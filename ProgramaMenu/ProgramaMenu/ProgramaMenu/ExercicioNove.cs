using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioNove
    {
     public static void Executar()
      {
            //Sexo
            Console.Write("Escreva aqui seu sexo, F para feminino e M para masculino: ");
            char sexo = char.Parse(Console.ReadLine());

            //Altura
            Console.Write("Escreva aqui a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            //Calculando o peso ideal
            double formula;

            if (sexo == 'm')
            {
                formula = (72.2 * altura) - 58;
                Console.WriteLine("sexo: " + sexo + "O peso ideal é: " + formula);
                Console.ReadLine();
            }

            else if (sexo == 'f')
            {
                formula = (62.1 * altura) - 44.7;
                Console.WriteLine("Sexo: " + sexo + "O seu peso ideal é: " + formula);
                Console.ReadLine();
            }

            Console.ReadKey();
            Console.Clear();
      }
    }
}
