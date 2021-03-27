using Repository.DataContext;
using Repository.Interface;
using Repository.Repository;
using RepositoryModel.Model;
using RepositoryModel.response;
using RepositoryModel.Validations;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Service
{
    public class CursoSevice : ICurso
    {
        private readonly IUnitOfWork<AppDbContext> _context;
        private readonly IRepository<AppDbContext> _repository;
        public CursoSevice(IUnitOfWork<AppDbContext> context, IRepository<AppDbContext> repository)
        {
            _context = context;
            _repository = repository;
        }

        public IEnumerable<CursoViewModel> GetAll()
        {
            return _context.GetAll<CursoViewModel, Curso>();
        }

        public DataResult GetById(int id)
        {
            return _context.GetById<CursoViewModel, Curso>(id);
        }

        public DataResult Insert(CursoViewModel curso)
        {
            CursoValidation valid = new CursoValidation(curso);
            DataResult response = new DataResult();
            var validations = valid.Message();

            if(validations.Count > 0)
            {
                response.Successfull = false;
                response.Messages = validations;
                return response;
            }
            Guid _cursoId = Guid.NewGuid();
            curso.Cursoid = _cursoId;
            response = _context.Insert<CursoViewModel, Curso>(curso);

            if(curso.ListaInstructor != null)
            {
                foreach(var id in curso.ListaInstructor)
                {
                    var cursoInstructor = new CursoInstructor
                    {
                        Cursoid = _cursoId,
                        InstructorId = id
                    };
                    _repository.Insert(cursoInstructor);
                }
            }
          
            return response;
        }

        public DataResult update(CursoViewModel curso)
        {
            DataResult response = _context.Update<CursoViewModel, Curso>(curso);
            return response;

        }
    }
}
