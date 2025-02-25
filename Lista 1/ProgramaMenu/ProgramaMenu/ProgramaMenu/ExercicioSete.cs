using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioSete
    {
        public static void Executar()
        {
            //Somar e mostrar o número
            Console.WriteLine("Soma par ou impar");
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            int resultado;

            //Impar leia 5
            if (n1 % 2 == 0)
            {
                resultado = n1 + 5;
            }
            //Par leia 8
            else
            {
                resultado = n1 + 8;
            }
            //Mostra o resultado na tela
            Console.WriteLine("A soma do valor é: " + resultado);
            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();
        }
    }
}
