using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Console
{
    public class Celula
    {
        public bool isEmpty { get; set; }
        public int valor { get; set; }

        public Celula()
        {
            isEmpty = true;
            valor = 0;
        }
    }
}
