using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArenaTotal_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(txtAltura.Text);
            double ancho = double.Parse(txtAncho.Text);
            double area = altura * ancho;
            double arenaNecesaria = area * 0.5;


            labCantidadArena.Text = "La cantidad de arena necesaria es: " + arenaNecesaria.ToString() + " m3";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
                this.Close();
            
        }
    }
}
