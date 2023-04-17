using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num, digito1, digito2, suma;

            num = int.Parse(txtNum.Text);
            digito1 = num / 10;
            digito2 = num % 10;

            suma = digito1 + digito2;

            labSuma.Text = $"La suma de los digitos es: {suma}";
        }

        private void labSuma_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
