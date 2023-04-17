using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {  
            string name = txtName.Text;
            int añoDeIngreso = int.Parse(txtYear.Text);
            double tarifaHoraria = double.Parse(txtTarifaHoraria.Text);
            int horasDiarias = int.Parse(txtHorasDiarias.Text);
            int diasAlMes = int.Parse(txtDiasTrabajados.Text);

            double sueldoBruto = tarifaHoraria * horasDiarias * diasAlMes;

            int antiguedad =  añoDeIngreso - 2023;

            double retenciones = 0.20 * sueldoBruto + (0.015 * sueldoBruto * antiguedad);

            double salarioNeto = sueldoBruto - retenciones;

            labSalario.Text = $"El sueldo neto de {name} es : $ {salarioNeto}";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
