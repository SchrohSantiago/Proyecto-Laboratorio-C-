using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSumarHoras_Click(object sender, EventArgs e)
        {
            int horaA = int.Parse(txtHoraA.Text);
            int minutosA = int.Parse(txtMinutoA.Text);
            int segundosA = int.Parse(txtSegundoA.Text);

            int horaB = int.Parse(txtHoraB.Text);
            int minutosB = int.Parse(txtMinutoB.Text);
            int segundosB = int.Parse(txtSegundoB.Text);

            int sumaSegundos = segundosA + segundosB;
            int sumaMinutos = minutosA + minutosB + (sumaSegundos / 60);
            sumaSegundos %= 60;
            int sumaHoras = horaA + horaB + (sumaMinutos / 60);
            sumaMinutos %= 60;
            sumaHoras %= 24;

            labResultado.Text = $"{sumaHoras:00}:{sumaMinutos:00}:{sumaSegundos:00}";




            labResultado.Text = $"{sumaHoras}:{sumaMinutos}:{sumaSegundos}";

        }
    }
}
