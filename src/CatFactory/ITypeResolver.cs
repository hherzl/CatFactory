using System;

namespace CatFactory
{
    public interface ITypeResolver
    {
        String Resolve(String type);
    }
}
