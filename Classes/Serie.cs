using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        public Serie(int id, Tipo tipo, Genero genero, string titulo, string descricao, int ano)
            : base(id, tipo, genero, titulo, descricao, ano)
        {
        }
    }
}
