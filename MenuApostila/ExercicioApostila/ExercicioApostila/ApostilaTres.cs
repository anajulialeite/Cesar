using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioApostila
{
    public class ApostilaTres
    {
        public static void Executar()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Quais são os benefícios de se criar um diagrama de classes?");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Entender melhor a visão geral dos esquemas de uma aplicação, expressar visualmente as necessidades específicas de um sistema e digulgar essas informações por toda a empresa, criar gráficos detalhados que destacam, qualquer código específico necessário para ser programado e implementado na estrutura descrita e fornecer uma descrição independente de implementação de tipos utilizados em um sistema e passados posteriormente entre seus componentes.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("O que é um ARRAY e como é a sua implementação?");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Array é um conjunto de elementos de um mesmo tipo de dados onde cada elemento do conjunto é acessado pela posição no array que é dada através de um índice (uma sequência de números inteiros). Um arrey de uma dimenssão é conhecido como vetor e um array com mais de uma dimenssão é conhecido como matriz. O uso de arrays é importante em qualquer linguagem de programação, porém é preciso ter atenção ao manusear informações presentes em uma array.");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
