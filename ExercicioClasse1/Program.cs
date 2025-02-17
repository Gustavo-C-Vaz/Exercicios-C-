using System;
namespace Exercicios
{

    class Pessoa
    {
        public string Nome;
        public int Idade;
    }

    class Princial
    {

        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Digite seus dados:");
            Console.Write("nome:");
            p1.Nome = Console.ReadLine();
            Console.Write("idade:");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os dados da outra pessoa:");
            Console.Write("nome:");
            p2.Nome = Console.ReadLine();
            Console.Write("idade:");
            p2.Idade = int.Parse(Console.ReadLine());


            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine(" Pessoa mais velha:" + p1.Nome);
            }
            else
            {
                Console.WriteLine(" Pessoa mais velha:" + p2.Nome);
            }
        }
    }
}
