using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquenta
    {
        public static void Executar()
        {
            //Declarando as variáveis
            Random gerador = new Random();
            bool acertou = false;
            int chute, qtdTentativas = 0;

            int numero = gerador.Next(101);
            
            //Um programa que sortei um número de 0 a 100
            while (acertou == false)
            {
                //Digite um número de 0 a 100
                Console.WriteLine("Digite um número entre 0 a 100: ");
                
                //Se acertar diga o número e a quantidade de tentativas
                chute = Convert.ToInt32(Console.ReadLine());
                qtdTentativas++;
                if (chute  == numero)
                {
                    //Agora tente acertar o número que digitei por x tentativas
                    Console.WriteLine($"Você acertou em {qtdTentativas} tentativas");
                    acertou = true;
                }
                else if (chute > numero)
                {
                    //Se errar:
                    //Diga se o número é menor
                    Console.WriteLine("O número menor é: ");
                }
                else
                {
                    //Diga se o número é maior
                    Console.WriteLine("O número maior é");
                }
                Console.ReadLine();
            }
            
            
        }   
        
    }
}
