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

namespace Cine
{
    public partial class FormFuncion : Form
    {
        public Conexion conexion;
        int iIndiceRegistro = -1;
        Int64 ID_Funcion = -1;

        public FormFuncion()
        {
            InitializeComponent();
            conexion = new Conexion();
            conexion.ConectaBD();
            Datos.DataSource = muestra();
            comboBoxIdPelicula.DataSource = LlenaComboboxIdPelicula();
            comboBoxIdSala.DataSource = LlenaComboboxIdSala();

        }

        private List<Funcion> muestra()
        {
            List<Funcion> lista = new List<Funcion>();

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT * FROM Establecimiento.Funcion"), conn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Funcion pcliete = new Funcion(reader.GetInt64(0), reader.GetInt64(1), reader.GetInt64(2), reader.GetBoolean(3));
                lista.Add(pcliete);
            }
            cn.cierraConexionBD();
            return lista;
        }

        private List<Int64> LlenaComboboxIdSala()
        {
            List<Int64> lista = new List<Int64>();

            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT IdSala FROM Establecimiento.Sala"), conn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(reader.GetInt64(0));
            }
            cn.cierraConexionBD();
            return lista;
        }

        private List<Int64> LlenaComboboxIdPelicula()
        {
            List<Int64> lista = new List<Int64>();

            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT IdPelicula FROM Establecimiento.Pelicula"), conn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(reader.GetInt64(0));
            }
            cn.cierraConexionBD();
            return lista;
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            Funcion auxPel = new Funcion(Convert.ToInt64(comboBoxIdPelicula.Text), Convert.ToInt64(comboBoxIdSala.Text), Convert.ToBoolean(comboBoxDisponibilidad.Text));

            if (auxPel.inserta() > 0)
            {
                MessageBox.Show("Se inserto correctamente");
                Datos.DataSource = muestra();
            }
            else
            {
                MessageBox.Show("fallo la insercion");
            }
        }

        private void Actualiza_Click(object sender, EventArgs e)
        {
            if (ID_Funcion != -1)
            {
                Funcion auxPel = new Funcion(ID_Funcion, Convert.ToInt64(comboBoxIdPelicula.Text), Convert.ToInt64(comboBoxIdSala.Text), Convert.ToBoolean(comboBoxDisponibilidad.Text));

                if (auxPel.actualiza() > 0)
                {
                    MessageBox.Show("Se actualizo correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la actualizo");
                }
                ID_Funcion = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            if (ID_Funcion != -1)
            {

                Funcion auxPel = new Funcion(ID_Funcion, Convert.ToInt64(comboBoxIdPelicula.Text), Convert.ToInt64(comboBoxIdSala.Text), Convert.ToBoolean(comboBoxDisponibilidad.Text));

                if (auxPel.elimina() > 0)
                {
                    MessageBox.Show("Se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la eliminación");
                }
                ID_Funcion = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iIndiceRegistro = e.RowIndex;
            comboBoxIdPelicula.Text = Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxIdSala.Text = Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxDisponibilidad.Text = Datos.Rows[e.RowIndex].Cells[3].Value.ToString();

            ID_Funcion = (Int64)Datos.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
