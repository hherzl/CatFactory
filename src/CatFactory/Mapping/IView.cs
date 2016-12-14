using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public interface IView : IDbObject
    {
        List<Column> Columns { get; set; }
    }
}
