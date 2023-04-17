using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

      

        //private void labelResultadoPerimetro_Click(object sender, EventArgs e)
        //{

        //}
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(txtRadio.Text);
            double area = Math.PI * radio * radio;
            labArea.Text = "El área del círculo es: " + area.ToString();
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(txtRadio.Text);
            double perimetro = 2 * Math.PI * radio;
            labPerimetro.Text = "El perímetro del círculo es: " + perimetro.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
