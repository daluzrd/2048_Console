using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Console
{
    public class Game
    {
        Celula[,] matriz;
        Comandos comandos;
        Impressão impressão;
        Random rnd;
        int[] valoresInseridos;
        int score;

        public Game()
        {
            matriz = new Celula[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = new Celula();
                }
            }

            valoresInseridos = new int[4] { 2, 2, 2, 4 };
            score = 0;

            impressão = new Impressão();
            comandos = new Comandos();
            rnd = new Random();
            InsereNumeros();
            InsereNumeros();
        }

        public int QtdCelulasVazias()
        {
            int qtd = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j].isEmpty)
                        qtd++;
                }
            }

            return qtd;
        }

        public void InsereNumeros()
        {
            int qtdCelulasVazias = 0;
            int pos = 0;
            int count;

            qtdCelulasVazias = QtdCelulasVazias();

            if (qtdCelulasVazias > 0)
            {
                pos = rnd.Next(1, qtdCelulasVazias);
                count = 0;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (matriz[i, j].isEmpty)
                        {
                            count++;
                            if (pos == count)
                            {
                                matriz[i, j].valor = valoresInseridos[rnd.Next(0, 3)];
                                matriz[i, j].isEmpty = false;
                                i = j = 4;
                            }
                        }
                    }
                }
            }
        }

        public void ImprimeMatriz()
        {
            impressão.ImprimeMatriz(matriz, score);
        }

        public bool Inputs(ConsoleKey ck)
        {
            if (ck == ConsoleKey.LeftArrow)
            {
                return comandos.Esquerda(matriz, ref score);
            }
            else if (ck == ConsoleKey.RightArrow)
            {
                return comandos.Direita(matriz, ref score);
            }
            else if (ck == ConsoleKey.UpArrow)
            {
                return comandos.Cima(matriz, ref score);
            }
            else if (ck == ConsoleKey.DownArrow)
            {
                return comandos.Baixo(matriz, ref score);
            }
            else if (ck == ConsoleKey.Enter)
            {
                return true;
            }
            else if (ck == ConsoleKey.Escape)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
