<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioSeis
    {
        public static void Executar()
        {
            //Declarando a variavel
            double Celsius, Fahrenheit;

            //Convertendo Celsius para Fahrenheit
            Console.WriteLine("Converendo temperatura: Graus Celsius -> Fahrenheit");

            Console.WriteLine("Digite a temperatura em Celsius: ");
            Celsius = double.Parse(Console.ReadLine());

            //Formula
            Fahrenheit = (9 * Celsius + 160) / 5;

            //Mostrar na tela a temperatura convertida
            Console.WriteLine("A temperatura convertida é: " + Fahrenheit + "ºF");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioSeis
    {
        public static void Executar()
        {
            //Declarando a variavel
            double Celsius, Fahrenheit;

            //Convertendo Celsius para Fahrenheit
            Console.WriteLine("Converendo temperatura: Graus Celsius -> Fahrenheit");

            Console.WriteLine("Digite a temperatura em Celsius: ");
            Celsius = double.Parse(Console.ReadLine());

            //Formula
            Fahrenheit = (9 * Celsius + 160) / 5;

            //Mostrar na tela a temperatura convertida
            Console.WriteLine("A temperatura convertida é: " + Fahrenheit + "ºF");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
