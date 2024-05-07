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

        //EXAMEN

        //PREGUNTA 1

        public void examen1(Vector v2, Vector vr)
        {
            //Vector vr = new Vector();
            for (int i = 1; i <= n; i++)
            {
                int ele = v[i];
                if (v2.frecuencia(ele) == 0 && vr.frecuencia(ele) == 0)
                {
                    vr.insertar(ele);
                }

            }
            for (int i = 1; i <= v2.n; i++)
            {
                int ele = v2.v[i];
                if (frecuencia(ele) == 0 && vr.frecuencia(ele) == 0)
                {
                    vr.insertar(ele);
                }

            }
            //return vr.Descargar();
        }

        public String examen1(Vector v2)
        {
            Vector vr = new Vector();
            for (int i = 1; i <= n; i++)
            {
                int ele = v[i];
                if (v2.frecuencia(ele) == 0 && vr.frecuencia(ele) == 0)
                {
                    vr.insertar(ele);
                }

            }
            for (int i = 1; i <= v2.n; i++)
            {
                int ele = v2.v[i];
                if (frecuencia(ele) == 0 && vr.frecuencia(ele) == 0)
                {
                    vr.insertar(ele);
                }

            }
            return vr.Descargar();
        }


        public int frecuencia(int ele)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == ele)
                {
                    c++;
                }
            }
            return c;
        }
        private void insertar(int ele)
        {
            n++;
            v[n] = ele;
        }


        //PREGUNTA 2
        public void preguntaSB2(Vector e, Vector f, int a, int b)
        {
            int num, c1;
            num = n;
            e.n = 0;
            c1 = 0;

            OrdBurbuja(a, b);
            NEnt n1 = new NEnt();

            for (int i = a; i <= b; i++)
            {


                n1.Cargar(v[i]);

                if ((n1.verif_fibo()) && ((v[i] != v[i + 1]) || (i == b)))
                {
                    c1 = c1 + 1;
                    e.v[c1] = v[i];

                    f.v[c1] = frec_elem_segmento(v[i], a, b);

                }
            }
            e.n = c1;
            f.n = c1;
        }

        public void OrdBurbuja(int a, int b)
        {
            int num = n;
            checked
            {
                for (int i = a; i <= b; i++)
                {
                    int num2 = i + 1;
                    int num3 = b;
                    for (int j = num2; j <= num3; j++)
                    {
                        if (v[i] < v[j])
                        {

                            Intercambio(i, j);
                        }
                    }
                }
            }
        }
        public void Intercambio(int a, int b)
        {
            int aux;

            aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }
        public int frec_elem_segmento(int elem, int a, int b)
        {
            int c = 0;
            int num = a;
            int num2 = b;
            checked
            {
                for (int i = num; i <= num2; i++)
                {

                    if (elem == v[i])
                    {
                        c++;
                    }
                }
                return c;
            }
        }
    }
}
