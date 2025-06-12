namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbMostrarValor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            //PODEMOS HACER ESTO

            //ventana.ShowDialog();

            // O VALIDAMOS Y HACEMOS ESTO
            if (ventana.ShowDialog() == DialogResult.OK) {
                lbMostrarValor.Text = $"{ventana.tbValor.Text}"; 
            }
            else
            {
                lbMostrarValor.Text = "Ingreso cancelado";
            }
        }
    }
}
