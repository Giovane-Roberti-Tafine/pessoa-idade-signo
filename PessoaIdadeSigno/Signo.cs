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
		protected string Nome { get; set; }
		protected int DiaInicio { get; set; }
		protected int MesInicio { get; set; }
		protected int DiaFim { get; set; }
		protected int MesFim { get; set; }
		protected string Elemento { get; set; }


		public Signo(string nome, int diaInicio, int mesInicio, int diaFim, int mesFim, string elemento)
		{
			Nome = nome;
			DiaInicio = diaInicio;
			MesInicio = mesInicio;
			DiaFim = diaFim;
			MesFim = mesFim;
			Elemento = elemento;

		}

		public static List<Signo> ListaSignos()
		{
			List<Signo> signos = new List<Signo>();

			signos.Add(new Signo("Aquario", 20, 1, 18, 2, "Agua"));
			signos.Add(new Signo("Peixes", 19, 2, 20, 3, "Agua"));
			signos.Add(new Signo("Aries", 21, 3, 19, 4, "Ar"));
			signos.Add(new Signo("Touro", 20, 4, 20, 5, "Terra"));
			signos.Add(new Signo("Gemeos", 21, 5, 21, 6, "Ar"));
			signos.Add(new Signo("Cancer", 22, 6, 22, 7, "Agua"));
			signos.Add(new Signo("Leao", 23, 7, 22, 8, "Fogo"));
			signos.Add(new Signo("Virgem", 23, 8, 22, 9, "Ar"));
			signos.Add(new Signo("Libra", 23, 9, 22, 10, "Terra"));
			signos.Add(new Signo("Escorpiao", 23, 10, 21, 11, "Agua"));
			signos.Add(new Signo("Sagitario", 22, 11, 21, 12, "Fogo"));
			signos.Add(new Signo("Capricornio", 22, 12, 19, 1, "Agua"));

			// signos[0] = new { diaInicio = 20, mesInicio = 1, diaFim = 18, mesFim = 2, nome = "Aquario"};
			// signos[1] = { diaInicio = 19, mesInicio = 2, diaFim = 20, mesFim = 3, nome = "Peixes"};
			// signos[2] = { diaInicio = 21, mesInicio = 3, diaFim = 19, mesFim = 4, nome = "Aries"};    
			// signos[3] = { diaInicio = 20, mesInicio = 4, diaFim = 20, mesFim = 5, nome = "Touro"};
			// signos[4] = { diaInicio = 21, mesInicio = 5, diaFim = 21, mesFim = 6, nome = "Gemeos"};
			// signos[5] = { diaInicio = 22, mesInicio = 6, diaFim = 22, mesFim = 7, nome = "Cancer"};
			// signos[6] = { diaInicio = 23, mesInicio = 7, diaFim = 22, mesFim = 8, nome = "Leao"};
			// signos[7] = { diaInicio = 23, mesInicio = 8, diaFim = 22, mesFim = 9, nome = "Virgem"};
			// signos[8] = { diaInicio = 23, mesInicio = 9, diaFim = 22, mesFim = 10, nome = "Libra"};
			// signos[9] = { diaInicio = 23, mesInicio = 10, diaFim = 21, mesFim = 11, nome = "Escorpiao"};
			// signos[10] = { diaInicio = 22, mesInicio = 11,diaFim = 21, mesFim = 12, nome = "Sagitario"};
			// signos[11] = { diaInicio = 22, mesInicio = 12,diaFim = 19, mesFim = 1, nome = "Capricornio"};

			return signos;
		}

		public static string NomeSigno(string data)
		{
			if (Pessoa.validaData(data))
            {
                var apenasNumeros = new Regex(@"[^\d]");
                string dataConvertida = apenasNumeros.Replace(data, "");

                int ano = int.Parse(dataConvertida.Substring(4, 4));
                int mes = int.Parse(dataConvertida.Substring(2, 2));
                int dia = int.Parse(dataConvertida.Substring(0, 2));

                Signo signo = ListaSignos().Find(s => (dia >= s.DiaInicio && mes == s.MesInicio) || (dia <= s.DiaFim && mes == s.MesFim));

                return signo.Nome;

            } 
			else
            {
				return "Data inválida";
            }

		}

		// var signos = Array {
		// 	{ diaInicio = 20, mesInicio = 1, diaFim = 18, mesFim = 2, nome = "Aquario"},
		// 	{ diaInicio = 19, mesInicio = 2, diaFim = 20, mesFim = 3, nome = "Peixes"},
		// };


		// {
		// 	new { diaInicio = 20, mesInicio = 1, diaFim = 18, mesFim = 2, nome = "Aquario"},
		// 	new { diaInicio = 19, mesInicio = 2, diaFim = 20, mesFim = 3, nome = "Peixes"},
		// };

		
	}
}
