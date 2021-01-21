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
    public partial class Ej3 : Form
    {
        public Ej3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void enviar_Click(object sender, EventArgs e)
        {
            string sistemaOperativo;
            string especialidadProgramacion;
            string especialidadGrafico;
            string especialidadAdmin;
            int horas = horasPC.Value;

            if (buttonWindows.Checked)
            {
               sistemaOperativo = "Windows";
            }
            else if (buttonLinux.Checked)
            {
                sistemaOperativo = "Linux";
            }
            else if (buttonMAC.Checked)
            {
                sistemaOperativo = "MAC OS X";
            }
            else
            {
                sistemaOperativo = "Ninguno";
            }

            especialidadProgramacion = (buttonProgramacion.Checked) ? "Si" : "No";
            especialidadGrafico = (buttonGrafico.Checked) ? "Si" : "No";
            especialidadAdmin = (buttonAdmin.Checked) ? "Si" : "No";

            MessageBox.Show("Sistema Operativo:\n" +
                sistemaOperativo + "\n\n" +
                "Especialidades: \n" +
                "Programacion: " + especialidadProgramacion + "\n" +
                "Diseño Grafico: " + especialidadGrafico + "\n" +
                "Administración: " + especialidadAdmin + "\n\n" +
                "Horas dedicadas al ordenador: " + horas + " horas");
        }
    }
}
