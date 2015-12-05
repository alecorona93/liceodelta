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
    public partial class Ateneo_Inscripciones : Form
    {
        public Ateneo_Inscripciones()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Insert INTO Inscriateneo(nocuenta, ciclo, añoingreso, cuatrimestre, grupo, nombre, apellidopaterno, apellidomaterno, lugarnac, fechanac, edad, domicilio, noext, noint, colonia, cp, telcasa, cel, email, escuela, promedio, nivel, enombre, etel, alergias, tipodesangre, certificado, certificado2, acta, curp, formato, identi, foto, carta, titulo, titulo2, cedula, cedula2, curriculum ) VALUES (@nocuenta, @ciclo, @añoingreso, @cuatrimestre, @grupo, @nombre, @apellidopaterno, @apellidomaterno, @lugarnac, @fechanac, @edad, @domicilio, @noext, @noint, @colonia, @cp, @telcasa, @cel, @email, @escuela, @promedio, @nivel, @enombre, @etel, @alergias, @tipodesangre, @certificado, @certificado2, @acta, @curp, @formato, @identi, @foto, @carta, @titulo, @titulo2, @cedula, @cedula2, @curriculum)", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtnocuenta.Text);
            instruccion.Parameters.AddWithValue("@ciclo", cboxciclo.Text);
            instruccion.Parameters.AddWithValue("@añoingreso", txtañoingreso.Text);
            instruccion.Parameters.AddWithValue("@cuatrimestre", txtcuatrimestre.Text);
            instruccion.Parameters.AddWithValue("@grupo", txtgrupo.Text);
            instruccion.Parameters.AddWithValue("@nombre ", txtnombre.Text);
            instruccion.Parameters.AddWithValue("@apellidopaterno ", txtapellidop.Text);
            instruccion.Parameters.AddWithValue("@apellidomaterno ", txtapellidom.Text);
            instruccion.Parameters.AddWithValue("@lugarnac ", txtlugarnac.Text);
            instruccion.Parameters.AddWithValue("@fechanac ", txtfechanac.Text);
            instruccion.Parameters.AddWithValue("@edad ", txtedad.Text);
            instruccion.Parameters.AddWithValue("@domicilio ", txtdomicilio.Text);
            instruccion.Parameters.AddWithValue("@noext ", txtnoext.Text);
            instruccion.Parameters.AddWithValue("@noint ", txtnoint.Text);
            instruccion.Parameters.AddWithValue("@colonia ", txtcolonia.Text);
            instruccion.Parameters.AddWithValue("@cp ", txtcp.Text);
            instruccion.Parameters.AddWithValue("@telcasa ", txttelcasa.Text);
            instruccion.Parameters.AddWithValue("@cel ", txtcel.Text);
            instruccion.Parameters.AddWithValue("@email ", txtemail.Text);

            instruccion.Parameters.AddWithValue("@escuela ", txtescuela.Text);
            instruccion.Parameters.AddWithValue("@promedio ", txtpromedio.Text);
            instruccion.Parameters.AddWithValue("@nivel ", cboxnivel.Text);
            instruccion.Parameters.AddWithValue("@enombre ", txtenombre.Text);
            instruccion.Parameters.AddWithValue("@etel ", txtetel.Text);
            instruccion.Parameters.AddWithValue("@alergias ", txtalergias.Text);
            instruccion.Parameters.AddWithValue("@tipodesangre ", txttipodesangre.Text);

            instruccion.Parameters.AddWithValue("@certificado ", cboxcertificado.Text);
            instruccion.Parameters.AddWithValue("@certificado2 ", txtcertificado.Text);
            instruccion.Parameters.AddWithValue("@acta ", txtacta.Text);
            instruccion.Parameters.AddWithValue("@curp ", txtcurp.Text);
            instruccion.Parameters.AddWithValue("@formato ", txtformato.Text);
            instruccion.Parameters.AddWithValue("@identi ", txtidentificacion.Text);
            instruccion.Parameters.AddWithValue("@foto ", txtfotos.Text);
            instruccion.Parameters.AddWithValue("@carta ", txtcarta.Text);
            instruccion.Parameters.AddWithValue("@titulo ", cboxtitulo.Text);
            instruccion.Parameters.AddWithValue("@titulo2 ", txttitulo.Text);
            instruccion.Parameters.AddWithValue("@cedula ", cboxcedula.Text);
            instruccion.Parameters.AddWithValue("@cedula2 ", txtcedula.Text);
            instruccion.Parameters.AddWithValue("@curriculum ", txtcurriculum.Text);

            Conexion.Open();
            instruccion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Guardado");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM inscriateneo WHERE nocuenta LIKE @nocuenta +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtbuscar.Text);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            while (Lector.Read())
            {
                cboxciclo.Text = Lector["ciclo"].ToString();
                txtañoingreso.Text = Lector["añoingreso"].ToString();
                txtcuatrimestre.Text = Lector["cuatrimestre"].ToString();
                txtgrupo.Text = Lector["grupo"].ToString();
                txtnocuenta.Text = Lector["nocuenta"].ToString();
                txtnombre.Text = Lector["nombre"].ToString();
                txtapellidop.Text = Lector["apellidopaterno"].ToString();
                txtapellidom.Text = Lector["apellidomaterno"].ToString();
                txtlugarnac.Text = Lector["lugarnac"].ToString();
                txtfechanac.Text = Lector["fechanac"].ToString();
                txtedad.Text = Lector["edad"].ToString();
                txtdomicilio.Text = Lector["domicilio"].ToString();
                txtnoext.Text = Lector["noext"].ToString();
                txtnoint.Text = Lector["noint"].ToString();
                txtcolonia.Text = Lector["colonia"].ToString();
                txtcp.Text = Lector["cp"].ToString();
                txttelcasa.Text = Lector["telcasa"].ToString();
                txtcel.Text = Lector["cel"].ToString();
                txtemail.Text = Lector["email"].ToString();
                txtescuela.Text = Lector["escuela"].ToString();
                txtpromedio.Text = Lector["promedio"].ToString();
                cboxnivel.Text = Lector["nivel"].ToString();
                txtenombre.Text = Lector["enombre"].ToString();
                txtetel.Text = Lector["etel"].ToString();
                txtalergias.Text = Lector["alergias"].ToString();
                txttipodesangre.Text = Lector["tipodesangre"].ToString();
                cboxcertificado.Text = Lector["certificado"].ToString();
                txtacta.Text = Lector["acta"].ToString();
                txtcertificado.Text = Lector["certificado2"].ToString();
                txtcurp.Text = Lector["curp"].ToString();
                txtformato.Text = Lector["formato"].ToString();
                txtidentificacion.Text = Lector["identi"].ToString();
                txtfotos.Text = Lector["foto"].ToString();
                txtcarta.Text = Lector["carta"].ToString();
                cboxtitulo.Text = Lector["titulo"].ToString();
                txttitulo.Text = Lector["titulo2"].ToString();
                cboxcedula.Text = Lector["cedula"].ToString();
                txtcedula.Text = Lector["cedula2"].ToString();
                txtcurriculum.Text = Lector["curriculum"].ToString();
            }
            MessageBox.Show("Esto es lo que encontré");
            Conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro quieres eliminar al alumno?", "Eliminar Alumno", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
                SqlCommand instruccion = new SqlCommand("DELETE inscriateneo WHERE nocuenta=@nocuenta", Conexion);
                instruccion.Parameters.AddWithValue("@nocuenta", txtnocuentaelimi.Text);
                Conexion.Open();
                instruccion.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Alumno Eliminado");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void Inscriateneo_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Creamos el objeto qe apuntara al reporte de crystal en mi caso CrystalReport1.rpt
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Alejandro\Desktop\Liceo Delta\Alumnos\Alumnos\CrystalReport8.rpt");

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

            pdv.Value = txtcuatrimestre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["cuatrimestre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtgrupo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["grupo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxciclo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ciclo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtañoingreso.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["añodeingreso"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidop.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["apellidopaterno"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtapellidom.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["apellido materno"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtnombre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombres"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtlugarnac.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["lugarnac"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtfechanac.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["fechanac"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtedad.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["edad"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtdomicilio.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["domicilio"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtnoext.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["noext"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtnoint.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["noint"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcolonia.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["colonia"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcp.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["cp"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txttelcasa.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["telcasa"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcel.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["cel"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtemail.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["email"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtescuela.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nomescuela"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtpromedio.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["promedio"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxnivel.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nivel"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxcertificado.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["certificado"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcertificado.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["certificado1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtacta.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["acta"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcurp.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["curp"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtformato.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["formato"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtidentificacion.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["indentificacion"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtfotos.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["foto"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcarta.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["carta"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxtitulo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["titulo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txttitulo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["titulo1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxcedula.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["cedula"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcedula.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["cedula1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtcurriculum.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["curriculum"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("UPDATE inscriateneo SET ciclo=@ciclo, añoingreso=@añoingreso, cuatrimestre=@cuatrimestre, grupo=@grupo, nombre=@nombre, apellidopaterno=@apellidopaterno, apellidomaterno=@apellidomaterno, lugarnac=@lugarnac, fechanac=@fechanac, edad=@edad, domicilio=@domicilio, noext=@noext, noint=@noint, colonia=@colonia, cp=@cp, telcasa=@telcasa, email=@email, escuela=@escuela, promedio=@promedio, nivel=@nivel, enombre=@enombre, etel=@etel, alergias=@alergias, tipodesangre=@tipodesangre, certificado=@certificado, certificado2=@certificado2, acta=@acta, curp=@curp, formato=@formato, identi=@identi, foto=@foto, carta=@carta, titulo=@titulo, titulo2=@titulo2, cedula=@cedula, cedula2=@cedula2, curriculum=@curriculum where nocuenta=@nocuenta", Conexion);
            instruccion.Parameters.AddWithValue("@ciclo", cboxciclo.Text);
            instruccion.Parameters.AddWithValue("@añoingreso", txtañoingreso.Text);
            instruccion.Parameters.AddWithValue("@cuatrimestre", txtcuatrimestre.Text);
            instruccion.Parameters.AddWithValue("@grupo", txtgrupo.Text);
            instruccion.Parameters.AddWithValue("@nombre ", txtnombre.Text);
            instruccion.Parameters.AddWithValue("@apellidopaterno ", txtapellidop.Text);
            instruccion.Parameters.AddWithValue("@apellidomaterno ", txtapellidom.Text);
            instruccion.Parameters.AddWithValue("@lugarnac ", txtlugarnac.Text);
            instruccion.Parameters.AddWithValue("@fechanac ", txtfechanac.Text);
            instruccion.Parameters.AddWithValue("@edad ", txtedad.Text);
            instruccion.Parameters.AddWithValue("@domicilio ", txtdomicilio.Text);
            instruccion.Parameters.AddWithValue("@noext ", txtnoext.Text);
            instruccion.Parameters.AddWithValue("@noint ", txtnoint.Text);
            instruccion.Parameters.AddWithValue("@colonia ", txtcolonia.Text);
            instruccion.Parameters.AddWithValue("@cp ", txtcp.Text);
            instruccion.Parameters.AddWithValue("@telcasa ", txttelcasa.Text);
            instruccion.Parameters.AddWithValue("@cel ", txtcel.Text);
            instruccion.Parameters.AddWithValue("@email ", txtemail.Text);

            instruccion.Parameters.AddWithValue("@escuela ", txtescuela.Text);
            instruccion.Parameters.AddWithValue("@promedio ", txtpromedio.Text);
            instruccion.Parameters.AddWithValue("@nivel ", cboxnivel.Text);
            instruccion.Parameters.AddWithValue("@enombre ", txtenombre.Text);
            instruccion.Parameters.AddWithValue("@etel ", txtetel.Text);
            instruccion.Parameters.AddWithValue("@alergias ", txtalergias.Text);
            instruccion.Parameters.AddWithValue("@tipodesangre ", txttipodesangre.Text);

            instruccion.Parameters.AddWithValue("@certificado ", cboxcertificado.Text);
            instruccion.Parameters.AddWithValue("@certificado2 ", txtcertificado.Text);
            instruccion.Parameters.AddWithValue("@acta ", txtacta.Text);
            instruccion.Parameters.AddWithValue("@curp ", txtcurp.Text);
            instruccion.Parameters.AddWithValue("@formato ", txtformato.Text);
            instruccion.Parameters.AddWithValue("@identi ", txtidentificacion.Text);
            instruccion.Parameters.AddWithValue("@foto ", txtfotos.Text);
            instruccion.Parameters.AddWithValue("@carta ", txtcarta.Text);
            instruccion.Parameters.AddWithValue("@titulo ", cboxtitulo.Text);
            instruccion.Parameters.AddWithValue("@titulo2 ", txttitulo.Text);
            instruccion.Parameters.AddWithValue("@cedula ", cboxcedula.Text);
            instruccion.Parameters.AddWithValue("@cedula2 ", txtcedula.Text);
            instruccion.Parameters.AddWithValue("@curriculum ", txtcurriculum.Text);
            instruccion.Parameters.AddWithValue("@nocuenta", txtnocuenta.Text);
            Conexion.Open();
            instruccion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Alumno Modificado");
        }
    }
}
