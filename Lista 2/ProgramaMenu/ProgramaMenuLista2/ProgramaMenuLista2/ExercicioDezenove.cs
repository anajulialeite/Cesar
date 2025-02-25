using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioDezenove
    {
        public static void Executar()
        {
            //Declarando as variáveis
            int A, B, C;

            //Verificador de triângulo
            Console.WriteLine("Digite o lado A= ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B= ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado C= ");
            C = int.Parse(Console.ReadLine());

            //Verificar se o triângulo é Equilátero, Isósceles, escaleno ou se os lados fornecidos não é um triângulo
            if (A < B + C && B < A + C && C < A + B)
            {
                if (A == B && B == C)
                {
                    Console.WriteLine("O Triângulo é Equilátero.");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("O Triângulo é Isósceles.");
                }
                else
                {
                    Console.WriteLine("O Triângulo é Escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}