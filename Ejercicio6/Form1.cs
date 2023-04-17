using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {

        double cantidadInicial;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnPorcentajeOcupacion_Click(object sender, EventArgs e)
        {
            double cupoTotal = double.Parse(txtCupoMaximo.Text);
            cantidadInicial = double.Parse(txtCantidadDePersonas.Text);
            double porcentajeOcupacion = (cantidadInicial / cupoTotal) * 100;

            labPorcentaje.Text = $"Ocupacion de la Sala: %{porcentajeOcupacion}";
        }

        private void btnUnoMenos_Click(object sender, EventArgs e)
        {
            cantidadInicial--;
            txtCantidadDePersonas.Text = cantidadInicial.ToString();

        }

        private void btnEntroUno_Click(object sender, EventArgs e)
        {
            cantidadInicial++;
            txtCantidadDePersonas.Text = cantidadInicial.ToString();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
