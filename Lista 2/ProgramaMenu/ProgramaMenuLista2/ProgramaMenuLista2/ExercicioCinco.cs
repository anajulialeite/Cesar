<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioCinco
    {
        public static void Executar()
        {
            //Declarando a variável
            double VelocidadeMedia, TempoGasto, Autonomia = 12;
            double Distancia, LitrosUsados;

            //Mostrar na tela o tempo gasto de viagem e a velocidade média
            Console.WriteLine("Quanto tempo gastou em sua viagem (horas)?: ");
            TempoGasto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média usada na viagem (km/h): ");
            VelocidadeMedia = double.Parse(Console.ReadLine());

            //Fórmula
            Distancia = VelocidadeMedia * TempoGasto;
            LitrosUsados = Distancia / Autonomia;

            //Mostrando o resultado na tela
            Console.WriteLine("Resultados:");
            Console.WriteLine("Velocidade Média = " + VelocidadeMedia + "km/h");
            Console.WriteLine("Tempo Gasto = " + TempoGasto + "horas");
            Console.WriteLine("Distância Percorrida = " + Distancia + "km");
            Console.WriteLine("Quantidade de combustível utilizado: " + LitrosUsados + "litros");
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
    public class ExercicioCinco
    {
        public static void Executar()
        {
            //Declarando a variável
            double VelocidadeMedia, TempoGasto, Autonomia = 12;
            double Distancia, LitrosUsados;

            //Mostrar na tela o tempo gasto de viagem e a velocidade média
            Console.WriteLine("Quanto tempo gastou em sua viagem (horas)?: ");
            TempoGasto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média usada na viagem (km/h): ");
            VelocidadeMedia = double.Parse(Console.ReadLine());

            //Fórmula
            Distancia = VelocidadeMedia * TempoGasto;
            LitrosUsados = Distancia / Autonomia;

            //Mostrando o resultado na tela
            Console.WriteLine("Resultados:");
            Console.WriteLine("Velocidade Média = " + VelocidadeMedia + "km/h");
            Console.WriteLine("Tempo Gasto = " + TempoGasto + "horas");
            Console.WriteLine("Distância Percorrida = " + Distancia + "km");
            Console.WriteLine("Quantidade de combustível utilizado: " + LitrosUsados + "litros");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
