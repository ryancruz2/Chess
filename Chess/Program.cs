// See https://aka.ms/new-console-template for more information
Tabuleiro tab = new(8,8);

tab.colocarPeca(new Torre(tab, Cor.Branca),new Posicao(0, 0));
tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 7));
tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 3));
Tela.ImprimirTabuleiro(tab);
Console.ReadLine();



