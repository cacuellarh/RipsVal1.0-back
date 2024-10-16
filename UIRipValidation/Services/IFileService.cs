using Presentation.RipsValidator.Core.Types;
using System.ComponentModel;
using System.Xml;

namespace Presentation.RipsValidator.Services
{
    public interface IFileService : INotifyPropertyChanged
    {
        string FilePath { get; set; }
        ValidationFileType ValidationTypeSelected { get; set; }
    }
}