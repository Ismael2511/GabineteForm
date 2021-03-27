using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.ViewModel
{
    public class CursoViewModel
    {
        public Guid Cursoid { get; set; }
        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public List<Guid> ListaInstructor { get; set; }
        public ICollection<InstructorViewModel> Instructores { get; set; }
    }
}
