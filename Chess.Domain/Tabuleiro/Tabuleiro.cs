namespace Chess.Domain.Tabuleiro;
public class Tabuleiro
{
    public int linhas { get; set; }
    public int colunas { get; set; }
    private Peca[,] pecas;

    public Tabuleiro(int linha, int colunas)
    {
        this.linhas = linha;
        this.colunas = colunas;
        pecas = new Peca[linha,colunas];
    }

    public void colocarPeca(Peca p, Posicao pos )
    {
        pecas[pos.line,pos.column] = p;
    }
    public Peca peca(int linha, int colunas)
    {
        return pecas[linha, colunas];
    }
}
