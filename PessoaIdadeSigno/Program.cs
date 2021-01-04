using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaIdadeSigno
{
    class Program
    {
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
                pessoa.Name = Console.ReadLine();

                Console.WriteLine("Digite a data de Nascimento");
                pessoa.DataNascimento = Console.ReadLine();

                while (!Pessoa.validaData(pessoa.DataNascimento))
                {
                    Console.WriteLine("Data incorreta");
                    Console.WriteLine("Irá tentar novamente S/N?");
                    string resposta = Console.ReadLine().ToLower();
                    if (resposta != "s") break;

                    Console.WriteLine("Digite a data de Nascimento");
                    pessoa.DataNascimento = Console.ReadLine();

                }

                if (Pessoa.validaData(pessoa.DataNascimento))
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
                Console.WriteLine("A pessoa " + p.Name);
                Console.WriteLine("Tem: " + p.calculaIdade(p.DataNascimento));
                Console.WriteLine("Signo da pessoa: " + Signo.NomeSigno(p.DataNascimento));
            }

            Console.ReadKey();
        }
    }
}
