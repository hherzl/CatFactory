using System;

namespace CatFactory
{
    public interface ISerializer
    {
        String Serialize<T>(T obj);

        T Deserialze<T>(String source);
    }
}
