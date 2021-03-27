using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Repository.DataContext;
using Repository.Interface;
using RepositoryModel.Model;
using RepositoryModel.response;
using RepositoryModel.Validations;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service
{
    public class UsuarioService : IUsuario
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly IJwtGenerate _jwtGenerate;
        private readonly IUnitOfWork<AppDbContext> _context;
        private readonly IUserSession _userSession;
        public UsuarioService(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, IJwtGenerate jwtGenerate, IUnitOfWork<AppDbContext> context, IUserSession userSession)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtGenerate = jwtGenerate;
            _userSession = userSession;
        }
        public class LoginValidation : AbstractValidator<LoginViewModel>
        {
            public LoginValidation()
            {
                RuleFor(x => x.UserName).NotEmpty();
                RuleFor(x => x.Password).NotEmpty();
            }
        }
        public async Task<DataResult> Login(LoginViewModel model)
        {
            DataResult response = new DataResult();
            response.Successfull = false;
                
            var usuario = await _userManager.FindByNameAsync(model.UserName);
            if(usuario == null)
            {
                response.Successfull = false;
                response.Messages.Add("El usuario No existe");
                return response;
            }
            var result = await _signInManager.CheckPasswordSignInAsync(usuario, model.Password, false);
            if (!result.Succeeded)
            {
                response.Successfull = false;
                response.Messages.Add("El password es invalido vuelva a intentarlo");
                return response;
            }
            try
            {
                var user = new UsuarioViewModel
                {
                    NombreCompleto = usuario.NombreCompleto,
                    Token = _jwtGenerate.CrearToken(usuario),
                    Username = usuario.UserName,
                    Email = usuario.Email,
                    Imagen = null
                };

                response.Successfull = true;
                response.Messages.Add("Registro Exitoso");
                response.Data = user;

            }
            catch (Exception ex)
            {
                response.LogError(ex);
            }

            
            return response;
        }

        public async Task<DataResult> RegisterUser(RegisterViewModel model)
        {
            var response = new DataResult();
            RegisterValidation validation = new RegisterValidation(model);

            var resultValidations = validation.Message();
            if (resultValidations.Count > 0)
            {
                response.Successfull = false;
                response.Messages = resultValidations;
                return response;
            }

            var userExist = _context.Where<Usuario>(x => x.Email == model.Email);
            if(userExist.Count() > 0)
            {
                response.Successfull = false;
                response.Messages.Add("Un usuario ya existe con este email");
                return response;
            }
            var existUsername = _context.Where<Usuario>(x => x.UserName == model.Username);
            if(existUsername.Count() > 0)
            {
                response.Successfull = false;
                response.Messages.Add("Un usuario ya existe con este username");
                return response;
            }

            var user = new Usuario
            {
                NombreCompleto = model.Nombre + " " + model.Apellidos,
                Email = model.Email,
                UserName = model.Username
            };

              var result = await _userManager.CreateAsync(user, model.Password);


            if (!result.Succeeded)
            {
               response.Successfull = false;
               foreach(var resu in result.Errors)
                {
                    response.Messages.Add(resu.Description);
                }
                return response;
            }

            var userData = new UsuarioViewModel
            {
                NombreCompleto = user.NombreCompleto,
                Token = _jwtGenerate.CrearToken(user),
                Username = user.UserName,
                Email = user.Email
            };
            response.Successfull = false;
            response.Messages.Add("Usuario Registrado");
            response.Data = userData;

            return response;
        }

        public async Task<DataResult> UsuarioActual()
        {
            var response = new DataResult();
            response.Successfull = false;
            try
            {
                var findUser = await _userManager.FindByNameAsync(_userSession.obtenerUsuarioSesion());

                var user = new UsuarioViewModel
                {
                    NombreCompleto = findUser.NombreCompleto,
                    Username = findUser.UserName,
                    Token = _jwtGenerate.CrearToken(findUser),
                    Email = findUser.Email,
                    Imagen = null
                };
                response.Successfull = true;
                response.Data = user;
                response.Messages.Add("Usuario Actual");
            }
            catch (Exception ex)
            {
               // response.Data = ex;
                response.Messages.Add("Hubo un error al momento de buscar el usuario" + " "+ ex);

            }
            return response;
        }
    }
}
