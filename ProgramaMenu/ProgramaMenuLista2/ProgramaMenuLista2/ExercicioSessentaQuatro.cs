using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Runtime.CompilerServices;

namespace ProgramaMenuLista2
{
    public class ExercicioSessentaQuatro
    {
        private static int[] Vetor = new int[10];

        public static void Executar()
        {
            //Declarando as variáveis
            bool continuar = true;
            int opcao = 0;

            do
            {
                //Carregando o vetor
                Console.WriteLine("Digite 1 para carregar o vetor ");
                Console.WriteLine("-------------------------------");

                //Menu de opções 
                switch (opcao)
                {
                    case 1:
                        CarregarVetor();
                        break;
                    case 2:
                        Console.WriteLine(ListarVetor());
                        break;
                    case 3:
                        Console.WriteLine(ListarParesVetor());
                        break;
                    case 4:
                        Console.WriteLine(ListarImparesVetor());
                        break;
                    case 5:
                        Console.WriteLine(QuantidadeParesNosImparesVetor());
                        break;
                    case 6:
                        Console.WriteLine(QuantidadeImparesNosParesVetor());
                        break;
                    case 7:
                        continuar = false;
                        break;
                }
                //Escolha a opção desejada
                Console.WriteLine("Digite uma opção: ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("2 - Para Listar o vetor");
                Console.WriteLine("3 - Para Exibir os números pares do vetor");
                Console.WriteLine("4 - Para Exibir os números ímpares do vetor");
                Console.WriteLine("5 - Para Exibir a quantidade de números pares nas posições ímpares do vetor");
                Console.WriteLine("6 - Para Exibir a quantidade de números ímpares nas posições pares do vetor");
                Console.WriteLine("7 - Para Sair");
                Console.WriteLine("---------------------------------");
                opcao = int.Parse(Console.ReadLine());
            } while (continuar);
        }
        //Método para carregar o vetor
        public static void CarregarVetor()
        {
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Digite o " + (x + 1) + "° número do vetor: ");
                Vetor[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nVetor carregado com sucesso!\n");
        }

        //Método para listar o vetor
        public static string ListarVetor()
        {
            string ListaVetor = "Valores do vetor:\n";
            for (int x = 0; x < 10; x++)
            {
                ListaVetor += "\t" + Vetor[x] + "\n";
            }
            return ListaVetor;
        }
        //Método para listar os números pares do vetor
        public static string ListarParesVetor()
        {
            string ListaVetor = "Valores do vetor:\n";
            for (int x = 0; x < 10; x++)
            {
                if (Vetor[x] % 2 == 0)
                {
                    ListaVetor += "\t" + Vetor[x] + "\n";
                }
            }
            return ListaVetor;
        }
        //Método para lustar os números ímpares do vetor
        public static string ListarImparesVetor()
        {
            string ListaVetor = "Valores do vetor:\n";
            for (int x = 0; x < 10; x++)
            {
                if (Vetor[x] % 2 == 1)
                {
                    ListaVetor += "\t" + Vetor[x] + "\n";
                }
            }
            return ListaVetor;
        }

        //Método para mostrar a quantidade de números pares nos ímpares do vetor
        public static int QuantidadeParesNosImparesVetor()
        {
            int quantidade = 0;
            for (int x = 1; x < 10; x = x + 2)
            {
                if (Vetor[x] % 2 == 0)
                {
                    quantidade++;
                }
            }
            return quantidade;
        }

        //Método para mostrar a quantidade de números ímpares nos pares do vetor
        public static int QuantidadeImparesNosParesVetor()
        {
            int quantidade = 0;
            for (int x = 0; x < 10; x = x + 2)
            {
                if (Vetor[x] % 2 == 1)
                {
                    quantidade++;
                }
            }
            //Mostrar a quantidade na tela
            return quantidade;
        }
    }
}

