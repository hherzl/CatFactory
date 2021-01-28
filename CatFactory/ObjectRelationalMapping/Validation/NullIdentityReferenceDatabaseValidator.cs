using System;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.ObjectRelationalMapping.Validation
{
    public class NullIdentityReferenceDatabaseValidator : IDatabaseValidator
    {
        public NullIdentityReferenceDatabaseValidator()
        {
        }

        public virtual ValidationResult Validate(Database database)
        {
            if (database == null)
                throw new ArgumentNullException(nameof(database));

            var result = new ValidationResult();

            foreach (var table in database.Tables)
            {
                if (table.Identity == null)
                    continue;

                if (table.Columns.Count(item => item.Name == table.Identity.Name) == 0)
                    result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has a null reference on identity, column: '{1}'", table.FullName, table.Identity.Name)));
            }

            return result;
        }
    }
}
