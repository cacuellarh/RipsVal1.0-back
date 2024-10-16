using Microsoft.Extensions.DependencyInjection;
using Rips.Backend.src.core.configuration;
using Rips.Backend.src.core.factories;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.infra.FileReader;
using Rips.Backend.src.infra.Map;
using Scrutor;
using System.Reflection;

namespace Rips.Backend.src.infra
{
    public static class RipsCoreServicesRegistration
    {
        public static void RegisterRipsCoreServicesRegistration(this IServiceCollection services)
        {
            services.AddTransient<IFileFlatReader, FileFlatReader>();
            services.AddTransient<IFileRipColumnsConfiguration, FileRipColumnsConfigRequired>();
            services.AddTransient<IValidateStructureServiceFactory, ValidateStructureServiceFactory>();
            services.AddTransient<IFileRipFactory, FileRipFactory>();
            services.AddTransient<IColumnLengthRequiredRegister, ColumnLengthRequiredRegister>();

            services.Scan(scan => scan
                .FromAssemblies(Assembly.GetExecutingAssembly())
                .AddClasses(classes => classes.AssignableTo<IFileRip>())
                .As<IFileRip>()
                .WithTransientLifetime());

            services.Scan(scan => scan
            .FromAssembliesOf(typeof(ACMap), typeof(CTMap))
            .AddClasses(classes => classes.AssignableTo(typeof(Imap<>)))
            .AsImplementedInterfaces() 
            .WithTransientLifetime());


        }
    }
}
