using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
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
            Console.WriteLine("Listar séries");
            Console.WriteLine("-----------------");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
            }

            foreach (var serie in lista)
            {
                var excluido = serie.RetornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", serie.RetornaId(), serie.RetornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova Série");
            Console.WriteLine("-------------");

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

            Serie serie = new Serie(id: repositorio.ProximoId(), 
                                    genero: (Genero) entradaGenero, 
                                    titulo: entradaTitulo, 
                                    descricao: entradaDescricao, 
                                    ano: entradaAno);
            repositorio.Insere(serie);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o Id da Série: ");
            int idSerie = int.Parse(Console.ReadLine());

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

            Serie serie = new Serie(id: idSerie,
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    descricao: entradaDescricao,
                                    ano: entradaAno);
            repositorio.Atualiza(idSerie, serie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Excluir Série");
            Console.WriteLine("-------------");

            Console.Write("Digite o Id da Série: ");
            int idSerie = int.Parse(Console.ReadLine());

            bool confirmaExclusao = Tela.DesejaExcluir();

            if(confirmaExclusao) repositorio.Exclui(idSerie);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Visualizar Série");
            Console.WriteLine("-------------");

            Console.Write("Digite o Id da Série: ");
            int idSerie = int.Parse(Console.ReadLine());

            Serie serie = repositorio.RetornaPorId(idSerie);
            Console.WriteLine(serie);
        }
    }
}
