using CatFactory.CodeFactory;

namespace CatFactory.Tests.Models
{
    public class EntityFrameworkCoreProject : Project<EntityFrameworkCoreProjectSettings>
    {
        public void Scaffolding(ICodeBuilder codeBuilder)
        {
            OnScaffoldingDefinition(new ScaffoldingDefinitionEventArgs(Logger, codeBuilder));
        }

        public void Scaffolded(ICodeBuilder codeBuilder)
        {
            OnScaffoldedDefinition(new ScaffoldedDefinitionEventArgs(Logger, codeBuilder));
        }
    }
}
