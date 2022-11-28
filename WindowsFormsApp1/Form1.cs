using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras;
            double coste = 0;

            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rdUrgente.Checked)
                tipoTelegrama = 'u';

            numPalabras = textoTelegrama
                .Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Length;

            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * numPalabras;
            }
            else if (tipoTelegrama == 'u')
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            }
            if (numPalabras == 0)
            {
                coste = 0;
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void txtTelegrama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
