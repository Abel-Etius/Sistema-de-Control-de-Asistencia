
using Microsoft.Data.SqlClient;

namespace ControlAsistencia.Datos.Conexion
{
    public class ConexionBD
    {
        private readonly string cadenaConexion =
            @"Server=localhost\MSSQLSERVER01;Database=ControlAsistencia;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }


}
