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
using System.IO;

namespace Alumnos
{
    public partial class listasateneo : Form
    {
        public listasateneo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = 1;
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Inscriateneo WHERE ciclo LIKE @ciclo +'%' AND añoingreso LIKE @añoingreso +'%' AND cuatrimestre LIKE @cuatrimestre +'%' AND grupo LIKE @grupo +'%' AND nivel LIKE @nivel +'%' ORDER BY apellidopaterno ASC", Conexion);
            instruccion.Parameters.AddWithValue("@ciclo", cboxciclo.Text);
            instruccion.Parameters.AddWithValue("@añoingreso", txtaño.Text);
            instruccion.Parameters.AddWithValue("@cuatrimestre", txtcuatrimestre.Text);
            instruccion.Parameters.AddWithValue("@grupo", txtgrupo.Text);
            instruccion.Parameters.AddWithValue("@nivel", cboxnivel.Text);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            while (Lector.Read())
            {
                TextBox temporal = (TextBox)Controls["txtapellidop" + p.ToString()];
                temporal.Text = (Lector["apellidopaterno"].ToString() + " " + Lector["apellidomaterno"].ToString() + " " + Lector["nombre"].ToString());
                TextBox temporal2 = (TextBox)Controls["txtno" + p.ToString()];
                temporal2.Text = p.ToString();
                p++;
            }
            Conexion.Close();
            MessageBox.Show("Lista generada con los alumnos inscritos");
        }

        private void btngenerar1_Click(object sender, EventArgs e)
        {
            //Creamos el objeto qe apuntara al reporte de crystal en mi caso CrystalReport1.rpt
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Alejandro\Desktop\Liceo Delta\Alumnos\Alumnos\listaevaluacionateneo.rpt");

            //Contendra los objetos cada campo de parámetros del informe.
            ParameterFieldDefinitions pfds;
            //representa un registro en el reporte
            ParameterFieldDefinition pfd;
            //objeto qe contendra el valor del parametro
            ParameterValues pvs = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            pdv.Value = txtnombreprofe.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nomprofe"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxciclo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ciclo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtaño.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["año"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcuatrimestre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["semestre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtgrupo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["grupo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtno1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop2.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre2"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);


            pdv.Value = txtapellidop3.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre3"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop4.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre4"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop5.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre5"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop6.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre6"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop7.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre7"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pfd.ApplyCurrentValues(pvs);
            pdv.Value = txtapellidop8.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre8"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop9.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre9"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop10.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre10"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop11.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre11"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop12.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre12"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop13.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre13"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop14.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre14"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop15.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre15"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop16.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre16"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop17.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre17"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop18.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre18"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop19.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre19"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop20.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre20"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno2.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no2"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno3.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no3"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno4.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no4"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno5.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no5"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno6.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no6"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno7.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no7"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno8.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no8"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno9.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no9"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno10.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no10"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno11.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no11"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno12.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no12"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno13.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no13"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno14.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no14"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno15.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no15"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno16.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no16"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno17.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no17"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno18.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no18"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno19.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no19"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno20.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no20"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);


            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Creamos el objeto qe apuntara al reporte de crystal en mi caso CrystalReport1.rpt
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Alejandro\Desktop\Liceo Delta\Alumnos\Alumnos\listaevaluacionateneo.rpt");

            //Contendra los objetos cada campo de parámetros del informe.
            ParameterFieldDefinitions pfds;
            //representa un registro en el reporte
            ParameterFieldDefinition pfd;
            //objeto qe contendra el valor del parametro
            ParameterValues pvs = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            pdv.Value = cboxciclo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ciclo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtaño.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["año"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcuatrimestre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["semestre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtgrupo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["grupo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtno1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop2.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre2"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);


            pdv.Value = txtapellidop3.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre3"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop4.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre4"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop5.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre5"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop6.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre6"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop7.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre7"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pfd.ApplyCurrentValues(pvs);
            pdv.Value = txtapellidop8.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre8"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop9.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre9"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop10.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre10"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop11.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre11"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop12.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre12"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop13.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre13"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop14.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre14"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop15.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre15"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop16.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre16"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop17.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre17"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop18.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre18"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop19.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre19"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop20.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre20"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno2.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no2"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno3.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no3"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno4.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no4"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno5.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no5"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno6.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no6"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno7.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no7"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno8.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no8"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno9.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no9"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno10.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no10"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno11.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no11"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno12.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no12"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno13.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no13"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno14.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no14"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno15.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no15"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno16.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no16"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno17.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no17"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno18.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no18"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno19.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no19"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtno20.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["no20"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);


            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }
    }
}
