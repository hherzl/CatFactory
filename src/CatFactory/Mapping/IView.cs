using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public interface IView : IReadableObject
    {
        String Description { get; set; }
    }
}
