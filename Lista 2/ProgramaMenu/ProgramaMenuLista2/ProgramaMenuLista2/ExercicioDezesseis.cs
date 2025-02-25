using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioDezesseis
    {
        public static void Executar()
        {
            //Declarando a variável
            int PrimeiroNumero, SegundoNumero;

            //Digite dois números
            Console.WriteLine("Digite o primeiro número: ");
            PrimeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            SegundoNumero = int.Parse(Console.ReadLine());

            //Um programa que mostre na tela o maior e o menor número
            if (PrimeiroNumero > SegundoNumero)
            {
                Console.WriteLine("O primeiro número é maior que o segundo número.");
            }
            else if (PrimeiroNumero < SegundoNumero)
            {
                Console.WriteLine("O primeiro número é menor que o segundo número.");
            }
            else
            {
                //Se os dois forem iguais, motre na tela
                Console.WriteLine("Os dois números são iguais.");
            }
            Console.ReadKey();
            Console.Clear();
        } 
    }
}
