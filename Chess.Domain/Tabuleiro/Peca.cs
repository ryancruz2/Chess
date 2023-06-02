﻿namespace Chess.Domain.Tabuleiro;
public class Peca
{
    public Posicao? posicao { get; set; }
    public Cor cor { get; protected set; }
    public int qteMovimentos { get; set; }
    public Tabuleiro tab { get; set; }

    public Peca(Cor cor, Tabuleiro tab)
    {
        this.posicao = null;
        this.cor = cor;
        this.tab = tab;
        this.qteMovimentos = 0;
    }

    public void incrementarQteMovimentos() => qteMovimentos++;
}
