using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioOnze
    {
        public static void Executar()
        {
            //Declarando a variável
            int A, B, Variavel1Tempora;

            //Troca de valores entre variáveis
            Console.WriteLine("Digite o valor da variável A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da variável B: ");
            B = int.Parse(Console.ReadLine());

            //Fórmula
            Variavel1Tempora = A;
            A = B;
            B = Variavel1Tempora;

            //Mostrar na tela a troca de valores entre variáveis
            Console.WriteLine("A=" +  A + " | B=" + B + "");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
