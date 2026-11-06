
using System.Data;
using Microsoft.Data.SqlClient;
using ControlAsistencia.Datos.Conexion;

namespace ControlAsistencia.Datos.Repositorios
{
    public class CursoDatos
    {
        private readonly ConexionBD conexionBD = new ConexionBD();

        public DataTable ObtenerCursos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                string consulta = "SELECT IdCurso, Nombre, Horario FROM Curso";

                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion))
                {
                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }
    }
}
