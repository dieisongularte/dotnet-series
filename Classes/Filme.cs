using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    class Filme : EntidadeBase
    {
        public Filme(int id, Genero genero, string titulo, string descricao, int ano, float nota)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Nota = nota;
            Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Título: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + Ano + Environment.NewLine;
            retorno += "Nota: " + Nota + Environment.NewLine;
            retorno += "Excluido: " + Excluido;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }

        public int RetornaId()
        {
            return Id;
        }

        public bool RetornaExcluido()
        {
            return Excluido;
        }

        public void Excluir()
        {
            Excluido = true;
        }
    }
}
