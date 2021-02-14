using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            bool comandoValido = true;
            ConsoleKey ck;
            do
            {
                game.ImprimeMatriz();

                do
                {
                    ck = Console.ReadKey().Key;
                    comandoValido = game.Inputs(ck);
                } while (!comandoValido);
                game.InsereNumeros();

                if (ck == ConsoleKey.Enter)
                {
                    game = new Game();
                }

            } while (ck != ConsoleKey.Escape);
        }
    }
}
