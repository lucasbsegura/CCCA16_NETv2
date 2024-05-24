using CCCA16_NETv2.AccountApp.Domain.Contract.Repository;
using CCCA16_NETv2.AccountApp.Infra.Database;
using CCCA16_NETv2.AccountApp.Infra.Repository;

namespace CCCA16_NETv2.AccountApp
{
    public class DiRegistrator
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IDbService, DbService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
        }
    }
}
