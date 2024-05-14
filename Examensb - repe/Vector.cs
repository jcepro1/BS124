using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examensb
{
    class Vector
    {
        const int MAX = 50;
        private int[] v;
        private int n;

        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        public void Cargar(int n1, int a, int b)
        {
            Random r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        public void Cargar(int ele)
        {
            n++;
            v[n] = ele;
        }

        public void cargardato(int nele)
        {
            n = nele;
            int num = n;
            for (int i = 1; i <= num; i++)
            {
                v[i] = Conversions.ToInteger(Interaction.InputBox(" ", " "));
            }
        }

        public string Descargar()
        {
            string s = "";
            int i;
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }


        //PREGUNTA 1 
        public void InvertirV(int m)
        {
            int naux = n;
            //se termina en n/ 2 ya que se referencian de extremo a extremo
            for (int i = 1; i <= n / 2; i++)
            {
                if (i % m == 0)
                {
                    // todo este conjunto en realidad es la función de intercambiar
                    int aux;
                    // la variable auxiliar toma la v[i]
                    aux = v[i];
                    // v[i] toma v[naux] que es su extremo
                    v[i] = v[naux];
                    // v[naux] toma aux que guardaba v[i] para el intercambio
                    v[naux] = aux;
                    // naux que tiene n se decrementa

                }
                naux--;

            }
        }


     


    }
}
