namespace CatFactory.OOP
{
    public class Documentation
    {
        public Documentation()
        {
        }

        public Documentation(string summary)
        {
            Summary = summary;
        }

        public string Summary { get; set; }

        public string Remarks { get; set; }
    }
}
