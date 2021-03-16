using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    public abstract class EntidadeBase
    {
        protected int Id { get; set; }
        protected Tipo Tipo { get; set; }
        protected Genero Genero { get; set; }
        protected string Titulo { get; set; }
        protected string Descricao { get; set; }
        protected int Ano { get; set; }
        protected bool Excluido { get; set; }

        public EntidadeBase(int id, Tipo tipo, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Tipo = tipo;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public string InfoAbrev()
        {
            return $"#ID {Id}: {Titulo} {(Excluido ? "- *Excluído*" : "")}";
        }

        public void Excluir()
        {
            Excluido = true;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Título: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de Início : " + Ano + Environment.NewLine;
            retorno += "Tipo: " + Tipo + Environment.NewLine;
            retorno += "Excluido: " + Excluido + Environment.NewLine;
            return retorno;
        }
    }
}
