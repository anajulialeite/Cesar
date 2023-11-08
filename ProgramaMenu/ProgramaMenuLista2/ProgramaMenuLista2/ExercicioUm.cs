using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioUm
    {
        public static void Executar()
        {
            //Declarando a variável
            int estoque_medio, estoque_maximo, estoque_minimo;

            //Validando o Código
            Console.WriteLine("Estoque Médio de uma peça");

            Console.WriteLine("Digite a quantida máxima de peça: ");
            estoque_maximo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade mínima de peça: ");
            estoque_minimo = int.Parse(Console.ReadLine());

            //Fórmula
            estoque_medio = estoque_maximo + estoque_minimo / 2;

            //Mostrar na tela
            Console.WriteLine("A média da peça é: " + estoque_medio);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
