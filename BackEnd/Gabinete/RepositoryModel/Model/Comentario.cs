using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.Model
{
    public class Comentario
    {
        public Guid comentarioid { get; set; }
        public string Alumno { get; set; }
        public int Puntaje { get; set; }
        public string ComentarioTexto { get; set; }
        public Guid cursoid { get; set; }

        public Curso Curso { get; set; }
    }
}
