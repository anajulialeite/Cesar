using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioCinco
    {
        public static void Executar()
        {
            //Encontrar o valor do Número
            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            //O dobro do número caso seja positivo
            if (numero >= 0)
            {
                int dobro = numero * numero;
                Console.WriteLine("O dobro de {0} é: {1}", numero, dobro);
            }
            //O triplo caso seja negativo
            else
            {
                int trilo = numero * numero * numero;
                Console.WriteLine("O triplo de {0} é: {1}", numero, trilo);
            }
             Console.ReadKey();
             Console.Clear();
        }    
    }   
}
