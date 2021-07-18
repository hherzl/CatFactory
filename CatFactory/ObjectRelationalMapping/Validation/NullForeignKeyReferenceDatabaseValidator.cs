using System;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.ObjectRelationalMapping.Validation
{
#pragma warning disable CS1591
    public class NullForeignKeyReferenceDatabaseValidator : IDatabaseValidator
    {
        public NullForeignKeyReferenceDatabaseValidator()
        {
        }

        public virtual ValidationResult Validate(Database database)
        {
            if (database == null)
                throw new ArgumentNullException(nameof(database));

            var result = new ValidationResult();

            foreach (var table in database.Tables)
            {
                foreach (var fk in table.ForeignKeys)
                {
                    var flag = false;

                    foreach (var column in table.Columns)
                    {
                        if (fk.Key.Contains(column.Name))
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (!flag)
                        result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has a null reference on foreign key, key: '{1}'", table.FullName, string.Join(",", fk.Key.Select(item => item)))));
                }
            }

            return result;
        }
    }
}
