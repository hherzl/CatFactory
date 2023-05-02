using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Xml.Serialization;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a view
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Columns={Columns.Count}")]
    public class View : DbObject, IView
    {
        #region [ Fields ]

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Column> m_columns;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Index> m_indexes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private dynamic m_importBag;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="View"/> class
        /// </summary>
        public View()
            : base()
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets identity (auto increment)
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets the extension data for import
        /// </summary>
        [XmlIgnore]
        public dynamic ImportBag
        {
            get => m_importBag ??= new ExpandoObject();
            set => m_importBag = value;
        }

        #endregion

        #region [ Indexers ]

        /// <summary>
        /// Gets or sets a column by index
        /// </summary>
        /// <param name="index">Column's index</param>
        /// <returns>A <see cref="Column"/> from current table</returns>
        public Column this[int index]
        {
            get => Columns[index];
            set => Columns[index] = value;
        }

        /// <summary>
        /// Gets or sets a column by name
        /// </summary>
        /// <param name="name">Column's name</param>
        /// <returns>A <see cref="Column"/> from current view</returns>
        public Column this[string name]
        {
            get => Columns.First(item => item.Name == name);
            set
            {
                for (var i = 0; i < Columns.Count; i++)
                {
                    var column = Columns[i];

                    if (column.Name == name)
                        column = value;
                }
            }
        }

        #endregion

        #region [ Members of IView ]

        /// <summary>
        /// Gets or sets the columns list
        /// </summary>
        public List<Column> Columns
        {
            get => m_columns ??= new List<Column>();
            set => m_columns = value;
        }

        /// <summary>
        /// Gets or sets indexes list
        /// </summary>
        public List<Index> Indexes
        {
            get => m_indexes ??= new List<Index>();
            set => m_indexes = value;
        }

        #endregion
    }
}
