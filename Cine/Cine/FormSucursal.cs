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
    public partial class FormSucursal : Form
    {
        public Conexion conexion;
        int iIndiceRegistro = -1;
        Int64 ID_Sucursal = -1;


        public FormSucursal()
        {
            InitializeComponent();
            conexion = new Conexion();
            conexion.ConectaBD();
            Datos.DataSource = muestra();
        }

        private List<Sucursal> muestra()
        {
            List<Sucursal> lista = new List<Sucursal>();

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("SELECT * FROM Establecimiento.Sucursal"), conn);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Sucursal pcliete = new Sucursal(reader.GetInt64(0), reader.GetString(1), reader.GetString(2));
                lista.Add(pcliete);
            }
            cn.cierraConexionBD();
            return lista;
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            Sucursal auxSuc = new Sucursal(textBoxNombre.Text, textBoxDireccion.Text);

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
            if (ID_Sucursal != -1)
            {
                Sucursal auxSuc = new Sucursal(ID_Sucursal, textBoxNombre.Text, textBoxDireccion.Text);

                if (auxSuc.actualiza() > 0)
                {
                    MessageBox.Show("Se actualizo correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la actualizo");
                }
                ID_Sucursal = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            if (ID_Sucursal != -1)
            {

                Sucursal auxSuc = new Sucursal(ID_Sucursal, textBoxNombre.Text, textBoxDireccion.Text);

                if (auxSuc.elimina() > 0)
                {
                    MessageBox.Show("Se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("fallo la eliminación");
                }
                ID_Sucursal = -1;
                Datos.DataSource = muestra();
            }
        }

        private void Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iIndiceRegistro = e.RowIndex;
            textBoxNombre.Text = Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDireccion.Text = Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
            ID_Sucursal = (Int64)Datos.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
