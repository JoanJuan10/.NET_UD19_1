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
    public partial class Ej1 : Form
    {
        public Ej1()
        {
            InitializeComponent();
        }

        private void botonSaludo_Click(object sender, EventArgs e)
        {
            string persona = this.saludoBox.Text;
            MessageBox.Show("Hola " + persona + "!");
        }
    }
}
