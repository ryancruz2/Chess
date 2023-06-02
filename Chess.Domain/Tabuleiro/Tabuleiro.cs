global using Chess.Domain.Exceptions;

namespace Chess.Domain.Tabuleiro;
public class Tabuleiro
{
    public int linhas { get; set; }
    public int colunas { get; set; }
    private Peca?[,] pecas;

    public Tabuleiro(int linha, int colunas)
    {
        this.linhas = linha;
        this.colunas = colunas;
        pecas = new Peca[linha, colunas];
    }

    public Peca? peca(Posicao pos) => pecas[pos.line, pos.column];
    public Peca? peca(int linha, int colunas) => pecas[linha, colunas]!;
    public bool posicaoValida(Posicao pos) => !(pos.line < 0 || pos.line >= this.linhas || pos.column < 0 || pos.column >= this.colunas);
    
    public Peca? retirarPeca(Posicao pos)
    {
        if (peca(pos) == null)
            return null;

        Peca aux = peca(pos);
        aux.posicao = null;
        pecas[pos.line, pos.column] = null;
        return aux;
    }
    public bool existePeca(Posicao pos)
    {
        validarPosicao(pos);
        return peca(pos) != null;
    }
    public void validarPosicao(Posicao pos)
    {
        if (!posicaoValida(pos))
            throw new TabuleiroException("Posição Invalida");
    }

    public void colocarPeca(Peca p, Posicao pos)
    {
        if (existePeca(pos))
            throw new TabuleiroException("Já existe uma peça nessa posição");

        pecas[pos.line, pos.column] = p;
        p.posicao = pos;
    }
}
