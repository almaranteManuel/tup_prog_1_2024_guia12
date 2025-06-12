using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Load(object sender, EventArgs e)
        {

        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbValor.Text);

        }
    }
}
