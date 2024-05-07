using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examensb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vector v1, v2, v3;
        NEnt n1;

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
            n1 = new NEnt();
        }

        private void cargarRndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargardato(int.Parse(textBox1.Text));
            textBox4.Text = v1.Descargar();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void cargarRndToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.Cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarManualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.cargardato(int.Parse(textBox1.Text));
            textBox5.Text = v2.Descargar();
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.Descargar();
        }

        private void cargarRndToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            v3.cargardato(int.Parse(textBox1.Text));
            textBox4.Text = v3.Descargar();
        }

        private void cargarManualToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            v3.cargardato(int.Parse(textBox1.Text));
            textBox4.Text = v3.Descargar();
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox6.Text = v3.Descargar();
        }

        private void eJERCICIO1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //1examen
            textBox6.Text = v1.examen1(v2);
           //v1.examen1(v2,v3);
        }

        private void eJERCICIO2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //2examen
            v1.preguntaSB2(v2, v3, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v2.Descargar();
            textBox6.Text = v3.Descargar();
        }
    }
}
