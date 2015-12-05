using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Web.UI;

namespace Alumnos
{
    public partial class Recibos : Form
    {
        public Recibos()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Insert INTO Recibos(nocuenta, lugar, fecha, recibi, cantidad, cantidadletra, concepto) VALUES (@nocuenta, @lugar, @fecha, @recibi, @cantidad, @cantidadletra, @concepto)", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtnocuenta.Text);
            instruccion.Parameters.AddWithValue("@lugar", txtlugar.Text);
            instruccion.Parameters.AddWithValue("@fecha", dateTimePicker1.Text);
            instruccion.Parameters.AddWithValue("@recibi", txtrecibi.Text);
            instruccion.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
            instruccion.Parameters.AddWithValue("@cantidadletra", txtcantidadletra.Text);
            instruccion.Parameters.AddWithValue("@concepto", txtconcepto.Text);
            Conexion.Open();
            instruccion.ExecuteNonQuery();
            Conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos el objeto qe apuntara al reporte de crystal en mi caso CrystalReport1.rpt
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Alejandro\Desktop\Liceo Delta\Alumnos\Alumnos\CrystalReport5.rpt");

            //Contendra los objetos cada campo de parámetros del informe.
            ParameterFieldDefinitions pfds;
            //representa un registro en el reporte
            ParameterFieldDefinition pfd;
            //objeto qe contendra el valor del parametro
            ParameterValues pvs = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtnocuenta.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nocuenta"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtlugar.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["lugar"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = dateTimePicker1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["fecha"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtrecibi.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["recibi"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtcantidad.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["cantidad"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtcantidadletra.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["cantidadletra"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtconcepto.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["concepto"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Recibos WHERE nocuenta LIKE @nocuenta +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtbuscar.Text);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            while (Lector.Read())
            {
                txtnocuenta.Text = Lector["nocuenta"].ToString();
                dateTimePicker1.Text = Lector["fecha"].ToString();
                txtlugar.Text = Lector["lugar"].ToString();
                txtrecibi.Text = Lector["recibi"].ToString();
                txtcantidad.Text = Lector["cantidad"].ToString();
                txtcantidadletra.Text = Lector["cantidadletra"].ToString();
                txtconcepto.Text = Lector["concepto"].ToString();
            }

            MessageBox.Show("Lectura Correcta");
            Conexion.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("UPDATE Recibos SET lugar=@lugar, fecha=@fecha, recibi=@recibi, cantidad=@cantidad, cantidadletra=@cantidadletra, concepto=@concepto where nocuenta=@nocuenta", Conexion);
            instruccion.Parameters.AddWithValue("@lugar", txtlugar.Text);
            instruccion.Parameters.AddWithValue("@fecha", dateTimePicker1.Text);
            instruccion.Parameters.AddWithValue("@recibi", txtrecibi.Text);
            instruccion.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
            instruccion.Parameters.AddWithValue("@cantidadletra", txtcantidadletra.Text);
            instruccion.Parameters.AddWithValue("@concepto", txtconcepto.Text);
            instruccion.Parameters.AddWithValue("@nocuenta", txtnocuenta.Text);
            Conexion.Open();
            instruccion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Recibo Modificado");
        }
    }
}
