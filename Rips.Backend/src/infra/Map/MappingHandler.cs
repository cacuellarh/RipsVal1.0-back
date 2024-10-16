using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.infra.Exceptions;

namespace Rips.Backend.src.infra.Map
{
    public static class MappingHandler
    {
        public static TResult ProcessMapping<TResult>(Func<TResult> func) where TResult : IFileRip
        {
            try
            { 
                return func();  
            }
            catch (Exception ex)
            {
                throw new MappingException($"Error al validar archivo {typeof(TResult).Name} detalles: {ex.Message}");
            }
        }
    }
}
