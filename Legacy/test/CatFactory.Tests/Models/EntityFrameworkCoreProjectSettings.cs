namespace CatFactory.Tests.Models
{
    public class EntityFrameworkCoreProjectSettings : ProjectSettings
    {
        public bool UseDataAnnotations { get; set; }

        public bool AddDataBindings { get; set; }

        public bool EntitiesWithDataContracts { get; set; }
    }
}
