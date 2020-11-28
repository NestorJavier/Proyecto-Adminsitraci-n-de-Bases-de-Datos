using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cine
{
    class Membresia
    {
        public Int64 IdMembresia { get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public int Puntos { get; set; }
        public int Promociones { get; set; }

        public Membresia()
        {

        }
        public Membresia(Int64 IdMembresia, String Nombre, String Telefono, int Puntos, int Promociones)
        {
            this.IdMembresia = IdMembresia;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Puntos = Puntos;
            this.Promociones = Promociones;
        }
        public Membresia(String Nombre, String Telefono, int Puntos, int Promociones)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Puntos = Puntos;
            this.Promociones = Promociones;
        }
        public int inserta()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Negocio.Membresia(NombreMiembro, Telefono, Puntos, Promocion)" +
                              " Values('{0}', '{1}', {2}, {3})",
                              this.Nombre, this.Telefono, this.Puntos, this.Promociones), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }
        public int actualiza()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("UPDATE Negocio.Membresia SET NombreMiembro = '{0}', Telefono = '{1}', Puntos = {2}, Promocion = {3} WHERE IdMiembro = '{4}'",
                                this.Nombre, this.Telefono, this.Puntos, this.Promociones, this.IdMembresia), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }

        public int elimina()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("DELETE FROM Negocio.Membresia WHERE IdMiembro = '{0}'", this.IdMembresia), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }

    }
}
