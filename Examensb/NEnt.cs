using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examensb
{
    class NEnt
    {
    
        private int n;


        public NEnt()
        {
            n = 0;
        }


        public void Cargar(int dato)
        {
            n = dato;
        }

        public bool verif_fibo()
        {
            int a = -1;
            int b = 1;
            int c;
            do
            {
                c = checked(a + b);
                a = b;
                b = c;
            }
            while (!((c == n) || (c > n)));
            return c == n;
        }
    }
}
