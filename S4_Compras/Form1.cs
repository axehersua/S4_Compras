using System;
using System.Globalization;
using System.Windows.Forms;

namespace S4_Compra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 100;
            nudCantidad.Value = 1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(
                txtPrecio.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out decimal precio) || precio <= 0)
            {
                MessageBox.Show(
                    "Ingrese un precio válido mayor a 0 usando punto decimal.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrecio.Focus();
                return;
            }

            var r = CalculadoraCompra.Calcular(
                precio, (int)nudCantidad.Value);

            label1.Text = "Subtotal: " +
                 CalculadoraCompra.Dinero(r.Subtotal);

            lblDescuento.Text = "Descuento: " +
                CalculadoraCompra.Dinero(r.Descuento);

            lblIva.Text = "IVA 15%: " +
                CalculadoraCompra.Dinero(r.Iva);

            lblTotal.Text = "TOTAL A PAGAR: " +
                CalculadoraCompra.Dinero(r.Total);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            nudCantidad.Value = 1;

            label1.Text = "Subtotal:";
            lblDescuento.Text = "Descuento:";
            lblIva.Text = "IVA 15%:";
            lblTotal.Text = "TOTAL A PAGAR:";

            txtPrecio.Focus();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}