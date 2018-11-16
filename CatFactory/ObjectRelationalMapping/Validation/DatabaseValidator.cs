using System;
using System.Linq;
using CatFactory.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.ObjectRelationalMapping.Validation
{
    /// <summary>
    /// Represents a validator for database's structure
    /// </summary>
    public class DatabaseValidator : IDatabaseValidator
    {
        /// <summary>
        /// Initializes a new instance of <see cref="DatabaseValidator"/> class
        /// </summary>
        public DatabaseValidator()
        {
        }

        /// <summary>
        /// Gets a validation result that contains all validation messages from validate action
        /// </summary>
        /// <param name="database">A database instance</param>
        /// <returns>A validation result that contains all validation messages (Log level and message) from validate action</returns>
        public virtual ValidationResult Validate(Database database)
        {
            if (database == null)
                throw new ArgumentNullException(nameof(database));

            var result = new ValidationResult();

            foreach (var table in database.Tables)
            {
                if (table.Columns.Count == 0)
                    result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' doesn't have columns", table.FullName)));

                foreach (var column in table.Columns)
                {
                    if (string.IsNullOrEmpty(column.Name))
                        result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has one column without name", table.FullName)));
                    else if (column.Name.Trim().Length == 0)
                        result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has one column without name", table.FullName)));
                    else if (table.Columns.Count(item => item.Name == column.Name) > 1)
                        result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has more than one column with name: '{1}'", table.FullName, column.Name)));
                }

                if (table.Identity != null)
                {
                    if (table.Columns.Count(item => item.Name == table.Identity.Name) == 0)
                        result.ValidationMessages.Add(new ValidationMessage(LogLevel.Error, string.Format("The table '{0}' has a null reference on identity, column: '{1}'", table.FullName, table.Identity.Name)));
                }

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
