namespace CatFactory.Mapping
{
    public class PrimaryKey : Constraint
    {
        public PrimaryKey()
        {
        }

        public PrimaryKey(params string[] key)
            : base(key)
        {
        }
    }
}
