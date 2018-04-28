namespace CatFactory.Tests.Models
{
    public class DapperProjectSettings : ProjectSettings
    {
        public bool UseStringBuilderForQueries { get; set; } = true;

        public bool UseQueryBuilder { get; set; } = true;
    }
}
