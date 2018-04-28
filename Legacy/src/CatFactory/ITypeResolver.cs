using System;

namespace CatFactory
{
    [Obsolete("Replace this object with DatabaseTypeMap list to resolve types between CLR and database")]
    public interface ITypeResolver
    {
        string Resolve(string type);
    }
}
