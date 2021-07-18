using System;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.ObjectRelationalMapping.Validation
{
#pragma warning disable CS1591
    public class NullPrimaryKeyReferenceDatabaseValidator : IDatabaseValidator
    {
        public NullPrimaryKeyReferenceDatabaseValidator()
        {
        }

        public virtual ValidationResult Validate(Database database)
        {
            if (database == null)
                throw new ArgumentNullException(nameof(database));

            var result = new ValidationResult();

            foreach (var table in database.Tables)
            {
                if (table.PrimaryKey == null)
                {
                    result.ValidationMessages.Add(new ValidationMessage(LogLevel.Warning, string.Format("The table '{0}' doesn't have definition for primary key", table.FullName)));
                }
                else
                {
                    var flag = false;

                    foreach (var column in table.Columns)
                        if (table.PrimaryKey.Key.Contains(column.Name))
                        {
                            flag = true;
                            break;
                        }

                    if (!flag)
                        result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has a null reference on primary key, key: '{1}'", table.FullName, string.Join(",", table.PrimaryKey.Key.Select(item => item)))));
                }
            }

            return result;
        }
    }
}
