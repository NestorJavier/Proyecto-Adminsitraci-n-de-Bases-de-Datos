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
    public partial class FormAsiento : Form
    {
        public Conexion conexion;
        int iIndiceRegistro = -1;
        Int64 ID_Asiento = -1;

        public FormAsiento()
        {
            InitializeComponent();
            conexion = new Conexion();
            conexion.ConectaBD();
            Datos.DataSource = muestra();
            comboBoxIdSala.DataSource = LlenaComboboxIdSala();
        }

        private List<Asiento> muestra()
        {
            List<Asiento> lista = new List<Asiento>();

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT * FROM Establecimiento.Asiento"), conn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Asiento pcliete = new Asiento(reader.GetInt64(0), reader.GetInt64(1), reader.GetBoolean(2), reader.GetString(3), reader.GetInt32(4));
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

        private void Alta_Click(object sender, EventArgs e)
        {
            Asiento auxPel = new Asiento(Convert.ToInt64(comboBoxIdSala.Text), Convert.ToBoolean(comboBoxEstado.Text), textBoxFila.Text, Convert.ToInt32(textBoxNumero.Text));

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
            if (ID_Asiento != -1)
            {
                Asiento auxPel = new Asiento(ID_Asiento, Convert.ToInt64(comboBoxIdSala.Text), Convert.ToBoolean(comboBoxEstado.Text), textBoxFila.Text, Convert.ToInt32(textBoxNumero.Text));

                if (auxPel.actualiza() > 0)
                {
                    MessageBox.Show("Se actualizo correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la actualizo");
                }
                ID_Asiento = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            if (ID_Asiento != -1)
            {

                Asiento auxPel = new Asiento(ID_Asiento, Convert.ToInt64(comboBoxIdSala.Text), Convert.ToBoolean(comboBoxEstado.Text), textBoxFila.Text, Convert.ToInt32(textBoxNumero.Text));

                if (auxPel.elimina() > 0)
                {
                    MessageBox.Show("Se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la eliminación");
                }
                ID_Asiento = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iIndiceRegistro = e.RowIndex;
            comboBoxIdSala.Text = Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxEstado.Text = Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxFila.Text = Datos.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxNumero.Text = Datos.Rows[e.RowIndex].Cells[4].Value.ToString();

            ID_Asiento = (Int64)Datos.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
