using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TemplateWebApi.APIs.Properties;

namespace TemplateWebApi.APIs.Installers
{
    public class DiContainerInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.Scan(x => x.FromAssemblies(Assembly.Load(Resources.BL_ASSEMBLY_NAME))
                .AddClasses(classes => classes
                    .Where(c => c.Name.EndsWith("Services")))
                .AsImplementedInterfaces()
                .WithScopedLifetime());
        }
    }
}