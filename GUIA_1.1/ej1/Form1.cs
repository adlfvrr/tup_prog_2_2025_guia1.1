namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ModalResultados Modal;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Modal = new ModalResultados();
            Moto moto = new Moto(tbMarca.Text,Convert.ToInt32(nudModelo.Value),Convert.ToDouble(tbValorFabrica.Text));
            double depreciacionLineal = moto.CalcularDepreciacionLineal(Convert.ToInt32(nudAño.Value), Convert.ToInt32(tbVidaUtil.Text));
            double depreciacionAnual = moto.CalcularDepreciacionAnual(Convert.ToInt32(nudAño.Value), Convert.ToDouble(tbDepreciacion.Text));
                Modal.tbResultado.Text = moto.VerDescripcion() + $@"
                Depreciacion lineal ${depreciacionLineal:f2}
                Depreciacion anual ${depreciacionAnual:f2}";
            if (Modal.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
