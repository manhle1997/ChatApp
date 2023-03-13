using ChatApp.Data.Contexts;
using ChatApp.Repository.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Repository.Extensions
{
    public static class RepositoryServiceCollectionExtensions
    {
        public static IServiceCollection RepositoryExtension(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<User>, UserRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
