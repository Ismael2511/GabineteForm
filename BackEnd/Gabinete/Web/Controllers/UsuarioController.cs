using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Interface;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario _user;
        public UsuarioController(IUsuario user)
        {
            _user = user;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await _user.Login(model);
            return Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var result = await _user.RegisterUser(model);
            return Ok(result);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> usuarioActual()
        {
            var user = await _user.UsuarioActual();
            return Ok(user);
        }
    }
}
