namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static Servicio servicio = new Servicio();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbIngresoNumero.Text);
            servicio.RegistrarValor(numero);
            tbIngresoNumero.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbBuscar.Text);
            int indice = servicio.BuscarValor(numero);
            if (indice != -1)
            {
                lbValorABuscar.Text = indice.ToString();
            }
            else
            {
                lbValorABuscar.Text = "!";
            }
            tbBuscar.Clear();
        }

        private void btnMaximoMinimo_Click(object sender, EventArgs e)
        {
            double maximo = servicio.CalcularMaximo();
            double minimo = servicio.CalcularMinimo();
            lbMaximo.Text = maximo.ToString();
            lbMinimo.Text = minimo.ToString();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double prom = servicio.CalcularPromedio();
            lbPromedio.Text = $"{prom:f2}";
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            lbCantidadIngreso.Text = servicio.Contador.ToString();
        }

        private void btnMostrarListaOrdenada_Click(object sender, EventArgs e)
        {
            lsbMostrarIngresados.Items.Clear();
            servicio.OrdenarLista();
            for (int i = 0; i < servicio.Contador; i++)
            {
                double numero = servicio.BuscarIndice(i);
                lsbMostrarIngresados.Items.Add($"{i}:{numero}");
            }
        }

        private void btnListaSuperiorAlPromedio_Click(object sender, EventArgs e)
        {
            lsbMostrarIngresados.Items.Clear();
            int[] listaSuperiorAlPromedio = servicio.ListaSuperioresAlPromedio(out int contadorSuperiores);
            for (int i = 0; i < contadorSuperiores; i++)
            {
                lsbMostrarIngresados.Items.Add($"{i}:{listaSuperiorAlPromedio[i]}");
            }
        }
    }
}
