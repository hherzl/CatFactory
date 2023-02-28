﻿using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Xml.Serialization;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a mapping for database data type for CLR
    /// </summary>
    [DebuggerDisplay("DatabaseType={DatabaseType}, ClrType={ClrType}, IsUserDefined={IsUserDefined}")]
    public class DatabaseTypeMap
    {
        #region [ Fields ]

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private dynamic m_importBag;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="DatabaseTypeMap"/> class
        /// </summary>
        public DatabaseTypeMap()
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the database type
        /// </summary>
        public string DatabaseType { get; set; }

        /// <summary>
        /// Gets or sets if database type allows lenght in declaration
        /// </summary>
        public bool AllowsLengthInDeclaration { get; set; }

        /// <summary>
        /// Gets or sets if database type allows precision in declaration
        /// </summary>
        public bool AllowsPrecInDeclaration { get; set; }

        /// <summary>
        /// Gets or sets if database type allows scale in declaration
        /// </summary>
        public bool AllowsScaleInDeclaration { get; set; }

        /// <summary>
        /// Gets or sets the full name for CLR type
        /// </summary>
        public string ClrFullNameType { get; set; }

        /// <summary>
        /// Gets if database type has full name CLR type
        /// </summary>
        public bool HasClrFullNameType
            => !string.IsNullOrEmpty(ClrFullNameType);

        /// <summary>
        /// Gets or sets the alias for CLR type
        /// </summary>
        public string ClrAliasType { get; set; }

        /// <summary>
        /// Gets or sets if database type has alias for CLR type
        /// </summary>
        public bool HasClrAliasType
            => !string.IsNullOrEmpty(ClrAliasType);

        /// <summary>
        /// Gets or sets if database type allow nullable for CLR
        /// </summary>
        public bool AllowClrNullable { get; set; }

        /// <summary>
        /// Gets or sets value for <see cref="DbType"/> enumeration
        /// </summary>
        public DbType DbTypeEnum { get; set; }

        /// <summary>
        /// Get or sets if database type is defined by user
        /// </summary>
        public bool IsUserDefined { get; set; }

        /// <summary>
        /// Gets or sets the parent database type for current database type
        /// </summary>
        public string ParentDatabaseType { get; set; }

        /// <summary>
        /// Gets or sets the collation
        /// </summary>
        public string Collation { get; set; }

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
    }
}
