using System;

namespace CatFactory.Mapping
{
    public interface IView : IReadableObject
    {
        String Description { get; set; }
    }
}
