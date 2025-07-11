namespace ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static private Servicio servicio = new Servicio();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int libreta = Convert.ToInt32(tbLibreta.Text);
            string nombre = tbNombres.Text;
            double nota = Convert.ToDouble(tbNota.Text);
            if (servicio.RegistrarAlumno(libreta, nombre, nota) != true)
            {
                MessageBox.Show("Límite de registros alcanzado");
            }
            tbLibreta.Clear();
            tbNombres.Clear();
            tbNota.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lsbResultados.Items.Clear();
            int idx = servicio.BuscarPorLibreta(Convert.ToInt32(tbBuscar.Text));
            if (idx != -1)
            {
                lsbResultados.Items.Add($@"Libreta: {servicio.Libretas[idx]}");
                lsbResultados.Items.Add($@"Nombre: {servicio.Nombres[idx]}");
                lsbResultados.Items.Add($@"Nota: {servicio.Notas[idx]}");
            }
            else
            {
                lsbResultados.Items.Add("Numero no encontrado");
            }
        }

        private void btnMayorYMenor_Click(object sender, EventArgs e)
        {
            lsbResultados.Items.Clear();
            int idxMayor = servicio.CalcularAlumnoMayorNota();
            int idxMenor = servicio.CalcularAlumnoMenorNota();
            lsbResultados.Items.Add($@"Alumno con mayor nota:");
            lsbResultados.Items.Add($"{servicio.Nombres[idxMayor]} - N° libreta: {servicio.Libretas[idxMayor]} - Nota: {servicio.Notas[idxMayor]}");
            lsbResultados.Items.Add($@"Alumno con menor nota:");
            lsbResultados.Items.Add($"{servicio.Nombres[idxMenor]} - N° libreta: {servicio.Libretas[idxMenor]} - Nota: {servicio.Notas[idxMenor]}");
        }
        private void btnCantidad_Click(object sender, EventArgs e)
        {
            lsbResultados.Items.Clear();
            lsbResultados.Items.Add($"La cantidad de alumnos ingresados es de {servicio.Cantidad}");
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            lsbResultados.Items.Clear();
            lsbResultados.Items.Add($"El promedio de notas es de {servicio.CalcularPromedio():f2}");
        }

        private void btnListaOrdenada_Click(object sender, EventArgs e)
        {
            lsbResultados.Items.Clear();
            servicio.OrdenadaAlumnosPorLibreta();
            for (int i = 0; i < servicio.Cantidad; i++)
            {
                lsbResultados.Items.Add($@"Nombre: {servicio.Nombres[i]} - Libreta: {servicio.Libretas[i]} - Nota: {servicio.Notas[i]}");
            }
        }

        private void btnMayorAlPromedio_Click(object sender, EventArgs e)
        {
            lsbResultados.Items.Clear();
            int[] mayoresAlPromedio = servicio.ListarAlumnosSuperaronElPromedio(out int cantidadMayores);
            lsbResultados.Items.Add($"Promedio: {servicio.CalcularPromedio():f2}");
            for(int i = 0; i < cantidadMayores; i++)
            {
                lsbResultados.Items.Add($@"Nombre: {servicio.Nombres[i]} - Libreta: {servicio.Libretas[i]} - Nota: {servicio.Notas[i]}");
            }
        }
    }
}
