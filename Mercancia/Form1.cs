
using Mercancia.Controlador;
using Mercancia.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mercancia
{
    public partial class Form1 : Form
    {
        Conexion conexion = new Conexion();
        CMercancias Cliente = new CMercancias();
        private string Nombre = null;
        private bool editar = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarCliente();

        }

        // Este otro metodo lo utilice para que los datos se actualizaran y no se multiplicaran
        public void MostrarCliente()
        {
            CMercancias refrescar = new CMercancias();
            dtgmercancias.DataSource = refrescar.MostrarCliente();
        }

        // Esto metodos son para limpiar los Textbox
        private void limpiar()
        {
            text1.Clear();
            text2.Clear();
            text3.Clear();
            text4.Clear();


        }

        // Este es el boton de guardar 
        // Pero tengo tambien para actualizar los datos con if con una variable llamabada editar 
        private void button1_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    Cliente.InsertaCliente(text1.Text, text2.Text, text3.Text, text4.Text, text5.Text);
                    MessageBox.Show("Se inserto Correctamente");
                    MostrarCliente();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            else
                try
                {
                    Cliente.ActualizarCliente(text1.Text, text2.Text, text3.Text, text4.Text, text5.Text);
                    MessageBox.Show("Se actualizo corretamente");
                    MostrarCliente();
                    limpiar();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)


        {

        }

        // Este es el boton eliminar 
        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (dtgmercancias.SelectedRows.Count > 0)
            {
                Nombre = dtgmercancias.CurrentRow.Cells["Nombre"].Value.ToString();
                Cliente.EliminarCliente(Nombre);
                MessageBox.Show("Se elimino los datos");
                MostrarCliente();
            }
            else
            {
                MessageBox.Show("Seleccione una fila ");
            }
        }

        // Este es el boton guardar 
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            editar = true;
            if (dtgmercancias.SelectedRows.Count > 0)

                text1.Text = dtgmercancias.CurrentRow.Cells["Nombre"].Value.ToString();
            text2.Text = dtgmercancias.CurrentRow.Cells["Apellido"].Value.ToString();
            text3.Text = dtgmercancias.CurrentRow.Cells["Dirección"].Value.ToString();
            text4.Text = dtgmercancias.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
            text5.Text = dtgmercancias.CurrentRow.Cells["Telefono"].Value.ToString();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void text5_TextChanged(object sender, EventArgs e)
        {

        }

        private void text5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void text7_TextChanged(object sender, EventArgs e)
        {


        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {



        }

        private void text7_KeyUp(object sender, KeyEventArgs e)
        {

            conexion.AbriConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Cliente where Nombre like('" + text7.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dtgmercancias.DataSource = dt;

           
        }
    }
}


