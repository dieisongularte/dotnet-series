using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    public static class Tela
    {
        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine("");
            Console.WriteLine("DIO Séries a seu dispor.");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
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
