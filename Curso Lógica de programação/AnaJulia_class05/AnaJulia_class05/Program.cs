using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaJulia_class05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Ana Júlia";
            int saldo = 20000;
            string nomeProduto = "Vídeo Game";
            int valorProduto = 150;
            string resultado = "sim";
            
            Console.WriteLine("-----Compra Online-----");
            Console.WriteLine();

            Console.WriteLine("Resultado");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("Nome do produto: " + nomeProduto);
            Console.WriteLine("Valor do produto: " + valorProduto);
            Console.WriteLine("Deseja realmente fazer essa compra? " + resultado);
            Console.ReadKey();
        }
    }
}
