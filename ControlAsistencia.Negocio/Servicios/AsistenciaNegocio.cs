
using System;
using System.Collections.Generic;
using System.Data;
using ControlAsistencia.Datos.Repositorios;
using ControlAsistencia.Negocio.Modelos;

namespace ControlAsistencia.Negocio.Servicios
{
    public class AsistenciaNegocio
    {
        private readonly AsistenciaDatos asistenciaDatos =
            new AsistenciaDatos();

        public void RegistrarAsistencia(
            int idCurso,
            string estudiante,
            DateTime fecha,
            bool presente)
        {
            if (idCurso <= 0)
                throw new Exception("Debe seleccionar un curso.");

            if (string.IsNullOrWhiteSpace(estudiante))
                throw new Exception("El nombre del estudiante es obligatorio.");

            if (fecha.Date > DateTime.Today)
                throw new Exception("No se permiten fechas futuras.");

            estudiante = estudiante.Trim();

            DataTable registros =
                asistenciaDatos.ConsultarAsistencia(idCurso, fecha);

            foreach (DataRow fila in registros.Rows)
            {
                string nombreRegistrado =
                    fila["Estudiante"].ToString() ?? string.Empty;

                if (nombreRegistrado.Equals(
                    estudiante,
                    StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception(
                        "Este estudiante ya tiene asistencia registrada para esa fecha.");
                }
            }

            asistenciaDatos.RegistrarAsistencia(
                idCurso, estudiante, fecha, presente);
        }

        public List<Asistencia> ConsultarAsistencia(
            int idCurso,
            DateTime fecha)
        {
            DataTable tabla =
                asistenciaDatos.ConsultarAsistencia(idCurso, fecha);

            List<Asistencia> asistencias = new List<Asistencia>();

            foreach (DataRow fila in tabla.Rows)
            {
                Asistencia asistencia = new Asistencia
                {
                    IdAsistencia = (int)fila["IdAsistencia"],
                    IdCurso = (int)fila["IdCurso"],
                    NombreCurso = fila["NombreCurso"].ToString()!,
                    Estudiante = fila["Estudiante"].ToString()!,
                    Fecha = Convert.ToDateTime(fila["Fecha"]),
                    Presente = Convert.ToBoolean(fila["Presente"])
                };

                asistencias.Add(asistencia);
            }

            return asistencias;
        }

        public DataTable CalcularPorcentajeAsistencia(int idCurso)
        {
            if (idCurso <= 0)
                throw new Exception("Debe seleccionar un curso.");

            return asistenciaDatos.CalcularPorcentajeAsistencia(idCurso);
        }

        public void ModificarAsistencia(int idAsistencia, bool presente)
        {
            if (idAsistencia <= 0)
                throw new Exception("El registro de asistencia no es válido.");

            asistenciaDatos.ModificarAsistencia(idAsistencia, presente);
        }

    }

}
