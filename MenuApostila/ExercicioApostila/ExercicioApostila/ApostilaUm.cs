<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioApostila
{
    public class ApostilaUm
    {
        public static void Executar()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Qual é a diferença entre Polimorfismo, Herança, Encapsulamento e Abstração?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Polimorfismo: Tudo o que o filho herda da classe pai, mas com métodos distintos.");
            Console.WriteLine("Herança: Tudo o que o filho herda da classe pai em seus atributos.");
            Console.WriteLine("Encapusulamento: Permitir o que pode ser visto na classe pai e na classe filho através do public.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Abstração: É a habilidade de modelar características do mundo real, de um denominado problema em questão que o programador esteja tentando resolver, e determinar como estas características irão atuar ao receber informações.");
            Console.WriteLine("O que é Associação, Agregação, Composição e Generalização?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Associação: Representa a relação existente entre objetos. Ela descreve o vínculo entre duas classes e geralmente determina que as instâncias de uma classe estão de alguma forma ligadas ás instâncias de outra classe.");
            Console.WriteLine("Agregação: Demonstra que as informações de um objeto precisam ser complementadas por um objeto de outras classe. Relação Todo-Parte, a perda de tudo não resulta, obrigatoriamente, na perda das partes.");
            Console.WriteLine("Composição: O Objetos-Parte têm que pertencer ao Objeto-Todo. Um depende do outro.");
            Console.WriteLine("Generalização: É quando existe a necessidade de criar uma classe que herde as propriedades de outra classe, isto é, os atributos, métodos e também relacionamentos da classe superior. Os atributos e métodos definidos na classe-mãe são herdadas pelas classes filhas.");

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

namespace ExercicioApostila
{
    public class ApostilaUm
    {
        public static void Executar()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Qual é a diferença entre Polimorfismo, Herança, Encapsulamento e Abstração?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Polimorfismo: Tudo o que o filho herda da classe pai, mas com métodos distintos.");
            Console.WriteLine("Herança: Tudo o que o filho herda da classe pai em seus atributos.");
            Console.WriteLine("Encapusulamento: Permitir o que pode ser visto na classe pai e na classe filho através do public.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Abstração: É a habilidade de modelar características do mundo real, de um denominado problema em questão que o programador esteja tentando resolver, e determinar como estas características irão atuar ao receber informações.");
            Console.WriteLine("O que é Associação, Agregação, Composição e Generalização?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Associação: Representa a relação existente entre objetos. Ela descreve o vínculo entre duas classes e geralmente determina que as instâncias de uma classe estão de alguma forma ligadas ás instâncias de outra classe.");
            Console.WriteLine("Agregação: Demonstra que as informações de um objeto precisam ser complementadas por um objeto de outras classe. Relação Todo-Parte, a perda de tudo não resulta, obrigatoriamente, na perda das partes.");
            Console.WriteLine("Composição: O Objetos-Parte têm que pertencer ao Objeto-Todo. Um depende do outro.");
            Console.WriteLine("Generalização: É quando existe a necessidade de criar uma classe que herde as propriedades de outra classe, isto é, os atributos, métodos e também relacionamentos da classe superior. Os atributos e métodos definidos na classe-mãe são herdadas pelas classes filhas.");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
