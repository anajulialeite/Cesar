using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elabora um algoritmo que leia dois valores do usuário e a operação que ele deseja 
             executar (operações: soma, subtração, divisão, multiplicação).
            E execute a operação desejada na tela.*/

            Console.WriteLine("Digite o número da operação que deseja executar");
            Console.WriteLine("1 - Soma.");
            Console.WriteLine("2 - Subtração.");
            Console.WriteLine("3 - Divisão.");
            Console.WriteLine("4 - Multiplicação.");
            Console.WriteLine("x----------------x");

            //número escolhido pelo usuário
            bool conversaoBemSucedida = true;
            int numeroEscolhido;
            do
            {
                conversaoBemSucedida = int.TryParse(Console.ReadLine(), out numeroEscolhido);

                //int numeroEscolhido = int.Parse(Console.ReadLine());
            } while (conversaoBemSucedida == false);

            //número desejado pelo usuário para realizar operação.
            Console.WriteLine("Informe o primeiro número da operação");
            decimal numero1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número da operação");
            decimal numero2 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("O número digitado foi: = " + numero1.ToString());
            //Console.WriteLine("O número digitado foi: = " + numero2.ToString());

            decimal resultado = 0;

            switch (numeroEscolhido)
            {
                case 1:
                    //soma
                        resultado = decimal.Parse(SomarNumeros(numero1, numero2).ToString());
                    break;

                case 2:
                    //Subtração
                        resultado = SubtrairNumeros(numero1, numero2);
                    break;

                case 3:
                    //Divisão
                        resultado = DividirNumeros(numero1, numero2);
                    break;

                case 4:
                    //Multiplicação
                        resultado = MultiplicarNumeros(numero1, numero2);
                    break;
            }

            Console.WriteLine("O resultado da operação é de: " + resultado.ToString());


            Console.ReadKey();
        }

        public static decimal SomarNumeros(decimal x, decimal y)
        {
            decimal resultado = x + y;
            return resultado;
        }
        
        public static decimal SubtrairNumeros(decimal x, decimal y)
        {
            decimal resultado = x - y;
            return resultado;
        }
        
        public static decimal DividirNumeros(decimal x, decimal y)
        {
            decimal resultado = x / y;
            return resultado;
        }
        
        public static decimal MultiplicarNumeros(decimal x, decimal y)
        {
            decimal resultado = x * y;
            return resultado;
        }
    }   
}
