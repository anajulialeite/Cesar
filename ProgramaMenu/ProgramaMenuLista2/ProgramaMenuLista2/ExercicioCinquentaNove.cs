using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinquentaNove
    {
        public static void Executar()
        {
            //Declarando as variáveis
            char[] letras = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };

            Console.WriteLine("Digite a primeira letra: ");
            char caractere = Convert.ToChar(Console.ReadLine());

            int primeiraL = ContaLetra(caractere, letras);

            Console.WriteLine("Digite a segunda letra: ");
            char outroL = Convert.ToChar(Console.ReadLine());

            int segundoL = ContaLetra(outroL, letras);

            int diferencas = Math.Abs(segundoL - primeiraL) - 1;

            //um progama que leia dois caracteres de A até Z e Mostra na tela quantos caracteres tem entres eles
            if (primeiraL >= 0 && segundoL >= 0 && diferencas >= 0)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine($"O número de caracteres entre eles é: {diferencas} ");
            }
            else
            {
                //Caso digite algo que n seja letra apresentará uma mensagem de erro
                Console.WriteLine("Erro!");
            }
            Console.ReadLine();
        }
        public static int ContaLetra(char ch, char[] letras)
        {
            int num = 0;
            for (int x = 0;  x < letras.Length; x++)
            {
                if (letras[x] == ch)
                {
                    return num;
                }
                num++;
            }
            return -1;
        }      
    }   
}
