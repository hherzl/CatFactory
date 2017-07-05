using System;

namespace CatFactory.CodeFactory
{
    public interface IObjectValue : IValue
    {
        Object Value { get; set; }
    }
}
