using Xunit;

namespace CatFactory.Tests
{
    public class CodeBuilderTest
    {
        [Fact]
        public void CreateFile()
        {
            // Arrange
            var codeBuilder = new MockCodeBuilder()
            {
                OutputDirectory = "C:\\Temp\\CatFactory"
            };

            // Act
            codeBuilder.CreateFile();
        }
    }
}
