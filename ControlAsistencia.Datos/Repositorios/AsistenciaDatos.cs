
using System.Data;
using Microsoft.Data.SqlClient;
using ControlAsistencia.Datos.Conexion;

namespace ControlAsistencia.Datos.Repositorios
{
    public class AsistenciaDatos
    {
        private readonly ConexionBD conexionBD = new ConexionBD();

        public void RegistrarAsistencia(
            int idCurso,
            string estudiante,
            DateTime fecha,
            bool presente)


        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO Asistencia
                    (IdCurso, Estudiante, Fecha, Presente)
                    VALUES
                    (@IdCurso, @Estudiante, @Fecha, @Presente)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.Add("@IdCurso", SqlDbType.Int).Value = idCurso;
                    comando.Parameters.Add("@Estudiante", SqlDbType.VarChar, 100).Value = estudiante;
                    comando.Parameters.Add("@Fecha", SqlDbType.Date).Value = fecha.Date;
                    comando.Parameters.Add("@Presente", SqlDbType.Bit).Value = presente;

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }

        }

        public DataTable ConsultarAsistencia(int idCurso, DateTime fecha)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                string consulta = @"
                    SELECT 
                        A.IdAsistencia,
                        A.IdCurso,
                        C.Nombre AS NombreCurso,
                        A.Estudiante,
                        A.Fecha,
                        A.Presente
                    FROM Asistencia A
                    INNER JOIN Curso C ON A.IdCurso = C.IdCurso
                    WHERE A.IdCurso = @IdCurso
                    AND A.Fecha = @Fecha";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.Add("@IdCurso", SqlDbType.Int).Value = idCurso;
                    comando.Parameters.Add("@Fecha", SqlDbType.Date).Value = fecha.Date;

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }



        public DataTable CalcularPorcentajeAsistencia(int idCurso)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                string consulta = @"
            SELECT
                Estudiante,
                COUNT(*) AS TotalClases,
                SUM(CASE WHEN Presente = 1 THEN 1 ELSE 0 END) AS Asistencias,
                CAST(
                    SUM(CASE WHEN Presente = 1 THEN 1.0 ELSE 0 END)
                    / COUNT(*) * 100
                    AS DECIMAL(5,2)
                ) AS PorcentajeAsistencia
            FROM Asistencia
            WHERE IdCurso = @IdCurso
            GROUP BY Estudiante
            ORDER BY Estudiante";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.Add("@IdCurso", SqlDbType.Int).Value = idCurso;

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }



public void ModificarAsistencia(int idAsistencia, bool presente)
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                string consulta = @"
            UPDATE Asistencia
            SET Presente = @Presente
            WHERE IdAsistencia = @IdAsistencia";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.Add("@Presente", SqlDbType.Bit).Value = presente;
                    comando.Parameters.Add("@IdAsistencia", SqlDbType.Int).Value = idAsistencia;

                    conexion.Open();

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        throw new Exception("No se encontró el registro de asistencia.");
                    }
                }
            }
        }

    }

}




