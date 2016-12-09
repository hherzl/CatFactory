using CatFactory.OOP;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void TestClassDefinition()
        {
            var classDefinition = new ClassDefinition();

            classDefinition.Properties.Add(new PropertyDefinition { Type = "Int32?", Name = "ID" });
            classDefinition.Properties.Add(new PropertyDefinition { Type = "String", Name = "Name" });
            classDefinition.Properties.Add(new PropertyDefinition { Type = "String", Name = "Description" });
        }
    }
}
