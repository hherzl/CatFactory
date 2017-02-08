using System;

namespace CatFactory.Mapping
{
    public interface IDbObject
    {
        String Schema { get; set; }

        String Name { get; set; }

        String FullName { get; }

        String Type { get; set; }
    }
}
