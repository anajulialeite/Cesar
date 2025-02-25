using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioDez
    {
        public static void Executar()
        {
            //Declarando as variávis
            decimal imc = 0;
            decimal peso = 0;
            decimal altura = 0;

            //Leia a altura e o peso
            Console.WriteLine("Entre com a sua altura: ");
            altura = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o peso: ");
            peso = decimal.Parse(Console.ReadLine());

            //Formula
            imc = peso / (altura * altura);

            //O IMC de um adulto
            Console.WriteLine("O IMC é: " + imc);
            if (imc < decimal.Parse("18,5"))
            {
                Console.WriteLine("Você está a baixo do peso ideal, cuide-se!");
            }
            else if (imc > decimal.Parse("18,50") && imc < 25)
            {
                Console.WriteLine("Você está com o peso ideal, Parabéns!");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine("Você está acima do peso ideal, Vamos emagrecer?");
            }
            else
            {
                Console.WriteLine("Você está obeso, cuide-se!");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}