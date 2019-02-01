using System;
using System.Linq;
using CatFactory.CodeFactory.Scaffolding;
using CatFactory.ObjectOrientedProgramming;
using CatFactory.ObjectRelationalMapping;

namespace CatFactory.Tests.Models
{
    public static class DapperProjectExtensions
    {
        public static DapperProject GlobalSelection(this DapperProject project, Action<DapperProjectSettings> action = null)
        {
            var settings = new DapperProjectSettings();

            var selection = project.Selections.FirstOrDefault(item => item.IsGlobal);

            if (selection == null)
            {
                selection = new ProjectSelection<DapperProjectSettings>
                {
                    Pattern = ProjectSelection<EntityFrameworkCoreProjectSettings>.GlobalPattern,
                    Settings = settings
                };

                project.Selections.Add(selection);
            }
            else
            {
                settings = selection.Settings;
            }

            action?.Invoke(settings);

            return project;
        }

        public static DapperProject Selection(this DapperProject project, string pattern, Action<DapperProjectSettings> action = null)
        {
            var selection = project.Selections.FirstOrDefault(item => item.Pattern == pattern);

            if (selection == null)
            {
                selection = new ProjectSelection<DapperProjectSettings>
                {
                    Pattern = pattern,
                    Settings = new DapperProjectSettings()
                };

                project.Selections.Add(selection);
            }

            action?.Invoke(selection.Settings);

            return project;
        }

        public static ProjectSelection<DapperProjectSettings> GlobalSelection(this DapperProject project)
            => project.Selections.FirstOrDefault(item => item.IsGlobal);

        public static ClassDefinition GetEntityClassDefinition(this DapperProject project, ITable table, ProjectSelection<DapperProjectSettings> projectSelection)
        {
            var definition = new ClassDefinition
            {
                Name = table.Name
            };

            foreach (var column in table.Columns)
            {
                definition.Properties.Add(new PropertyDefinition(column.Type, column.Name));
            }

            return definition;
        }
    }
}
