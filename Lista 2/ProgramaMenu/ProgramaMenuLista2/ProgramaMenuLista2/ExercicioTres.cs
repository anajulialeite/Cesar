using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioTres
    {
        public static void Executar()
        {
            //Pedir para o programa ler a comissão
            Console.WriteLine("Programa para ler a comissão");

            //Declarando a variável + comissão de 5%
            int Idvendedor, Idpeca;
            double PrecoPeca, Quantidade, ValorComissao, PorcentagemComissao = 0.05;

            //Mostrar na tela Identificação, código, preço e quantidade
            Console.WriteLine("Digite a identificação da peça: ");
            Idpeca = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço individual da peça: ");
            PrecoPeca = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de peças vendidas: ");
            Quantidade = double.Parse(Console.ReadLine());

            //Fórmula
            ValorComissao = (PrecoPeca * Quantidade) * PorcentagemComissao;

            //Mostrar o resultado na tela
            Console.WriteLine("O valor da comissão é de: ", + ValorComissao / 0.05);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
