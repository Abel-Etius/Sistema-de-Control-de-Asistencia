using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia.Negocio.Modelos
{
    public class Asistencia
    {
        public int IdAsistencia { get; set; }
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; } = string.Empty;
        public string Estudiante { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public bool Presente { get; set; }
    }
}
