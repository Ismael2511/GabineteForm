using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Service
{
    public class FileService
    {
        // subir archivo
        /*
         private IMaintenance _maintenance;
        private IRepository<ApplicationDbContext> _context;
        public FileService(IMaintenance maintenance,  IRepository<ApplicationDbContext> context)
        {
            _maintenance = maintenance;
            _context = context;
        }

        public ServiceResult GetAlbum(int id)
        {
            ServiceResult model = new ServiceResult();

            var listAlbum = _context.Where<mae_album>(x => x.id_miembro == id);
            var lista = new List<AlbumViewModel>();
            foreach (var item in listAlbum.Data)
            {
                var idFile = (int)item.id_foto;
                var listaFile = _context.Where<mae_file>(x => x.id == idFile);
                var albumViewModel = new AlbumViewModel
                {
                    id = listaFile.Data[0].id,
                    url = listaFile.Data[0].path
                };
                lista.Add(albumViewModel);
            }
            model.ResultObject = lista;
            model.Success = true;

            return model;
        }

        public async Task<ServiceResult> UploadAlbum(IFormFile file, FilePickViewModel mod, int id)
        {
            ServiceResult model = new ServiceResult();
            if (file == null || file.Length == 0)
            {
                model.Success = false;
                model.ResultTitle = "Debe seleccionar un archivo";
                return model;
            }
            string strFileExtension = System.IO.Path.GetExtension(file.FileName);

            Guid guid = Guid.NewGuid();
            var name = guid.ToString() + strFileExtension;
            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/userperfil",
                        name);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // var mod = new FilePickViewModel();
            // mod.categoria = "MIEMBRO_PROFILE";
            mod.nombre = name;
            mod.path = "userperfil/" + name;
            var dataMember = _context.GetById<mae_membresia>(id);
            if (dataMember.Successfull)
            {
                var map = MapperHelper.Instance.Map<FilePickViewModel, mae_file>(mod);
                var insertdata = _context.Insert<mae_file>(map);
                var foto = (mae_file)insertdata.Data;


                var album = new mae_album
                {
                    id_miembro = id,
                    id_foto = foto.id
                };
                _context.Insert(album);

                var listAlbum = _context.Where<mae_album>(x => x.id_miembro == id);
                var lista = new List<AlbumViewModel>();
                foreach(var item in listAlbum.Data)
                {
                    var idFile = (int)item.id_foto;
                    var listaFile = _context.Where<mae_file>(x => x.id == idFile);
                    var albumViewModel = new AlbumViewModel
                    {
                        id = listaFile.Data[0].id,
                        url = listaFile.Data[0].path
                    };
                    lista.Add(albumViewModel);
                }
                model.ResultObject = lista;
                model.Success = true;

            }

            return model;
        }

        public async  Task<ServiceResult> UploadFile(IFormFile file, FilePickViewModel mod, int id)
        {
            ServiceResult model = new ServiceResult();
            if (file == null || file.Length == 0)
            {
                model.Success = false;
                model.ResultTitle = "Debe seleccionar un archivo";
               return model;
            }
            string strFileExtension = System.IO.Path.GetExtension(file.FileName);

            Guid guid = Guid.NewGuid();
            var name = guid.ToString() + strFileExtension;
            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/userperfil",
                        name);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

           // var mod = new FilePickViewModel();
           // mod.categoria = "MIEMBRO_PROFILE";
             mod.nombre = name;
             mod.path = "userperfil/" + name;

            // int userID = Convert.ToInt32(Request.Form["uid"].ToString());
            model = _maintenance.changePicture(mod, id);

            return model;
        }
         */

        //Para enpoint
        /*
          //getIdEntidad
        [HttpPost]
        [RequestSizeLimit(100000000)]
        [Route("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file, int id)
        {         
            var mod = new FilePickViewModel();
            mod.categoria = "PASTOR_PROFILE";

              // int userID = Convert.ToInt32(Request.Form["uid"].ToString());
             var  model = await _file.UploadFile(file, mod, id);

            return Ok(model);
        }
         */
    }
}
