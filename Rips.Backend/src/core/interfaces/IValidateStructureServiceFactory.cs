namespace Rips.Backend.src.core.interfaces
{
    public interface IValidateStructureServiceFactory
    {
        public IValidateStructureService Create(Type fileRipType);
    }
}
