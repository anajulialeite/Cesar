using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioDezessete
    {
        public static void Executar()
        {
            //Declarando a variável
            int Numero;

            //Verificador de Número
            Console.WriteLine("Digite o primeiro numero: ");
            Numero = int.Parse(Console.ReadLine());

            //verificar se o número está entre 0 e 9 e escrever valor válico, caso contrário, inválido
            if (Numero >= 0 && Numero <= 9)
            {
                Console.WriteLine("Valor Válido!");
            }
            else
            {
                Console.WriteLine("Valor Inválido!");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}