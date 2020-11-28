using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cine
{

    class Funcion
    {
        public Int64 IdFuncion { get; set; }
        public Int64 IdPelicula { get; set; }
        public Int64 IdSala { get; set; }
        public bool Disponibilidad { get; set; }

        public Funcion()
        {

        }

        public Funcion(Int64 IdFuncion, Int64 IdPelicula, Int64 IdSala, bool Disponibilidad)
        {
            this.IdFuncion = IdFuncion;
            this.IdPelicula = IdPelicula;
            this.IdSala = IdSala;
            this.Disponibilidad = Disponibilidad;
        }
        public Funcion(Int64 IdPelicula, Int64 IdSala, bool Disponibilidad)
        {
            this.IdFuncion = IdFuncion;
            this.IdPelicula = IdPelicula;
            this.IdSala = IdSala;
            this.Disponibilidad = Disponibilidad;
        }
        public int inserta()
        {
            int Disp;
            if (this.Disponibilidad)
                Disp = 1;
            else
                Disp = 0;

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Establecimiento.Funcion(IdPelicula, IdSala, Disponibilidad)" +
                              " Values({0}, {1}, {2})",
                              this.IdPelicula, this.IdSala, Disp), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }
        public int actualiza()
        {
            int Disp;
            if (this.Disponibilidad)
                Disp = 1;
            else
                Disp = 0;

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("UPDATE Establecimiento.Funcion SET IdPelicula = {0}, IdSala = {1}, Disponibilidad = {2} WHERE IdFuncion = '{3}'",
                                this.IdPelicula, this.IdSala, Disp, this.IdFuncion), conn);

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
                string.Format("DELETE FROM Establecimiento.Funcion WHERE IdFuncion = '{0}'", this.IdFuncion), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }

    }
}


