using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD19_1
{
    public partial class MiniCalculadora : Form
    {
        private double primerNumero, segundoNumero, resultado;
        private string operacion;

        private void boton0_Click(object sender, EventArgs e)
        {
                textoCalculadora.Text = textoCalculadora.Text + "0";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (textoCalculadora.Text == "0" && textoCalculadora.Text != null)
            {
                textoCalculadora.Text = "1";
            }
            else
            {
                textoCalculadora.Text = textoCalculadora.Text + "1";
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (textoCalculadora.Text == "0" && textoCalculadora.Text != null)
            {
                textoCalculadora.Text = "2";
            }
            else
            {
                textoCalculadora.Text = textoCalculadora.Text + "2";
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            if (textoCalculadora.Text == "0" && textoCalculadora.Text != null)
            {
                textoCalculadora.Text = "3";
            }
            else
            {
                textoCalculadora.Text = textoCalculadora.Text + "3";
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (textoCalculadora.Text == "0" && textoCalculadora.Text != null)
            {
                textoCalculadora.Text = "4";
            }
            else
            {
                textoCalculadora.Text = textoCalculadora.Text + "4";
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            if (textoCalculadora.Text == "0" && textoCalculadora.Text != null)
            {
                textoCalculadora.Text = "5";
            }
            else
            {
                textoCalculadora.Text = textoCalculadora.Text + "5";
            }
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            if (textoCalculadora.Text == "0" && textoCalculadora.Text != null)
            {
                textoCalculadora.Text = "6";
            }
            else
            {
                textoCalculadora.Text = textoCalculadora.Text + "6";
            }
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            if (textoCalculadora.Text == "0" && textoCalculadora.Text != null)
            {
                textoCalculadora.Text = "7";
            }
            else
            {
                textoCalculadora.Text = textoCalculadora.Text + "7";
            }
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            if (textoCalculadora.Text == "0" && textoCalculadora.Text != null)
            {
                textoCalculadora.Text = "8";
            }
            else
            {
                textoCalculadora.Text = textoCalculadora.Text + "8";
            }
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            if (textoCalculadora.Text == "0" && textoCalculadora.Text != null)
            {
                textoCalculadora.Text = "9";
            }
            else
            {
                textoCalculadora.Text = textoCalculadora.Text + "9";
            }
        }

        private void resetCalculadora_Click(object sender, EventArgs e)
        {
            textoCalculadora.Text = "0";
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            this.primerNumero = Convert.ToDouble(textoCalculadora.Text);
            textoCalculadora.Text = "0";
            this.operacion = "+";
        }

        private void restar_Click(object sender, EventArgs e)
        {
            this.primerNumero = Convert.ToDouble(textoCalculadora.Text);
            textoCalculadora.Text = "0";
            this.operacion = "-";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            this.primerNumero = Convert.ToDouble(textoCalculadora.Text);
            textoCalculadora.Text = "0";
            this.operacion = "*";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            this.primerNumero = Convert.ToDouble(textoCalculadora.Text);
            textoCalculadora.Text = "0";
            this.operacion = "/";
        }

        private void resolver_Click(object sender, EventArgs e)
        {
            this.segundoNumero = Convert.ToDouble(textoCalculadora.Text);

            if (this.operacion == "+")
            {
                this.resultado = (this.primerNumero + this.segundoNumero);
                textoCalculadora.Text = Convert.ToString(this.resultado);
                this.primerNumero = this.resultado;
            }
            if (this.operacion == "-")
            {
                this.resultado = (this.primerNumero - this.segundoNumero);
                textoCalculadora.Text = Convert.ToString(this.resultado);
                this.primerNumero = this.resultado;
            }
            if (this.operacion == "*")
            {
                this.resultado = (this.primerNumero * this.segundoNumero);
                textoCalculadora.Text = Convert.ToString(this.resultado);
                this.primerNumero = this.resultado;
            }
            if (this.operacion == "/")
            {
                if (this.segundoNumero == 0)
                {
                    textoCalculadora.Text = "No puedes divir por 0";

                }
                else
                {
                    this.resultado = (this.primerNumero / this.segundoNumero);
                    textoCalculadora.Text = Convert.ToString(this.resultado);
                    this.primerNumero = this.resultado;
                }
            }
        }

        public MiniCalculadora()
        {
            InitializeComponent();
        }


    }
}
