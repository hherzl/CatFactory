using CatFactory.CodeFactory;
using Xunit;

namespace CatFactory.Tests
{
    public class CodeFactoryTests
    {
        [Fact]
        public void ValidateLines()
        {
            // Arrange and Act
            var codeLine = new CodeLine("var foo = 123;");
            var commentLine = new CommentLine("This is a comment");
            var todoLine = new TodoLine("Add code for this implementation: '{0}'", "Create database");
            var warningLine = new PreprocessorDirectiveLine("#warning");

            // Assert
            Assert.True(commentLine is ILine);
            Assert.True(todoLine is ILine);
            Assert.True(todoLine.Content == "Add code for this implementation: 'Create database'");
            Assert.True(warningLine is ILine);
        }
    }
}
