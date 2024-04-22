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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String placa;
        int velocidad, multa, 
            cantInfra1, cantInfra2, cantInfra3, cantInfra4,
            totalInfra1, totalInfra2, totalInfra3, totalInfra4, 
            promInfra1, promInfra2, promInfra3, promInfra4;

        private void btnComparendo_Click(object sender, EventArgs e)
        {
            placa = txtPlaca.Text;
            velocidad = int.Parse(txtVelocidad.Text);
            if (velocidad > 80)
            {
                multa = (velocidad - 80) * 2000;
                dgvMultas.Rows.Add(placa, velocidad, "80Km/h", multa);
                switch (comboBoxCuadrante.SelectedIndex)
                {
                    case 0:
                        cantInfra1++;
                        totalInfra1 += multa;
                        promInfra1 = totalInfra1 / cantInfra1;
                        break;
                    case 1:
                        cantInfra2++;
                        totalInfra2 += multa;
                        promInfra2 = totalInfra2 / cantInfra2;
                        break;
                    case 2:
                        cantInfra3++;
                        totalInfra3 += multa;
                        promInfra3 = totalInfra3 / cantInfra3;
                        break;
                    case 3:
                        cantInfra4++;
                        totalInfra4 += multa;
                        promInfra4 = totalInfra4 / cantInfra4;
                        break;
                }
                mostrarValores();
            } else
            {
                MessageBox.Show("La velocidad no genera multa");
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            inicializarVariables();
            mostrarValores();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicializarVariables();
            mostrarValores();
        }

        private void inicializarVariables()
        {
            cantInfra1 = 0; cantInfra2 = 0; cantInfra3 = 0; cantInfra4 = 0;
            totalInfra1 = 0; totalInfra2 = 0; totalInfra3 = 0; totalInfra4 = 0;
            promInfra1 = 0; promInfra2 = 0; promInfra3 = 0; promInfra4 = 0;
        }

        private void mostrarValores()
        {
            txtC1Infracciones.Text = cantInfra1.ToString();
            txtC2Infracciones.Text = cantInfra2.ToString();
            txtC3Infracciones.Text = cantInfra3.ToString();
            txtC4Infracciones.Text = cantInfra4.ToString();
            txtC1MultaP.Text = promInfra1.ToString();
            txtC2MultaP.Text = promInfra2.ToString();
            txtC3MultaP.Text = promInfra3.ToString();
            txtC4MultaP.Text = promInfra4.ToString();
            txtC1TotalMul.Text = totalInfra1.ToString();
            txtC2TotalMul.Text = totalInfra2.ToString();
            txtC3TotalMul.Text = totalInfra3.ToString();
            txtC4TotalMul.Text = totalInfra4.ToString();
        }
    }
}
