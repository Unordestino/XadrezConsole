using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console {
    class Program {
        static void Main(string[] args) {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.Terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicão();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicão();

                    partida.executaMovimento(origem, destino);
                }

            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
