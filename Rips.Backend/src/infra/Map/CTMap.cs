using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.infra.Map
{
    public class CTMap : Imap<CT>
    {  
        public CT Map(string[] input)
        {
            CodeHealthProvider codeProvider = new CodeHealthProvider(input[0]);
            Date submissionDate = new Date(input[1]);
            string fileCode = input[2];
            string totalRecords = input[3];

            CT ctIntance = new CT(
                    codeProvider,
                    submissionDate,
                    fileCode,
                    totalRecords);

            return ctIntance;
        }
    }
}
