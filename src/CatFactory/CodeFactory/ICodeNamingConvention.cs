using System;

namespace CatFactory.CodeFactory
{
    public interface ICodeNamingConvention : INamingConvention
    {
        String GetInterfaceName(String value);

        String GetClassName(String value);

        String GetConstantName(String value);

        String GetFieldName(String value);

        String GetPropertyName(String value);

        String GetMethodName(String value);

        String GetParameterName(String value);
    }
}
