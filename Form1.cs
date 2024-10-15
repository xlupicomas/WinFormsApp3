namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double horasTrabajadas) &&
                double.TryParse(textBox1.Text, out double costePorHora))
            {
                double sueldo = horasTrabajadas * costePorHora;

                label4.Text = sueldo.ToString("C2");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en ambos campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
