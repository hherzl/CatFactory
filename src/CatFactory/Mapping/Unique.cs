namespace CatFactory.Mapping
{
    public class Unique : Constraint
    {
        public Unique()
        {
        }

        public Unique(params string[] key)
            : base(key)
        {
        }
    }
}
