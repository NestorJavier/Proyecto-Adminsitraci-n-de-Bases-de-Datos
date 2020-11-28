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
    public partial class FormMembresia : Form
    {
        public Conexion conexion;
        int iIndiceRegistro = -1;
        Int64 ID_Membresia = -1;

        public FormMembresia()
        {
            InitializeComponent();
            conexion = new Conexion();
            conexion.ConectaBD();
            Datos.DataSource = muestra();
        }
        private List<Membresia> muestra()
        {
            List<Membresia> lista = new List<Membresia>();

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT * FROM Negocio.Membresia"), conn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Membresia pcliete = new Membresia(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3),reader.GetInt32(4));
                lista.Add(pcliete);
            }
            cn.cierraConexionBD();
            return lista;
        }

    

        private void Alta_Click_1(object sender, EventArgs e)
        {
            Membresia auxSuc = new Membresia(textBoxNombre.Text, textBoxTelefono.Text, Convert.ToInt32(textBoxPuntos.Text), Convert.ToInt32(comboBoxPromociones.Text));

            if (auxSuc.inserta() > 0)
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
            if (ID_Membresia != -1)
            {
                Membresia auxSuc = new Membresia(ID_Membresia, textBoxNombre.Text, textBoxTelefono.Text, Convert.ToInt32(textBoxPuntos.Text), Convert.ToInt32(comboBoxPromociones.Text));

                if (auxSuc.actualiza() > 0)
                {
                    MessageBox.Show("Se actualizo correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la actualizo");
                }
                ID_Membresia = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            if (ID_Membresia != -1)
            {

                Membresia auxSuc = new Membresia(ID_Membresia, textBoxNombre.Text, textBoxTelefono.Text, Convert.ToInt32(textBoxPuntos.Text), Convert.ToInt32(comboBoxPromociones.Text));

                if (auxSuc.elimina() > 0)
                {
                    MessageBox.Show("Se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la eliminación");
                }
                ID_Membresia = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iIndiceRegistro = e.RowIndex;
            ID_Membresia = (Int64)Datos.Rows[e.RowIndex].Cells[0].Value;
            textBoxNombre.Text = Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxTelefono.Text = Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxPuntos.Text = Datos.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxPromociones.Text = Datos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
