using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularVuelto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double total = double.Parse(txtTotalAPagar.Text);
            double dineroEntregado = double.Parse(txtDineroEntregado.Text);
            double vueltoTotal = dineroEntregado - total;

            labVuelto.Text = $"El vuelto para {nombre} es: $ {vueltoTotal}";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
