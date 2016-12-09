using System;

namespace CatFactory.CodeFactory
{
    public interface INamingConvention
    {
        String ValidName(String name);

        String GetInterfaceName(String value);

        String GetClassName(String value);

        String GetFieldName(String value);

        String GetPropertyName(String value);

        String GetMethodName(String value);

        String GetParameterName(String value);
    }
}
