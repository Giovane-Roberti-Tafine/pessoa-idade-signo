using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PessoaIdadeSigno
{
    class Pessoa : Signo
    {
        public string DataNascimento { get; set; }
        public string Nome { get; set; }

        private static StringBuilder str = new StringBuilder();

        public static bool ValidaData(string data)
        {
            CultureInfo culture;
            DateTimeStyles styles;
            DateTime dateResult;

            //Regex regex = new Regex(@"^([0-9]{2})[-./]?([0-9]{2})[-./]?([0-9]{4})$");

            culture = CultureInfo.CreateSpecificCulture("pt-BR");
            styles = DateTimeStyles.AssumeLocal;

            string dataConvertida;
            //dataConvertida = string.Join("", Regex.Split(data, @"[^\d]"));
            //dataConvertida = new string(data.Where(Char.IsDigit).ToArray());
            str.Clear();
            dataConvertida = str.Append(data.Where(Char.IsDigit).ToArray()).ToString();

            int ano = int.Parse(dataConvertida.Substring(4, 4));
            int mes = int.Parse(dataConvertida.Substring(2, 2));
            int dia = int.Parse(dataConvertida.Substring(0, 2));
            if (DateTime.TryParse($"{dia}/{mes}/{ano}", culture, styles, out dateResult))
                return true;
            else
                return false;

        }

        public string CalculaIdade()
        {
            if (!ValidaData(DataNascimento)) return "Data inválida";

            //var apenasNumeros = new Regex(@"[^\d]");
            //string dataConvertida = apenasNumeros.Replace(DataNascimento, "");
            str.Clear();
            string dataConvertida = str.Append(DataNascimento.Where(Char.IsDigit).ToArray()).ToString();

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

        public string NomeSigno()
        {
            return NomeSigno(this.DataNascimento);
        }
    }
}
