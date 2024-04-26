using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Ahorcado
{
    public partial class juego_ahorcado : Form
    {
        public juego_ahorcado()
        {
            InitializeComponent();
        }

        String[] palabras = {"PROGRAMACION", "SPRINGBOOT", "LARAVEL", "CSHARP", "PYTHON",
            "MONGODB", "DJANGO", "JAVASERVERFACES", "KOTLIN", "MYSQL"};
        String palabraAdivinar;
        String[] vectorLetras;
        int fallos = 0, marcador = 0;

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            inactivarBotones(true);
            txtPalabra.ResetText();
            txtLetra.ResetText();
            fallos = 0;
            txtFallos.Text = fallos.ToString();
            txtMarcador.Text = marcador.ToString();
            Random random = new Random();
            palabraAdivinar = palabras[random.Next(0, 9)];

            vectorLetras = new string[palabraAdivinar.Length];
            for (int i = 0; i < palabraAdivinar.Length; i++)
            {
                vectorLetras[i] = "_";
                txtPalabra.Text += vectorLetras[i] + " ";
            }
        }

        private void verficarLetra(char letra)
        {
            bool verificar = false;

            for (int i = 0; i < palabraAdivinar.Length; i++)
            {
                if (palabraAdivinar[i].Equals(letra))
                {
                    vectorLetras[i] = letra.ToString();
                    verificar = true;
                }
            }

            if (!verificar)
            {
                fallos++;
            }

            switch (fallos)
            {
                case 1:
                    pnl1.Visible = false;
                    break;
                case 2:
                    pnl2.Visible = false;
                    break;
                case 3:
                    pnl3.Visible = false;
                    break;
                case 4:
                    pnl4.Visible = false;
                    break;
                case 5:
                    pnl5.Visible = false;
                    break;
                case 6:
                    pnl6.Visible = false;
                    break;
                case 7:
                    pnl7.Visible = false;
                    break;
                case 8:
                    pnl8.Visible = false;
                    inactivarBotones(false);
                    MessageBox.Show("Lo siento, ha perdido la palabra era " + palabraAdivinar);
                    break;
            }
            txtPalabra.ResetText();
            for (int i = 0; i < palabraAdivinar.Length; i++)
            {
                txtPalabra.Text += vectorLetras[i] + " ";
            }
            txtLetra.Text += letra + " ";
            txtFallos.Text = fallos.ToString();

            bool ganador = true;
            for (int i = 0; i < palabraAdivinar.Length;i++)
            {
                if (vectorLetras[i] != palabraAdivinar[i].ToString())
                {
                    ganador = false;
                }
            }

            if (ganador)
            {
                MessageBox.Show("Felicitaciones!!!, ha ganado");
                marcador++;
                txtMarcador.Text = marcador.ToString();
                inactivarBotones(false);
            }
        }

        private void inactivarBotones(bool activar)
        {
            btnA.Enabled = activar;
            btnB.Enabled = activar;
            btnC.Enabled = activar;
            btnD.Enabled = activar;
            btnE.Enabled = activar;
            btnF.Enabled = activar;
            btnG.Enabled = activar;
            btnH.Enabled = activar;
            btnI.Enabled = activar;
            btnJ.Enabled = activar;
            btnK.Enabled = activar;
            btnL.Enabled = activar;
            btnM.Enabled = activar;
            btnN.Enabled = activar;
            btnO.Enabled = activar;
            btnP.Enabled = activar;
            btnQ.Enabled = activar;
            btnR.Enabled = activar;
            btnS.Enabled = activar;
            btnT.Enabled = activar;
            btnU.Enabled = activar;
            btnV.Enabled = activar;
            btnW.Enabled = activar;
            btnX.Enabled = activar;
            btnY.Enabled = activar;
            btnZ.Enabled = activar;

            pnl1.Visible = activar;
            pnl2.Visible = activar;
            pnl3.Visible = activar;
            pnl4.Visible = activar;
            pnl5.Visible = activar;
            pnl6.Visible = activar;
            pnl7.Visible = activar;
            pnl8.Visible = activar;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            verficarLetra('A');
            btnA.Enabled = false;

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            verficarLetra('B');
            btnB.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            verficarLetra('C');
            btnC.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            verficarLetra('D');
            btnD.Enabled = false;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            verficarLetra('E');
            btnE.Enabled = false;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            verficarLetra('F');
            btnF.Enabled = false;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            verficarLetra('G');
            btnG.Enabled = false;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            verficarLetra('H');
            btnH.Enabled = false;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            verficarLetra('I');
            btnI.Enabled = false;
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            verficarLetra('J');
            btnJ.Enabled = false;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            verficarLetra('K');
            btnK.Enabled = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            verficarLetra('L');
            btnL.Enabled = false;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            verficarLetra('M');
            btnM.Enabled = false;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            verficarLetra('N');
            btnN.Enabled = false;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            verficarLetra('O');
            btnO.Enabled = false;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            verficarLetra('P');
            btnP.Enabled = false;
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            verficarLetra('Q');
            btnQ.Enabled = false;
        }
        private void btnR_Click(object sender, EventArgs e)
        {
            verficarLetra('R');
            btnR.Enabled = false;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            verficarLetra('S');
            btnS.Enabled = false;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            verficarLetra('T');
            btnT.Enabled = false;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            verficarLetra('U');
            btnU.Enabled = false;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            verficarLetra('V');
            btnV.Enabled = false;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            verficarLetra('W');
            btnW.Enabled = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            verficarLetra('X');
            btnX.Enabled = false;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            verficarLetra('Y');
            btnY.Enabled = false;
        }

        private void juego_ahorcado_Load(object sender, EventArgs e)
        {
            inactivarBotones(false);
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            verficarLetra('Z');
            btnZ.Enabled = false;
        }
    }
}
