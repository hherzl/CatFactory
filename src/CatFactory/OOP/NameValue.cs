namespace CatFactory.OOP
{
    public class NameValue : INameValue
    {
        public NameValue()
        {
        }

        public NameValue(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
