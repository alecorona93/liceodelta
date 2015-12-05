using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Ateneoo : Form
    {
        public Ateneoo()
        {
            InitializeComponent();
        }

        private void btninscripciones_Click(object sender, EventArgs e)
        {
            Ateneo_Inscripciones forma = new Ateneo_Inscripciones();
            forma.ShowDialog();
        }

        private void btnboletas_Click(object sender, EventArgs e)
        {
            boletasateneo forma = new boletasateneo();
            forma.ShowDialog();
        }

        private void btncredenciales_Click(object sender, EventArgs e)
        {
            credencialesateneo forma = new credencialesateneo();
            forma.ShowDialog();
        }

        private void btnrecibos_Click(object sender, EventArgs e)
        {
            recibosateneo forma = new recibosateneo();
            forma.ShowDialog();
        }

        private void btnlistas_Click(object sender, EventArgs e)
        {
            listasateneo forma = new listasateneo();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeroscuentaateneo forma = new numeroscuentaateneo();
            forma.ShowDialog();
        }
    }
}
