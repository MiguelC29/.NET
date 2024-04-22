using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2;
        double result;

        private void btnSum_Click(object sender, EventArgs e)
        {
            Operation('+');
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            Operation('-');
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Operation('*');
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Operation('/');
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            textNum2.Text = "";
            textResult.Text = "";
        }

        private void Operation(char operation)
        {
            num1 = int.Parse(textNum1.Text);
            num2 = int.Parse(textNum2.Text);

            switch(operation)
            {
                case '+': 
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break ;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if(num2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        return;
                    } else
                    {
                        result = num1 / num2;
                    }
                    break;
            }

            textResult.Text = result.ToString();
        }
    }
}
