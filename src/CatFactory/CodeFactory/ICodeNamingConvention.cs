namespace CatFactory.CodeFactory
{
    public interface ICodeNamingConvention : INamingConvention
    {
        string GetNamespace(string value);

        string GetInterfaceName(string value);

        string GetClassName(string value);

        string GetConstantName(string value);

        string GetFieldName(string value);

        string GetPropertyName(string value);

        string GetMethodName(string value);

        string GetParameterName(string value);
    }
}
