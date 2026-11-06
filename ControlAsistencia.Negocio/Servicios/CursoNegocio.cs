
using System.Collections.Generic;
using System.Data;
using ControlAsistencia.Datos.Repositorios;
using ControlAsistencia.Negocio.Modelos;

namespace ControlAsistencia.Negocio.Servicios
{
    public class CursoNegocio
    {
        private readonly CursoDatos cursoDatos = new CursoDatos();

        public List<Curso> ObtenerCursos()
        {
            DataTable tabla = cursoDatos.ObtenerCursos();

            List<Curso> cursos = new List<Curso>();

            foreach (DataRow fila in tabla.Rows)
            {
                Curso curso = new Curso
                {
                    IdCurso = (int)fila["IdCurso"],
                    Nombre = fila["Nombre"].ToString()!,
                    Horario = fila["Horario"] == DBNull.Value
                        ? string.Empty
                        : fila["Horario"].ToString()!
                };

                cursos.Add(curso);
            }

            return cursos;
        }
    }
}
