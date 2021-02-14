using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Console
{
    public class Impressão
    {
        public void ImprimeMatriz(Celula[,] matriz, int score)
        {
            Console.Clear();
            Console.WriteLine("SCORE: {0}\n\n", score);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("+--------+--------+--------+--------+");
                Console.WriteLine("|        |        |        |        |");
                if (matriz[i, 0].valor < 10)
                {
                    Console.Write("|      {0} |", matriz[i, 0].valor != 0 ? matriz[i, 0].valor.ToString() : " ");
                }
                else if (matriz[i, 0].valor < 100)
                {
                    Console.Write("|     {0} |", matriz[i, 0].valor);
                }
                else if (matriz[i, 0].valor < 1000)
                {
                    Console.Write("|    {0} |", matriz[i, 0].valor);
                }
                else if (matriz[i, 0].valor < 10000)
                {
                    Console.Write("|   {0} |", matriz[i, 0].valor);
                }
                else
                {
                    Console.Write("|  {0} |", matriz[i, 0].valor);
                }
                if (matriz[i, 1].valor < 10)
                {
                    Console.Write("      {0} |", matriz[i, 1].valor != 0 ? matriz[i, 1].valor.ToString() : " ");
                }
                else if (matriz[i, 1].valor < 100)
                {
                    Console.Write("     {0} |", matriz[i, 1].valor);
                }
                else if (matriz[i, 1].valor < 1000)
                {
                    Console.Write("    {0} |", matriz[i, 1].valor);
                }
                else if (matriz[i, 1].valor < 10000)
                {
                    Console.Write("   {0} |", matriz[i, 1].valor);
                }
                else
                {
                    Console.Write("  {0} |", matriz[i, 1].valor);
                }
                if (matriz[i, 2].valor < 10)
                {
                    Console.Write("      {0} |", matriz[i, 2].valor != 0 ? matriz[i, 2].valor.ToString() : " ");
                }
                else if (matriz[i, 2].valor < 100)
                {
                    Console.Write("     {0} |", matriz[i, 2].valor);
                }
                else if (matriz[i, 2].valor < 1000)
                {
                    Console.Write("    {0} |", matriz[i, 2].valor);
                }
                else if (matriz[i, 2].valor < 10000)
                {
                    Console.Write("   {0} |", matriz[i, 2].valor);
                }
                else
                {
                    Console.Write("  {0} |", matriz[i, 2].valor);
                }
                if (matriz[i, 3].valor < 10)
                {
                    Console.Write("      {0} |", matriz[i, 3].valor != 0 ? matriz[i, 3].valor.ToString() : " ");
                }
                else if (matriz[i, 3].valor < 100)
                {
                    Console.Write("     {0} |", matriz[i, 3].valor);
                }
                else if (matriz[i, 3].valor < 1000)
                {
                    Console.Write("    {0} |", matriz[i, 3].valor);
                }
                else if (matriz[i, 3].valor < 10000)
                {
                    Console.Write("   {0} |", matriz[i, 3].valor);
                }
                else
                {
                    Console.Write("  {0} |", matriz[i, 3].valor);
                }
                Console.WriteLine("\n|        |        |        |        |");
            }
            Console.WriteLine("+--------+--------+--------+--------+");
            Console.WriteLine("\n\n Enter = Reinicia\t Esc = Sair\t← = Esquerda\t→ = Direita\t↑ = Cima\t↓=Baixo\t");
        }
    }
}
