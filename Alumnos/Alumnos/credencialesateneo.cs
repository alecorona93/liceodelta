using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Web.UI;

namespace Alumnos
{
    public partial class credencialesateneo : Form
    {
        public credencialesateneo()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Inscriateneo WHERE nocuenta LIKE @nocuenta +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtbuscar.Text);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            while (Lector.Read())
            {
                txtnocuenta.Text = Lector["nocuenta"].ToString();
                txtalumno.Text = Lector["nombre"].ToString() + " " + Lector["apellidopaterno"].ToString() + " " + Lector["apellidomaterno"].ToString();
                txtetel.Text = Lector["cel"].ToString();
                txtalergias.Text = Lector["alergias"].ToString();
                txttiposangre.Text = Lector["tipodesangre"].ToString();
            }
            MessageBox.Show("Esto encontré");
            Conexion.Close();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            //Creamos el objeto qe apuntara al reporte de crystal en mi caso CrystalReport1.rpt
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Alejandro\Desktop\Liceo Delta\Alumnos\Alumnos\credencialesateneos.rpt");

            //Contendra los objetos cada campo de parámetros del informe.
            ParameterFieldDefinitions pfds;
            //representa un registro en el reporte
            ParameterFieldDefinition pfd;
            //objeto qe contendra el valor del parametro
            ParameterValues pvs = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtalumno.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["alumno"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = dateTimePicker1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["fecha"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtnocuenta.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nocuenta"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txttiposangre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["tiposangre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtalergias.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["alergias"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtetel.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["etel"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }
    }
}
