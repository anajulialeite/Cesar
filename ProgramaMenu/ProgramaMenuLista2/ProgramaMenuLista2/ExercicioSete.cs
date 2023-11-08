using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioSete
    {
        public static void Executar()
        {
            //Declarando a variavel
            double Celsius, Fahrenheit;

            //Convertendo Fahrenheit para Celsius
            Console.WriteLine("Convertendo a temperatura: Graus Fahrenheit -> Celsius");

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            Fahrenheit = double.Parse(Console.ReadLine());

            //Fórmula
            Celsius = (Fahrenheit - 32) * 5 / 9;

            //Mostrar na tela a temperatura convertida
            Console.WriteLine("A temperatura convertida é: " +  Celsius + "°C");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
