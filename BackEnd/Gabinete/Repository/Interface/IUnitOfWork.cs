using RepositoryModel.response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Interface
{
    public interface IUnitOfWork<Db>
    {
        IEnumerable<vm> GetAll<vm,Ent>() where Ent : class where vm : class;
        IEnumerable<Ent> Where<Ent>(Expression<Func<Ent, bool>> specification) where Ent : class;
        DataResult GetById<vm, Ent>(int id) where Ent : class where vm : class;
        DataResult Insert<vm, ent>(vm data) where vm : class where ent : class;
        DataResult Update<vm, ent>(vm data) where vm : class where ent : class;
    }
}
