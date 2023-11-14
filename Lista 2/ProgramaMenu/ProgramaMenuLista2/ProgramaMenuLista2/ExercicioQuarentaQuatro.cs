using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuarentaQuatro
    {
        public static void Executar()
        {
            //Declarando as variáveis
            bool continuar = true;
            char letra;
            int opcao;

            do
            {
                do
                {
                    //Fazer um programa Menu que leia 4 opções
                    Console.WriteLine("Digite uma das opções: \n\t1 - Conversão de graus Celsius em Graus Fahrenheit\n\t2 - Conversão de Graus Fahrenheit em Graus Celsius\n\t3 - Peso ideal do homem\n\t4 - Pesol ideal da mulher\n\n");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao < 1 || opcao > 4) Console.WriteLine("Opcao Errada. \n");
                } while (opcao < 1 || opcao > 4);
                double Celsius, Fahrenheit;
                double Altura, PesoIdeal;
                switch (opcao)
                {
                    //Converter de Celsius para Fahrenheit
                    case 1:
                        Console.WriteLine("Digite a temperatura em °C: ");
                        Celsius = double.Parse(Console.ReadLine());
                        Fahrenheit = (Celsius * 1.8) + 32;
                        Console.WriteLine("A temperatura convertida é: " + Fahrenheit + "°F.\n");
                        break;

                    //Converter de Fahrenheit para Celsius
                    case 2:
                        Console.WriteLine("Digite a temperatura em °F: ");
                        Fahrenheit = double.Parse(Console.ReadLine());
                        Celsius = (Fahrenheit - 32) / 1.8;
                        Console.WriteLine("A temperatura convertida é: " + Celsius + "°C.\n");
                        break;

                    //Peso ideal do homem 
                    case 3:
                        Console.WriteLine("Digite a altura: ");
                        Altura = double.Parse(Console.ReadLine());
                        PesoIdeal = (72.7 * Altura) - 58;
                        Console.WriteLine("Seu peso ideal é: " + PesoIdeal + "kg");
                        break;

                    //Peso ideal da mulher
                    case 4:
                        Console.WriteLine("Digite a altura: ");
                        Altura = double.Parse(Console.ReadLine());
                        PesoIdeal = (62.1 * Altura) - 44.7;
                        Console.WriteLine("Seu peso ideal é: " + PesoIdeal + "kg");
                        break;
                    default:
                        //Digite N para encerrar o programa
                        Console.WriteLine("Opção Errada.\n");
                        break;

                }

                //Digite s para encerrar o programa e N para continuar rodando o programa
                //Mostrar na tela
                Console.WriteLine("\nDesea encerrar o programa? (s/N)? ");
                letra = char.Parse(Console.ReadLine());
                if (letra == 's' || letra == 'S')
                {
                    continuar = false;
                }
            } while (continuar);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
