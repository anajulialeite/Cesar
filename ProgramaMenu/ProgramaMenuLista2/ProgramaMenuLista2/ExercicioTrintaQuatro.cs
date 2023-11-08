using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTrintaQuatro
    {
        public static void Executar()
        {
            //Declarando a variável
            int NumeroAtual, Maior, Menor;

            //Digite o numero para registrar e um número negativo para finalizar o código
            Console.WriteLine("Digite um numero (negativo para sair): ");
            NumeroAtual = int.Parse(Console.ReadLine());

            //Programa de números
            if (NumeroAtual >= 0)
            {
                Menor = NumeroAtual;
                Maior = NumeroAtual;
                while (NumeroAtual >= 0)
                {
                    //Escolha uma série de números
                    Console.WriteLine("Digite outro número: ");
                    NumeroAtual = int.Parse(Console.ReadLine());
                    if (NumeroAtual > Maior)
                    {
                        Maior = NumeroAtual;
                    }
                    if (NumeroAtual < Menor && NumeroAtual >= 0)
                    {
                        Menor = NumeroAtual;
                    }
                }
                //Exibir na tela o resultado
                Console.WriteLine("\nO maior número foi: " + Maior + " e o menor foi: " + Menor);
                Console.ReadKey();
                Console.Clear(); 
            }
        }
    }
}
