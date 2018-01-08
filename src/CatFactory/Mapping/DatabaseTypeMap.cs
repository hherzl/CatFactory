using System;
using System.Data;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("DatabaseType={DatabaseType}, ClrType={ClrType}")]
    public class DatabaseTypeMap
    {
        public DatabaseTypeMap()
        {
        }

        public string DatabaseType { get; set; }

        public bool AllowsLengthInDeclaration { get; set; }

        public bool AllowsPrecInDeclaration { get; set; }

        public bool AllowsScaleInDeclaration { get; set; }

        public string ClrFullNameType { get; set; }

        public bool HasClrFullNameType
            => !string.IsNullOrEmpty(ClrFullNameType);

        [XmlIgnore]
        public Type ClrType
            => HasClrFullNameType ? Type.GetType(ClrFullNameType) : null;

        public string ClrAliasType { get; set; }

        public bool HasClrAliasType
            => !string.IsNullOrEmpty(ClrAliasType);

        public bool AllowClrNullable { get; set; }

        public DbType DbTypeEnum { get; set; }

        public bool IsUserDefined { get; set; }

        public string ParentDatabaseType { get; set; }
    }
}
