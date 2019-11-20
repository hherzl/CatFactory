using System.Data.Common;
using CatFactory.CodeFactory;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Contains extension methods for implementations of <see cref="DbDataReader"/> class
    /// </summary>
    public static class DbDataReaderExtensions
    {
        /// <summary>
        /// Gets a class definition from <see cref="DbDataReader"/> implementation
        /// </summary>
        /// <param name="dataReader">Implementation of <see cref="DbDataReader"/> class</param>
        /// <param name="name">Class name</param>
        /// <param name="namingConvention">Implementation of <see cref="ICodeNamingConvention"/> interface</param>
        /// <returns></returns>
        public static ClassDefinition GetClassDefinition(this DbDataReader dataReader, string name = null, ICodeNamingConvention namingConvention = null)
        {
            var definition = new ClassDefinition
            {
                AccessModifier = AccessModifier.Public,
                Name = name ?? "Class1"
            };

            if (dataReader.FieldCount > 0)
            {
                for (var i = 0; i < dataReader.FieldCount; i++)
                {
                    var propertyType = dataReader.GetFieldType(i);
                    var propertyName = namingConvention == null ? dataReader.GetName(i) : namingConvention.GetPropertyName(dataReader.GetName(i));

                    definition.Properties.Add(new PropertyDefinition
                    {
                        AccessModifier = AccessModifier.Public,
                        Type = propertyType.Name,
                        Name = propertyName,
                        IsAutomatic = true
                    });
                }
            }

            return definition;
        }
    }
}
