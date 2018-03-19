using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("IndexName={IndexName}, IndexDescription={IndexDescription}, IndexKeys={IndexKeys}")]
    public class Index
    {
        public Index()
        {
        }

        public string IndexName { get; set; }

        public string IndexDescription { get; set; }

        public string IndexKeys { get; set; }
    }
}
