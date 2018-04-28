using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public interface IReadableObject : IDbObject
    {
        List<Column> Columns { get; set; }
    }
}
