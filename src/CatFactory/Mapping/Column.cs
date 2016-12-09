using System;

namespace CatFactory.Mapping
{
    public class Column
    {
        public Column()
        {

        }

        public String Name { get; set; }

        public String Type { get; set; }

        public Int32 Length { get; set; }

        public Int16 Prec { get; set; }

        public Boolean Nullable { get; set; }
    }
}
