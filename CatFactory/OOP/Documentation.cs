namespace CatFactory.OOP
{
    public class Documentation
    {
        public Documentation()
        {
        }

        public string Summary { get; set; }

        public bool HasSummary
            => !string.IsNullOrEmpty(Summary);

        public string Remarks { get; set; }

        public bool HasRemarks
            => !string.IsNullOrEmpty(Remarks);
    }
}
