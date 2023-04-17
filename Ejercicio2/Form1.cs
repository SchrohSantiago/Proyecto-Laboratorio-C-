using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcularTiempo_Click(object sender, EventArgs e)
        {
            double velocidad = double.Parse(txtVelocidad.Text);
            int distancia = int.Parse(txtDistancia.Text);
            string nombre = txtDestino.Text;
            double tiempo = distancia / velocidad;

            TimeSpan tiempoBienCalculado = TimeSpan.FromHours(tiempo); // Funcion predeterminada para pasar la entrada numerica a tiempo horario.

            labTiempo.Text = $"A la velocidad de {velocidad} Km, tardaran {tiempoBienCalculado} Horas en llegar a {nombre}";
        }
    }
}
