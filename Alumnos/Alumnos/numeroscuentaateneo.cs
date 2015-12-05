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

namespace Alumnos
{
    public partial class numeroscuentaateneo : Form
    {
        public numeroscuentaateneo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Inscriateneo WHERE apellidopaterno LIKE @apellidopaterno +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@apellidopaterno", (txtapellidop.Text));
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            listBox1.Items.Clear();
            while (Lector.Read())
            {
                listBox1.Items.Add(Lector["nocuenta"].ToString() + " " + Lector["apellidopaterno"].ToString() + " " + Lector["apellidomaterno"].ToString() + " " + Lector["nombre"].ToString());
                listBox1.Items.Add(" ");
            }
            Conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Inscriateneo", Conexion);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            listBox1.Items.Clear();
            while (Lector.Read())
            {
                listBox1.Items.Add(Lector["nocuenta"].ToString() + " " + Lector["apellidopaterno"].ToString() + " " + Lector["apellidomaterno"].ToString() + " " + Lector["nombre"].ToString());
                listBox1.Items.Add(" ");
            }
            Conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Boletasateneo WHERE nombre LIKE @nombre +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@nombre", (txtnombre.Text));
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            listBox1.Items.Clear();
            while (Lector.Read())
            {
                listBox1.Items.Add(Lector["nocuenta"].ToString() + " " + Lector["nombre"].ToString());
                listBox1.Items.Add(" ");
            }
            Conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Boletasateneo", Conexion);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            listBox1.Items.Clear();
            while (Lector.Read())
            {
                listBox1.Items.Add(Lector["nocuenta"].ToString() + " "+ Lector["nombre"].ToString());
                listBox1.Items.Add(" ");
            }
            Conexion.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Recibosateneo WHERE recibi LIKE @recibi +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@recibi", (txtrecibi.Text));
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            listBox1.Items.Clear();
            while (Lector.Read())
            {
                listBox1.Items.Add(Lector["nocuenta"].ToString() + " " + Lector["recibi"].ToString());
                listBox1.Items.Add(" ");
            }
            Conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Recibosateneo", Conexion);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            listBox1.Items.Clear();
            while (Lector.Read())
            {
                listBox1.Items.Add(Lector["nocuenta"].ToString() +" " + Lector["recibi"].ToString());
                listBox1.Items.Add(" ");
            }
            Conexion.Close();
        }
    }
}
