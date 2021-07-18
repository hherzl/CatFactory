using System;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.ObjectRelationalMapping.Validation
{
#pragma warning disable CS1591
    public class NoColumnsDatabaseValidator : IDatabaseValidator
    {
        public NoColumnsDatabaseValidator()
        {
        }

        public virtual ValidationResult Validate(Database database)
        {
            if (database == null)
                throw new ArgumentNullException(nameof(database));

            var result = new ValidationResult();

            foreach (var table in database.Tables)
            {
                if (table.Columns.Count == 0)
                    result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' doesn't have columns", table.FullName)));
            }

            return result;
        }
    }
}
