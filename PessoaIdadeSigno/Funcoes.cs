using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaIdadeSigno
{
    class Funcoes
    {
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
    }
}
