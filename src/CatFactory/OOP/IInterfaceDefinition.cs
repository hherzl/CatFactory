using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IInterfaceDefinition : IObjectDefinition
    {
        List<MetadataAttribute> Attributes { get; set; }

        List<EventDefinition> Events { get; set; }

        Boolean IsPartial { get; set; }
    }
}
