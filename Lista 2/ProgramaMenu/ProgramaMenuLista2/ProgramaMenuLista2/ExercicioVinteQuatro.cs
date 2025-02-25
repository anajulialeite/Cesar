using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioVinteQuatro
    {
        public static void Executar()
        {
            //Declarando a variável
            double PrimeiroNumero, SegundoNumero, Resultado;
            int Menu;
            bool LoopMenu = true;

            //Leia dois números inteiros
            Console.WriteLine("digite o primeiro número: ");
            PrimeiroNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            SegundoNumero = double.Parse(Console.ReadLine());

            //Programa menu
            while (LoopMenu)
            {
                Console.WriteLine("Você deseja verificar se...1 - um dos números lidos é ou não múltiplo do outro 2 - os dois números lidos são pares 3 - a média dos dois números é maior ou igual a 7 4 - Sair");
                Menu = int.Parse(Console.ReadLine());
                
                //Mostrar o resultado na tela com a as opções do menu
                switch (Menu)
                {
                    case 1:
                        if (PrimeiroNumero % SegundoNumero == 0 || SegundoNumero % PrimeiroNumero == 0)
                        {
                            Console.WriteLine("Sim, um dos números é múltiplo do outro");
                        }
                        else
                        {
                            Console.WriteLine("Não, nenhum dos números é múltiplos do outro");
                        }
                        break;
                    
                    case 2:
                        if (PrimeiroNumero % 2 == 0 && SegundoNumero % 2 == 0)
                        {
                            Console.WriteLine("Sim, os dois números lidos são pares.");
                        }
                        else
                        {
                            Console.WriteLine("Não, os dois números lidos são ímpares.");
                        }
                        break;
                    
                    case 3:
                        if ((PrimeiroNumero + SegundoNumero) / 2 >= 7)
                        {
                            Console.WriteLine("Sim, a média dos dois números é maior ou igual a 7.");
                        }
                        else
                        {
                            Console.WriteLine("Não, a média dos dois números não é maior ou igual a 7.");
                        }
                        break;
                    
                    case 4:
                        LoopMenu = false;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
        
    

