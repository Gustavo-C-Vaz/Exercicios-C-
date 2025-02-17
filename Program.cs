﻿using System;
namespace Exercicio
{

    class Residente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {

            Residente[] vetor = new Residente[10];

            Console.WriteLine("Digite o número de novos residentes (1 a 10):");
            int n = int.Parse(Console.ReadLine());

            int i = 0;

            while (i != n)
            {

                Console.WriteLine("Cadastro: ");
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o Email: ");
                string email = Console.ReadLine();
                Console.Write("Digite o número do quarto (1 a 10): ");
                int num = int.Parse(Console.ReadLine());

                if (vetor[num] == null)
                {
                    vetor[num] = new Residente { Nome = nome, Email = email };
                }
                else
                {
                    Console.WriteLine("Quarto já ocupado!");
                }

                i++;
            }

            Console.WriteLine("Quartos ocupados: ");

            for (int a = 0; a < 10; a++)
            {

                if (vetor[a] != null)
                {
                    Console.WriteLine("Quarto: " + a);
                    Console.WriteLine("Nome: " + vetor[a].Nome);
                    Console.WriteLine("Email: " + vetor[a].Email);
                }
            }

        }
    }
}
