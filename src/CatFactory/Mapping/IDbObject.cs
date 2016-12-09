using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public interface IDbObject
    {
        String Schema { get; set; }

        String Name { get; set; }

        String FullName { get; }

        List<Column> Columns { get; set; }
    }
}
