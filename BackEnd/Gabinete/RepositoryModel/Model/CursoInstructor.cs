using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.Model
{
    public class CursoInstructor
    {
        public Guid Cursoid { get; set; }
        public Curso Curso { get; set; }

        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
