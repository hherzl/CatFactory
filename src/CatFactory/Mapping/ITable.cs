using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public interface ITable : IDbObject
    {
        List<Column> Columns { get; set; }

        PrimaryKey PrimaryKey { get; set; }

        Identity Identity { get; set; }
    }
}
