using System; // Necessário para Console e ConsoleColor

class Program
{
    static void Main(string[] args)
    {
        EscolherOpcao();
    }

    static void EscolherOpcao()
    {
        // blabla bla
        bool OpcaoValida = false;
        string opcaoEmTexto;
        int numeroOpcao = 0;

        while (!OpcaoValida)
        {
            Console.WriteLine("Digite somente o numero da opção que deseja: \n");
            Console.WriteLine("1- Criptografar \n 2-Traduzir \n 3- Sair");
            opcaoEmTexto = Console.ReadLine() ?? "";

            // ERRO CORRIGIDO: Removido o [0], pois TryParse precisa da string completa.
            if (int.TryParse(opcaoEmTexto, out int opcaoEscolhida))
            {
                if (opcaoEscolhida == 1 || opcaoEscolhida == 2 || opcaoEscolhida == 3)
                {
                    OpcaoValida = true;
                    numeroOpcao = opcaoEscolhida;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro: Por Favor digite dentro das opções possiveis");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Por Favor digite somente numeros");
                Console.ResetColor();
            }
        }

        switch (numeroOpcao)
        {
            case 1:
                InterfaceDeCriptografia();
                break;
            case 2:
                InterfaceDeDescriptografia();
                break;
            case 3:
                return;
        }
    }

    static void InterfaceDeCriptografia()
    {
        string mensagem = "";
        Console.WriteLine("Escreva a mensagem a ser traduzida");
        mensagem = Console.ReadLine() ?? "";
        
  
        Program p = new Program(); 
        Console.WriteLine($"A tradução é \n" + p.TraducaoCriptografada(mensagem));
    }

    static void InterfaceDeDescriptografia()
    {
        string mensagem = "";
        Console.WriteLine("Escreva a mensagem a ser traduzida");
        mensagem = Console.ReadLine() ?? "";
        

        Program p = new Program();
        Console.WriteLine($"A tradução é \n" + p.TraducaoCriptografada(mensagem));
    }

    /// <summary>
    /// Função que criptografa a menssagem
    /// </summary>
    /// <param name="MensagemACriptografar">Menssagem a ser criptografar</param>
    /// <returns>A menssagem criptografia</returns>
    string TraducaoCriptografada(string MensagemACriptografar)
    {
        char[] caracteresCriptografados = new char[MensagemACriptografar.Length];

        for (int i = 0; i < MensagemACriptografar.Length; i++)
        {
            caracteresCriptografados[i] = TextoParaCriptografia(MensagemACriptografar[i]);
        }
        return new string(caracteresCriptografados);
    }

    // Método de instância (não estático)
    char TextoParaCriptografia(char CaractereASerCriptografado)
    {
        switch (CaractereASerCriptografado)
        {
            case 'q' or 'Q': 
                return '+';

            case 'w' or 'W':
                return '×';

            case 'e' or 'E':
                return '÷';

            case 'r' or 'R':
                return '=';

            case 't' or 'T':
                return '/';

            case 'y' or 'Y':
                return '_';

            case 'u' or 'U':
                return '<';

            case 'i' or 'I':
                return '>';

            case 'o' or 'O':
                return '[';

            case 'p' or 'P':
                return ']';

            case 'a' or 'A':
                return '@';

            case 's' or 'S':
                return '#';

            case 'd' or 'D':
                return '$';

            case 'f' or 'F':
                return '%';

            case 'g' or 'G':
                return '^';

            case 'h' or 'H':
                return '&';

            case 'j' or 'J':
                return '*';

            case 'k' or 'K':
                return '(';

            case 'l' or 'L':
                return ')';

            case 'z' or 'Z':
                return '-';

            case 'x' or 'X':
                return '\'';

            case 'c' or 'C':
                return '"';

            case 'v' or 'V':
                return ':';

            case 'b' or 'B':
                return ';';

            case 'n' or 'N':
                return ',';

            case 'm' or 'M':
                return '?';

            default:
                return CaractereASerCriptografado;
        }
    }
}