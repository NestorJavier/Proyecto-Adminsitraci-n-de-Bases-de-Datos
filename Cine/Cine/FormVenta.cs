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
    public partial class FormVenta : Form
    {
        public Conexion conexion;
        int iIndiceRegistro = -1;
        Int64 ID_Venta = -1;

        public FormVenta()
        {
            InitializeComponent();
            conexion = new Conexion();
            conexion.ConectaBD();
            Datos.DataSource = muestra();
            comboBoxIdFuncion.DataSource = LlenaComboboxIdFuncion();
            comboBoxIdMiembro.DataSource = LlenaComboboxIdMiembro();
        }

        private List<Venta> muestra()
        {
            List<Venta> lista = new List<Venta>();

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT * FROM Negocio.Venta"), conn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Venta pcliete = new Venta(reader.GetInt64(0), reader.GetInt64(1), reader.GetInt64(2), reader.GetString(3), reader.GetFloat(4));
                lista.Add(pcliete);
            }
            cn.cierraConexionBD();
            return lista;
        }

        private List<Int64> LlenaComboboxIdFuncion()
        {
            List<Int64> lista = new List<Int64>();

            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT IdFuncion FROM Establecimiento.Funcion"), conn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(reader.GetInt64(0));
            }
            cn.cierraConexionBD();
            return lista;
        }
        private List<Int64> LlenaComboboxIdMiembro()
        {
            List<Int64> lista = new List<Int64>();

            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT IdMiembro FROM Negocio.Membresia"), conn);
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
            Venta auxPel = new Venta(Convert.ToInt64(comboBoxIdFuncion.Text), Convert.ToInt64(comboBoxIdMiembro.Text), textBoxHora.Text, Convert.ToDouble(textBoxTotal.Text));

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
            if (ID_Venta != -1)
            {
                Venta auxPel = new Venta(ID_Venta, Convert.ToInt64(comboBoxIdFuncion.Text), Convert.ToInt64(comboBoxIdMiembro.Text), textBoxHora.Text, Convert.ToDouble(textBoxTotal.Text));

                if (auxPel.actualiza() > 0)
                {
                    MessageBox.Show("Se actualizo correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la actualizo");
                }
                ID_Venta = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            if (ID_Venta != -1)
            {

                Venta auxPel = new Venta(ID_Venta, Convert.ToInt64(comboBoxIdFuncion.Text), Convert.ToInt64(comboBoxIdMiembro.Text), textBoxHora.Text, Convert.ToDouble(textBoxTotal.Text));

                if (auxPel.elimina() > 0)
                {
                    MessageBox.Show("Se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la eliminación");
                }
                ID_Venta = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iIndiceRegistro = e.RowIndex;
            comboBoxIdFuncion.Text = Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxIdMiembro.Text = Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxHora.Text = Datos.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxTotal.Text = Datos.Rows[e.RowIndex].Cells[4].Value.ToString();

            ID_Venta = (Int64)Datos.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
