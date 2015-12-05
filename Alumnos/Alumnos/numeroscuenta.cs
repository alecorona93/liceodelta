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
    public partial class numeroscuenta : Form
    {
        public numeroscuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Inscriliceo WHERE apellidopaterno LIKE @apellidopaterno +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@apellidopaterno", (txtapellidop.Text));
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            listBox1.Items.Clear();
            while (Lector.Read())
            {
                listBox1.Items.Add(Lector["nocuenta"].ToString() +" "+ Lector["apellidopaterno"].ToString() +" "+ Lector["apellidomaterno"].ToString()+" "+Lector["nombres"].ToString());
                listBox1.Items.Add(" ");
            }
            Conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Inscriliceo", Conexion);
            SqlDataReader Lector;
            Conexion.Open();
            Lector = instruccion.ExecuteReader();
            listBox1.Items.Clear();
            while (Lector.Read())
            {
                listBox1.Items.Add(Lector["nocuenta"].ToString() + " " + Lector["apellidopaterno"].ToString() + " " + Lector["apellidomaterno"].ToString() + " " + Lector["nombres"].ToString());
                listBox1.Items.Add(" ");
            }
            Conexion.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtapellidop_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Boletas WHERE nombre LIKE @nombre +'%'", Conexion);
            instruccion.Parameters.AddWithValue("@nombre", (txtapellidop.Text));
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
            SqlCommand instruccion = new SqlCommand("Select * FROM Boletas", Conexion);
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

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=(localdb)\\projects;Initial Catalog=Tarea;Integrated Security=True");
            SqlCommand instruccion = new SqlCommand("Select * FROM Recibos WHERE recibi LIKE @recibi +'%'", Conexion);
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
            SqlCommand instruccion = new SqlCommand("Select * FROM Recibos", Conexion);
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
    }
}
