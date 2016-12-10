using Xunit;

namespace CatFactory.Tests
{
    public class CodeBuilderTest
    {
        [Fact]
        public void CreateFile()
        {
            var codeBuilder = new MockCodeBuilder()
            {
                OutputDirectory = "C:\\Temp"
            };

            codeBuilder.CreateFile();
        }
    }
}
