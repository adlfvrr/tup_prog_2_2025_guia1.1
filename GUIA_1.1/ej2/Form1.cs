using ej2.Models;

namespace ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Viaje nuevoviaje;
        ModalViaje modalViaje;
        ModalDatos modalDatos;
        ModalInforme modalInforme;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarViaje_Click(object sender, EventArgs e)
        {
            modalViaje = new ModalViaje();
            modalInforme = new ModalInforme();
            if (modalViaje.ShowDialog() == DialogResult.OK)
            {
                int hInicio = Convert.ToInt32(modalViaje.tbHInicio.Text);
                int mInicio = Convert.ToInt32(modalViaje.tbMInicio.Text);
                int asientos = Convert.ToInt32(modalViaje.tbAsientos.Text);
                nuevoviaje = new Viaje(asientos, hInicio, mInicio);
                modalInforme.lsbResultados.Items.Add($"Hora de inicio: {hInicio}:{mInicio} - Asientos: {asientos}");
            }
        }

        private void btnIngresarParada_Click(object sender, EventArgs e)
        {
            modalDatos = new ModalDatos();
            if (modalDatos.ShowDialog() == DialogResult.OK)
            {
                int hLlegada = Convert.ToInt32(modalDatos.tbHLlegada.Text);
                int mLlegada = Convert.ToInt32(modalDatos.tbMLlegada.Text);
                int hSalida = Convert.ToInt32(modalDatos.tbHSalida.Text);
                int mSalida = Convert.ToInt32(modalDatos.tbMSalida.Text);
                int ascienden = Convert.ToInt32(modalDatos.tbAscienden.Text);
                int descienden = Convert.ToInt32(modalDatos.tbDescienden.Text);
                nuevoviaje.RealizarParada(hLlegada, mLlegada, hSalida, mSalida, ascienden, descienden);
                modalInforme.lsbResultados.Items.Add($"Parada n°{nuevoviaje.CantParadas}");
                modalInforme.lsbResultados.Items.Add($"Hora de llegada: {hLlegada}:{mLlegada}");
                modalInforme.lsbResultados.Items.Add($"Hora de salida: {hSalida}:{mSalida}");
                modalInforme.lsbResultados.Items.Add($"Ascienden: {ascienden} pasajeros");
                modalInforme.lsbResultados.Items.Add($"Descienden: {descienden} pasajeros");
                modalInforme.lsbResultados.Items.Add("---");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int hFinalizacion = Convert.ToInt32(tbHorFinalizacion.Text);
            int mFinalizacion = Convert.ToInt32(tbMinFinalizacion.Text);
            nuevoviaje.Finalizar(hFinalizacion, mFinalizacion);
            modalInforme.lsbResultados.Items.Add($"Viaje finalizado - Hora de finalización: {hFinalizacion}:{mFinalizacion}");
            modalInforme.lsbResultados.Items.Add($"Pasajeros transportados: {nuevoviaje.Transportados} pasajeros en total");
            modalInforme.ShowDialog();
        }
    }
}
