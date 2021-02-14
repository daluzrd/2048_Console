using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Console
{
    public class Comandos
    {
        public bool Esquerda(Celula[,] matriz, ref int score)
        {
            bool isValid = false;
            for (int i = 0; i < 4; i++)
            {
                //Soma entre células
                for (int j = 0; j < 3; j++)
                {
                    if (!matriz[i, j].isEmpty && matriz[i, j + 1].valor == matriz[i, j].valor)
                    {
                        matriz[i, j].valor += matriz[i, j + 1].valor;
                        matriz[i, j + 1] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                    else if (j < 2 && !matriz[i, j].isEmpty && matriz[i, j + 1].isEmpty && matriz[i, j + 2].valor == matriz[i, j].valor)
                    {
                        matriz[i, j].valor += matriz[i, j + 2].valor;
                        matriz[i, j + 2] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                    else if (j < 1 && !matriz[i, j].isEmpty && matriz[i, j + 1].isEmpty && matriz[i, j + 2].isEmpty && matriz[i, j + 3].valor == matriz[i, j].valor)
                    {
                        matriz[i, j].valor += matriz[i, j + 3].valor;
                        matriz[i, j + 3] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                }
                //Deslocamento de células para células vazias
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j].isEmpty && !matriz[i, j + 1].isEmpty)
                    {
                        matriz[i, j] = matriz[i, j + 1];
                        matriz[i, j + 1] = new Celula();
                        isValid = true;
                    }
                    else if (j < 2 && matriz[i, j].isEmpty && matriz[i, j + 1].isEmpty && !matriz[i, j + 2].isEmpty)
                    {
                        matriz[i, j] = matriz[i, j + 2];
                        matriz[i, j + 2] = new Celula();
                        isValid = true;
                    }
                    else if (j < 1 && matriz[i, j].isEmpty && matriz[i, j + 1].isEmpty && matriz[i, j + 2].isEmpty && !matriz[i, j + 3].isEmpty)
                    {
                        matriz[i, j] = matriz[i, j + 3];
                        matriz[i, j + 3] = new Celula();
                        isValid = true;
                    }
                }
            }
            return isValid;
        }

        public bool Direita(Celula[,] matriz, ref int score)
        {
            bool isValid = false;
            for (int i = 0; i < 4; i++)
            {
                //Soma entre células
                for (int j = 3; j > 0; j--)
                {
                    if (!matriz[i, j].isEmpty && matriz[i, j - 1].valor == matriz[i, j].valor)
                    {
                        matriz[i, j].valor += matriz[i, j - 1].valor;
                        matriz[i, j - 1] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                    else if (j > 1 && !matriz[i, j].isEmpty && matriz[i, j - 1].isEmpty && matriz[i, j - 2].valor == matriz[i, j].valor)
                    {
                        matriz[i, j].valor += matriz[i, j - 2].valor;
                        matriz[i, j - 2] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                    else if (j > 2 && !matriz[i, j].isEmpty && matriz[i, j - 1].isEmpty && matriz[i, j - 2].isEmpty && matriz[i, j - 3].valor == matriz[i, j].valor)
                    {
                        matriz[i, j].valor += matriz[i, j - 3].valor;
                        matriz[i, j - 3] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                }
                //Deslocamento de células para células vazias
                for (int j = 3; j > 0; j--)
                {
                    if (matriz[i, j].isEmpty && !matriz[i, j - 1].isEmpty)
                    {
                        matriz[i, j] = matriz[i, j - 1];
                        matriz[i, j - 1] = new Celula();
                        isValid = true;
                    }
                    else if (j > 1 && matriz[i, j].isEmpty && matriz[i, j - 1].isEmpty && !matriz[i, j - 2].isEmpty)
                    {
                        matriz[i, j] = matriz[i, j - 2];
                        matriz[i, j - 2] = new Celula();
                        isValid = true;
                    }
                    else if (j > 2 && matriz[i, j].isEmpty && matriz[i, j - 1].isEmpty && matriz[i, j - 2].isEmpty && !matriz[i, j - 3].isEmpty)
                    {
                        matriz[i, j] = matriz[i, j - 3];
                        matriz[i, j - 3] = new Celula();
                        isValid = true;
                    }
                }
            }
            return isValid;
        }

        public bool Cima(Celula[,] matriz, ref int score)
        {
            bool isValid = false;
            for (int j = 0; j < 4; j++)
            {
                //Soma entre células
                for (int i = 0; i < 3; i++)
                {
                    if (!matriz[i, j].isEmpty && matriz[i, j].valor == matriz[i + 1, j].valor)
                    {
                        matriz[i, j].valor += matriz[i + 1, j].valor;
                        matriz[i + 1, j] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                    else if (i < 2 && !matriz[i, j].isEmpty && matriz[i + 1, j].isEmpty && matriz[i, j].valor == matriz[i + 2, j].valor)
                    {
                        matriz[i, j].valor += matriz[i + 2, j].valor;
                        matriz[i + 2, j] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                    else if (i < 1 && !matriz[i, j].isEmpty && matriz[i + 1, j].isEmpty && matriz[i + 2, j].isEmpty && matriz[i, j].valor == matriz[i + 3, j].valor)
                    {
                        matriz[i, j].valor += matriz[i + 3, j].valor;
                        matriz[i + 3, j] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                }
                //Deslocamento de células vazias
                for (int i = 0; i < 3; i++)
                {
                    if (matriz[i, j].isEmpty && !matriz[i + 1, j].isEmpty)
                    {
                        matriz[i, j] = matriz[i + 1, j];
                        matriz[i + 1, j] = new Celula();
                        isValid = true;
                    }
                    else if (i < 2 && matriz[i, j].isEmpty && matriz[i + 1, j].isEmpty && !matriz[i + 2, j].isEmpty)
                    {
                        matriz[i, j] = matriz[i + 2, j];
                        matriz[i + 2, j] = new Celula();
                        isValid = true;
                    }
                    else if (i < 1 && matriz[i, j].isEmpty && matriz[i + 1, j].isEmpty && matriz[i + 2, j].isEmpty && !matriz[i + 3, j].isEmpty)
                    {
                        matriz[i, j] = matriz[i + 3, j];
                        matriz[i + 3, j] = new Celula();
                        isValid = true;
                    }
                }
            }
            return isValid;
        }

        public bool Baixo(Celula[,] matriz, ref int score)
        {
            bool isValid = false;
            for (int j = 0; j < 4; j++)
            {
                //Soma entre células
                for (int i = 3; i > 0; i--)
                {
                    if (!matriz[i, j].isEmpty && matriz[i, j].valor == matriz[i - 1, j].valor)
                    {
                        matriz[i, j].valor += matriz[i - 1, j].valor;
                        matriz[i - 1, j] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                    else if (i > 1 && !matriz[i, j].isEmpty && matriz[i - 1, j].isEmpty && matriz[i, j].valor == matriz[i - 2, j].valor)
                    {
                        matriz[i, j].valor += matriz[i - 2, j].valor;
                        matriz[i - 2, j] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                    else if (i > 2 && !matriz[i, j].isEmpty && matriz[i - 1, j].isEmpty && matriz[i - 2, j].isEmpty && matriz[i, j].valor == matriz[i - 3, j].valor)
                    {
                        matriz[i, j].valor += matriz[i - 3, j].valor;
                        matriz[i - 3, j] = new Celula();
                        score += matriz[i, j].valor;
                        isValid = true;
                    }
                }
                //Deslocamento células vazias
                for (int i = 3; i > 0; i--)
                {
                    if (matriz[i, j].isEmpty && !matriz[i - 1, j].isEmpty)
                    {
                        matriz[i, j] = matriz[i - 1, j];
                        matriz[i - 1, j] = new Celula();
                        isValid = true;
                    }
                    else if (i > 1 && matriz[i, j].isEmpty && matriz[i - 1, j].isEmpty && !matriz[i - 2, j].isEmpty)
                    {
                        matriz[i, j] = matriz[i - 2, j];
                        matriz[i - 2, j] = new Celula();
                        isValid = true;
                    }
                    else if (i > 2 && matriz[i, j].isEmpty && matriz[i - 1, j].isEmpty && matriz[i - 2, j].isEmpty && !matriz[i - 3, j].isEmpty)
                    {
                        matriz[i, j] = matriz[i - 3, j];
                        matriz[i - 3, j] = new Celula();
                        isValid = true;
                    }
                }
            }
            return isValid;
        }
    }
}
