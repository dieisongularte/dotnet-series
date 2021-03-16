using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    public static class Tela
    {
        public static int FilmeOrSerie()
        {
            Console.WriteLine("DIO Séries/Filmes a seu dispor.");
            Console.WriteLine("Escolha o sistema abaixo");
            Console.Write("1-Filme ## 2-Serie: ");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao != 1 && opcao != 2)
            {
                while (opcao != 1 && opcao != 2)
                {
                    Console.Beep();
                    Console.WriteLine("Opção Inválida");
                    Console.Write("1-Filme ## 2-Serie: ");
                    opcao = int.Parse(Console.ReadLine());
                }
            }
            return opcao;
        }

        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine("");
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
