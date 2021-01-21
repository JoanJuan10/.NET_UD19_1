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
    public partial class Ej2 : Form
    {
        public Ej2()
        {
            InitializeComponent();
        }

        private void boxPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPelicula_Click(object sender, EventArgs e)
        {
            string pelicula = tituloPelicula.Text;
            boxPeliculas.Items.Add(pelicula);
        }
    }
}
