using System.Data.Common;

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
        /// <returns></returns>
        public static ClassDefinition GetClassDefinition(this DbDataReader dataReader)
        {
            var definition = new ClassDefinition();

            if (dataReader.FieldCount > 0)
            {
                for (var i = 0; i < dataReader.FieldCount; i++)
                {
                    var type = dataReader.GetFieldType(i);
                    var name = dataReader.GetName(i);

                    definition.Properties.Add(new PropertyDefinition(type.Name, name));
                }
            }

            return definition;
        }
    }
}
