// See https://aka.ms/new-console-template for more information
using Chess.Domain.Exceptions;

try
{
 PartidaDeXadrez partida = new PartidaDeXadrez();

    

    while (!partida.terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.tab);
        
        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();

        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
        partida.executaMovimento(origem, destino);
    }
    //PosicaoXadrez pos = new('c', 7);
    //Console.WriteLine(pos);
    //Console.WriteLine(pos.ToPosicao());

} catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();
