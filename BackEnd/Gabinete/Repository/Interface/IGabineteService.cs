using RepositoryModel.response;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IGabineteService
    {
        DataResult Insert(GabineteViewModel model);
        DataResult GetById(int id);
    }
}
