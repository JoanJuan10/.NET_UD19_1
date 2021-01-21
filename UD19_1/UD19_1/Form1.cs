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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ej1Button_Click(object sender, EventArgs e)
        {
            Form ej1 = new Ej1();
            ej1.Show();
        }

        private void ej2Button_Click(object sender, EventArgs e)
        {
            Form ej2 = new Ej2();
            ej2.Show();
        }

        private void ej3Button_Click(object sender, EventArgs e)
        {
            Form ej3 = new Ej3();
            ej3.Show();
        }

        private void ej4Button_Click(object sender, EventArgs e)
        {
            Form calculadora = new MiniCalculadora();
            calculadora.Show();
        }
    }
}
