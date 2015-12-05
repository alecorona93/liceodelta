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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void btnliceo_Click(object sender, EventArgs e)
        {
            Liceo forma = new Liceo();
            forma.ShowDialog();
        }

        private void btnateneo_Click(object sender, EventArgs e)
        {
            Ateneoo forma = new Ateneoo();
            forma.ShowDialog();
        }
    }
}
