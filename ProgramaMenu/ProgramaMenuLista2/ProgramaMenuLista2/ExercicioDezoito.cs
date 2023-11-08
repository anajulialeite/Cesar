using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioDezoito
    {
        public static void Executar()
        {
            //Declarando a variável
            int Codigo;

            //Verificador de código
            Console.WriteLine("Digite o código: ");
            Codigo = int.Parse(Console.ReadLine());

            //menu do código
            switch (Codigo)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;

                case 2:
                    Console.WriteLine("Dois");
                    break;

                case 3:
                    Console.WriteLine("Três");
                    break;

                default:
                    Console.WriteLine("Código Inválido");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
