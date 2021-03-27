using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Repository.Interface;
using RepositoryModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Repository.Service
{
    public class UserSession : IUserSession
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserSession(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;

        }
        public string obtenerUsuarioSesion()
        {
            var userName = _httpContextAccessor.HttpContext.User?.Claims?
                                .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            return userName;
        }
    }
}
