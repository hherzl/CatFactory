using Xunit;

namespace CatFactory.Tests
{
    public class MarkupTests
    {
        [Fact]
        public void TestHtml()
        {
            var codeBuilder = new HtmlCodeBuilder
            {
                OutputDirectory = "C:\\Temp"
            };

            codeBuilder.CreateFile();
        }
    }
}
