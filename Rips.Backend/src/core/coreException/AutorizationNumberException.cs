namespace Rips.Backend.src.core.coreException
{
    public class AutorizationNumberException : InvalidOperationException
    {
        public AutorizationNumberException(string autorizationNumber) 
            : base($"Se ingreso el numero de autorizacion ({autorizationNumber}) lo cual puede generar un error ya que no es una " +
                  $"caracteristica implementada correctamente.") { }

    }
}
