using System;
using System.IO;

class Program
{
    static void Main()
    {   
        Console.WriteLine("\n--------------------------------------------------------------------------------");
        Console.WriteLine("                              GERADOR DE SENHA");
        Console.WriteLine("--------------------------------------------------------------------------------");

        Console.WriteLine("\n             Qual a quantidade de dígitos que você deseja?");

        if (int.TryParse(Console.ReadLine(), out int quantidade_d) && quantidade_d > 0)
        {
            Console.WriteLine("\n                   Incluir números S/N?");
            string numero = Console.ReadLine()?.ToUpper();

            while (numero != "S" && numero != "N")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n                        ERRO! Escolha S ou N.");
                Console.ResetColor();
                Console.WriteLine("\n                   Incluir números S/N?");
                numero = Console.ReadLine()?.ToUpper();
            }
            bool incluirNumeros = numero == "S";

            Console.WriteLine("\n                   Incluir símbolos S/N?");
            string simbolo = Console.ReadLine()?.ToUpper();
            while (simbolo != "S" && simbolo != "N")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n                       ERRO! Escolha S ou N.");
                Console.ResetColor();
            Console.WriteLine("\n                   Incluir símbolos S/N?");
                simbolo = Console.ReadLine()?.ToUpper();
            }
            bool incluirSimbolos = simbolo == "S";

            Console.WriteLine("\n                  Incluir letras maiúsculas S/N?");
            string Letras_ma = Console.ReadLine()?.ToUpper();
            while (Letras_ma != "S" && Letras_ma != "N")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n                       ERRO! Escolha S ou N.");
                Console.ResetColor();
            Console.WriteLine("\n                  Incluir letras maiúsculas S/N?");
                Letras_ma = Console.ReadLine()?.ToUpper();
            }
            bool incluirMaiusculas = Letras_ma == "S";

            Console.WriteLine("\n                  Incluir letras minúsculas S/N?");
            string Letras_mi = Console.ReadLine()?.ToUpper();
            while (Letras_mi != "S" && Letras_mi != "N")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n                       ERRO! Escolha S ou N.");
                Console.ResetColor();
                Console.WriteLine("\n                  Incluir letras minúsculas S/N?");
                Letras_mi = Console.ReadLine()?.ToUpper();
            }
            bool incluirMinusculas = Letras_mi == "S";

            string senha = GerarSenha(quantidade_d, incluirNumeros, incluirSimbolos, incluirMaiusculas, incluirMinusculas);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine($"\n                  Senha gerada: {senha}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n             Entrada inválida! Por favor, insira um número para a quantidade de dígitos.");
            Console.ResetColor();
        }
    }

    static string GerarSenha(int quantidade_d, bool incluirNumeros, bool incluirSimbolos, bool incluirMaiusculas, bool incluirMinusculas)
    {
        string numeros = "0123456789";
        string simbolos = "!@#$%^&*()_+-=[]{}|;:,.<>?";
        string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";

        string conjuntoCaracteres = "";

        if (incluirNumeros)
            conjuntoCaracteres += numeros;
        if (incluirSimbolos)
            conjuntoCaracteres += simbolos;
        if (incluirMaiusculas)
            conjuntoCaracteres += letrasMaiusculas;
        if (incluirMinusculas)
            conjuntoCaracteres += letrasMinusculas;

        if (conjuntoCaracteres.Length == 0)
        {
            return "Erro: Nenhum tipo de caractere selecionado para a senha.";
        }

        Random random = new Random();
        char[] senha = new char[quantidade_d];

        for (int i = 0; i < quantidade_d; i++)
        {
            senha[i] = conjuntoCaracteres[random.Next(conjuntoCaracteres.Length)];
        }

        string senhaFinal = new string(senha);
        using (StreamWriter escrever = new StreamWriter("bkp.txt"))
        {
            escrever.WriteLine(senhaFinal);
        }

        return senhaFinal;
    }
}
