using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cine
{
    class Pelicula
    {
        public Int64    IdPelicula { get; set; }
        public String   Titulo { get; set; }
        public int      Duracion { get; set; }
        public String   Genreo { get; set; }
        public String   Sipnopsis { get; set; }
        public String FechaLlegada { get; set; }

        public Pelicula()
        {

        }

        public Pelicula(Int64 IdPelicula, String Titulo, int Duracion, String Genreo, String Sipnopsis, String FechaLlegada)
        {
            this.IdPelicula = IdPelicula;
            this.Titulo = Titulo;
            this.Duracion = Duracion;
            this.Genreo = Genreo;
            this.Sipnopsis = Sipnopsis;
            this.FechaLlegada = FechaLlegada;
        }
        public Pelicula(String Titulo, int Duracion, String Genreo, String Sipnopsis, String FechaLlegada)
        {
            this.Titulo = Titulo;
            this.Duracion = Duracion;
            this.Genreo = Genreo;
            this.Sipnopsis = Sipnopsis;
            this.FechaLlegada = FechaLlegada;
        }
        public int insertaPelicula()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Establecimiento.Pelicula(Titulo, Duracion, Genero, Sinopsis, FechaLlegada)" +
                              " Values('{0}', {1}, '{2}', '{3}', '{4}')",
                              this.Titulo, this.Duracion, this.Genreo, this.Sipnopsis, this.FechaLlegada), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }
        public int actualizaPelicula()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("UPDATE Establecimiento.Pelicula SET Titulo = '{0}', Duracion = '{1}', Genero = '{2}', Sinopsis  = '{3}', FechaLlegada = '{4}' WHERE IdPelicula = '{5}'",
                               this.Titulo, this.Duracion, this.Genreo, this.Sipnopsis, this.FechaLlegada, this.IdPelicula), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }

        public int eliminaPelicula()
        {
            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("DELETE FROM Establecimiento.Pelicula WHERE IdPelicula = '{0}'", this.IdPelicula), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }
    }
}
