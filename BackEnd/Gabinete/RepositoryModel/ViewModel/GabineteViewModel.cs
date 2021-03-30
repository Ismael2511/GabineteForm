using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.ViewModel
{
    public class GabineteViewModel
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string nacionalidad { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string telefono3 { get; set; }
        public string celular { get; set; }
        public string lugar_residencia { get; set; }
        public string fecha_nacimiento { get; set; }

        // FALLECIDO (SI QUIERES SEPARALO)
        public string tipo_programa { get; set; }
        public string nombre_fallecido { get; set; }
        public string num_doc_fallecido { get; set; }
        public string fecha_fallecimiento { get; set; }
        public string detalles_fallecimiento { get; set; }
    }
}
