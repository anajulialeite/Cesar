namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Qual é o seu nome? ");
            string namePerson = Console.ReadLine();

            Console.Write("Qual é a sua idade: ");
            int age = Convert. ToInt32 (Console.ReadLine());
            Console.WriteLine("Meu nome é: " + namePerson + " e minha idade é: " + age);
        }
    }
}
