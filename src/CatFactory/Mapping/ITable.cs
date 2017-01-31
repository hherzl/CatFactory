using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public interface ITable : IReadableObject
    {
        String Description { get; set; }

        PrimaryKey PrimaryKey { get; set; }

        Identity Identity { get; set; }

        List<ForeignKey> ForeignKeys { get; set; }

        List<Unique> Uniques { get; set; }
    }
}
