using Microsoft.Extensions.DependencyInjection;
using Rips.Backend.src.core.interfaces;

namespace Rips.Backend.src.core.factories
{
    public class FileRipFactory : IFileRipFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public FileRipFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IFileRip CreateFileRip<T>(IFileRip type) where T : IFileRip
        {
            return (IFileRip)_serviceProvider.GetRequiredService(typeof(T));
        }
    }
}
