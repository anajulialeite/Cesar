using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioVinteDois
    {
        public static void Executar()
        {
            //Declarando a variável
            double A = 0, B = 0, Numero;

            //Organizando os números
            do
            {
                Console.WriteLine("Digite um número, digite 0 para sair: ");
                Numero = double.Parse(Console.ReadLine());
                if (Numero == 0)
                {
                    A += Numero;
                    Console.WriteLine("Número Armazenado em A");
                }
                else if (Numero < 0)
                {
                    B += Numero;
                    Console.WriteLine("Número armazenado em B");
                }

             //Mostrar resultado na tela
            } while (Numero != 0);
            Console.WriteLine("A = %2f B = %2f ", A, B);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
