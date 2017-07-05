using System;

namespace CatFactory.CodeFactory
{
    public interface IArrayValue : IValue
    {
        Object[] Value { get; set; }
    }
}
