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
    public partial class InscriLiceo : Form
    {   

        public InscriLiceo()
        {
            InitializeComponent();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label95_Click(object sender, EventArgs e)
        {

        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {

        }



        private void InscriLiceo_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Insert INTO InscriLiceo(nocuenta, lugaryfecha, carrera, semestre, grupo, año, ciclo, plans, area, apellidopaterno, apellidomaterno, nombres, calle, numero, colonia, municipio, femenino, masculino, telefono, celular, cp, curp, email, lugaryfechanac, soltero, casado, divorciado, unionlibre, propia, rentada, tsi, tno, familia, propio, intercambio, beca, publico, privado, asi, ano, imss, issste, numhab, nomescuela, promedio, añodeegreso, ubicacion, pais, estado, muni, localidad, mapellidos, mnombres, mdireccion, mciudad, mestado, mtelcasa, mteltrabajo, mcp,  mtelcelular, memail, papellidos, pnombres, pdireccion, pciudad, pestado, ptelcasa, pteltrabajo, pcp,  ptelcelular, pemail, tapellidos, tnombres, tdireccion, tciudad, testado, ttelcasa, tteltrabajo, tcp,  ttelcelular, temail, enombre, eparentesco, etelcasa, eteltrabajo, etelcelular, eemail, imdoctor, imhospital, imdireccion, imciudad, imtipodesangre, imtelhospi, imtelconsulta, imalergias, imenferme, immedicamentos ) VALUES (@nocuenta, @lugaryfecha, @carrera, @semestre, @grupo, @año, @ciclo, @plans, @area, @apellidopaterno, @apellidomaterno, @nombres, @calle, @numero, @colonia, @municipio, @femenino, @masculino, @telefono, @celular, @cp, @curp, @email, @lugaryfechanac, @soltero, @casado, @divorciado, @unionlibre, @propia, @rentada, @tsi, @tno, @familia, @propio, @intercambio, @beca, @publico, @privado, @asi, @ano, @imss, @issste, @numhab, @nomescuela, @promedio, @añodeegreso, @ubicacion, @pais, @estado, @muni, @localidad, @mapellidos, @mnombres, @mdireccion, @mciudad, @mestado, @mtelcasa, @mteltrabajo, @mcp, @mtelcelular, @memail, @papellidos, @pnombres, @pdireccion, @pciudad, @pestado, @ptelcasa, @pteltrabajo, @pcp,  @ptelcelular, @pemail,  @tapellidos, @tnombres, @tdireccion, @tciudad, @testado, @ttelcasa, @tteltrabajo, @tcp, @ttelcelular, @temail, @enombre, @eparentesco, @etelcasa, @eteltrabajo, @etelcelular, @eemail, @imdoctor, @imhospital, @imdireccion, @imciudad, @imtipodesangre, @imtelhospi, @imtelconsulta, @imalergias, @imenferme, @immedicamentos)", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtnocuenta.Text);
            if (!String.IsNullOrWhiteSpace(txtlugaryfecha.Text))
                instruccion.Parameters.AddWithValue("@lugaryfecha ", txtlugaryfecha.Text);
            else
                instruccion.Parameters.AddWithValue("@lugaryfecha", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@lugaryfecha ", txtlugaryfecha.Text);
            if (!String.IsNullOrWhiteSpace(txtcarrera.Text))
                instruccion.Parameters.AddWithValue("@carrera", txtcarrera.Text);
            else
                instruccion.Parameters.AddWithValue("@carrera", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@carrera", txtcarrera.Text);
            if (!String.IsNullOrWhiteSpace(txtsemestre.Text))
                instruccion.Parameters.AddWithValue("@semestre", txtsemestre.Text);
            else
                instruccion.Parameters.AddWithValue("@semestre", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@semestre", txtsemestre.Text);
            if (!String.IsNullOrWhiteSpace(txtgrupo.Text))
                instruccion.Parameters.AddWithValue("@grupo ", txtgrupo.Text);
            else
                instruccion.Parameters.AddWithValue("@grupo ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@grupo ", txtgrupo.Text);
            if (!String.IsNullOrWhiteSpace(txtañoingre.Text))
                instruccion.Parameters.AddWithValue("@año", txtañoingre.Text);
            else
                instruccion.Parameters.AddWithValue("@año ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@año", txtañoingre.Text);
            if (!String.IsNullOrWhiteSpace(cboxciclo.Text))
                instruccion.Parameters.AddWithValue("@ciclo", cboxciclo.Text);
            else
                instruccion.Parameters.AddWithValue("@ciclo ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@ciclo", cboxciclo.Text);
            if (!String.IsNullOrWhiteSpace(txtplans.Text))
                instruccion.Parameters.AddWithValue("@plans", txtplans.Text);
            else
                instruccion.Parameters.AddWithValue("@plans", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@plans", txtplans.Text);
            if (!String.IsNullOrWhiteSpace(txtarea.Text))
                instruccion.Parameters.AddWithValue("@area ", txtarea.Text);
            else
                instruccion.Parameters.AddWithValue("@area ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@area ", txtarea.Text);

            if (!String.IsNullOrWhiteSpace(txtapellidop.Text))
                instruccion.Parameters.AddWithValue("@apellidopaterno ", txtapellidop.Text);
            else
                instruccion.Parameters.AddWithValue("@apellidopaterno ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@apellidopaterno ", txtapellidop.Text);
            if (!String.IsNullOrWhiteSpace(txtapellidom.Text))
                instruccion.Parameters.AddWithValue("@apellidomaterno ", txtapellidom.Text);
            else
                instruccion.Parameters.AddWithValue("@apellidomaterno ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@apellidomaterno ", txtapellidom.Text);
            if (!String.IsNullOrWhiteSpace(txtnombre.Text))
                instruccion.Parameters.AddWithValue("@nombres ", txtnombre.Text);
            else
                instruccion.Parameters.AddWithValue("@nombres ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@nombres ", txtnombre.Text);
            if (!String.IsNullOrWhiteSpace(txtcalle.Text))
                instruccion.Parameters.AddWithValue("@calle ", txtcalle.Text);
            else
                instruccion.Parameters.AddWithValue("@calle ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@calle ", txtcalle.Text);
            if (!String.IsNullOrWhiteSpace(txtnumerocalle.Text))
                instruccion.Parameters.AddWithValue("@numero ", txtnumerocalle.Text);
            else
                instruccion.Parameters.AddWithValue("@numero ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@numero ", txtnumerocalle.Text);
            if (!String.IsNullOrWhiteSpace(txtcolonia.Text))
                instruccion.Parameters.AddWithValue("@colonia ", txtcolonia.Text);
            else
                instruccion.Parameters.AddWithValue("@colonia ", DBNull.Value);
           // instruccion.Parameters.AddWithValue("@colonia ", txtcolonia.Text);
            if (!String.IsNullOrWhiteSpace(txtmunicipio.Text))
                instruccion.Parameters.AddWithValue("@municipio ", txtmunicipio.Text);
            else
                instruccion.Parameters.AddWithValue("@municipio ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@municipio ", txtmunicipio.Text);
            if (!String.IsNullOrWhiteSpace(txtf.Text))
                instruccion.Parameters.AddWithValue("@femenino ", txtf.Text);
            else
                instruccion.Parameters.AddWithValue("@femenino ", DBNull.Value);
           // instruccion.Parameters.AddWithValue("@femenino ", txtf.Text);
            if (!String.IsNullOrWhiteSpace(txtm.Text))
                instruccion.Parameters.AddWithValue("@masculino ", txtm.Text);
            else
                instruccion.Parameters.AddWithValue("@masculino ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@masculino ", txtm.Text);
            if (!String.IsNullOrWhiteSpace(txttelefono.Text))
                instruccion.Parameters.AddWithValue("@telefono ", txttelefono.Text);
            else
                instruccion.Parameters.AddWithValue("@telefono ", DBNull.Value);
           // instruccion.Parameters.AddWithValue("@telefono ", txttelefono.Text);
            if (!String.IsNullOrWhiteSpace(txtcelular.Text))
                instruccion.Parameters.AddWithValue("@celular ", txtcelular.Text);
            else
                instruccion.Parameters.AddWithValue("@celular ", DBNull.Value);
           // instruccion.Parameters.AddWithValue("@celular ", txtcelular.Text);
            if (!String.IsNullOrWhiteSpace(txtcp.Text))
                instruccion.Parameters.AddWithValue("@cp ", txtcp.Text);
            else
                instruccion.Parameters.AddWithValue("@cp ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@cp ", txtcp.Text);
            if (!String.IsNullOrWhiteSpace(txtcurp.Text))
                instruccion.Parameters.AddWithValue("@curp ", txtcurp.Text);
            else
                instruccion.Parameters.AddWithValue("@curp ", DBNull.Value);
            //instruccion.Parameters.AddWithValue("@curp ", txtcurp.Text);
            instruccion.Parameters.AddWithValue("@email ", txtemail.Text);
            instruccion.Parameters.AddWithValue("@lugaryfechanac ", txtfechanac.Text);

            instruccion.Parameters.AddWithValue("@soltero ", txtsoltero.Text);
            instruccion.Parameters.AddWithValue("@casado ", txtcasado.Text);
            instruccion.Parameters.AddWithValue("@divorciado ", txtdivorciado.Text);
            instruccion.Parameters.AddWithValue("@unionlibre ", txtunionlibre.Text);
            instruccion.Parameters.AddWithValue("@propia ", txtpropia.Text);
            instruccion.Parameters.AddWithValue("@rentada ", txtrentada.Text);
            instruccion.Parameters.AddWithValue("@tsi ", txttsi.Text);
            instruccion.Parameters.AddWithValue("@tno ", txttno.Text);
            instruccion.Parameters.AddWithValue("@familia ", txtfamilia.Text);
            instruccion.Parameters.AddWithValue("@propio ", txtpropio.Text);
            instruccion.Parameters.AddWithValue("@intercambio ", txtintercambio.Text);
            instruccion.Parameters.AddWithValue("@beca ", txtbeca.Text);
            instruccion.Parameters.AddWithValue("@publico ", txtpublico.Text);
            instruccion.Parameters.AddWithValue("@privado ", txtprivado.Text);
            instruccion.Parameters.AddWithValue("@asi ", txtasi.Text);
            instruccion.Parameters.AddWithValue("@ano ", txtano.Text);
            instruccion.Parameters.AddWithValue("@imss ", txtimss.Text);
            instruccion.Parameters.AddWithValue("@issste ", txtissste.Text);
            instruccion.Parameters.AddWithValue("@numhab ", txtnumhab.Text);
            instruccion.Parameters.AddWithValue("@nomescuela ", txtnomescuela.Text);
            instruccion.Parameters.AddWithValue("@promedio ", txtpromedio.Text);
            instruccion.Parameters.AddWithValue("@añodeegreso ", txtañoegreso.Text);
            instruccion.Parameters.AddWithValue("@ubicacion ", txtubicacion.Text);
            instruccion.Parameters.AddWithValue("@pais ", txtpais.Text);
            instruccion.Parameters.AddWithValue("@estado ", txtestado.Text);
            instruccion.Parameters.AddWithValue("@muni ", txtmuni.Text);
            instruccion.Parameters.AddWithValue("@localidad ", txtlocalidad.Text);

            instruccion.Parameters.AddWithValue("@mapellidos ", txtmapellidos.Text);
            instruccion.Parameters.AddWithValue("@mnombres ", txtmnombres.Text);
            instruccion.Parameters.AddWithValue("@mdireccion ", txtmdireccion.Text);
            instruccion.Parameters.AddWithValue("@mciudad ", txtmciudad.Text);
            instruccion.Parameters.AddWithValue("@mestado ", txtmestado.Text);
            instruccion.Parameters.AddWithValue("@mtelcasa ", txtmtelcasa.Text);
            instruccion.Parameters.AddWithValue("@mteltrabajo ", txtmteltrabajo.Text);
            instruccion.Parameters.AddWithValue("@mcp ", txtmcp.Text);
            instruccion.Parameters.AddWithValue("@mtelcelular ", txtmtelcelular.Text);
            instruccion.Parameters.AddWithValue("@memail ", txtmemail.Text);

            instruccion.Parameters.AddWithValue("@papellidos ", txtpapellidos.Text);
            instruccion.Parameters.AddWithValue("@pnombres ", txtpnombres.Text);
            instruccion.Parameters.AddWithValue("@pdireccion ", txtpdireccion.Text);
            instruccion.Parameters.AddWithValue("@pciudad ", txtpciudad.Text);
            instruccion.Parameters.AddWithValue("@pestado ", txtpestado.Text);
            instruccion.Parameters.AddWithValue("@ptelcasa ", txtptelcasa.Text);
            instruccion.Parameters.AddWithValue("@pteltrabajo ", txtpteltrabajo.Text);
            instruccion.Parameters.AddWithValue("@pcp ", txtpcp.Text);
            instruccion.Parameters.AddWithValue("@ptelcelular ", txtptelcelular.Text);
            instruccion.Parameters.AddWithValue("@pemail ", txtpemail.Text);

            instruccion.Parameters.AddWithValue("@tapellidos ", txttapellidos.Text);
            instruccion.Parameters.AddWithValue("@tnombres ", txttnombres.Text);
            instruccion.Parameters.AddWithValue("@tdireccion ", txttdireccion.Text);
            instruccion.Parameters.AddWithValue("@tciudad ", txttciudad.Text);
            instruccion.Parameters.AddWithValue("@testado ", txttestado.Text);
            instruccion.Parameters.AddWithValue("@ttelcasa ", txtttelcasa.Text);
            instruccion.Parameters.AddWithValue("@tteltrabajo ", txttteltrabajo.Text);
            instruccion.Parameters.AddWithValue("@tcp ", txttcp.Text);
            instruccion.Parameters.AddWithValue("@ttelcelular ", txtttelcelular.Text);
            instruccion.Parameters.AddWithValue("@temail ", txttemail.Text);

            instruccion.Parameters.AddWithValue("@enombre ", txtenombres.Text);
            instruccion.Parameters.AddWithValue("@eparentesco ", txteparentesco.Text);
            instruccion.Parameters.AddWithValue("@etelcasa ", txtetelcasa.Text);
            instruccion.Parameters.AddWithValue("@eteltrabajo ", txteteltrabajo.Text);
            instruccion.Parameters.AddWithValue("@etelcelular ", txtetelcelular.Text);
            instruccion.Parameters.AddWithValue("@eemail ", txteemail.Text);

            instruccion.Parameters.AddWithValue("@imdoctor ", txtimdoctor.Text);
            instruccion.Parameters.AddWithValue("@imhospital ", txtimhospital.Text);
            instruccion.Parameters.AddWithValue("@imdireccion ", txtimdireccion.Text);
            instruccion.Parameters.AddWithValue("@imciudad ", txtimciudad.Text);
            instruccion.Parameters.AddWithValue("@imtipodesangre ", txtimtiposangre.Text);
            instruccion.Parameters.AddWithValue("@imtelhospi ", txtimtelhospi.Text);
            instruccion.Parameters.AddWithValue("@imtelconsulta ", txtimtelconsulta.Text);
            instruccion.Parameters.AddWithValue("@imalergias ", txtimalergias.Text);
            instruccion.Parameters.AddWithValue("@imenferme ", txtimenferme.Text);
            instruccion.Parameters.AddWithValue("@immedicamentos ", txtimmedicamentos.Text);




            Conexion.Open();
            instruccion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Alumno Guardado");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM InscriLiceo WHERE nocuenta LIKE @nocuenta +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtbuscar.Text);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            while (Lector.Read())
            {
                txtañoingre.Text = Lector["año"].ToString();
                cboxciclo.Text = Lector["ciclo"].ToString();
                txtnocuenta.Text=Lector["nocuenta"].ToString();
                txtlugaryfecha.Text = Lector["lugaryfecha"].ToString();
                txtcarrera.Text = Lector["carrera"].ToString();
                txtsemestre.Text = Lector["semestre"].ToString();
                txtgrupo.Text = Lector["grupo"].ToString();
                txtplans.Text = Lector["plans"].ToString();
                txtarea.Text = Lector["area"].ToString();
                txtapellidop.Text = Lector["apellidopaterno"].ToString();
                txtapellidom.Text = Lector["apellidomaterno"].ToString();
                txtnombre.Text = Lector["nombres"].ToString();
                txtcalle.Text = Lector["calle"].ToString();
                txtnumerocalle.Text = Lector["numero"].ToString();
                txtcolonia.Text = Lector["colonia"].ToString();
                txtmunicipio.Text = Lector["municipio"].ToString();
                txtm.Text = Lector["masculino"].ToString();
                txtf.Text = Lector["femenino"].ToString();


                txttelefono.Text = Lector["telefono"].ToString();
                txtcelular.Text = Lector["celular"].ToString();
                txtcp.Text = Lector["cp"].ToString();
                txtcurp.Text = Lector["curp"].ToString();
                txtemail.Text = Lector["email"].ToString();
                txtfechanac.Text = Lector["lugaryfechanac"].ToString();
                txtsoltero.Text = Lector["soltero"].ToString();
                txtcasado.Text = Lector["casado"].ToString();
                txtdivorciado.Text = Lector["divorciado"].ToString();
                txtunionlibre.Text = Lector["unionlibre"].ToString();
                txtpropia.Text = Lector["propia"].ToString();
                txtrentada.Text = Lector["rentada"].ToString();
                txtfamilia.Text = Lector["familia"].ToString();
                txtpropio.Text = Lector["propio"].ToString();
                txtintercambio.Text = Lector["intercambio"].ToString();
                txtbeca.Text = Lector["beca"].ToString();




                txttsi.Text = Lector["tsi"].ToString();
                txttno.Text = Lector["tno"].ToString();
                txtpublico.Text = Lector["publico"].ToString();
                txtprivado.Text = Lector["privado"].ToString();
                txtasi.Text = Lector["asi"].ToString();
                txtano.Text = Lector["ano"].ToString();

                txtimss.Text = Lector["imss"].ToString();
                txtissste.Text = Lector["issste"].ToString();

                txtnumhab.Text = Lector["numhab"].ToString();

                txtnomescuela.Text = Lector["nomescuela"].ToString();
                txtpromedio.Text = Lector["promedio"].ToString();
                txtañoegreso.Text = Lector["añodeegreso"].ToString();
                txtubicacion.Text = Lector["ubicacion"].ToString();
                txtpais.Text = Lector["pais"].ToString();
                txtestado.Text = Lector["estado"].ToString();
                txtmuni.Text = Lector["muni"].ToString();
                txtlocalidad.Text = Lector["localidad"].ToString();

                txtmapellidos.Text = Lector["mapellidos"].ToString();
                txtmnombres.Text = Lector["mnombres"].ToString();
                txtmdireccion.Text = Lector["mdireccion"].ToString();
                txtmciudad.Text = Lector["mciudad"].ToString();
                txtmestado.Text = Lector["mestado"].ToString();
                txtmtelcasa.Text = Lector["mtelcasa"].ToString();
                txtmteltrabajo.Text = Lector["mteltrabajo"].ToString();
                txtmcp.Text = Lector["mcp"].ToString();
                txtmtelcelular.Text = Lector["mtelcelular"].ToString();
                txtmemail.Text = Lector["memail"].ToString();

                txtpapellidos.Text = Lector["papellidos"].ToString();
                txtpnombres.Text = Lector["pnombres"].ToString();
                txtpdireccion.Text = Lector["pdireccion"].ToString();
                txtpciudad.Text = Lector["pciudad"].ToString();
                txtpestado.Text = Lector["pestado"].ToString();
                txtptelcasa.Text = Lector["ptelcasa"].ToString();
                txtpteltrabajo.Text = Lector["pteltrabajo"].ToString();
                txtpcp.Text = Lector["pcp"].ToString();
                txtptelcelular.Text = Lector["ptelcelular"].ToString();
                txtpemail.Text = Lector["pemail"].ToString();

                txttapellidos.Text = Lector["tapellidos"].ToString();
                txttnombres.Text = Lector["tnombres"].ToString();
                txttdireccion.Text = Lector["tdireccion"].ToString();
                txttciudad.Text = Lector["tciudad"].ToString();
                txttestado.Text = Lector["testado"].ToString();
                txtttelcasa.Text = Lector["ttelcasa"].ToString();
                txttteltrabajo.Text = Lector["tteltrabajo"].ToString();
                txttcp.Text = Lector["tcp"].ToString();
                txtttelcelular.Text = Lector["ttelcelular"].ToString();
                txttemail.Text = Lector["temail"].ToString();

                txtenombres.Text = Lector["enombre"].ToString();
                txteparentesco.Text = Lector["eparentesco"].ToString();
                txtetelcasa.Text = Lector["etelcasa"].ToString();
                txteteltrabajo.Text = Lector["eteltrabajo"].ToString();
                txtetelcelular.Text = Lector["etelcelular"].ToString();
                txteemail.Text = Lector["eemail"].ToString();

                txtimdoctor.Text = Lector["imdoctor"].ToString();
                txtimhospital.Text = Lector["imhospital"].ToString();
                txtimdireccion.Text = Lector["imdireccion"].ToString();
                txtimciudad.Text = Lector["imciudad"].ToString();
                txtimtiposangre.Text = Lector["imtipodesangre"].ToString();
                txtimtelhospi.Text = Lector["imtelhospi"].ToString();
                txtimtelconsulta.Text = Lector["imtelconsulta"].ToString();
                txtimalergias.Text = Lector["imalergias"].ToString();
                txtimenferme.Text = Lector["imenferme"].ToString();
                txtimmedicamentos.Text = Lector["immedicamentos"].ToString();



            }
            MessageBox.Show("Esto es lo que encontré");
            Conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro quieres eliminar al alumno?", "Eliminar Alumno", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
                SqlCommand instruccion = new SqlCommand("DELETE InscriLiceo WHERE nocuenta=@nocuenta", Conexion);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Creamos el objeto qe apuntara al reporte de crystal en mi caso CrystalReport1.rpt
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Alejandro\Desktop\Liceo Delta\Alumnos\Alumnos\CrystalReport1.rpt");

            //Contendra los objetos cada campo de parámetros del informe.
            ParameterFieldDefinitions pfds;
            //representa un registro en el reporte
            ParameterFieldDefinition pfd;
            //objeto qe contendra el valor del parametro
            ParameterValues pvs = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtnombre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nombre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtnocuenta.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nocuenta"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtlugaryfecha.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["lugaryfecha"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtapellidop.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["apellidopaterno"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtcarrera.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["carrera"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtsemestre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["semestre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtgrupo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["grupo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtplans.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["plan"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtarea.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["area"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtapellidom.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["apellidomaterno"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtcalle.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["calle"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtnumerocalle.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["numero"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtcolonia.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["colonia"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtmunicipio.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["municipio"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtm.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["masculino"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtf.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["femenino"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txttelefono.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["telefono"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtcelular.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["celular"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtcp.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["cp"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtcurp.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["curp"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtemail.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["email"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtfechanac.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["fechanac"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtsoltero.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["soltero"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtcasado.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["casado"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtdivorciado.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["divorciado"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtunionlibre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["unionlibre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtpropia.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["propia"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtrentada.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["rentada"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtfamilia.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["familia"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtpropio.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["propio"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtintercambio.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["intercambio"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtbeca.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["beca"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtasi.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["asi"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtano.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ano"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtimss.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["imss"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtissste.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["issste"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txttsi.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["tsi"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txttno.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["tno"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtpublico.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["publico"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtprivado.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["privado"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtnumhab.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["numhab"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtnomescuela.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nomescuela"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtpromedio.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["promedio"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtañoegreso.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["añodeegreso"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtubicacion.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ubicacion"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtpais.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["pais"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtestado.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["estado"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtmuni.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["muni"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = cboxciclo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ciclo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el segundo valor del textbox y el nombre del segundo parametro
            pdv.Value = txtañoingre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["añodeingreso"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);
 


            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();

            

            

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Creamos el objeto qe apuntara al reporte de crystal en mi caso CrystalReport1.rpt
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Alejandro\Desktop\Liceo Delta\Alumnos\Alumnos\CrystalReport2.rpt");

            //Contendra los objetos cada campo de parámetros del informe.
            ParameterFieldDefinitions pfds;
            //representa un registro en el reporte
            ParameterFieldDefinition pfd;
            //objeto qe contendra el valor del parametro
            ParameterValues pvs = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmapellidos.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mapellidos"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmnombres.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mnombre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmdireccion.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mdireccion"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmciudad.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mciudad"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmestado.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mestado"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmtelcasa.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mtelcasa"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmteltrabajo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mteltrabajo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmcp.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mcp"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmtelcelular.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mcelular"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmemail.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["memail"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);






            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtpapellidos.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["papellidos"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtpnombres.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["pnombre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtpdireccion.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["pdireccion"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtpciudad.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["pciudad"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtpestado.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["pestado"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtptelcasa.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ptelcasa"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtpteltrabajo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["pteltrabajo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtpcp.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["pcp"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtptelcelular.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["pcelular"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtpemail.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["pemail"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);







            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txttapellidos.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["tapellidos"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txttnombres.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["tnombre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txttdireccion.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["tdireccion"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txttciudad.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["tciudad"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txttestado.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["testado"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtttelcasa.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ttelcasa"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txttteltrabajo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["tteltrabajo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txttcp.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["tcp"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtttelcelular.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["tcelular"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txttemail.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["temail"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);




            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtenombres.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["enombre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txteparentesco.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["eparentesco"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtetelcasa.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["etelcasa"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txteteltrabajo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["eteltrabajo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txttemail.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["temail"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtetelcelular.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ecelular"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txteemail.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["eemail"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtimhospital.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["imhospital"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtimdoctor.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["imdoctor"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtimdireccion.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["imdireccion"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtimciudad.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["imciudad"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);


            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtimtiposangre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["imtipodesangre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtimtelhospi.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["imtelhospital"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtimtelconsulta.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["imtelconsulta"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtimalergias.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["imalergias"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtimenferme.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["imenfermedades"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtimmedicamentos.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["immedicamentos"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        private void txtlugaryfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("UPDATE InscriLiceo SET lugaryfecha=@lugaryfecha, carrera=@carrera, semestre=@semestre, grupo=@grupo, año=@año, ciclo=@ciclo, plans=@plans, area=@area, apellidopaterno=@apellidopaterno, apellidomaterno=@apellidomaterno, nombres=@nombres, calle=@calle, numero=@numero, colonia=@colonia, municipio=@municipio, femenino=@femenino, masculino=@masculino, telefono=@telefono, celular=@celular, cp=@cp, curp=@curp, email=@email, lugaryfechanac=@lugaryfechanac, soltero=@soltero, casado=@casado, divorciado=@divorciado, unionlibre=@unionlibre, propia=@propia, rentada=@rentada, tsi=@tsi, tno=@tno, familia=@familia, propio=@propio, intercambio=@intercambio, beca=@beca, publico=@publico, privado=@privado, asi=@asi, ano=@ano, imss=@imss, issste=@issste, numhab=@numhab, nomescuela=@nomescuela, promedio=@promedio, añodeegreso=@añodeegreso, ubicacion=@ubicacion, pais=@pais, estado=@estado, muni=@muni, localidad=@localidad, mapellidos=@mapellidos, mnombres=@mnombres, mdireccion=@mdireccion, mciudad=@mciudad, mestado=@mestado, mtelcasa=@mtelcasa, mteltrabajo=@mteltrabajo, mcp=@mcp,  mtelcelular=@mtelcelular, memail=@memail, papellidos=@papellidos, pnombres=@pnombres, pdireccion=@pdireccion, pciudad=@pciudad, pestado=@pestado, ptelcasa=@ptelcasa, pteltrabajo=@pteltrabajo, pcp=@pcp,  ptelcelular=@ptelcelular, pemail=@pemail, tapellidos=@tapellidos, tnombres=@tnombres, tdireccion=@tdireccion, tciudad=@tciudad, testado=@testado, ttelcasa=@ttelcasa, tteltrabajo=@tteltrabajo, tcp=@tcp,  ttelcelular=@ttelcelular, temail=@temail, enombre=@enombre, eparentesco=@eparentesco, etelcasa=@etelcasa, eteltrabajo=@eteltrabajo, etelcelular=@etelcelular, eemail=@eemail, imdoctor=@imdoctor, imhospital=@imhospital, imdireccion=@imdireccion, imciudad=@imciudad, imtipodesangre=@imtipodesangre, imtelhospi=@imtelhospi, imtelconsulta=@imtelconsulta, imalergias=@imalergias, imenferme=@imenferme, immedicamentos=@immedicamentos WHERE nocuenta=@nocuenta", Conexion);
            instruccion.Parameters.AddWithValue("@lugaryfecha ", txtlugaryfecha.Text);
            instruccion.Parameters.AddWithValue("@carrera", txtcarrera.Text);
            instruccion.Parameters.AddWithValue("@semestre", txtsemestre.Text);
            instruccion.Parameters.AddWithValue("@grupo ", txtgrupo.Text);
            instruccion.Parameters.AddWithValue("@año", txtañoingre.Text);
            instruccion.Parameters.AddWithValue("@ciclo", cboxciclo.Text);
            instruccion.Parameters.AddWithValue("@plans", txtplans.Text);
            instruccion.Parameters.AddWithValue("@area ", txtarea.Text);

            instruccion.Parameters.AddWithValue("@apellidopaterno ", txtapellidop.Text);
            instruccion.Parameters.AddWithValue("@apellidomaterno ", txtapellidom.Text);
            instruccion.Parameters.AddWithValue("@nombres ", txtnombre.Text);
            instruccion.Parameters.AddWithValue("@calle ", txtcalle.Text);
            instruccion.Parameters.AddWithValue("@numero ", txtnumerocalle.Text);
            instruccion.Parameters.AddWithValue("@colonia ", txtcolonia.Text);
            instruccion.Parameters.AddWithValue("@municipio ", txtmunicipio.Text);
            instruccion.Parameters.AddWithValue("@femenino ", txtf.Text);
            instruccion.Parameters.AddWithValue("@masculino ", txtm.Text);
            instruccion.Parameters.AddWithValue("@telefono ", txttelefono.Text);
            instruccion.Parameters.AddWithValue("@celular ", txtcelular.Text);
            instruccion.Parameters.AddWithValue("@cp ", txtcp.Text);
            instruccion.Parameters.AddWithValue("@curp ", txtcurp.Text);
            instruccion.Parameters.AddWithValue("@email ", txtemail.Text);
            instruccion.Parameters.AddWithValue("@lugaryfechanac ", txtfechanac.Text);

            instruccion.Parameters.AddWithValue("@soltero ", txtsoltero.Text);
            instruccion.Parameters.AddWithValue("@casado ", txtcasado.Text);
            instruccion.Parameters.AddWithValue("@divorciado ", txtdivorciado.Text);
            instruccion.Parameters.AddWithValue("@unionlibre ", txtunionlibre.Text);
            instruccion.Parameters.AddWithValue("@propia ", txtpropia.Text);
            instruccion.Parameters.AddWithValue("@rentada ", txtrentada.Text);
            instruccion.Parameters.AddWithValue("@tsi ", txttsi.Text);
            instruccion.Parameters.AddWithValue("@tno ", txttno.Text);
            instruccion.Parameters.AddWithValue("@familia ", txtfamilia.Text);
            instruccion.Parameters.AddWithValue("@propio ", txtpropio.Text);
            instruccion.Parameters.AddWithValue("@intercambio ", txtintercambio.Text);
            instruccion.Parameters.AddWithValue("@beca ", txtbeca.Text);
            instruccion.Parameters.AddWithValue("@publico ", txtpublico.Text);
            instruccion.Parameters.AddWithValue("@privado ", txtprivado.Text);
            instruccion.Parameters.AddWithValue("@asi ", txtasi.Text);
            instruccion.Parameters.AddWithValue("@ano ", txtano.Text);
            instruccion.Parameters.AddWithValue("@imss ", txtimss.Text);
            instruccion.Parameters.AddWithValue("@issste ", txtissste.Text);
            instruccion.Parameters.AddWithValue("@numhab ", txtnumhab.Text);
            instruccion.Parameters.AddWithValue("@nomescuela ", txtnomescuela.Text);
            instruccion.Parameters.AddWithValue("@promedio ", txtpromedio.Text);
            instruccion.Parameters.AddWithValue("@añodeegreso ", txtañoegreso.Text);
            instruccion.Parameters.AddWithValue("@ubicacion ", txtubicacion.Text);
            instruccion.Parameters.AddWithValue("@pais ", txtpais.Text);
            instruccion.Parameters.AddWithValue("@estado ", txtestado.Text);
            instruccion.Parameters.AddWithValue("@muni ", txtmuni.Text);
            instruccion.Parameters.AddWithValue("@localidad ", txtlocalidad.Text);

            instruccion.Parameters.AddWithValue("@mapellidos ", txtmapellidos.Text);
            instruccion.Parameters.AddWithValue("@mnombres ", txtmnombres.Text);
            instruccion.Parameters.AddWithValue("@mdireccion ", txtmdireccion.Text);
            instruccion.Parameters.AddWithValue("@mciudad ", txtmciudad.Text);
            instruccion.Parameters.AddWithValue("@mestado ", txtmestado.Text);
            instruccion.Parameters.AddWithValue("@mtelcasa ", txtmtelcasa.Text);
            instruccion.Parameters.AddWithValue("@mteltrabajo ", txtmteltrabajo.Text);
            instruccion.Parameters.AddWithValue("@mcp ", txtmcp.Text);
            instruccion.Parameters.AddWithValue("@mtelcelular ", txtmtelcelular.Text);
            instruccion.Parameters.AddWithValue("@memail ", txtmemail.Text);

            instruccion.Parameters.AddWithValue("@papellidos ", txtpapellidos.Text);
            instruccion.Parameters.AddWithValue("@pnombres ", txtpnombres.Text);
            instruccion.Parameters.AddWithValue("@pdireccion ", txtpdireccion.Text);
            instruccion.Parameters.AddWithValue("@pciudad ", txtpciudad.Text);
            instruccion.Parameters.AddWithValue("@pestado ", txtpestado.Text);
            instruccion.Parameters.AddWithValue("@ptelcasa ", txtptelcasa.Text);
            instruccion.Parameters.AddWithValue("@pteltrabajo ", txtpteltrabajo.Text);
            instruccion.Parameters.AddWithValue("@pcp ", txtpcp.Text);
            instruccion.Parameters.AddWithValue("@ptelcelular ", txtptelcelular.Text);
            instruccion.Parameters.AddWithValue("@pemail ", txtpemail.Text);

            instruccion.Parameters.AddWithValue("@tapellidos ", txttapellidos.Text);
            instruccion.Parameters.AddWithValue("@tnombres ", txttnombres.Text);
            instruccion.Parameters.AddWithValue("@tdireccion ", txttdireccion.Text);
            instruccion.Parameters.AddWithValue("@tciudad ", txttciudad.Text);
            instruccion.Parameters.AddWithValue("@testado ", txttestado.Text);
            instruccion.Parameters.AddWithValue("@ttelcasa ", txtttelcasa.Text);
            instruccion.Parameters.AddWithValue("@tteltrabajo ", txttteltrabajo.Text);
            instruccion.Parameters.AddWithValue("@tcp ", txttcp.Text);
            instruccion.Parameters.AddWithValue("@ttelcelular ", txtttelcelular.Text);
            instruccion.Parameters.AddWithValue("@temail ", txttemail.Text);

            instruccion.Parameters.AddWithValue("@enombre ", txtenombres.Text);
            instruccion.Parameters.AddWithValue("@eparentesco ", txteparentesco.Text);
            instruccion.Parameters.AddWithValue("@etelcasa ", txtetelcasa.Text);
            instruccion.Parameters.AddWithValue("@eteltrabajo ", txteteltrabajo.Text);
            instruccion.Parameters.AddWithValue("@etelcelular ", txtetelcelular.Text);
            instruccion.Parameters.AddWithValue("@eemail ", txteemail.Text);

            instruccion.Parameters.AddWithValue("@imdoctor ", txtimdoctor.Text);
            instruccion.Parameters.AddWithValue("@imhospital ", txtimhospital.Text);
            instruccion.Parameters.AddWithValue("@imdireccion ", txtimdireccion.Text);
            instruccion.Parameters.AddWithValue("@imciudad ", txtimciudad.Text);
            instruccion.Parameters.AddWithValue("@imtipodesangre ", txtimtiposangre.Text);
            instruccion.Parameters.AddWithValue("@imtelhospi ", txtimtelhospi.Text);
            instruccion.Parameters.AddWithValue("@imtelconsulta ", txtimtelconsulta.Text);
            instruccion.Parameters.AddWithValue("@imalergias ", txtimalergias.Text);
            instruccion.Parameters.AddWithValue("@imenferme ", txtimenferme.Text);
            instruccion.Parameters.AddWithValue("@immedicamentos ", txtimmedicamentos.Text);
            instruccion.Parameters.AddWithValue("@nocuenta ", txtnocuenta.Text);
            Conexion.Open();
            instruccion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Alumno Modificado");
        }

        private void label119_Click(object sender, EventArgs e)
        {

        }

        private void label118_Click(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void label117_Click(object sender, EventArgs e)
        {

        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label109_Click(object sender, EventArgs e)
        {

        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void label107_Click(object sender, EventArgs e)
        {

        }

        private void label108_Click(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label112_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void label114_Click(object sender, EventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void txtmtelcasa_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
