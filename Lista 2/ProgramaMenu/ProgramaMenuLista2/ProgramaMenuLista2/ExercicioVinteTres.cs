using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioVinteTres
    {
        public static void Executar()
        {
            //Declarando a Variável
            double PrimeiroNumero, SegundoNumero, Resultado;
            int Menu;

            //Menu Calculadora
            Console.WriteLine("Digite uma das operações a seguir:\n\t1 - Adição\n\t2 - Subtração\n\t3 - Multiplicação\n\t4 - Divisão\n");
            Menu = int.Parse(Console.ReadLine());

            //Mostrar na tela os números
            Console.WriteLine("Digite o primeiro numero: ");
            PrimeiroNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            SegundoNumero = double.Parse(Console.ReadLine());

            //Menu de calculadora - mostrar o resultado na tela
            switch (Menu)
            {
                //Soma
                case 1:
                    Resultado = PrimeiroNumero + SegundoNumero;
                    Console.WriteLine("Resultado: " + Resultado);
                    break;
                //Subtração
                case 2:
                    Resultado = PrimeiroNumero - SegundoNumero;
                    Console.WriteLine("Resultado: " + Resultado);
                    break;
                //Multiplicação
                case 3:
                    Resultado = PrimeiroNumero * SegundoNumero;
                    Console.WriteLine("Resultado : " + Resultado);
                    break;
                //Divisão
                case 4:
                    Resultado = PrimeiroNumero / SegundoNumero;
                    Console.WriteLine("Resultado: " + Resultado);
                    break;
                //Opção inválida
                default:
                    Console.WriteLine("opção inválida!");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
        
    

