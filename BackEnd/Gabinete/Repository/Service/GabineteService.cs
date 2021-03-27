using Repository.DataContext;
using Repository.Interface;
using RepositoryModel.Model.gabineteDB;
using RepositoryModel.response;
using RepositoryModel.Validations;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Service
{
    public class GabineteService : IGabineteService
    {
        private readonly IUnitOfWork<gabineteDbContext> _context;
        private readonly IRepository<gabineteDbContext> _repository;
        public GabineteService(IUnitOfWork<gabineteDbContext> context, IRepository<gabineteDbContext> repository)
        {
            _context = context;
            _repository = repository;
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
            response = _context.Insert<GabineteViewModel, mae_persona>(model);

            return response;
        }
        public DataResult GetById(int id)
        {
            return _context.GetById<GabineteViewModel, mae_persona>(id);
        }
    }
}
