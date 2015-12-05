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
    public partial class Boletas1 : Form
    {
        public Boletas1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Insert INTO Boletas(nocuenta, nombre, semestre, grupo, materia1, materia2, materia3, materia4, materia5, materia6, materia7, materia8, materia9, mat11, mat21, mat31, mat41, mat51, mat61, mat71, mat81, mat91, mat12, mat22, mat32, mat42, mat52, mat62, mat72, mat82, mat92, mat13, mat23, mat33, mat43, mat53, mat63, mat73, mat83, mat93, ord1, ord2, ord3, ord4, ord5, ord6, ord7, ord8, ord9, extra1, extra2, extra3, extra4, extra5, extra6, extra7, extra8, extra9, final1, final2, final3, final4, final5, final6, final7, final8, final9) VALUES (@nocuenta, @nombre, @semestre, @grupo, @materia1, @materia2, @materia3, @materia4, @materia5, @materia6, @materia7, @materia8, @materia9, @mat11, @mat21, @mat31, @mat41, @mat51, @mat61, @mat71, @mat81, @mat91, @mat12, @mat22, @mat32, @mat42, @mat52, @mat62, @mat72, @mat82, @mat92, @mat13, @mat23, @mat33, @mat43, @mat53, @mat63, @mat73, @mat83, @mat93, @ord1, @ord2, @ord3, @ord4, @ord5, @ord6, @ord7, @ord8, @ord9, @extra1, @extra2, @extra3, @extra4, @extra5, @extra6, @extra7, @extra8, @extra9, @final1, @final2, @final3, @final4, @final5, @final6, @final7, @final8, @final9)", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtnocuenta.Text);
            instruccion.Parameters.AddWithValue("@nombre ", txtnombre.Text);
            instruccion.Parameters.AddWithValue("@semestre", txtsemestre.Text);
            instruccion.Parameters.AddWithValue("@grupo", txtgrupo.Text);

            instruccion.Parameters.AddWithValue("@materia1", cboxmat1.Text);
            instruccion.Parameters.AddWithValue("@materia2", cboxmat2.Text);
            instruccion.Parameters.AddWithValue("@materia3", cboxmat3.Text);
            instruccion.Parameters.AddWithValue("@materia4", cboxmat4.Text);
            instruccion.Parameters.AddWithValue("@materia5", cboxmat5.Text);
            instruccion.Parameters.AddWithValue("@materia6", cboxmat6.Text);
            instruccion.Parameters.AddWithValue("@materia7", cboxmat7.Text);
            instruccion.Parameters.AddWithValue("@materia8", cboxmat8.Text);
            instruccion.Parameters.AddWithValue("@materia9", cboxmat9.Text);

            instruccion.Parameters.AddWithValue("@mat11", txtmat11.Text);
            instruccion.Parameters.AddWithValue("@mat21", txtmat21.Text);
            instruccion.Parameters.AddWithValue("@mat31", txtmat31.Text);
            instruccion.Parameters.AddWithValue("@mat41", txtmat41.Text);
            instruccion.Parameters.AddWithValue("@mat51", txtmat51.Text);
            instruccion.Parameters.AddWithValue("@mat61", txtmat61.Text);
            instruccion.Parameters.AddWithValue("@mat71", txtmat71.Text);
            instruccion.Parameters.AddWithValue("@mat81", cboxmat81.Text);
            instruccion.Parameters.AddWithValue("@mat91", cboxmat91.Text);

            instruccion.Parameters.AddWithValue("@mat12", txtmat12.Text);
            instruccion.Parameters.AddWithValue("@mat22", txtmat22.Text);
            instruccion.Parameters.AddWithValue("@mat32", txtmat32.Text);
            instruccion.Parameters.AddWithValue("@mat42", txtmat42.Text);
            instruccion.Parameters.AddWithValue("@mat52", txtmat52.Text);
            instruccion.Parameters.AddWithValue("@mat62", txtmat62.Text);
            instruccion.Parameters.AddWithValue("@mat72", txtmat72.Text);
            instruccion.Parameters.AddWithValue("@mat82", cboxmat82.Text);
            instruccion.Parameters.AddWithValue("@mat92", cboxmat92.Text);

            instruccion.Parameters.AddWithValue("@mat13", txtmat13.Text);
            instruccion.Parameters.AddWithValue("@mat23", txtmat23.Text);
            instruccion.Parameters.AddWithValue("@mat33", txtmat33.Text);
            instruccion.Parameters.AddWithValue("@mat43", txtmat43.Text);
            instruccion.Parameters.AddWithValue("@mat53", txtmat53.Text);
            instruccion.Parameters.AddWithValue("@mat63", txtmat63.Text);
            instruccion.Parameters.AddWithValue("@mat73", txtmat73.Text);
            instruccion.Parameters.AddWithValue("@mat83", cboxmat83.Text);
            instruccion.Parameters.AddWithValue("@mat93", cboxmat93.Text);

            instruccion.Parameters.AddWithValue("@ord1", txtord1.Text);
            instruccion.Parameters.AddWithValue("@ord2", txtord2.Text);
            instruccion.Parameters.AddWithValue("@ord3", txtord3.Text);
            instruccion.Parameters.AddWithValue("@ord4", txtord4.Text);
            instruccion.Parameters.AddWithValue("@ord5", txtord5.Text);
            instruccion.Parameters.AddWithValue("@ord6", txtord6.Text);
            instruccion.Parameters.AddWithValue("@ord7", txtord7.Text);
            instruccion.Parameters.AddWithValue("@ord8", cboxord8.Text);
            instruccion.Parameters.AddWithValue("@ord9", cboxord9.Text);

            instruccion.Parameters.AddWithValue("@extra1", txtextra1.Text);
            instruccion.Parameters.AddWithValue("@extra2", txtextra2.Text);
            instruccion.Parameters.AddWithValue("@extra3", txtextra3.Text);
            instruccion.Parameters.AddWithValue("@extra4", txtextra4.Text);
            instruccion.Parameters.AddWithValue("@extra5", txtextra5.Text);
            instruccion.Parameters.AddWithValue("@extra6", txtextra6.Text);
            instruccion.Parameters.AddWithValue("@extra7", txtextra7.Text);
            instruccion.Parameters.AddWithValue("@extra8", cboxextra8.Text);
            instruccion.Parameters.AddWithValue("@extra9", cboxextra9.Text);

            instruccion.Parameters.AddWithValue("@final1", txtfin1.Text);
            instruccion.Parameters.AddWithValue("@final2", txtfin2.Text);
            instruccion.Parameters.AddWithValue("@final3", txtfin3.Text);
            instruccion.Parameters.AddWithValue("@final4", txtfin4.Text);
            instruccion.Parameters.AddWithValue("@final5", txtfin5.Text);
            instruccion.Parameters.AddWithValue("@final6", txtfin6.Text);
            instruccion.Parameters.AddWithValue("@final7", txtfin7.Text);
            instruccion.Parameters.AddWithValue("@final8", cboxfin8.Text);
            instruccion.Parameters.AddWithValue("@final9", cboxfin9.Text);





            Conexion.Open();
            instruccion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Calificaciones Guardadas");

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Boletas WHERE nocuenta LIKE @nocuenta +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtbuscar.Text);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            while (Lector.Read())
            {
                txtnocuenta.Text = Lector["nocuenta"].ToString();
                txtnombre.Text = Lector["nombre"].ToString();
                txtsemestre.Text = Lector["semestre"].ToString();
                txtgrupo.Text = Lector["grupo"].ToString();

                cboxmat1.Text = Lector["materia1"].ToString();
                cboxmat2.Text = Lector["materia2"].ToString();
                cboxmat3.Text = Lector["materia3"].ToString();
                cboxmat4.Text = Lector["materia4"].ToString();
                cboxmat5.Text = Lector["materia5"].ToString();
                cboxmat6.Text = Lector["materia6"].ToString();
                cboxmat7.Text = Lector["materia7"].ToString();
                cboxmat8.Text = Lector["materia8"].ToString();
                cboxmat9.Text = Lector["materia9"].ToString();

                txtmat11.Text = Lector["mat11"].ToString();
                txtmat21.Text = Lector["mat21"].ToString();
                txtmat31.Text = Lector["mat31"].ToString();
                txtmat41.Text = Lector["mat41"].ToString();
                txtmat51.Text = Lector["mat51"].ToString();
                txtmat61.Text = Lector["mat61"].ToString();
                txtmat71.Text = Lector["mat71"].ToString();
                cboxmat81.Text = Lector["mat81"].ToString();
                cboxmat91.Text = Lector["mat91"].ToString();

                txtmat12.Text = Lector["mat12"].ToString();
                txtmat22.Text = Lector["mat22"].ToString();
                txtmat32.Text = Lector["mat32"].ToString();
                txtmat42.Text = Lector["mat42"].ToString();
                txtmat52.Text = Lector["mat52"].ToString();
                txtmat62.Text = Lector["mat62"].ToString();
                txtmat72.Text = Lector["mat72"].ToString();
                cboxmat82.Text = Lector["mat82"].ToString();
                cboxmat92.Text = Lector["mat92"].ToString();

                txtmat13.Text = Lector["mat13"].ToString();
                txtmat23.Text = Lector["mat23"].ToString();
                txtmat33.Text = Lector["mat33"].ToString();
                txtmat43.Text = Lector["mat43"].ToString();
                txtmat53.Text = Lector["mat53"].ToString();
                txtmat63.Text = Lector["mat63"].ToString();
                txtmat73.Text = Lector["mat73"].ToString();
                cboxmat83.Text = Lector["mat83"].ToString();
                cboxmat93.Text = Lector["mat93"].ToString();

                txtord1.Text = Lector["ord1"].ToString();
                txtord2.Text = Lector["ord2"].ToString();
                txtord3.Text = Lector["ord3"].ToString();
                txtord4.Text = Lector["ord4"].ToString();
                txtord5.Text = Lector["ord5"].ToString();
                txtord6.Text = Lector["ord6"].ToString();
                txtord7.Text = Lector["ord7"].ToString();
                cboxord8.Text = Lector["ord8"].ToString();
                cboxord9.Text = Lector["ord9"].ToString();

                txtextra1.Text = Lector["extra1"].ToString();
                txtextra2.Text = Lector["extra2"].ToString();
                txtextra3.Text = Lector["extra3"].ToString();
                txtextra4.Text = Lector["extra4"].ToString();
                txtextra5.Text = Lector["extra5"].ToString();
                txtextra6.Text = Lector["extra6"].ToString();
                txtextra7.Text = Lector["extra7"].ToString();
                cboxextra8.Text = Lector["extra8"].ToString();
                cboxextra9.Text = Lector["extra9"].ToString();

                txtfin1.Text = Lector["final1"].ToString();
                txtfin2.Text = Lector["final2"].ToString();
                txtfin3.Text = Lector["final3"].ToString();
                txtfin4.Text = Lector["final4"].ToString();
                txtfin5.Text = Lector["final5"].ToString();
                txtfin6.Text = Lector["final6"].ToString();
                txtfin7.Text = Lector["final7"].ToString();
                cboxfin8.Text = Lector["final8"].ToString();
                cboxfin9.Text = Lector["final9"].ToString();


            }
            MessageBox.Show("Lectura Correcta");
            Conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro quieres eliminar al alumno?", "Eliminar Alumno", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("DELETE Boletas WHERE nocuenta=@nocuenta", Conexion);
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
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("UPDATE Boletas SET nocuenta=@nocuenta, nombre=@nombre, semestre=@semestre, grupo=@grupo, materia1=@materia1, materia2=@materia2, materia3=@materia3, materia4=@materia4, materia5=@materia5, materia6=@materia6, materia7=@materia7, materia8=@materia8, materia9=@materia9, mat11=@mat11, mat21=@mat21, mat31=@mat31, mat41=@mat41, mat51=@mat51, mat61=@mat61, mat71=@mat71, mat81=@mat81, mat91=@mat91, mat12=@mat12, mat22=@mat22, mat32=@mat32, mat42=@mat42, mat52=@mat52, mat62=@mat62, mat72=@mat72, mat82=@mat82, mat92=@mat92, mat13=@mat13, mat23=@mat23, mat33=@mat33, mat43=@mat43, mat53=@mat53, mat63=@mat63, mat73=@mat73, mat83=@mat83, mat93=@mat93, ord1=@ord1, ord2=@ord2, ord3=@ord3, ord4=@ord4, ord5=@ord5, ord6=@ord6, ord7=@ord7, ord8=@ord8, ord9=@ord9, extra1=@extra1, extra2=@extra2, extra3=@extra3, extra4=@extra4, extra5=@extra5, extra6=@extra6, extra7=@extra7, extra8=@extra8, extra9=@extra9, final1=@final1, final2=@final2, final3=@final3, final4=@final4, final5=@final5, final6=@final6, final7=@final7, final8=@final8, final9=@final9", Conexion);
            instruccion.Parameters.AddWithValue("@nocuenta", txtnocuenta.Text);
            instruccion.Parameters.AddWithValue("@nombre ", txtnombre.Text);
            instruccion.Parameters.AddWithValue("@semestre", txtsemestre.Text);
            instruccion.Parameters.AddWithValue("@grupo", txtgrupo.Text);

            instruccion.Parameters.AddWithValue("@materia1", cboxmat1.Text);
            instruccion.Parameters.AddWithValue("@materia2", cboxmat2.Text);
            instruccion.Parameters.AddWithValue("@materia3", cboxmat3.Text);
            instruccion.Parameters.AddWithValue("@materia4", cboxmat4.Text);
            instruccion.Parameters.AddWithValue("@materia5", cboxmat5.Text);
            instruccion.Parameters.AddWithValue("@materia6", cboxmat6.Text);
            instruccion.Parameters.AddWithValue("@materia7", cboxmat7.Text);
            instruccion.Parameters.AddWithValue("@materia8", cboxmat8.Text);
            instruccion.Parameters.AddWithValue("@materia9", cboxmat9.Text);

            instruccion.Parameters.AddWithValue("@mat11", txtmat11.Text);
            instruccion.Parameters.AddWithValue("@mat21", txtmat21.Text);
            instruccion.Parameters.AddWithValue("@mat31", txtmat31.Text);
            instruccion.Parameters.AddWithValue("@mat41", txtmat41.Text);
            instruccion.Parameters.AddWithValue("@mat51", txtmat51.Text);
            instruccion.Parameters.AddWithValue("@mat61", txtmat61.Text);
            instruccion.Parameters.AddWithValue("@mat71", txtmat71.Text);
            instruccion.Parameters.AddWithValue("@mat81", cboxmat81.Text);
            instruccion.Parameters.AddWithValue("@mat91", cboxmat91.Text);

            instruccion.Parameters.AddWithValue("@mat12", txtmat12.Text);
            instruccion.Parameters.AddWithValue("@mat22", txtmat22.Text);
            instruccion.Parameters.AddWithValue("@mat32", txtmat32.Text);
            instruccion.Parameters.AddWithValue("@mat42", txtmat42.Text);
            instruccion.Parameters.AddWithValue("@mat52", txtmat52.Text);
            instruccion.Parameters.AddWithValue("@mat62", txtmat62.Text);
            instruccion.Parameters.AddWithValue("@mat72", txtmat72.Text);
            instruccion.Parameters.AddWithValue("@mat82", cboxmat82.Text);
            instruccion.Parameters.AddWithValue("@mat92", cboxmat92.Text);

            instruccion.Parameters.AddWithValue("@mat13", txtmat13.Text);
            instruccion.Parameters.AddWithValue("@mat23", txtmat23.Text);
            instruccion.Parameters.AddWithValue("@mat33", txtmat33.Text);
            instruccion.Parameters.AddWithValue("@mat43", txtmat43.Text);
            instruccion.Parameters.AddWithValue("@mat53", txtmat53.Text);
            instruccion.Parameters.AddWithValue("@mat63", txtmat63.Text);
            instruccion.Parameters.AddWithValue("@mat73", txtmat73.Text);
            instruccion.Parameters.AddWithValue("@mat83", cboxmat83.Text);
            instruccion.Parameters.AddWithValue("@mat93", cboxmat93.Text);

            instruccion.Parameters.AddWithValue("@ord1", txtord1.Text);
            instruccion.Parameters.AddWithValue("@ord2", txtord2.Text);
            instruccion.Parameters.AddWithValue("@ord3", txtord3.Text);
            instruccion.Parameters.AddWithValue("@ord4", txtord4.Text);
            instruccion.Parameters.AddWithValue("@ord5", txtord5.Text);
            instruccion.Parameters.AddWithValue("@ord6", txtord6.Text);
            instruccion.Parameters.AddWithValue("@ord7", txtord7.Text);
            instruccion.Parameters.AddWithValue("@ord8", cboxord8.Text);
            instruccion.Parameters.AddWithValue("@ord9", cboxord9.Text);

            instruccion.Parameters.AddWithValue("@extra1", txtextra1.Text);
            instruccion.Parameters.AddWithValue("@extra2", txtextra2.Text);
            instruccion.Parameters.AddWithValue("@extra3", txtextra3.Text);
            instruccion.Parameters.AddWithValue("@extra4", txtextra4.Text);
            instruccion.Parameters.AddWithValue("@extra5", txtextra5.Text);
            instruccion.Parameters.AddWithValue("@extra6", txtextra6.Text);
            instruccion.Parameters.AddWithValue("@extra7", txtextra7.Text);
            instruccion.Parameters.AddWithValue("@extra8", cboxextra8.Text);
            instruccion.Parameters.AddWithValue("@extra9", cboxextra9.Text);

            instruccion.Parameters.AddWithValue("@final1", txtfin1.Text);
            instruccion.Parameters.AddWithValue("@final2", txtfin2.Text);
            instruccion.Parameters.AddWithValue("@final3", txtfin3.Text);
            instruccion.Parameters.AddWithValue("@final4", txtfin4.Text);
            instruccion.Parameters.AddWithValue("@final5", txtfin5.Text);
            instruccion.Parameters.AddWithValue("@final6", txtfin6.Text);
            instruccion.Parameters.AddWithValue("@final7", txtfin7.Text);
            instruccion.Parameters.AddWithValue("@final8", cboxfin8.Text);
            instruccion.Parameters.AddWithValue("@final9", cboxfin9.Text);


            Conexion.Open();
            instruccion.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Alumno Modificado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Creamos el objeto que apuntara al reporte de crystal en mi caso CrystalReport1.rpt
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\Alejandro\Desktop\Liceo Delta\Alumnos\Alumnos\CrystalReport3.rpt");

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

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtnocuenta.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["nocuenta"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtsemestre.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["semestre"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtgrupo.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["grupo"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat2.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia2"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat3.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia3"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat4.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia4"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat5.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia5"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat6.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia6"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat7.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia7"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat8.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia8"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat9.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["materia9"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);


            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmat11.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat11"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmat21.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat21"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmat31.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat31"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmat41.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat41"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmat51.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat51"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmat61.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat61"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = txtmat71.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat71"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat81.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat81"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            //aqui pasamos el valor del primer TextBox y el nombre del parametro en el reporte.
            pdv.Value = cboxmat91.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat91"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat12.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat12"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat22.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat22"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat32.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat32"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat42.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat42"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat52.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat52"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat62.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat62"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat72.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat72"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxmat82.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat82"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxmat92.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat92"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);


            pdv.Value = txtmat13.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat13"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat23.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat23"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat33.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat33"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat43.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat43"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat53.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat53"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat63.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat63"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtmat73.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat73"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxmat83.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat83"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxmat93.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["mat93"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);




            pdv.Value = txtord1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ord1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtord2.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ord2"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtord3.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ord3"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtord4.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ord4"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtord5.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ord5"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtord6.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ord6"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtord7.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ord7"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxord8.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ord8"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxord9.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["ord9"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtextra1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["extra1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtextra2.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["extra2"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtextra3.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["extra3"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtextra4.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["extra4"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtextra5.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["extra5"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtextra6.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["extra6"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtextra7.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["extra7"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxextra8.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["extra8"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxextra9.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["extra9"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtfin1.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["final1"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtfin2.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["final2"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtfin3.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["final3"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtfin4.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["final4"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtfin5.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["final5"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtfin6.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["final6"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = txtfin7.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["final7"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxfin8.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["final8"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            pdv.Value = cboxfin9.Text;
            pfds = crystalrpt.DataDefinition.ParameterFields;
            pfd = pfds["final9"];
            pvs.Add(pdv);
            pfd.ApplyCurrentValues(pvs);

            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        private void Boletas1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtfin1.Text) == 0)
                txtfin1.Text = txtextra1.Text;

            if (Convert.ToDouble(txtfin2.Text) == 0)
                txtfin2.Text = txtextra2.Text;

            if (Convert.ToDouble(txtfin3.Text) == 0)
                txtfin3.Text = txtextra3.Text;

            if (Convert.ToDouble(txtfin4.Text) == 0)
                txtfin4.Text = txtextra4.Text;

            if (Convert.ToDouble(txtfin5.Text) == 0)
                txtfin5.Text = txtextra5.Text;

            if (Convert.ToDouble(txtfin6.Text) == 0)
                txtfin6.Text = txtextra6.Text;

            if (Convert.ToDouble(txtfin7.Text) == 0)
                txtfin7.Text = txtextra7.Text;

            if (cboxfin8.Text=="0")
            cboxfin9.Text = cboxextra9.Text;

            if (cboxfin9.Text=="0")
            cboxfin9.Text = cboxextra9.Text;

            txtpromfinal.Text = ((Convert.ToDouble(txtfin1.Text) + Convert.ToDouble(txtfin2.Text) + Convert.ToDouble(txtfin3.Text) + Convert.ToDouble(txtfin4.Text) + Convert.ToDouble(txtfin5.Text) + Convert.ToDouble(txtfin6.Text) + Convert.ToDouble(txtfin7.Text)) / 7).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double fin1, fin2, fin3, fin4, fin5, fin6, fin7;
            if (Convert.ToDouble(txtmat11.Text) + Convert.ToDouble(txtmat12.Text) + Convert.ToDouble(txtmat13.Text) < 24)
                txtord1.BackColor = Color.Red;
            if (Convert.ToDouble(txtmat21.Text) + Convert.ToDouble(txtmat22.Text) + Convert.ToDouble(txtmat23.Text) < 24)
                txtord2.BackColor = Color.Red;
            if (Convert.ToDouble(txtmat31.Text) + Convert.ToDouble(txtmat32.Text) + Convert.ToDouble(txtmat33.Text) < 24)
                txtord3.BackColor = Color.Red;
            if (Convert.ToDouble(txtmat41.Text) + Convert.ToDouble(txtmat42.Text) + Convert.ToDouble(txtmat43.Text) < 24)
                txtord4.BackColor = Color.Red;
            if (Convert.ToDouble(txtmat51.Text) + Convert.ToDouble(txtmat52.Text) + Convert.ToDouble(txtmat53.Text) < 24)
                txtord5.BackColor = Color.Red;
            if (Convert.ToDouble(txtmat61.Text) + Convert.ToDouble(txtmat62.Text) + Convert.ToDouble(txtmat63.Text) < 24)
                txtord6.BackColor = Color.Red;
            if (Convert.ToDouble(txtmat71.Text) + Convert.ToDouble(txtmat72.Text) + Convert.ToDouble(txtmat73.Text) < 24)
                txtord7.BackColor = Color.Red;

            if (Convert.ToDouble(txtmat11.Text) + Convert.ToDouble(txtmat12.Text) + Convert.ToDouble(txtmat13.Text) >= 24)
            {
                fin1 = ((Convert.ToDouble(txtmat11.Text) + Convert.ToDouble(txtmat12.Text) + Convert.ToDouble(txtmat13.Text)) / 3);
                fin1 = Math.Round(fin1, 1);
                txtfin1.Text = fin1.ToString();
                txtord1.Text = "--";
                txtextra1.Text = "--";
            }
            if (Convert.ToDouble(txtmat21.Text) + Convert.ToDouble(txtmat22.Text) + Convert.ToDouble(txtmat23.Text) >= 24)
            {
                fin2 = ((Convert.ToDouble(txtmat21.Text) + Convert.ToDouble(txtmat22.Text) + Convert.ToDouble(txtmat23.Text)) / 3);
                fin2 = Math.Round(fin2, 1);
                txtfin2.Text = fin2.ToString();
                txtord2.Text = "--";
                txtextra2.Text = "--";
            }
            if (Convert.ToDouble(txtmat31.Text) + Convert.ToDouble(txtmat32.Text) + Convert.ToDouble(txtmat33.Text) >= 24)
            {
                fin3 = ((Convert.ToDouble(txtmat31.Text) + Convert.ToDouble(txtmat32.Text) + Convert.ToDouble(txtmat33.Text)) / 3);
                fin3 = Math.Round(fin3, 1);
                txtfin3.Text = fin3.ToString();
                txtord3.Text = "--";
                txtextra3.Text = "--";
            }
            if (Convert.ToDouble(txtmat41.Text) + Convert.ToDouble(txtmat42.Text) + Convert.ToDouble(txtmat43.Text) >= 24)
            {
                fin4 = ((Convert.ToDouble(txtmat41.Text) + Convert.ToDouble(txtmat42.Text) + Convert.ToDouble(txtmat43.Text)) / 3);
                fin4 = Math.Round(fin4, 1);
                txtfin4.Text = fin4.ToString();
                txtord4.Text = "--";
                txtextra4.Text = "--";
            }
            if (Convert.ToDouble(txtmat51.Text) + Convert.ToDouble(txtmat52.Text) + Convert.ToDouble(txtmat53.Text) >= 24)
            {
                fin5 = ((Convert.ToDouble(txtmat51.Text) + Convert.ToDouble(txtmat52.Text) + Convert.ToDouble(txtmat53.Text)) / 3);
                fin5 = Math.Round(fin5, 1);
                txtfin5.Text = fin5.ToString();
                txtord5.Text = "--";
                txtextra5.Text = "--";
            }
            if (Convert.ToDouble(txtmat61.Text) + Convert.ToDouble(txtmat62.Text) + Convert.ToDouble(txtmat63.Text) >= 24)
            {
                fin6 = ((Convert.ToDouble(txtmat61.Text) + Convert.ToDouble(txtmat62.Text) + Convert.ToDouble(txtmat63.Text)) / 3);
                fin6 = Math.Round(fin6, 1);
                txtfin6.Text = fin6.ToString();
                txtord6.Text = "--";
                txtextra6.Text = "--";
            }
            if (Convert.ToDouble(txtmat71.Text) + Convert.ToDouble(txtmat72.Text) + Convert.ToDouble(txtmat73.Text) >= 24)
            {
                fin7 = ((Convert.ToDouble(txtmat71.Text) + Convert.ToDouble(txtmat72.Text) + Convert.ToDouble(txtmat73.Text)) / 3);
                fin7 = Math.Round(fin7, 1);
                txtfin7.Text = fin7.ToString();
                txtord7.Text = "--";
                txtextra7.Text = "--";
            }
            if (cboxmat91.Text == "A.C." & cboxmat92.Text == "A.C." & cboxmat93.Text == "A.C.")
            {
                cboxfin9.Text = "A.C.";
                cboxord9.Text = "--";
                cboxextra9.Text = "--";
            }
            else
            {
                cboxord9.BackColor = Color.Red;
            }
            if (cboxmat81.Text == "A.C." & cboxmat82.Text == "A.C." & cboxmat83.Text == "A.C.")
            {
                cboxfin8.Text = "A.C.";
                cboxord8.Text = "--";
                cboxextra8.Text = "--";
            }
            else
            {
                cboxord8.BackColor=Color.Red;
            }
        }

        private void btnextra_Click(object sender, EventArgs e)
        {
            double fin1, fin2, fin3, fin4, fin5, fin6, fin7;
            if (Convert.ToDouble(txtfin1.Text) == 0 && Convert.ToDouble(txtord1.Text) >= 6)
            {
                fin1 = ((((Convert.ToDouble(txtmat11.Text) + Convert.ToDouble(txtmat12.Text) + Convert.ToDouble(txtmat13.Text)) / 3) + Convert.ToDouble(txtord1.Text)) / 2);
                fin1 = Math.Round(fin1, 1);
                txtfin1.Text = fin1.ToString();
                txtextra1.Text = "--";
            }
            if (Convert.ToDouble(txtfin2.Text) == 0 && Convert.ToDouble(txtord2.Text) >= 6)
            {
                fin2 = ((((Convert.ToDouble(txtmat21.Text) + Convert.ToDouble(txtmat22.Text) + Convert.ToDouble(txtmat23.Text)) / 3) + Convert.ToDouble(txtord2.Text)) / 2);
                fin2 = Math.Round(fin2, 1);
                txtfin2.Text = fin2.ToString();
                txtextra2.Text = "--";
            }
            if (Convert.ToDouble(txtfin3.Text) == 0 && Convert.ToDouble(txtord3.Text) >= 6)
            {
                fin3 = ((((Convert.ToDouble(txtmat31.Text) + Convert.ToDouble(txtmat32.Text) + Convert.ToDouble(txtmat33.Text)) / 3) + Convert.ToDouble(txtord3.Text)) / 2);
                fin3 = Math.Round(fin3, 1);
                txtfin3.Text = fin3.ToString();
                txtextra3.Text = "--";
            }
            if (Convert.ToDouble(txtfin4.Text) == 0 && Convert.ToDouble(txtord4.Text) >= 6)
            {
                fin4 = ((((Convert.ToDouble(txtmat41.Text) + Convert.ToDouble(txtmat42.Text) + Convert.ToDouble(txtmat43.Text)) / 3) + Convert.ToDouble(txtord4.Text)) / 2);
                fin4 = Math.Round(fin4, 1);
                txtfin4.Text = fin4.ToString();
                txtextra4.Text = "--";
            }
            if (Convert.ToDouble(txtfin5.Text) == 0 && Convert.ToDouble(txtord5.Text) >= 6)
            {
                fin5 = ((((Convert.ToDouble(txtmat51.Text) + Convert.ToDouble(txtmat52.Text) + Convert.ToDouble(txtmat53.Text)) / 3) + Convert.ToDouble(txtord5.Text)) / 2);
                fin5 = Math.Round(fin5, 1);
                txtfin5.Text = fin5.ToString();
                txtextra5.Text = "--";
            }
            if (Convert.ToDouble(txtfin6.Text) == 0 && Convert.ToDouble(txtord6.Text) >= 6)
            {
                fin6 = ((((Convert.ToDouble(txtmat61.Text) + Convert.ToDouble(txtmat62.Text) + Convert.ToDouble(txtmat63.Text)) / 3) + Convert.ToDouble(txtord6.Text)) / 2);
                fin6 = Math.Round(fin6, 1);
                txtfin6.Text = fin6.ToString();
                txtextra6.Text = "--";
            }
            if (Convert.ToDouble(txtfin7.Text) == 0 && Convert.ToDouble(txtord7.Text) >= 6)
            {
                fin7 = ((((Convert.ToDouble(txtmat71.Text) + Convert.ToDouble(txtmat72.Text) + Convert.ToDouble(txtmat73.Text)) / 3) + Convert.ToDouble(txtord7.Text)) / 2);
                fin7 = Math.Round(fin7, 1);
                txtfin7.Text = fin7.ToString();
                txtextra7.Text = "--";
            }

            if (Convert.ToDouble(txtfin1.Text) == 0)
                txtextra1.BackColor = Color.Red;
            if (Convert.ToDouble(txtfin2.Text) == 0)
                txtextra2.BackColor = Color.Red;
            if (Convert.ToDouble(txtfin3.Text) == 0)
                txtextra3.BackColor = Color.Red;
            if (Convert.ToDouble(txtfin4.Text) == 0)
                txtextra4.BackColor = Color.Red;
            if (Convert.ToDouble(txtfin5.Text) == 0)
                txtextra5.BackColor = Color.Red;
            if (Convert.ToDouble(txtfin6.Text) == 0)
                txtextra6.BackColor = Color.Red;
            if (Convert.ToDouble(txtfin7.Text) == 0)
                txtextra7.BackColor = Color.Red;

            if (cboxord8.Text == "A.C.")
            {
                cboxextra8.Text = "--";
                cboxfin8.Text = "A.C.";
            }
            if (cboxord8.Text == "N.A.")
            {
                cboxextra8.BackColor = Color.Red;
                cboxfin8.Text = "0";
            }
            if (cboxord9.Text == "N.A.")
            {
                cboxextra9.BackColor = Color.Red;
                cboxfin9.Text = "0";
            }

            if (cboxord9.Text == "A.C.")
            {
                cboxextra9.Text = "--";
                cboxfin9.Text = "A.C.";
            }
        }
    }
}
