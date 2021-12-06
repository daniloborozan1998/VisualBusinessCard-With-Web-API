using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VisualBusinessCards.DataAccess;
using VisualBusinessCards.DataAccess.Implementations;
using VisualBusinessCards.DataAccess.Interface;
using VisualBusinessCards.Services.Implementations;
using VisualBusinessCards.Services.Interface;

namespace VisualBusinessCards.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<VisualBusinessCardsDbContext>(x =>
                x.UseSqlServer(connectionString));
        }
        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>(); //DI
        }
        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IUserServices, UserServices>(); //DI
        }
    }
}
