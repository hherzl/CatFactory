using System;

namespace CatFactory.OOP
{
    public class Documentation
    {
        public Documentation()
        {
        }

        public Documentation(String summary)
        {
            Summary = summary;
        }

        public String Summary { get; set; }

        public String Remarks { get; set; }
    }
}
