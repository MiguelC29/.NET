using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGames
{
    public partial class CellGames : Form
    {
        public CellGames()
        {
            InitializeComponent();
        }

        String[,] matrizJuegos =
        {
            {"FIFA", "DEPORTES", "100", "100000", "50"},
            {"NFS", "VELOCIDAD", "120", "120000", "10"},
            {"HALO", "ACCIÓN", "150", "160000", "100"},
            {"MINECRAFT", "AVENTURA", "180", "200000", "50"}
        };

        // [,] -> doble dimension | [] -> vector normal
        int[] vectorVentas = { 0, 0, 0, 0 };
        int descuento = 0, totalVentas, index;

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            try
            {
                cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad que desea " + "comprar", "Comprar Juegos", "0"));
            } catch(Exception ex)
            {
                MessageBox.Show("No ingresó ninguna cantidad");
            }

            matrizJuegos[index, 4] = (int.Parse(matrizJuegos[index, 4]) + cantidad).ToString();
            txtDisponible.Text = matrizJuegos[index, 4];
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            btnComprar.Enabled = false;
            btnFinalizarVenta.Enabled = true;
            int cantidad = 0;
            try
            {
                cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad que desea " + "vender", "Vender Juegos", "0"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ingresó ninguna cantidad");
            }

            if (cantidad <= int.Parse(matrizJuegos[index, 4]))
            {
                matrizJuegos[index, 4] = (int.Parse(matrizJuegos[index, 4]) - cantidad).ToString();
                txtDisponible.Text = matrizJuegos[index, 4];
                vectorVentas[index] += cantidad;
                totalVentas += int.Parse(matrizJuegos[index, 3]) * cantidad;

                //DESCUENTOS
                if (cantidad > 25 && matrizJuegos[index, 1] == "ACCIÓN")
                {
                    descuento = 15;
                } else if (descuento < 10 && cantidad >= 32 && matrizJuegos[index, 0] == "FIFA" || cantidad > 12 && matrizJuegos[index, 1] == "DEPORTES" || cantidad > 15 && matrizJuegos[index, 1] == "VELOCIDAD")
                {
                    descuento = 10;
                }
            } else
            {
                MessageBox.Show("La cantidad solicitada no está dísponible");
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            btnComprar.Enabled = true;
            btnFinalizarVenta.Enabled = false;

            totalVentas = totalVentas - totalVentas * descuento / 100;
            MessageBox.Show("El total a pagar es " + totalVentas + "\n con un descuento del " + descuento + "%");
            totalVentas = 0;
            descuento = 0;
        }

        private void btnMasVendido_Click(object sender, EventArgs e)
        {
            int mayor = vectorVentas[0];
            int posicion = 0;

            for (int i = 0; i < vectorVentas.Length; i++)
            {
                if (vectorVentas[i] > mayor)
                {
                    mayor = vectorVentas[i];
                    posicion = i;
                }
            }

            MessageBox.Show("El juego más vendido es " + matrizJuegos[posicion, 0]);
        }

        private void cmbJuego_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cmbJuego.SelectedIndex;
            txtNombre.Text = matrizJuegos[index, 0];
            txtCategoria.Text = matrizJuegos[index, 1];
            txtTamano.Text = matrizJuegos[index, 2];
            txtPrecio.Text = matrizJuegos[index, 3];
            txtDisponible.Text = matrizJuegos[index, 4];

            switch(index)
            {
                case 0:
                    pbJuego.Image = VideoGames.Properties.Resources.fifa;
                    break;
                case 1:
                    pbJuego.Image = VideoGames.Properties.Resources.nfc;
                    break;
                case 2:
                    pbJuego.Image = VideoGames.Properties.Resources.halo;
                    break;
                case 3:
                    pbJuego.Image = VideoGames.Properties.Resources.minecraft;
                    break;
            }
        }

        private void CellGames_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < matrizJuegos.GetLength(0); i++)
            {
                cmbJuego.Items.Add(matrizJuegos[i, 0]);
            }
            cmbJuego.SelectedIndex = 0;
        }
    }
}
