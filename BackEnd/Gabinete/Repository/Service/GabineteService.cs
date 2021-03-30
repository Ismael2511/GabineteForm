using Repository.DataContext;
using Repository.Interface;
using RepositoryModel.Model.gabineteDB;
using RepositoryModel.response;
using RepositoryModel.Validations;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Repository.Service
{
    public class GabineteService : IGabineteService
    {
        private readonly IUnitOfWork<gabineteDbContext> _context;
        private readonly IRepository<gabineteDbContext> _repository;
        private readonly IEmailServices _email;
        public GabineteService(IUnitOfWork<gabineteDbContext> context, IRepository<gabineteDbContext> repository, IEmailServices emai)
        {
            _context = context;
            _repository = repository;
            _email = emai;
        }
        public DataResult Insert(GabineteViewModel model)
        {
            gabineteValidation valid = new gabineteValidation(model);
            DataResult response = new DataResult();
            var validations = valid.Message();

            if (validations.Count > 0)
            {
                response.Successfull = false;
                response.Messages = validations;
                return response;
            }
            model.codigo = Guid.NewGuid().ToString();
            response = _context.Insert<GabineteViewModel, mae_persona>(model);
            if (response.Successfull)
            {
                using (WebClient client = new WebClient())
                {
                    string htmlCode = client.DownloadString(_email.url() + "theme_email/detalle.html");
                    // info@gabinetedelafamilia.gob.do
                    htmlCode = htmlCode.Replace("DCODIGO", model.codigo);
                    htmlCode = htmlCode.Replace("DNOMBRE", model.nombre);
                    htmlCode = htmlCode.Replace("DAPELLIDO", model.apellido);
                    htmlCode = htmlCode.Replace("DTIPO_DOCUMENTO", model.tipo_documento);
                    htmlCode = htmlCode.Replace("DNUMERO_DOCUMENTO", model.numero_documento);
                    htmlCode = htmlCode.Replace("EMAIL", model.email);
                    htmlCode = htmlCode.Replace("DIRECCION", model.direccion);
                    htmlCode = htmlCode.Replace("NACIONALIDAD", model.nacionalidad);
                    htmlCode = htmlCode.Replace("TELEFONO1", model.telefono1 ?? "No registrado");
                    htmlCode = htmlCode.Replace("TELEFONO2", model.telefono2 ?? "No registrado");
                    htmlCode = htmlCode.Replace("TELEFONO3", model.telefono3 ?? "No registrado");
                    htmlCode = htmlCode.Replace("CELULAR", model.celular);
                    htmlCode = htmlCode.Replace("LUAGAR_RESIDENCIA", model.lugar_residencia);
                    htmlCode = htmlCode.Replace("FECHA_NACIMIENTO", model.fecha_nacimiento);
                    htmlCode = htmlCode.Replace("TIPO_PROGRAMA", model.tipo_programa);
                    htmlCode = htmlCode.Replace("NOMBRE_FALLECIDO", model.nombre_fallecido);
                    htmlCode = htmlCode.Replace("DOCUMENTO_FALLECIDO", model.num_doc_fallecido);
                    htmlCode = htmlCode.Replace("FECHA_FALLECIMIENTO", model.fecha_fallecimiento);
                    htmlCode = htmlCode.Replace("DETALLE_FALLECIMIENTO", model.detalles_fallecimiento);
                    _email.SendEmail("Esmerlin79@hotmail.com", "Formulario Casos Covid-19", htmlCode);
                }
            }
            return response;
        }
        public DataResult GetById(int id)
        {
            return _context.GetById<GabineteViewModel, mae_persona>(id);
        }
    }
}
