using CatFactory.CodeFactory;

namespace CatFactory.Tests
{
    public class MockCodeBuilder : CodeBuilder
    {
        public override string FileName
        {
            get
            {
                return "Mock";
            }
        }

        public override string FileExtension
        {
            get
            {
                return "txt";
            }
        }

        public override string Code
        {
            get
            {
                return "MockCodeBuilder";
            }
        }
    }
}
