using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosWindows
{
    public partial class FormTienda : Form
    {
        public FormTienda()
        {
            InitializeComponent();
        }

        int cantidad, valorCompra, 
            precio1=5000,
            precio2 = 10000,
            precio3 = 20000;
        int ventasTienda1, ventasTienda2, ventasTienda3;

        private void FormTienda_Load(object sender, EventArgs e)
        {
            inicializarVariables();
            mostrarValores();
        }

        int ventasArticulo1, ventasArticulo2, ventasArticulo3, ventasTotales;

        private void inicializarVariables()
        {
            ventasTienda1= 0; ventasTienda2= 0; ventasTienda3= 0;
            ventasArticulo1= 0; ventasArticulo2= 0; ventasArticulo3= 0;
            ventasTotales= 0;
        }

        private void mostrarValores()
        {
            txtVCompra.Text = valorCompra.ToString();
            txtTienda1.Text = ventasTienda1.ToString();
            txtTienda2.Text = ventasTienda2.ToString();
            txtTienda3.Text = ventasTienda3.ToString();
            txtArticulo1.Text = ventasArticulo1.ToString();
            txtArticulo2.Text = ventasArticulo2.ToString();
            txtArticulo3.Text = ventasArticulo3.ToString();
            txtVentasTotales.Text = ventasTotales.ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            cantidad = int.Parse(txtCantidad.Text);

            switch (cmbArticulo.SelectedIndex)
            {
                case 0:
                    valorCompra = cantidad * precio1;
                    ventasArticulo1 += valorCompra;
                    break;
                case 1:
                    valorCompra = cantidad * precio2;
                    ventasArticulo2 += valorCompra;
                    break;
                case 2:
                    valorCompra = cantidad * precio3;
                    ventasArticulo3 += valorCompra;
                    break;
            }

            switch (cmbTienda.SelectedIndex)
            {
                case 0:
                    ventasTienda1 += valorCompra;
                    break;
                case 1:
                    ventasTienda2 += valorCompra;
                    break;
                case 2:
                    ventasTienda3 += valorCompra;
                    break;
            }

            ventasTotales = ventasTienda1 + ventasTienda1 + ventasTienda3;
            mostrarValores();
        }
    }
}
