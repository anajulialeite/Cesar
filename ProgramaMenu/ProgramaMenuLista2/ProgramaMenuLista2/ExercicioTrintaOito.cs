using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTrintaOito
    {
        public static void Executar()
        {
            //Declarando a variável
            int C;
            double N, E = 0, PrecoHora, PrecoExcedente;
            bool continuar = true;
            char texto;

            //Faça um programa que calcule 10,00 por hora, se as horas passar de 50, calcule o excedente
            do
            {
                E = 0;
                PrecoHora = 10;
                PrecoExcedente = PrecoHora * 2;

                Console.WriteLine("Digite o código do operário: ");
                C = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de horas trabalhadas: ");
                N = double.Parse(Console.ReadLine());

                if (N > 50)
                {
                    E = N - 50;
                }

                //Mostrar na tela o resulatdo, S para continuar calculando, N para sair do programa
                Console.WriteLine("\nID: " + C + "\nSalario: " + (N * PrecoHora) + "\nSalario excedente: " + (E * PrecoExcedente) + "\nSalario total: " + (E * PrecoExcedente + N * PrecoHora) + "\n\nDeseja encerrrar o programa? (S/N)? ");
                texto = char.Parse(Console.ReadLine());
                if (texto == 's' || texto == 'S')
                {
                    continuar = false;
                }

            } while (continuar);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

