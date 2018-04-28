using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("ConstraintType={ConstraintType}, ConstraintName={ConstraintName}, ConstraintKeys={ConstraintKeys}")]
    public class ConstraintDetail
    {
        public ConstraintDetail()
        {
        }

        public string ConstraintType { get; set; }

        public string ConstraintName { get; set; }

        public string DeleteAction { get; set; }

        public string UpdateAction { get; set; }

        public string StatusEnabled { get; set; }

        public string StatusForReplication { get; set; }

        public string ConstraintKeys { get; set; }
    }
}
