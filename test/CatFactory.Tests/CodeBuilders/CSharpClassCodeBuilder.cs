namespace CatFactory.Tests.CodeBuilders
{
    public class CSharpClassCodeBuilder : CSharpCodeBuilder
    {
        public override string Code => string.Format("public class {0} {{ }}", ObjectDefinition.Name);
    }
}
