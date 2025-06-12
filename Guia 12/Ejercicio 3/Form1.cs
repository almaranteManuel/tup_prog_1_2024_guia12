using System.Numerics;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] vector = new double[5];


        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            FormModal ventana = new FormModal();
            int contador = 0;

            while (contador < 4 && ventana.ShowDialog() == DialogResult.OK)
            {

                vector[contador] = Convert.ToDouble(ventana.tbValor.Text);
                contador++;
                ventana.tbValor.Clear();
            }
            lbCantidad.Text = $"{contador}";
            for (int i = 0; i <= contador; i++)
            {

                lsbListado.Items.Add(vector[i]);

            }

        }
    }
}
