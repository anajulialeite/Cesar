using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuarenta
    {
        public static void Executar()
        {
            //Declarando as variáveis
            double numero;
            bool parar = false;
            char letra;

            do
            {
                do
                {
                    //Digite um número para o índice de poluição, número negativo é um número inválido
                    Console.WriteLine("Digite o índice da poluição: ");
                    numero = double.Parse(Console.ReadLine());
                    if (numero < 0) Console.WriteLine("Numero inválido digite um número positivo.");

                //Um programa que mostra o índece de poluição
                } while (numero < 0);

                Console.WriteLine();

                //Se o número for aceitável ok,
                if (numero >= 0 && numero <= 0.25) 
                {
                    Console.WriteLine("Índice de poluição aceitável!");
                }

                //Se o número for alto para o nível de poluição, pedir para suspender as atividades do grupo
                if (numero >= 0.3)
                {
                    Console.WriteLine("Suspender atividades das indústrias do 1° Grupo!");
                }

                if (numero >= 0.4)
                {
                    Console.WriteLine("Suspender atividades das indústrias do 2° Grupo!");
                }

                if (numero >= 0.5)
                {
                    Console.WriteLine("Suspender atividades das indústrias do 3° Grupo!");
                }

                //Mostrar o resultado na tela e se deseja continuar ou encerrar o programa
                Console.WriteLine("\nDeseja encerrar o programa? (s/N? ");
                letra = char.Parse(Console.ReadLine());
                if (letra == 's' || letra == 'S')
                {
                    parar = true;
                }
            } while (parar == false);
        }
    }
}


