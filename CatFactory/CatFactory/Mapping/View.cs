﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a view
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Columns={Columns.Count}")]
    public class View : DbObject, IView
    {
        /// <summary>
        /// Initializes a new instance of <see cref="View"/> class
        /// </summary>
        public View()
        {
        }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a column by index
        /// </summary>
        /// <param name="index">Column's index</param>
        /// <returns>A <see cref="Column"/> from current table</returns>
        public Column this[int index]
        {
            get
            {
                return Columns[index];
            }
            set
            {
                Columns[index] = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Column> m_columns;

        /// <summary>
        /// Gets or sets the columns list
        /// </summary>
        public List<Column> Columns
        {
            get
            {
                return m_columns ?? (m_columns = new List<Column>());
            }
            set
            {
                m_columns = value;
            }
        }

        /// <summary>
        /// Gets a column by name
        /// </summary>
        /// <param name="name">Name for column</param>
        /// <returns>A column as selection result</returns>
        public Column GetColumn(string name)
            => Columns.First(item => item.Name == name);

        /// <summary>
        /// Gets or sets identity (auto increment)
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets row Guid column
        /// </summary>
        public RowGuidCol RowGuidCol { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Index> m_indexes;

        /// <summary>
        /// Gets or sets indexes list
        /// </summary>
        public List<Index> Indexes
        {
            get
            {
                return m_indexes ?? (m_indexes = new List<Index>());
            }
            set
            {
                m_indexes = value;
            }
        }
    }
}
