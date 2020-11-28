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
    public partial class FormSala : Form
    {
        public Conexion conexion;
        int iIndiceRegistro = -1;
        Int64 ID_Sala = -1;

        public FormSala()
        {
            InitializeComponent();
            conexion = new Conexion();
            conexion.ConectaBD();
            Datos.DataSource = muestra();
            comboBoxIdSucursal.DataSource = LlenaComboboxSucursales();
        }
        private List<Sala> muestra()
        {
            List<Sala> lista = new List<Sala>();

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT * FROM Establecimiento.Sala"), conn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Sala pcliete = new Sala(reader.GetInt64(0), reader.GetInt64(1), reader.GetInt32(2), reader.GetInt32(3));
                lista.Add(pcliete);
            }
            cn.cierraConexionBD();
            return lista;
        }

        private List<Int64> LlenaComboboxSucursales()
        {
            List<Int64> lista = new List<Int64>();

            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT IdSucursal FROM Establecimiento.Sucursal"), conn);
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
            Sala auxPel = new Sala(Convert.ToInt64(comboBoxIdSucursal.Text), Convert.ToInt32(textBoxNumero.Text), Convert.ToInt32(textBoxCupoTotal.Text));

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
            if (ID_Sala != -1)
            {
                Sala auxPel = new Sala(ID_Sala, Convert.ToInt64(comboBoxIdSucursal.Text), Convert.ToInt32(textBoxNumero.Text), Convert.ToInt32(textBoxCupoTotal.Text));

                if (auxPel.actualiza() > 0)
                {
                    MessageBox.Show("Se actualizo correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la actualizo");
                }
                ID_Sala = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            if (ID_Sala != -1)
            {

                Sala auxPel = new Sala(ID_Sala, Convert.ToInt64(comboBoxIdSucursal.Text), Convert.ToInt32(textBoxNumero.Text), Convert.ToInt32(textBoxCupoTotal.Text));

                if (auxPel.elimina() > 0)
                {
                    MessageBox.Show("Se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la eliminación");
                }
                ID_Sala = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iIndiceRegistro = e.RowIndex;
            comboBoxIdSucursal.Text = Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxNumero.Text = Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxCupoTotal.Text = Datos.Rows[e.RowIndex].Cells[3].Value.ToString();
            ID_Sala = (Int64)Datos.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
