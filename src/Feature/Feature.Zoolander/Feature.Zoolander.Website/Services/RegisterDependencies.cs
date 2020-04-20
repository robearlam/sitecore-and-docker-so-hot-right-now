using Feature.Zoolander.Website.Controllers;
using Feature.Zoolander.Website.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Feature.Zoolander.Website.Services
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICastListRepository, CastListRepository>();
            serviceCollection.AddTransient<CastListController>();
        }
    }
}