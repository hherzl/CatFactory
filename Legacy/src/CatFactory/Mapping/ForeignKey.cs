namespace CatFactory.Mapping
{
    public class ForeignKey : Constraint
    {
        public ForeignKey()
        {
        }

        public ForeignKey(params string[] key)
            : base(key)
        {
        }

        public string References { get; set; }

        public string Child { get; set; }
    }
}
