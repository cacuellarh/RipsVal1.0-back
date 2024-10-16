using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using System.Reflection;

namespace Rips.Backend.src.core.configuration
{
    public class ColumnLengthRequiredRegister : IColumnLengthRequiredRegister
    {
        private Dictionary<Type, int> _columnsConfigurationRequired;
        private Type[] typesCurrentAssembly;
        private Assembly _assembly;
        public ColumnLengthRequiredRegister()
        {
            _columnsConfigurationRequired = new Dictionary<Type, int>();
            _assembly = Assembly.GetExecutingAssembly(); ;
            typesCurrentAssembly = _assembly.GetTypes();
            BuildConfigurationDictionary();
        }

        private void BuildConfigurationDictionary()
        {
            Type[] types = typesCurrentAssembly
                .Where(type => type.IsClass &&
                type.IsDefined(typeof(ColumnLengthRequired), false &&
                type.IsAssignableFrom(typeof(IFileRip)))).ToArray();

            foreach (Type type in types)
            {
                ColumnLengthRequired lengthConfigurationFile = (ColumnLengthRequired)Attribute.GetCustomAttribute(type, typeof(ColumnLengthRequired));

                NanisGuardV.validation.NotNull(lengthConfigurationFile);
                _columnsConfigurationRequired.Add(type, lengthConfigurationFile!.Length);
            }
        }

        public int GetColumnRequiredLength<FileRip>() where FileRip : IFileRip
        {
            var type = typeof(FileRip);

            if (!_columnsConfigurationRequired.ContainsKey(type))
                throw new InvalidOperationException($"No existe una configuracion regiustrada para el tipo {type.Name}");

            return _columnsConfigurationRequired[type];
        }
    }
}
