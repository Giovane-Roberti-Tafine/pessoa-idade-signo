using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PessoaIdadeSigno
{
    class Signo
    {
        // Procurando mexer com interface IReadOnlyList ao inves de List
        private readonly IReadOnlyList<TipoSigno> Signos = new List<TipoSigno>
        {
            new TipoSigno("Aquario", 20, 1, 18, 2, "Agua"),
            new TipoSigno("Peixes", 19, 2, 20, 3, "Agua"),
            new TipoSigno("Aries", 21, 3, 19, 4, "Ar"),
            new TipoSigno("Touro", 20, 4, 20, 5, "Terra"),
            new TipoSigno("Gemeos", 21, 5, 21, 6, "Ar"),
            new TipoSigno("Cancer", 22, 6, 22, 7, "Agua"),
            new TipoSigno("Leao", 23, 7, 22, 8, "Fogo"),
            new TipoSigno("Virgem", 23, 8, 22, 9, "Ar"),
            new TipoSigno("Libra", 23, 9, 22, 10, "Terra"),
            new TipoSigno("Escorpiao", 23, 10, 21, 11, "Agua"),
            new TipoSigno("Sagitario", 22, 11, 21, 12, "Fogo"),
            new TipoSigno("Capricornio", 22, 12, 19, 1, "Agua")
        };


        protected List<TipoSigno> ListaSignos()
        {
            return Signos.ToList();
        }

        protected string NomeSigno(string data)
        {
            if (Funcoes.ValidaData(data))
            {
                string dataConvertida = Funcoes.SomenteNumeros(data);

                int ano = int.Parse(dataConvertida.Substring(4, 4));
                int mes = int.Parse(dataConvertida.Substring(2, 2));
                int dia = int.Parse(dataConvertida.Substring(0, 2));

                TipoSigno signo = Signos.FirstOrDefault(s => (dia >= s.DiaInicio && mes == s.MesInicio) || (dia <= s.DiaFim && mes == s.MesFim));

                return signo.Nome ?? "Não existe um signo para essa data";

            }
            else
            {
                return "Data inválida";
            }

        }

    }
}
