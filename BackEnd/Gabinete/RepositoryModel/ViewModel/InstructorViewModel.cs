using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.ViewModel
{
    public class InstructorViewModel
    {
        public Guid instructorId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Grado { get; set; }
        public byte[] FotoPerfil { get; set; }
    }
}
