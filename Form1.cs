namespace Practica_1_Gestion_de_ahorros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double monto;

        private void activar_controles()
        {
            txtCliente.Enabled = false;
            txtMonto.Enabled = false;
            btnAbrir.Enabled = false;

            btnDeposito.Enabled = true;
            btnRetiro.Enabled = true;
        }

        private void desactivar_controles()
        {
            txtCliente.Enabled = true;
            txtMonto.Enabled = true;
            btnAbrir.Enabled = true;

            btnDeposito.Enabled = false;
            btnRetiro.Enabled = false;
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            string cliente;

            cliente = txtCliente.Text;
            monto = Convert.ToDouble(txtMonto.Text);

            if (monto > 0)
            {
                activar_controles();
            }
            else MessageBox.Show("El monto debe ser mayor o igual que 0", "Gestión de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private double leer(string mensaje)
        {
            double cantidad;
            cantidad = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese monto a " + mensaje, "Gestión de ahorros", "0", 100, 0));
            return cantidad;
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            double deposito;
            deposito = leer("depositar");
            monto = monto + deposito;
            listBox1.Items.Add(deposito);
            Mostrar();
        }

        private void Mostrar()
        {
            txtSaldo.Text = Convert.ToString(monto);
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            double retiro;
            retiro = leer("retirar");

            if (retiro <= monto)
            {
                monto = monto - retiro;
                listBox2.Items.Add(retiro);
                Mostrar();
            }
            else
            {
                MessageBox.Show("La cantidad de retiro es mayor al monto disponible", "Gestión de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtMonto.Clear();
            txtSaldo.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            desactivar_controles();
        }
    }
}