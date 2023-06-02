// See https://aka.ms/new-console-template for more information
using Chess.Domain.Exceptions;

try
{
    //Tabuleiro tab = new(8, 8);

    //tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
    //tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 7));
    //tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 2));
    //Tela.ImprimirTabuleiro(tab);

    PosicaoXadrez pos = new('c', 7);
    Console.WriteLine(pos);
    Console.WriteLine(pos.ToPosicao());

} catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();
