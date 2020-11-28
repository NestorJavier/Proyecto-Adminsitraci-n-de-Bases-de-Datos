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
    public partial class FormPelicula : Form
    {
        public Conexion conexion;
        int iIndiceRegistro = -1;
        Int64 ID_Pelicula = -1;

        public FormPelicula()
        {
            InitializeComponent();
            conexion = new Conexion();
            conexion.ConectaBD();
            Datos.DataSource = muestra();
        }

        private List<Pelicula> muestra()
        {
            List<Pelicula> lista = new List<Pelicula>();

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT * FROM Establecimiento.Pelicula"), conn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Pelicula pcliete = new Pelicula(reader.GetInt64(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5).ToString("yyyy/MM/dd"));
                lista.Add(pcliete);
            }
            cn.cierraConexionBD();
            return lista;
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            Pelicula auxPel = new Pelicula(textBoxTitulo.Text,Convert.ToInt32(textBoxDuracion.Text), comboBoxGenero.Text, richTextBoxSipnopsis.Text, dateTimePickerFechaLlegada.Text);

            if (auxPel.insertaPelicula() > 0)
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
            if (ID_Pelicula != -1)
            {
                Pelicula auxPel = new Pelicula(ID_Pelicula, textBoxTitulo.Text, Convert.ToInt32(textBoxDuracion.Text), comboBoxGenero.Text, richTextBoxSipnopsis.Text, dateTimePickerFechaLlegada.Text);

                if (auxPel.actualizaPelicula() > 0)
                {
                    MessageBox.Show("Se actualizo correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la actualizo");
                }
                ID_Pelicula = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            if (ID_Pelicula != -1)
            {

                Pelicula auxPel = new Pelicula(ID_Pelicula, textBoxTitulo.Text, Convert.ToInt32(textBoxDuracion.Text), comboBoxGenero.Text, richTextBoxSipnopsis.Text, dateTimePickerFechaLlegada.Text);

                if (auxPel.eliminaPelicula() > 0)
                {
                    MessageBox.Show("Se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la eliminación");
                }
                ID_Pelicula = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iIndiceRegistro = e.RowIndex;
            textBoxTitulo.Text = Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDuracion.Text = Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxGenero.Text = Datos.Rows[e.RowIndex].Cells[3].Value.ToString();

            string date = Datos.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePickerFechaLlegada.Value = Convert.ToDateTime(date);

            richTextBoxSipnopsis.Text = Datos.Rows[e.RowIndex].Cells[4].Value.ToString();
            ID_Pelicula = (Int64)Datos.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
