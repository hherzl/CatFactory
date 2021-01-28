using System;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.ObjectRelationalMapping.Validation
{
    public class NullUniqueReferenceDatabaseValidator : IDatabaseValidator
    {
        public NullUniqueReferenceDatabaseValidator()
        {
        }

        public virtual ValidationResult Validate(Database database)
        {
            if (database == null)
                throw new ArgumentNullException(nameof(database));

            var result = new ValidationResult();

            foreach (var table in database.Tables)
            {
                foreach (var unique in table.Uniques)
                {
                    var flag = false;

                    foreach (var column in table.Columns)
                    {
                        if (unique.Key.Contains(column.Name))
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (!flag)
                        result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has a null reference on unique, key: '{1}'", table.FullName, string.Join(",", unique.Key.Select(item => item)))));
                }
            }

            return result;
        }
    }
}
