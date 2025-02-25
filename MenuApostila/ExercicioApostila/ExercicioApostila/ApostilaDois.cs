<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace ExercicioApostila
{
    public class ApostilaDois
    {

        private string Marca;

        //O mesmo Exercício da apostila 5 exercício 1 e 2
        public string MarcaCarro
        {
            //Um programa que leia marca
            get { return Marca; }
            set { Marca = value; }
        }
        //valor
        private double Valor;

        public double Valores
        {
            get { return Valor; }
            set { Valor = value; }
        }

        //cor
        private string Cor;

        public string CorCarro
        {
            get { return Cor; }
            set { Cor = value; }
        }
        //modelo
        private string Modelo;

        public string ModeloCarro
        {
            get { return Modelo; }
            set { Modelo = value; }
        }
        //ano
        private int Ano;

        public int AnoCarro
        {
            get { return Ano; }
            set { Ano = value; }
        }
        //Imprima na tela todos os carros pelo maior valor para o menor valor
        public int Acao;
        public int Id;


        public void Mensagem()
        {
            //Um programa que cadastra um carro, exclua o carro e liste os carros do maior valor para o menor valor
            Console.WriteLine("Digite 1 para cadastrar um carro: ");
            Console.WriteLine("Digite 2 para Excluir um carro: ");
            Console.WriteLine("Digite qualquer outro numero para Encerrar: ");
        }

        public static void Executar()
        {
            ApostilaDois carro = new ApostilaDois();
            carro.Mensagem();

            if (int.TryParse(Console.ReadLine(), out carro.Acao))
            {
                //Um programa para listar os carros, ler e excluir
                switch (carro.Acao)
                {
                    case 1:
                        Console.WriteLine("Digite a marca do carro: ");
                        carro.MarcaCarro = Console.ReadLine();
                        Console.WriteLine("Digite o valor do carro: ");
                        if (double.TryParse(Console.ReadLine(), out double valor))
                        {
                            carro.Valores = valor;
                            Console.WriteLine("Digite a cor do carro: ");
                            carro.CorCarro = Console.ReadLine();
                            Console.WriteLine("Digite o modelo do carro: ");
                            carro.ModeloCarro = Console.ReadLine();
                            Console.WriteLine("Digite o ano do carro: ");
                            if (int.TryParse(Console.ReadLine(), out int ano))
                            {
                                carro.AnoCarro = ano;
                                carro.Id = carrosList.Count + 1;
                                carrosList.Add(carro);
                                Console.WriteLine("Carro cadastrado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Ano inválido. O programa será encerrado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. O programa será encerrado.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Digite o ID do carro a ser excluído: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            carro.Id = id;
                            ApostilaDois carroASerExcluido = carrosList.Find(c => c.Id == carro.Id);
                            if (carroASerExcluido != null)
                            {
                                carrosList.Remove(carroASerExcluido);
                                Console.WriteLine($"Carro com ID {carro.Id} excluído com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Carro não encontrado com o ID fornecido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("ID inválido. O programa será encerrado.");
                        }
                        break;
                }
            }
        }



        //Mostrar o resultado na tela
        public static List<ApostilaDois> carrosList = new List<ApostilaDois>();
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace ExercicioApostila
{
    public class ApostilaDois
    {

        private string Marca;

        //O mesmo Exercício da apostila 5 exercício 1 e 2
        public string MarcaCarro
        {
            //Um programa que leia marca
            get { return Marca; }
            set { Marca = value; }
        }
        //valor
        private double Valor;

        public double Valores
        {
            get { return Valor; }
            set { Valor = value; }
        }

        //cor
        private string Cor;

        public string CorCarro
        {
            get { return Cor; }
            set { Cor = value; }
        }
        //modelo
        private string Modelo;

        public string ModeloCarro
        {
            get { return Modelo; }
            set { Modelo = value; }
        }
        //ano
        private int Ano;

        public int AnoCarro
        {
            get { return Ano; }
            set { Ano = value; }
        }
        //Imprima na tela todos os carros pelo maior valor para o menor valor
        public int Acao;
        public int Id;


        public void Mensagem()
        {
            //Um programa que cadastra um carro, exclua o carro e liste os carros do maior valor para o menor valor
            Console.WriteLine("Digite 1 para cadastrar um carro: ");
            Console.WriteLine("Digite 2 para Excluir um carro: ");
            Console.WriteLine("Digite qualquer outro numero para Encerrar: ");
        }

        public static void Executar()
        {
            ApostilaDois carro = new ApostilaDois();
            carro.Mensagem();

            if (int.TryParse(Console.ReadLine(), out carro.Acao))
            {
                //Um programa para listar os carros, ler e excluir
                switch (carro.Acao)
                {
                    case 1:
                        Console.WriteLine("Digite a marca do carro: ");
                        carro.MarcaCarro = Console.ReadLine();
                        Console.WriteLine("Digite o valor do carro: ");
                        if (double.TryParse(Console.ReadLine(), out double valor))
                        {
                            carro.Valores = valor;
                            Console.WriteLine("Digite a cor do carro: ");
                            carro.CorCarro = Console.ReadLine();
                            Console.WriteLine("Digite o modelo do carro: ");
                            carro.ModeloCarro = Console.ReadLine();
                            Console.WriteLine("Digite o ano do carro: ");
                            if (int.TryParse(Console.ReadLine(), out int ano))
                            {
                                carro.AnoCarro = ano;
                                carro.Id = carrosList.Count + 1;
                                carrosList.Add(carro);
                                Console.WriteLine("Carro cadastrado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Ano inválido. O programa será encerrado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. O programa será encerrado.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Digite o ID do carro a ser excluído: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            carro.Id = id;
                            ApostilaDois carroASerExcluido = carrosList.Find(c => c.Id == carro.Id);
                            if (carroASerExcluido != null)
                            {
                                carrosList.Remove(carroASerExcluido);
                                Console.WriteLine($"Carro com ID {carro.Id} excluído com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Carro não encontrado com o ID fornecido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("ID inválido. O programa será encerrado.");
                        }
                        break;
                }
            }
        }



        //Mostrar o resultado na tela
        public static List<ApostilaDois> carrosList = new List<ApostilaDois>();
    }
}
>>>>>>> f8b855ad52e2ed192d9236823c24957c979a0edb
