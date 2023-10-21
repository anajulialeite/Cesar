using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenu
{
    public class ExercicioOnze
    {
        public static void Executar()
        {
            //Declarando a variável
            double valor = 0;
            int op = 0;
            double calc1 = 0;
            double valorf = 0;

            Console.WriteLine("Digite o valor do produto: ");
            valor = double.Parse(Console.ReadLine());

            //Menu de pagamento
            Console.WriteLine("Digite a forma de pagamento: ");
            Console.WriteLine("Digite 1 para pagamento à vista em cheque ou dinheiro");
            Console.WriteLine("Digite 2 para pagamento à vista no cartão de crédito");
            Console.WriteLine("Digite 3 para pagamento em duas vezes");
            Console.WriteLine("Digite 4 para pagamento em mais de duas vezes");

            //Informando as opções
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    calc1 = 0.1 * valor;
                    valorf = valor - calc1;
                    Console.WriteLine("O valor total da compra é: " + valorf);
                    break;

                case 2:
                    calc1 = 0.15 * valor;
                    valorf = valor - calc1;
                    Console.WriteLine("O valor total da compra é: " + valorf);
                    break;

                case 3:
                    Console.WriteLine("O valor total da compra dividido em duas vezes é: " + valor);
                    break;

                case 4:
                    calc1 = 0.1 * valor;
                    valorf = valor + calc1;
                    Console.WriteLine("O valor total da compra é: " + valorf);
                    break;

            }
        }
    }
}






