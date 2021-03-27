using RepositoryModel.Model;
using RepositoryModel.response;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IUsuario
    {
        Task<DataResult> Login(LoginViewModel model);
        Task<DataResult> RegisterUser(RegisterViewModel model);
        Task<DataResult> UsuarioActual();
    }
}
