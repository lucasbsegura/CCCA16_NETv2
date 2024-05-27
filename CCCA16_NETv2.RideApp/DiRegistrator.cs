using CCCA16_NETv2.RideApp.Domain.Contracts;
using CCCA16_NETv2.RideApp.Infra.Database;
using CCCA16_NETv2.RideApp.Infra.Gateway;
using CCCA16_NETv2.RideApp.Infra.Repository;

namespace CCCA16_NETv2.RideApp
{
    public class DiRegistrator
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IDbService, DbService>();
            services.AddTransient<IAccountGateway, AccountGateway>();
            services.AddTransient<IPositionRepository, PositionRepository>();
            services.AddTransient<IRideRepository, RideRepository>();
        }
    }
}
