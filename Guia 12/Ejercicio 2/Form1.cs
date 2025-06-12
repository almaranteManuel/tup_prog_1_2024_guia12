namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormModal ventana = new FormModal();
           

            ventana.lbMostrarValor.Text = tbValor.Text;

            ventana.ShowDialog();
        }
    }
}
