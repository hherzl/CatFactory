using System.Linq;
using CatFactory.CodeFactory;
using CatFactory.Tests.CodeBuilders;
using CatFactory.Tests.Models;
using Xunit;

namespace CatFactory.Tests
{
    public static class EntityFrameworkCoreProjectExtensions
    {
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

    public class EntityFrameworkCoreProjectTests
    {
        [Fact]
        public void TestEntityFrameworkCoreProject()
        {
            // Arrange
            var project = new EntityFrameworkCoreProject
            {
                Name = "OnlineStore",
                Database = Databases.OnlineStore,
                OutputDirectory = "C:\\Temp\\CatFactory\\EntityFrameworkCore",
                AuthorInfo = new AuthorInfo
                {
                    Name = "Hans H.",
                    Email = "hansh@catfactory.org"
                }
            };

            project.BuildFeatures();

            project.GlobalSelection(settings =>
            {
                settings.UseDataAnnotations = true;
                settings.AddDataBindings = true;
            });

            project.Selection("Sales.OrderHeader", settings => settings.EntitiesWithDataContracts = true);

            project.ScaffoldingDefinition += (source, args) =>
            {
            };

            project.ScaffoldedDefinition += (source, args) =>
            {
            };

            // Act
            project.Scaffold();

            // Assert
            Assert.True(project.Selections.Count == 2);
        }
    }
}
