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
                        ListarSerie();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
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

        private static void ListarSerie()
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

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir");
            Console.WriteLine("-------------");

            foreach (int j in Enum.GetValues(typeof(Tipo)))
            {
                Console.WriteLine("{0}-{1}", j, Enum.GetName(typeof(Tipo), j));
            }

            Console.Write("Digite o tipo entre as opções acima: ");
            int entradaTipo = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Título: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição: ");
            string entradaDescricao = Console.ReadLine();

            if (entradaTipo == 1)
            {
                Console.Write("Digite a nota: ");
                float entradaNota = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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

        private static void AtualizarSerie()
        {
            Console.Write("Digite o Id da Série: ");
            int idSerie = int.Parse(Console.ReadLine());

            foreach (int j in Enum.GetValues(typeof(Tipo)))
            {
                Console.WriteLine("{0}-{1}", j, Enum.GetName(typeof(Tipo), j));
            }

            Console.Write("Digite o tipo entre as opções acima: ");
            int entradaTipo = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            if (entradaTipo == 1)
            {
                Console.Write("Digite a nota: ");
                float entradaNota = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Filme filme = new Filme(id: idSerie,
                                        tipo: (Tipo)entradaTipo,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno,
                                        nota: entradaNota);
                baseRepositorio.Atualiza(idSerie, filme);
            }
            else
            {
                Serie serie = new Serie(id: idSerie,
                                        tipo: (Tipo)entradaTipo,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);
                baseRepositorio.Atualiza(idSerie, serie);
            }
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Excluir Série");
            Console.WriteLine("-------------");

            Console.Write("Digite o Id da Série: ");
            int idSerie = int.Parse(Console.ReadLine());

            bool confirmaExclusao = Tela.DesejaExcluir();

            if(confirmaExclusao) baseRepositorio.Exclui(idSerie);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Visualizar Série");
            Console.WriteLine("-------------");

            Console.Write("Digite o Id da Série: ");
            int idSerie = int.Parse(Console.ReadLine());

            EntidadeBase entidadeBase = baseRepositorio.RetornaPorId(idSerie);
            Console.WriteLine(entidadeBase);
        }
    }
}
