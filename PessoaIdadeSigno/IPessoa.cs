using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaIdadeSigno
{
    interface IPessoa
    {
        string DataNascimento { get; set; }
        string Nome { get; set; }

        string CalculaIdade();
    }
}
