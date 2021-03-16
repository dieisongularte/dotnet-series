using System;
using System.Globalization;

namespace DIO.Series
{
    class Filme : EntidadeBase
    {
        protected float Nota { get; set; }

        public Filme(int id, Tipo tipo, Genero genero, string titulo, string descricao, int ano, float nota) 
            : base(id, tipo, genero, titulo, descricao, ano)
        {
            Nota = nota;
        }

        public override string ToString()
        {
            return base.ToString() + "Nota: " + Nota.ToString(CultureInfo.InvariantCulture);
        }
    }
}
