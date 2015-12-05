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
    public partial class boletasateneo : Form
    {
        public boletasateneo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Insert INTO Boletasateneo(nocuenta, cuatrimestre, nombre, materia1, materia2, materia3, materia4, calif1, calif2, calif3, calif4, promedio) VALUES (@nocuenta, @cuatrimestre, @nombre, @materia1, @materia2, @materia3, @materia4, @calif1, @calif2, @calif3, @calif4, @promedio)", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtnocuenta.Text);
            instruccion.Parameters.AddWithValue("@cuatrimestre ", txtcuatrimestre.Text);
            instruccion.Parameters.AddWithValue("@nombre ", txtnombre.Text);
            instruccion.Parameters.AddWithValue("@materia1 ", cboxmat1.Text);
            instruccion.Parameters.AddWithValue("@materia2 ", cboxmat2.Text);
            instruccion.Parameters.AddWithValue("@materia3 ", cboxmat3.Text);
            instruccion.Parameters.AddWithValue("@materia4 ", cboxmat4.Text);
            instruccion.Parameters.AddWithValue("@materia5 ", cboxmat4.Text);

            instruccion.Parameters.AddWithValue("@calif1 ", txtcalif1.Text);
            instruccion.Parameters.AddWithValue("@calif2 ", txtcalif2.Text);
            instruccion.Parameters.AddWithValue("@calif3 ", txtcalif3.Text);
            instruccion.Parameters.AddWithValue("@calif4 ", txtcalif4.Text);
            instruccion.Parameters.AddWithValue("@calif5 ", txtcalif4.Text);

            instruccion.Parameters.AddWithValue("@promedio ", txtpromedio.Text);
            

            Conexion.Open();
            instruccion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Alumno Guardado ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Boletasateneo WHERE nocuenta LIKE @nocuenta +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtbuscar.Text);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            while (Lector.Read())
            {
                txtcuatrimestre.Text = Lector["cuatrimestre"].ToString();
                txtnocuenta.Text = Lector["nocuenta"].ToString();
                txtnombre.Text = Lector["nombre"].ToString();
                txtcuatrimestre.Text = Lector["cuatrimestre"].ToString();
                cboxmat1.Text = Lector["materia1"].ToString();
                cboxmat2.Text = Lector["materia2"].ToString();
                cboxmat3.Text = Lector["materia3"].ToString();
                cboxmat4.Text = Lector["materia4"].ToString();
                cboxmat5.Text = Lector["materia5"].ToString();
                txtcalif1.Text = Lector["calif1"].ToString();
                txtcalif2.Text = Lector["calif2"].ToString();
                txtcalif3.Text = Lector["calif3"].ToString();
                txtcalif4.Text = Lector["calif4"].ToString();
                txtcalif5.Text = Lector["calif5"].ToString();
                txtpromedio.Text = Lector["promedio"].ToString();
            }
            MessageBox.Show("Esto Encontré");
            Conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("UPDATE Boletasateneo SET  cuatrimestre=@cuatrimestre, nombre=@nombre, materia1=@materia1, materia2=@materia2, materia3=@materia3, materia4=@materia4, materia5=@materia5, calif1=@calif1, calif2=@calif2, calif3=@calif3, calif4=@calif4, calif5=@calif5, promedio=@promedio", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtnocuenta.Text);
            instruccion.Parameters.AddWithValue("@cuatrimestre ", txtcuatrimestre.Text);
            instruccion.Parameters.AddWithValue("@nombre ", txtnombre.Text);
            instruccion.Parameters.AddWithValue("@materia1 ", cboxmat1.Text);
            instruccion.Parameters.AddWithValue("@materia2 ", cboxmat2.Text);
            instruccion.Parameters.AddWithValue("@materia3 ", cboxmat3.Text);
            instruccion.Parameters.AddWithValue("@materia4 ", cboxmat4.Text);
            instruccion.Parameters.AddWithValue("@materia5 ", cboxmat4.Text);

            instruccion.Parameters.AddWithValue("@calif1 ", txtcalif1.Text);
            instruccion.Parameters.AddWithValue("@calif2 ", txtcalif2.Text);
            instruccion.Parameters.AddWithValue("@calif3 ", txtcalif3.Text);
            instruccion.Parameters.AddWithValue("@calif4 ", txtcalif4.Text);
            instruccion.Parameters.AddWithValue("@calif5 ", txtcalif5.Text);

            instruccion.Parameters.AddWithValue("@promedio ", txtpromedio.Text);
            Conexion.Open();
            instruccion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Alumno Modificado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Creamos el objeto qe apuntara al reporte de crystal en mi caso CrystalReport1.rpt
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Alejandro\Desktop\Liceo Delta\Alumnos\Alumnos\CrystalReport9.rpt");

            //Contendra los objetos cada campo de parámetros del informe.
            ParameterFieldDefinitions pfds;
            //representa un registro en el reporte
            ParameterFieldDefinition pfd;
            //objeto qe contendra el valor del parametro
            ParameterValues pvs = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtcuatrimestre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["cuatrimestre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtnocuenta.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nocuenta"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtnombre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxmat1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxmat2.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia2"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxmat3.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia3"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxmat4.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia4"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxmat5.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia5"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcalif1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["calif1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcalif2.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["calif2"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcalif3.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["calif3"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcalif4.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["calif4"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcalif5.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["calif5"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtpromedio.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["promedio"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double suma;
            suma = (Convert.ToDouble(txtcalif1.Text) + Convert.ToDouble(txtcalif2.Text) + Convert.ToDouble(txtcalif3.Text) + Convert.ToDouble(txtcalif4.Text) + Convert.ToDouble(txtcalif5.Text))/5;
            txtpromedio.Text = suma.ToString();
        }
    }
}
