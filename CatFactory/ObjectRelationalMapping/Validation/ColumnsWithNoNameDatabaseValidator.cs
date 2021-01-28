using System;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.ObjectRelationalMapping.Validation
{
    public class ColumnsWithNoNameDatabaseValidator : IDatabaseValidator
    {
        public ColumnsWithNoNameDatabaseValidator()
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
                    if (string.IsNullOrEmpty(column.Name))
                        result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has one column without name", table.FullName)));
                    else if (column.Name.Trim().Length == 0)
                        result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has one column without name", table.FullName)));
                }
            }

            return result;
        }
    }
}
