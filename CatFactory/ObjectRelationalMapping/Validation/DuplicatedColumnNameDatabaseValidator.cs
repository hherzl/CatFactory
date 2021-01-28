using System;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.ObjectRelationalMapping.Validation
{
    public class DuplicatedColumnNameDatabaseValidator : IDatabaseValidator
    {
        public DuplicatedColumnNameDatabaseValidator()
        {
        }

        public virtual ValidationResult Validate(Database database)
        {
            if (database == null)
                throw new ArgumentNullException(nameof(database));

            var result = new ValidationResult();

            foreach (var table in database.Tables)
            {
                foreach (var column in table.Columns)
                {
                    if (table.Columns.Count(item => item.Name == column.Name) > 1)
                        result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has more than one column with name: '{1}'", table.FullName, column.Name)));
                }
            }

            return result;
        }
    }
}
