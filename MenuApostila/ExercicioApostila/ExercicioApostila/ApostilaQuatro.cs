<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioApostila
{
    public class ApostilaQuatro
    {
        public static void Executar()
        {
            int ExercicioApostila = -2;

            do
            {
                Console.WriteLine("Escolha o Exercício que deseja corrigir: ");
                ExercicioApostila = int.Parse(Console.ReadLine());

                switch (ExercicioApostila)
                {
                    case 1:
                        //Declarando as variáveis
                        int NumElementos = 0;
                        int SomaDosNumeros = 0;
                        int MediaDosNumeros = 0;
                        int menor = 0, maior = 0;

                        int[] MeuArray;

                        //Informe o número
                        Console.WriteLine("Informe o número de elementos: ");
                        NumElementos = Convert.ToInt32(Console.ReadLine());

                        MeuArray = new int[NumElementos];

                        for (int l = 0; l < NumElementos; l++)
                        {
                            //Informe um segundo número
                            Console.WriteLine("Informe o número: ");
                            MeuArray[l] = Convert.ToInt32(Console.ReadLine());
                        }

                        for (int j = 0; j < NumElementos; j++)
                        {
                            SomaDosNumeros += MeuArray[j];
                        }

                        //Econtrando o maior e o menor número e calcular a média de 20 números inteiros
                        MediaDosNumeros = (SomaDosNumeros / MeuArray.Length);

                        menor = MeuArray[0];
                        maior = MeuArray[0];

                        for (int j = 0; j < NumElementos; j++)
                        {
                            if (j == 0)
                            {
                                menor = MeuArray[0];
                                maior = MeuArray[0];
                            }
                            if (MeuArray[j] < menor)
                            {
                                menor = MeuArray[j];
                            }
                            else if (MeuArray[j] > maior)
                            {
                                maior = MeuArray[j];
                            }
                        }

                        //Mostrar o resultado na tela
                        Console.WriteLine(new string('=', 50));
                        Console.WriteLine("RESULTADO FINAL");
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("A média é {0}", MediaDosNumeros);
                        Console.WriteLine("O menor número é: " + menor);
                        Console.WriteLine("O maior número é: " + maior);
                        break;

                    case 2:
                        //Declarando a variável
                        double valorCompraVista = 0;
                        double valorCompraPrazo = 0;
                        double valorCompraTotal = 0;
                        string tipoCompra = string.Empty;
                        double valorCompra = 0;

                        //Um programa que leia 15 prestações de compras à vista e à prazo
                        for (int k = 0; k < 15; k++)
                        {
                            Console.WriteLine("Digite o valor da compra: ");
                            valorCompra = double.Parse(Console.ReadLine());

                            do
                            {
                                //mostrar as compras à vista e à prazo
                                Console.WriteLine("Digite V para compras à vista.");
                                Console.WriteLine("Digite P para compras a prazo.");
                                tipoCompra = Console.ReadLine();

                                if (tipoCompra != "V" && tipoCompra != "P")
                                    Console.WriteLine("Digite V ou P: ");

                            } while (tipoCompra != "V" && tipoCompra != "P");

                            if (tipoCompra == "V")
                                valorCompraVista += valorCompra;

                            if (tipoCompra == "P")
                                valorCompraPrazo += valorCompra;
                        }

                        valorCompraTotal = valorCompraPrazo + valorCompraVista;

                        //Mostrar na tela o valor total das compras
                        Console.WriteLine("O valor total de compras a prazo foi de: {0}", valorCompraPrazo);
                        Console.WriteLine("O valor total de compras à vista foi de: {0}", valorCompraVista);
                        Console.WriteLine("O valor total de compras foi de: {0}", valorCompraTotal);
                        break;

                    case 3:
                        //Declarando as variáveis
                        int pop, filhos, total_filhos = 0, i, y = 1;
                        float sal, total_sal = 0, media_sal, media_filhos, maior_sal = 0, perc_sal = 0;

                        Console.WriteLine("Qual é a população da cidade: ");
                        pop = int.Parse(Console.ReadLine());

                        for (i = 1; i <= pop; i++)
                        {
                            //Um programa que leia o valor do salário e quantidade de filhos
                            //Entravista feita com 200 pessoas
                            Console.WriteLine("Qual o seu salário: R$: ");
                            sal = float.Parse(Console.ReadLine());
                            Console.WriteLine("Qual a quantidade de filhos: ");
                            filhos = int.Parse(Console.ReadLine());

                            //A porcentagem de pessoas com salários até R$1.500,00
                            total_sal = sal + total_sal;
                            total_filhos = total_filhos + filhos;

                            if (maior_sal < sal)
                            {
                                maior_sal = sal;
                            }
                            if (sal <= 1500)
                            {
                                perc_sal = (y * 100.0f) / pop;
                                y++;
                            }
                        }

                        media_sal = total_sal / pop;
                        media_filhos = (float)total_filhos / pop;
                        //Mostrar na tela a média salarial
                        Console.WriteLine("A média do salário da população é R$ {0:F2}", media_sal);
                        //Mostrar na tela a média do número de filhos
                        Console.WriteLine("A média do número de filhos é {0:F1}", media_filhos);
                        //Mostrar na tela o menor salário
                        Console.WriteLine("O maior salário é R$ {0:F2}", maior_sal);
                        //Mostrra na tela a porcentagem do salário
                        Console.WriteLine("A porcentagem das pessoas com salários até R$ 1500.00 é {0:F1}%", perc_sal);
                        break;

                    default:
                        break;
                }
            } while (ExercicioApostila != -1);
        }
    }
}


















=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioApostila
{
    public class ApostilaQuatro
    {
        public static void Executar()
        {
            int ExercicioApostila = -2;

            do
            {
                Console.WriteLine("Escolha o Exercício que deseja corrigir: ");
                ExercicioApostila = int.Parse(Console.ReadLine());

                switch (ExercicioApostila)
                {
                    case 1:
                        //Declarando as variáveis
                        int NumElementos = 0;
                        int SomaDosNumeros = 0;
                        int MediaDosNumeros = 0;
                        int menor = 0, maior = 0;

                        int[] MeuArray;

                        //Informe o número
                        Console.WriteLine("Informe o número de elementos: ");
                        NumElementos = Convert.ToInt32(Console.ReadLine());

                        MeuArray = new int[NumElementos];

                        for (int l = 0; l < NumElementos; l++)
                        {
                            //Informe um segundo número
                            Console.WriteLine("Informe o número: ");
                            MeuArray[l] = Convert.ToInt32(Console.ReadLine());
                        }

                        for (int j = 0; j < NumElementos; j++)
                        {
                            SomaDosNumeros += MeuArray[j];
                        }

                        //Econtrando o maior e o menor número e calcular a média de 20 números inteiros
                        MediaDosNumeros = (SomaDosNumeros / MeuArray.Length);

                        menor = MeuArray[0];
                        maior = MeuArray[0];

                        for (int j = 0; j < NumElementos; j++)
                        {
                            if (j == 0)
                            {
                                menor = MeuArray[0];
                                maior = MeuArray[0];
                            }
                            if (MeuArray[j] < menor)
                            {
                                menor = MeuArray[j];
                            }
                            else if (MeuArray[j] > maior)
                            {
                                maior = MeuArray[j];
                            }
                        }

                        //Mostrar o resultado na tela
                        Console.WriteLine(new string('=', 50));
                        Console.WriteLine("RESULTADO FINAL");
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("A média é {0}", MediaDosNumeros);
                        Console.WriteLine("O menor número é: " + menor);
                        Console.WriteLine("O maior número é: " + maior);
                        break;

                    case 2:
                        //Declarando a variável
                        double valorCompraVista = 0;
                        double valorCompraPrazo = 0;
                        double valorCompraTotal = 0;
                        string tipoCompra = string.Empty;
                        double valorCompra = 0;

                        //Um programa que leia 15 prestações de compras à vista e à prazo
                        for (int k = 0; k < 15; k++)
                        {
                            Console.WriteLine("Digite o valor da compra: ");
                            valorCompra = double.Parse(Console.ReadLine());

                            do
                            {
                                //mostrar as compras à vista e à prazo
                                Console.WriteLine("Digite V para compras à vista.");
                                Console.WriteLine("Digite P para compras a prazo.");
                                tipoCompra = Console.ReadLine();

                                if (tipoCompra != "V" && tipoCompra != "P")
                                    Console.WriteLine("Digite V ou P: ");

                            } while (tipoCompra != "V" && tipoCompra != "P");

                            if (tipoCompra == "V")
                                valorCompraVista += valorCompra;

                            if (tipoCompra == "P")
                                valorCompraPrazo += valorCompra;
                        }

                        valorCompraTotal = valorCompraPrazo + valorCompraVista;

                        //Mostrar na tela o valor total das compras
                        Console.WriteLine("O valor total de compras a prazo foi de: {0}", valorCompraPrazo);
                        Console.WriteLine("O valor total de compras à vista foi de: {0}", valorCompraVista);
                        Console.WriteLine("O valor total de compras foi de: {0}", valorCompraTotal);
                        break;

                    case 3:
                        //Declarando as variáveis
                        int pop, filhos, total_filhos = 0, i, y = 1;
                        float sal, total_sal = 0, media_sal, media_filhos, maior_sal = 0, perc_sal = 0;

                        Console.WriteLine("Qual é a população da cidade: ");
                        pop = int.Parse(Console.ReadLine());

                        for (i = 1; i <= pop; i++)
                        {
                            //Um programa que leia o valor do salário e quantidade de filhos
                            //Entravista feita com 200 pessoas
                            Console.WriteLine("Qual o seu salário: R$: ");
                            sal = float.Parse(Console.ReadLine());
                            Console.WriteLine("Qual a quantidade de filhos: ");
                            filhos = int.Parse(Console.ReadLine());

                            //A porcentagem de pessoas com salários até R$1.500,00
                            total_sal = sal + total_sal;
                            total_filhos = total_filhos + filhos;

                            if (maior_sal < sal)
                            {
                                maior_sal = sal;
                            }
                            if (sal <= 1500)
                            {
                                perc_sal = (y * 100.0f) / pop;
                                y++;
                            }
                        }

                        media_sal = total_sal / pop;
                        media_filhos = (float)total_filhos / pop;
                        //Mostrar na tela a média salarial
                        Console.WriteLine("A média do salário da população é R$ {0:F2}", media_sal);
                        //Mostrar na tela a média do número de filhos
                        Console.WriteLine("A média do número de filhos é {0:F1}", media_filhos);
                        //Mostrar na tela o menor salário
                        Console.WriteLine("O maior salário é R$ {0:F2}", maior_sal);
                        //Mostrra na tela a porcentagem do salário
                        Console.WriteLine("A porcentagem das pessoas com salários até R$ 1500.00 é {0:F1}%", perc_sal);
                        break;

                    default:
                        break;
                }
            } while (ExercicioApostila != -1);
        }
    }
}


















>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
