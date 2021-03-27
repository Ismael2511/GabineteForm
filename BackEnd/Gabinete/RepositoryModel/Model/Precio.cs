using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryModel.Model
{
    public class Precio
    {
        public Guid precioid { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal PrecioActual { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Promocion { get; set; }
        public Guid cursoid { get; set; }

        public Curso Curso { get; set; }
    }
}
