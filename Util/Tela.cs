using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    public static class Tela
    {
        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine("");
            Console.WriteLine("DIO Séries/Filmes a seu dispor.");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Inserir");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("5 - Visualizar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        public static int GetId()
        {
            Console.Write("Digite o Id da Série ou Filme: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public static int GetTipo()
        {
            foreach (int j in Enum.GetValues(typeof(Tipo)))
            {
                Console.WriteLine("{0}-{1}", j, Enum.GetName(typeof(Tipo), j));
            }

            Console.Write("Digite o tipo entre as opções acima: ");
            return int.Parse(Console.ReadLine());
        }

        public static int GetGenero()
        {
            Console.WriteLine();
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            return int.Parse(Console.ReadLine());
        }

        public static string GetTitulo()
        {
            Console.Write("Digite o Título: ");
            return Console.ReadLine();
        }

        public static string GetDescricao()
        {
            Console.Write("Digite a Descrição: ");
            return Console.ReadLine();
        }

        public static int GetAno()
        {
            Console.Write("Digite o Ano de Início: ");
            return int.Parse(Console.ReadLine());
        }

        public static float GetNota()
        {
            Console.Write("Digite a nota: ");
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static bool DesejaExcluir()
        {
            Console.Write("Tem certeza que deseja excluir? Y/N: ");
            string opc = Console.ReadLine().ToUpper();
            if (opc != "Y" && opc != "N")
            {
                while (opc != "Y" && opc != "N")
                {
                    Console.Beep();
                    Console.Write("Opção inválida escolha Y/N: ");
                    opc = Console.ReadLine().ToUpper();
                }
            }
            return opc == "Y" ? true : false;
        }
    }
}
