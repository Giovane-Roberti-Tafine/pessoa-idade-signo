namespace PessoaIdadeSigno
{
    struct TipoSigno
    {
        public string Nome { get; set; }
        public int DiaInicio { get; set; }
        public int MesInicio { get; set; }
        public int DiaFim { get; set; }
        public int MesFim { get; set; }
        public string Elemento { get; set; }

        public TipoSigno(string nome, int diaInicio, int mesInicio, int diaFim, int mesFim, string elemento)
        {
            Nome = nome;
            DiaInicio = diaInicio;
            MesInicio = mesInicio;
            DiaFim = diaFim;
            MesFim = mesFim;
            Elemento = elemento;
        }

    }
}
