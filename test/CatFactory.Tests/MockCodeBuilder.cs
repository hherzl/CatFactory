using System;
using CatFactory.CodeFactory;

namespace CatFactory.Tests
{
    public class MockCodeBuilder : CodeBuilder
    {
        public override String FileName => "Mock";

        public override String FileExtension => "txt";

        public override String Code => "MockCodeBuilder";
    }
}
