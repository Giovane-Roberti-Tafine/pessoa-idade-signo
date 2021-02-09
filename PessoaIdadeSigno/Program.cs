using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaIdadeSigno
{
    class Program
    {
        // Em POO sempre procura trabalhar com abstração como a inteface ao inves de classe
        // Liguagem intermediaria que a plataforma .Net transforma o código se chama JIT 
        static void Main(string[] args)
        {
            int quantidadePessoa;
            List<Pessoa> pessoas = new List<Pessoa>();

            Console.WriteLine("Hello World");

            Console.WriteLine("Digite a quantidade de Pessoas");
            quantidadePessoa = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= quantidadePessoa)
            {
                Pessoa pessoa = new Pessoa();
                Console.WriteLine("Digite o nome da " + i + " pessoa");
                pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Digite a data de Nascimento");
                pessoa.DataNascimento = Console.ReadLine();

                while (!Funcoes.ValidaData(pessoa.DataNascimento))
                {
                    Console.WriteLine("Data incorreta");
                    Console.WriteLine("Irá tentar novamente S/N?");
                    string resposta = Console.ReadLine().ToLower();
                    if (resposta != "s") break;

                    Console.WriteLine("Digite a data de Nascimento");
                    pessoa.DataNascimento = Console.ReadLine();

                }

                if (Funcoes.ValidaData(pessoa.DataNascimento))
                {
                    Console.WriteLine("Pessoa Salva");
                    pessoas.Add(pessoa);
                }
                else
                {
                    Console.WriteLine("Pessoa não Salva");
                }

                i += 1;
            }

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine("A pessoa " + p.Nome);
                Console.WriteLine("Tem: " + p.CalculaIdade());
                Console.WriteLine("Signo da pessoa: " + p.NomeSigno());
            }

            Console.ReadKey();
        }
    }
}
