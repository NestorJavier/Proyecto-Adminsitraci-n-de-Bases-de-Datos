using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cine
{
    class Asiento
    {
        public Int64 IdAsiento { get; set; }
        public Int64 IdSala { get; set; }
        public bool Estado { get; set; }
        public string Fila { get; set; }
        public int Numero { get; set; }

        public Asiento()
        {

        }

        public Asiento(Int64 IdAsiento, Int64 IdSala, bool Estado, string Fila, int Numero)
        {
            this.IdAsiento = IdAsiento;
            this.IdSala = IdSala;
            this.Estado = Estado;
            this.Fila = Fila;
            this.Numero = Numero;
        }

        public Asiento(Int64 IdSala, bool Estado, string Fila, int Numero)
        {
            this.IdSala = IdSala;
            this.Estado = Estado;
            this.Fila = Fila;
            this.Numero = Numero;
        }

        public int inserta()
        {
            int Est;
            if (this.Estado)
                Est = 1;
            else
                Est = 0;

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("INSERT INTO Establecimiento.Asiento(IdSala, Estado, Fila, Numero)" +
                              " Values({0}, {1}, '{2}', {3})",
                              this.IdSala, Est, this.Fila, this.Numero), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }
        public int actualiza()
        {
            int Est;
            if (this.Estado)
                Est = 1;
            else
                Est = 0;

            int respuesta = 0;
            Conexion cn = new Conexion();
            SqlConnection conn = cn.ConectaBD();
            SqlCommand comando = new SqlCommand(
                string.Format("UPDATE Establecimiento.Asiento SET IdSala = {0}, Estado = {1}, Fila = '{2}', Numero = {3} WHERE IdAsiento = '{4}'",
                                 this.IdSala, Est, this.Fila, this.Numero, this.IdAsiento), conn);

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
                string.Format("DELETE FROM Establecimiento.Asiento WHERE IdAsiento = '{0}'", this.IdAsiento), conn);

            respuesta = comando.ExecuteNonQuery();
            cn.cierraConexionBD();
            return respuesta;
        }

    }
}
