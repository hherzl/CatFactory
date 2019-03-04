namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents a naming convention for programming language
    /// </summary>
    public interface ICodeNamingConvention : INamingConvention
    {
        /// <summary>
        /// Gets the namespace name for code naming convention
        /// </summary>
        /// <param name="values">An object array that contains zero or more objects to build namespace</param>
        /// <returns>A <see cref="string"/> that represents a valid namespace name</returns>
        string GetNamespace(params string[] values);

        /// <summary>
        /// Gets the interface name for code naming convention
        /// </summary>
        /// <param name="value">A name to transform according a programming language</param>
        /// <returns>A <see cref="string"/> that represents a valid interface name</returns>
        string GetInterfaceName(string value);

        /// <summary>
        /// Gets the class name for code naming convention
        /// </summary>
        /// <param name="value"></param>
        /// <returns>A <see cref="string"/> that represents a valid class name</returns>
        string GetClassName(string value);

        /// <summary>
        /// Gets the constant name for code naming convention
        /// </summary>
        /// <param name="value"></param>
        /// <returns>A <see cref="string"/> that represents a valid constant name</returns>
        string GetConstantName(string value);

        /// <summary>
        /// Gets the field name for code naming convention
        /// </summary>
        /// <param name="value"></param>
        /// <returns>A <see cref="string"/> that represents a valid field name</returns>
        string GetFieldName(string value);

        /// <summary>
        /// Gets the property name for code naming convention
        /// </summary>
        /// <param name="value"></param>
        /// <returns>A <see cref="string"/> that represents a valid property name</returns>
        string GetPropertyName(string value);

        /// <summary>
        /// Gets the method name for code naming convention
        /// </summary>
        /// <param name="value"></param>
        /// <returns>A <see cref="string"/> that represents a valid method name</returns>
        string GetMethodName(string value);

        /// <summary>
        /// Gets the parameter name for code naming convention
        /// </summary>
        /// <param name="value"></param>
        /// <returns>A <see cref="string"/> that represents a valid parameter name</returns>
        string GetParameterName(string value);
    }
}
