using Microsoft.Extensions.DependencyInjection;
using Rips.Backend.src.core.configuration;
using Rips.Backend.src.core.domainService;
using Rips.Backend.src.core.interfaces;


namespace Rips.Backend.src.core.factories
{
    public class ValidateStructureServiceFactory : IValidateStructureServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public ValidateStructureServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IValidateStructureService Create(Type fileRipType)
        {
            TypeIsAssignableToIFileRip(fileRipType);

            var mapType = typeof(Imap<>).MakeGenericType(fileRipType);
            var map = _serviceProvider.GetRequiredService(mapType);
            var columnsConfiguration = _serviceProvider.GetRequiredService<IColumnLengthRequiredRegister>();
            var reader = _serviceProvider.GetRequiredService<IFileFlatReader>();

            var validateStructureServiceType = typeof(ValidateStructureService<>).MakeGenericType(fileRipType);
            var instance = Activator.CreateInstance(validateStructureServiceType, map, columnsConfiguration, reader);

            if (instance is not null) return (IValidateStructureService)instance;

            throw new ArgumentNullException($"No se pudo obtener implementacion para validacion del tipo {fileRipType.Name}");
        }

        private void TypeIsAssignableToIFileRip(Type fileRipType)
        {
            if (!typeof(IFileRip).IsAssignableFrom(fileRipType))
                throw new ArgumentException($"{fileRipType.Name} does not implement IFileRip");
        }

    }
}
