namespace CatFactory.Mapping
{
    public class Check : Constraint
    {
        public Check()
        {
        }

        public Check(params string[] key)
            : base(key)
        {
        }
    }
}
