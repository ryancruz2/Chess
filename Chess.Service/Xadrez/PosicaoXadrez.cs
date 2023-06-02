namespace Chess.Service.Xadrez;
public class PosicaoXadrez
{
    public PosicaoXadrez(char coluna, int linha)
    {
        this.coluna = coluna;
        this.linha = linha;
    }

    public char coluna { get;set; }
    public int linha { get;set; }

    public Posicao ToPosicao() => new(8 - linha, coluna - 'a');
    public override string ToString() => $"{coluna.ToString().ToUpper()}{linha}";
}
