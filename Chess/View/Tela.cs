namespace Chess.View;
class Tela
{
    public static void ImprimirTabuleiro(Tabuleiro tab)
    {
        for (int i = 0; i < tab.linhas; i++)
        {
            Console.Write($"{8 - i} ");
            for (int j = 0; j < tab.colunas; j++)
            {
                if (tab.peca(i, j) is null)
                    Console.Write("- ");
                else
                    ImprimirPeca(tab.peca(i, j));

            }
            Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h ");
    }

    public static void ImprimirPeca(Peca peca)
    {
        switch (peca.cor)
        {
            case Cor.Branca:
                Console.Write($"{peca} ");
                break;
            case Cor.Preta:
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{peca} ");
                    Console.ForegroundColor = aux;
                    break;
                }
            default:
                Console.Write($"{peca} ");
                break;
        }

    }
}
