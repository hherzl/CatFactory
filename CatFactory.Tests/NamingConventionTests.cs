using Xunit;

namespace CatFactory.Tests
{
    public class NamingConventionTests
    {
        [Fact]
        public void TestCamelCase()
        {
            Assert.True(NamingConvention.GetCamelCase("FOO") == "foo");
            Assert.True(NamingConvention.GetCamelCase("Bar") == "bar");
            Assert.True(NamingConvention.GetCamelCase("zaz") == "zaz");
            Assert.True(NamingConvention.GetCamelCase("FooBarZaz") == "fooBarZaz");
            Assert.True(NamingConvention.GetCamelCase("foo bar zaz") == "fooBarZaz");
            Assert.True(NamingConvention.GetCamelCase("foo_bar_zaz") == "fooBarZaz");
        }

        [Fact]
        public void TestPascalCase()
        {
            Assert.True(NamingConvention.GetPascalCase("FOO") == "Foo");
            Assert.True(NamingConvention.GetPascalCase("Bar") == "Bar");
            Assert.True(NamingConvention.GetPascalCase("zaz") == "Zaz");
            Assert.True(NamingConvention.GetPascalCase("fooBarZaz") == "FooBarZaz");
            Assert.True(NamingConvention.GetPascalCase("foo.bar.zaz") == "FooBarZaz");
            Assert.True(NamingConvention.GetPascalCase("foo_bar_zaz") == "FooBarZaz");
            Assert.True(NamingConvention.GetPascalCase("foo bar zaz") == "FooBarZaz");
        }

        [Fact]
        public void TestSnakeCase()
        {
            Assert.Equal("schema_id", NamingConvention.GetSnakeCase("schema_id"));
            Assert.Equal("schema_id", NamingConvention.GetSnakeCase("schema.id") );
            Assert.Equal("schema_id", NamingConvention.GetSnakeCase("schema id") );
            Assert.Equal("FOO", NamingConvention.GetSnakeCase("FOO") );
            Assert.Equal("Bar", NamingConvention.GetSnakeCase("Bar") );
            Assert.Equal("zaz", NamingConvention.GetSnakeCase("zaz") );
            Assert.Equal("fooBarZaz",NamingConvention.GetSnakeCase("fooBarZaz")  );
            Assert.Equal("foo_bar_zaz",NamingConvention.GetSnakeCase("foo.bar.zaz") );
            Assert.Equal("foo_bar_zaz",NamingConvention.GetSnakeCase("foo_bar_zaz") );
            Assert.Equal("foo_bar_zaz",NamingConvention.GetSnakeCase("foo bar zaz") );
        }
    }
}
