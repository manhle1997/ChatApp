using ChatApp.Data.Contexts;
using ChatApp.Services.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ServiceExtension(this IServiceCollection services)
        {
            services.AddTransient<IBaseService<User>, UserService>();
            services.AddTransient<IUserService, UserService>();
            return services;
        }
    }
}
