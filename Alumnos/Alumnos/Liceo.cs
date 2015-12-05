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
    public partial class Liceo : Form
    {
        public Liceo()
        {
            InitializeComponent();
        }

        private void btninscripciones_Click(object sender, EventArgs e)
        {
            InscriLiceo forma = new InscriLiceo();
            forma.ShowDialog();
        }

        private void btnboletas_Click(object sender, EventArgs e)
        {
            Boletas1 forma = new Boletas1();
            forma.ShowDialog();
        }

        private void btnrecibos_Click(object sender, EventArgs e)
        {
            Recibos forma = new Recibos();
            forma.ShowDialog();
        }

        private void btnlistas_Click(object sender, EventArgs e)
        {
            Listas forma = new Listas();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeroscuenta forma = new numeroscuenta();
            forma.ShowDialog();
        }

        private void btncredenciales_Click(object sender, EventArgs e)
        {
            Credenciales forma = new Credenciales();
            forma.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
