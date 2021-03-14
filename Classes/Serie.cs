using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
            : base(id, genero, titulo, descricao, ano)
        {
        }
    }
}
