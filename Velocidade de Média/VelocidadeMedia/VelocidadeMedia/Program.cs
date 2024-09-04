using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelocidadeMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita a distância ao usuário
            Console.Write("Digite a distância percorrida (em quilômetros): ");
            string entradaDistancia = Console.ReadLine();

            // Solicita o tempo ao usuário
            Console.Write("Digite o tempo gasto (em horas): ");
            string entradaTempo = Console.ReadLine();

            try
            {
                // Converte as entradas para números de ponto flutuante
                double distancia = Convert.ToDouble(entradaDistancia);
                double tempo = Convert.ToDouble(entradaTempo);

                // Verifica se o tempo é diferente de zero para evitar divisão por zero
                if (tempo == 0)
                {
                    Console.WriteLine("O tempo não pode ser zero.");
                }
                else
                {
                    // Calcula a velocidade média
                    double velocidadeMedia = distancia / tempo;

                    // Exibe o resultado
                    Console.WriteLine($"A velocidade média é {velocidadeMedia} km/h.");
                }
            }
            catch (FormatException)
            {
                // Trata o caso onde a entrada não pode ser convertida para número
                Console.WriteLine("Por favor, insira um número válido para distância e tempo.");
            }
        }
    }
}
    

