using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuatro
    {
        public static void Executar()
        {
            //Declrando a variável
            int[] valores = new int[4];

            Console.WriteLine("Calculador de valor numéricos");

            //Fórmula
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite o valor " + (i + 1) + ": ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            //Ler os valores e apresentar os resultado da soma e multiplicação na tela
            Console.WriteLine("Resultado");

            Console.WriteLine("Valor 1 e Valor 2:");
            Console.WriteLine("	" + valores[0] + " + " + valores[1] + " = " + (valores[0] + valores[1]) + "");
            Console.WriteLine("	" + valores[0] + " * " + valores[1] + " = " + (valores[0] * valores[1]) + "");

            Console.WriteLine("Valor 1 e Valor 3:");
            Console.WriteLine("	" + valores[0] + " + " + valores[2] + " = " + (valores[0] + valores[2]) + "");
            Console.WriteLine("	" + valores[0] + " * " + valores[2] + " = " + (valores[0] * valores[2]) + "");

            Console.WriteLine("Valor 1 e Valor 4:");
            Console.WriteLine("	" + valores[0] + " + " + valores[3] + " = " + (valores[0] + valores[3]) + "");
            Console.WriteLine("	" + valores[0] + " * " + valores[3] + " = " + (valores[0] * valores[3]) + "");

            Console.WriteLine("Valor 2 e Valor 3:");
            Console.WriteLine("	" + valores[1] + " + " + valores[2] + " = " + (valores[1] + valores[2]) + "");
            Console.WriteLine("	" + valores[1] + " * " + valores[2] + " = " + (valores[1] * valores[2]) + "");

            Console.WriteLine("Valor 2 e Valor 4:");
            Console.WriteLine("	" + valores[1] + " + " + valores[3] + " = " + (valores[1] + valores[3]) + "");
            Console.WriteLine("	" + valores[1] + " * " + valores[3] + " = " + (valores[1] * valores[3]) + "");

            Console.WriteLine("Valor 3 e Valor 4:");
            Console.WriteLine("	" + valores[2] + " + " + valores[3] + " = " + (valores[2] + valores[3]) + "");
            Console.WriteLine("	" + valores[2] + " * " + valores[3] + " = " + (valores[2] * valores[3]) + "");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
