using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    class Filme : EntidadeBase
    {
        protected float Nota { get; set; }

        public Filme(int id, Genero genero, string titulo, string descricao, int ano, float nota) 
            : base(id, genero, titulo, descricao, ano)
        {
            Nota = nota;
        }

        public override string ToString()
        {
            return base.ToString() + "Nota: " + Nota;
        }
    }
}
