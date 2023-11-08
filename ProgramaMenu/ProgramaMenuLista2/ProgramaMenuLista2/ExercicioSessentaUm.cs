using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioSessentaUm
    {
        public static void Executar()
        {
            //Um programa que calcule e mostre na tela o valor do salário antigo e do novo salário atualizado com o reajuste
            Console.WriteLine("Digite o salário atual: ");
            double SalarioAtual = double.Parse(Console.ReadLine());
            Console.WriteLine("********************************");
            Console.WriteLine("Digie o percentual de reajuste: ");
            double valor = (double.Parse(Console.ReadLine()) / 100);
            Console.WriteLine("********************************");
            Console.WriteLine("O novo salarial é de R$" + (Reajuste(SalarioAtual, valor)) + ".");
            Console.ReadKey();
        }
        //Método
        public static double Reajuste(double Salario, double IndiceReajuste)
        {
            //Fórmula
            double NovoSalario = Salario + (Salario * IndiceReajuste);
            //Retorne o novo salário
            return NovoSalario;
        }
    }
}
