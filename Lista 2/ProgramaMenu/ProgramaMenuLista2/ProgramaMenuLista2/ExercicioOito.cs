using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMenuLista2
{
    public class ExercicioOito
    {
        public static void Executar()
        {
            //Declarando a variavel
            double RaioLata, AlturaLata, VolumeLata;

            //Calculando o volume da lata de óleo
            Console.WriteLine("Digite o diâmetro da lata (em cm): ");
            RaioLata = double.Parse(Console.ReadLine()) / 2;

            Console.WriteLine("Digite a altura da lata (em cm): ");
            AlturaLata = double.Parse(Console.ReadLine());

            //Fórmula
            VolumeLata = Math.PI * RaioLata * RaioLata * AlturaLata;

            //Mostrar o resultado na tela
            Console.WriteLine("O volume da lata é de: " + VolumeLata + "cm³");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
