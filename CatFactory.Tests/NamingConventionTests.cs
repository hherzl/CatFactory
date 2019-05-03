using Xunit;

namespace CatFactory.Tests
{
    public class NamingConventionTests
    {
        [Fact]
        public void TestCamelCase()
        {
            Assert.True("foo" == NamingConvention.GetCamelCase("FOO"));
            Assert.True("bar" == NamingConvention.GetCamelCase("Bar"));
            Assert.True("zaz" == NamingConvention.GetCamelCase("zaz"));
            Assert.True("fooBarZaz" == NamingConvention.GetCamelCase("FooBarZaz"));
            Assert.True("fooBarZaz" == NamingConvention.GetCamelCase("foo bar zaz"));
            Assert.True("fooBarZaz" == NamingConvention.GetCamelCase("FOO BAR ZAZ"));
            Assert.True("fooBarZaz" == NamingConvention.GetCamelCase("foo_bar_zaz"));
            Assert.True("fooBarZaz" == NamingConvention.GetCamelCase("FOO-BAR-ZAZ"));
            Assert.True("fooBarZaz" == NamingConvention.GetCamelCase("foo-bar-zaz"));
            Assert.True("fooBarZaz" == NamingConvention.GetCamelCase("FOO-BAR-ZAZ"));
        }

        [Fact]
        public void TestPascalCase()
        {
            Assert.True("Foo" == NamingConvention.GetPascalCase("FOO"));
            Assert.True("Bar" == NamingConvention.GetPascalCase("Bar"));
            Assert.True("Zaz" == NamingConvention.GetPascalCase("zaz"));
            Assert.True("FooBarZaz" == NamingConvention.GetPascalCase("fooBarZaz"));
            Assert.True("FooBarZaz" == NamingConvention.GetPascalCase("foo.bar.zaz"));
            Assert.True("FooBarZaz" == NamingConvention.GetPascalCase("FOO.BAR.ZAZ"));
            Assert.True("FooBarZaz" == NamingConvention.GetPascalCase("foo_bar_zaz"));
            Assert.True("FooBarZaz" == NamingConvention.GetPascalCase("FOO_BAR_ZAZ"));
            Assert.True("FooBarZaz" == NamingConvention.GetPascalCase("foo-bar-zaz"));
            Assert.True("FooBarZaz" == NamingConvention.GetPascalCase("FOO-BAR-ZAZ"));
            Assert.True("FooBarZaz" == NamingConvention.GetPascalCase("foo bar zaz"));
            Assert.True("FooBarZaz" == NamingConvention.GetPascalCase("FOO BAR ZAZ"));
        }

        [Fact]
        public void TestSnakeCase()
        {
            Assert.Equal("schema_id", NamingConvention.GetSnakeCase("schema_id"));
            Assert.Equal("SCHEMA_ID", NamingConvention.GetSnakeCase("SCHEMA_ID"));
            Assert.Equal("schema_id", NamingConvention.GetSnakeCase("schema id"));
            Assert.Equal("SCHEMA_ID", NamingConvention.GetSnakeCase("SCHEMA ID"));
            Assert.Equal("FOO", NamingConvention.GetSnakeCase("FOO"));
            Assert.Equal("Bar", NamingConvention.GetSnakeCase("Bar"));
            Assert.Equal("zaz", NamingConvention.GetSnakeCase("zaz"));
            Assert.Equal("foo_Bar_Zaz", NamingConvention.GetSnakeCase("fooBarZaz"));
            Assert.Equal("foo_bar_zaz", NamingConvention.GetSnakeCase("foo.bar.zaz"));
            Assert.Equal("foo_bar_zaz", NamingConvention.GetSnakeCase("foo_bar_zaz"));
            Assert.Equal("foo_bar_zaz", NamingConvention.GetSnakeCase("foo bar zaz"));
        }

        [Fact]
        public void TestKebabCase()
        {
            Assert.True("foo" == NamingConvention.GetKebabCase("FOO"));
            Assert.True("bar" == NamingConvention.GetKebabCase("Bar"));
            Assert.True("zaz" == NamingConvention.GetKebabCase("zaz"));
            Assert.True("foo-bar-zaz" == NamingConvention.GetKebabCase("FooBarZaz"));
            Assert.True("foo-bar-zaz" == NamingConvention.GetKebabCase("foo bar zaz"));
            Assert.True("foo-bar-zaz" == NamingConvention.GetKebabCase("foo-bar-zaz"));
            Assert.True("foo-bar-zaz" == NamingConvention.GetKebabCase("foo_bar_zaz"));
            Assert.True("foo-bar-zaz" == NamingConvention.GetKebabCase("foo.bar.zaz"));
        }
    }
}
