using CatFactory.CodeFactory;

namespace CatFactory.Tests.CodeBuilders
{
    public class CSharpCodeBuilder : CodeBuilder
    {
        public override string FileExtension => "cs";

        public override string FileName => ObjectDefinition.Name;
    }
}
