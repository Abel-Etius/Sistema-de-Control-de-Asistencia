using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia.Negocio.Modelos
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Horario { get; set; } = string.Empty;

    }
}
