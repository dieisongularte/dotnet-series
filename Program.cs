using System;
using System.Globalization;

namespace DIO.Series
{
    class Program
    {
        static EntidadeBaseRepositorio baseRepositorio = new EntidadeBaseRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = Tela.ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Listar();
                        break;
                    case "2":
                        Inserir();
                        break;
                    case "3":
                        Atualizar();
                        break;
                    case "4":
                        Excluir();
                        break;
                    case "5":
                        Visualizar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = Tela.ObterOpcaoUsuario();
            }
        }

        private static void Listar()
        {
            Console.WriteLine("Listar");
            Console.WriteLine("-----------------");

            var lista = baseRepositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série/filme cadastrada");
            }

            foreach (var item in lista)
            {
                Console.WriteLine(item.InfoAbrev());
            }
        }

        private static void Inserir()
        {
            Console.WriteLine("Inserir");
            Console.WriteLine("-------------");

            int entradaTipo = Tela.GetTipo();
            int entradaGenero = Tela.GetGenero();
            string entradaTitulo = Tela.GetTitulo();
            int entradaAno = Tela.GetAno();
            string entradaDescricao = Tela.GetDescricao();

            if (entradaTipo == 1)
            {
                float entradaNota = Tela.GetNota();

                Filme filme = new Filme(id: baseRepositorio.ProximoId(),
                                        tipo: (Tipo)entradaTipo,
                                        genero: (Genero)entradaGenero, 
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno,
                                        nota: entradaNota);
                baseRepositorio.Insere(filme);
            }
            else
            {
                Serie serie = new Serie(id: baseRepositorio.ProximoId(),
                                        tipo: (Tipo) entradaTipo,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);
                baseRepositorio.Insere(serie);
            }
        }

        private static void Atualizar()
        {
            int id = Tela.GetId();
            int entradaTipo = Tela.GetTipo();
            int entradaGenero = Tela.GetGenero();
            string entradaTitulo = Tela.GetTitulo();
            int entradaAno = Tela.GetAno();
            string entradaDescricao = Tela.GetDescricao();

            if (entradaTipo == 1)
            {
                float entradaNota = Tela.GetNota();

                Filme filme = new Filme(id: id,
                                        tipo: (Tipo)entradaTipo,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno,
                                        nota: entradaNota);
                baseRepositorio.Atualiza(id, filme);
            }
            else
            {
                Serie serie = new Serie(id: id,
                                        tipo: (Tipo)entradaTipo,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);
                baseRepositorio.Atualiza(id, serie);
            }
        }

        private static void Excluir()
        {
            Console.WriteLine("Excluir");
            Console.WriteLine("-------------");

            int id = Tela.GetId();
            bool confirmaExclusao = Tela.DesejaExcluir();
            if(confirmaExclusao) baseRepositorio.Exclui(id);
        }

        private static void Visualizar()
        {
            Console.WriteLine("Visualizar");
            Console.WriteLine("-------------");

            int id = Tela.GetId();
            EntidadeBase entidadeBase = baseRepositorio.RetornaPorId(id);
            Console.WriteLine("-------------");
            Console.WriteLine(entidadeBase);
        }
    }
}
