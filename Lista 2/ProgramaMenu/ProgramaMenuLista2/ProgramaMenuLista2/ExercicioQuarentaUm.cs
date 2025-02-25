using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioQuarentaUm
    {
        public static void Executar()
        {
            //Declarando as variáveis
            double idade;
            bool parar = false;
            char letra;
            string categoria;

            do
            {
                do
                {
                    //Digite a Idade do nadador
                    Console.WriteLine("Digite a idade do nadador: ");
                    idade = double.Parse(Console.ReadLine());
                    //Idade negativa inválida
                    if (idade < 5) Console.WriteLine("Idade Inválida: ");
                } while (idade < 5);

                Console.WriteLine();

                //Faça um programa que leia a idade do nadador e indique a sua categoria
                if (idade >= 5 && idade < 8) categoria = "Infantil A";
                else if (idade >= 8 && idade < 12) categoria = "Infantil B";
                else if (idade >= 12 && idade < 14) categoria = "Juvenil A";
                else if (idade >= 14 && idade < 18) categoria = "uvenil B";
                else categoria = "Adultos";

                Console.WriteLine("A categoria é: " + categoria);

                //Mostrar o resultado na tela e perguntar se deseja continuar ou encerrar
                Console.WriteLine("\nDeseja encerrar o programa? (s/N)? ");
                letra = char.Parse(Console.ReadLine());
                if (letra == 's' || letra == 'S')
                {
                    parar = true;
                }

            } while (parar == false);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
