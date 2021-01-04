using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PessoaIdadeSigno
{
    class Pessoa
    {
        public string DataNascimento { get; set; }
        public string Name { get; set; }

        public static bool validaData(string data)
        {
            Regex regex = new Regex(@"^([0-9]{2})[-./]?([0-9]{2})[-./]?([0-9]{4})$");

            return regex.IsMatch(data) ? true : false;
        }

        public string calculaIdade(string data)
        {
            if (!validaData(data)) return "Data inválida";

            var apenasNumeros = new Regex(@"[^\d]");
            string dataConvertida = apenasNumeros.Replace(data, "");

            DateTime dateAtual = DateTime.Now;
            int ano = int.Parse(dataConvertida.Substring(4, 4));
            int mes = int.Parse(dataConvertida.Substring(2, 2));
            int dia = int.Parse(dataConvertida.Substring(0, 2));

            if (ano <= dateAtual.Year)
            {
                if (dia == dateAtual.Day && mes == dateAtual.Month && ano == dateAtual.Year)
                {
                    return "Parece que nasceu hoje";
                }

                if (mes == dateAtual.Month && dia == dateAtual.Day)
                {
                    return "Parabéns, seu aniversário é hoje, você faz " + (dateAtual.Year - ano) + " anos";
                }

                if (mes > dateAtual.Month || (mes == dateAtual.Month && dia > dateAtual.Day))
                {
                    return (dateAtual.Year - ano - 1) + " anos";
                }
                else
                {
                    return (dateAtual.Year - ano) + " anos";
                }
            }

            return "Data não Calculável";
        }
    }
}
