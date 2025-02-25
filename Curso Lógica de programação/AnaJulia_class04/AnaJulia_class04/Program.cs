using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaJulia_class04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Concatenando variáveis
            
            string primeiroNome, segundoNome;

            primeiroNome = "Ana";
            segundoNome = "Júlia";

            string NomeCompleto = string.Concat(primeiroNome, " " ,segundoNome);

            Console.WriteLine(NomeCompleto);
            Console.ReadLine();


        }
    }
}
