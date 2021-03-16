using System;
using DIO.Series.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    class EntidadeBaseRepositorio : IRepositorio<EntidadeBase>
    {
        private List<EntidadeBase> lista = new List<EntidadeBase>();
        public void Atualiza(int id, EntidadeBase entidade)
        {
            lista[id] = entidade;
        }

        public void Exclui(int id)
        {
            lista[id].Excluir();
        }

        public void Insere(EntidadeBase entidade)
        {
            lista.Add(entidade);
        }

        public List<EntidadeBase> Lista()
        {
            return lista;
        }

        public int ProximoId()
        {
            return lista.Count;
        }

        public EntidadeBase RetornaPorId(int id)
        {
            return lista[id];
        }
    }
}
