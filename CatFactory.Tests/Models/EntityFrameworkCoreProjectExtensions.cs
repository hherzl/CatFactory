using System;
using System.Linq;
using CatFactory.CodeFactory;
using CatFactory.CodeFactory.Scaffolding;
using CatFactory.ObjectOrientedProgramming;
using CatFactory.ObjectRelationalMapping;
using CatFactory.Tests.CodeBuilders;

namespace CatFactory.Tests.Models
{
    public static class EntityFrameworkCoreProjectExtensions
    {
        public static EntityFrameworkCoreProject GlobalSelection(this EntityFrameworkCoreProject project, Action<EntityFrameworkCoreProjectSettings> action = null)
        {
            var settings = new EntityFrameworkCoreProjectSettings();

            var selection = project.Selections.FirstOrDefault(item => item.IsGlobal);

            if (selection == null)
            {
                selection = new ProjectSelection<EntityFrameworkCoreProjectSettings>
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

        public static ProjectSelection<EntityFrameworkCoreProjectSettings> GlobalSelection(this EntityFrameworkCoreProject project)
            => project.Selections.FirstOrDefault(item => item.IsGlobal);

        public static EntityFrameworkCoreProject Selection(this EntityFrameworkCoreProject project, string pattern, Action<EntityFrameworkCoreProjectSettings> action = null)
        {
            var selection = project.Selections.FirstOrDefault(item => item.Pattern == pattern);

            if (selection == null)
            {
                var globalSettings = project.GlobalSelection().Settings;

                selection = new ProjectSelection<EntityFrameworkCoreProjectSettings>
                {
                    Pattern = pattern,
                    Settings = new EntityFrameworkCoreProjectSettings
                    {
                        UseDataAnnotations = globalSettings.UseDataAnnotations,
                        AddDataBindings = globalSettings.AddDataBindings,
                        EntitiesWithDataContracts = globalSettings.EntitiesWithDataContracts
                    }
                };

                project.Selections.Add(selection);
            }

            action?.Invoke(selection.Settings);

            return project;
        }

        public static ClassDefinition GetEntityClassDefinition(this EntityFrameworkCoreProject project, ITable table, ProjectSelection<EntityFrameworkCoreProjectSettings> projectSelection)
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

        public static void Scaffold(this EntityFrameworkCoreProject project)
        {
            foreach (var table in project.Database.Tables)
            {
                var selection = project.Selections.FirstOrDefault(item => item.Pattern == table.FullName) ?? project.GlobalSelection();

                var codeBuilder = new CSharpClassCodeBuilder
                {
                    ObjectDefinition = project.GetEntityClassDefinition(table, selection),
                    OutputDirectory = project.OutputDirectory,
                    ForceOverwrite = true
                };

                codeBuilder.TranslatedDefinition += (source, args) =>
                {
                    if (project.AuthorInfo != null)
                    {
                        codeBuilder.Lines.Insert(0, new CommentLine("// Author name: {0}", project.AuthorInfo.Name));
                        codeBuilder.Lines.Insert(1, new CommentLine("// Email: {0}", project.AuthorInfo.Email));
                        codeBuilder.Lines.Insert(2, new CodeLine());
                    }
                };

                project.Scaffolding(codeBuilder);

                codeBuilder.CreateFile();

                project.Scaffolded(codeBuilder);
            }
        }
    }
}
