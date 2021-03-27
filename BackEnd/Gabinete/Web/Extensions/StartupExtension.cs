using Microsoft.Extensions.DependencyInjection;
using Repository.Interface;
using Repository.Repository;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Extensions
{
    public static class StartupExtension
    {
        public static void ServicesImplementations(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            services.AddScoped<IJwtGenerate, JwtGenerate>();
            services.AddScoped<IUserSession, UserSession>();

            services.AddTransient<IGabineteService, GabineteService>();
            services.AddTransient<IEmailServices, EmailServices>();
            services.AddTransient<IUsuario, UsuarioService>();

            services.AddTransient<ICurso, CursoSevice>();
        }
    }
}
