using System.Diagnostics;

namespace CatFactory.OOP
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("Name={Name}, Constraint={Constraint}")]
    public class GenericTypeDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public GenericTypeDefinition()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Constraint { get; set; }
    }
}
