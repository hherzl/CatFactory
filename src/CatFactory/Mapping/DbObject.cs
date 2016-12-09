using System;

namespace CatFactory.Mapping
{
    public class DbObject
    {
        public DbObject()
        {

        }

        public String Schema { get; set; }

        public String Name { get; set; }

        public String Type { get; set; }

        public String FullName
        {
            get
            {
                return String.IsNullOrEmpty(Schema) ? Name : String.Format("{0}.{1}", Schema, Name);
            }
        }
    }
}
