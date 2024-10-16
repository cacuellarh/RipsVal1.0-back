using NanisGuard.src;
using Rips.Backend.src.core.coreException;

namespace Rips.Backend.src.core.extensions
{
    public static partial class GuardExtensions
    {
        public static void AutorizationNumberWarning(this IGuardValidation guardValidation, string input)
        {
            if (input != string.Empty)
            {
                throw new AutorizationNumberException(input);
            }
        }
    }
}
