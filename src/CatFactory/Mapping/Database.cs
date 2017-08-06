using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}, DbObjects={DbObjects.Count}")]
    public class Database
    {
        public Database()
        {
        }

        public String Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IDatabaseNamingConvention m_namingConvention;

        [XmlIgnore]
        public IDatabaseNamingConvention NamingConvention
        {
            get
            {
                return m_namingConvention ?? (m_namingConvention = new DatabaseNamingConvention());
            }
            set
            {
                m_namingConvention = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<DbObject> m_dbObjects;

        public List<DbObject> DbObjects
        {
            get
            {
                return m_dbObjects ?? (m_dbObjects = new List<DbObject>());
            }
            set
            {
                m_dbObjects = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Table> m_tables;

        public List<Table> Tables
        {
            get
            {
                return m_tables ?? (m_tables = new List<Table>());
            }
            set
            {
                m_tables = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<View> m_views;

        public List<View> Views
        {
            get
            {
                return m_views ?? (m_views = new List<View>());
            }
            set
            {
                m_views = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<StoredProcedure> m_storedProcedures;

        public List<StoredProcedure> StoredProcedures
        {
            get
            {
                return m_storedProcedures ?? (m_storedProcedures = new List<StoredProcedure>());
            }
            set
            {
                m_storedProcedures = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ScalarFunction> m_scalarFunctions;

        public List<ScalarFunction> ScalarFunctions
        {
            get
            {
                return m_scalarFunctions ?? (m_scalarFunctions = new List<ScalarFunction>());
            }
            set
            {
                m_scalarFunctions = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableFunction> m_tableFunctions;

        public List<TableFunction> TableFunctions
        {
            get
            {
                return m_tableFunctions ?? (m_tableFunctions = new List<TableFunction>());
            }
            set
            {
                m_tableFunctions = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<DbType> m_dbTypes;

        public List<DbType> DbTypes
        {
            get
            {
                return m_dbTypes ?? (m_dbTypes = new List<DbType>());
            }
            set
            {
                m_dbTypes = value;
            }
        }

        public virtual ITable FindTableByFullName(String fullName)
            => Tables.FirstOrDefault(item => String.Join(".", new String[] { Name, item.Schema, item.Name }) == fullName);

        public virtual ITable FindTableBySchemaAndName(String fullName)
            => Tables.FirstOrDefault(item => item.FullName == fullName);

        public virtual IEnumerable<ITable> FindTablesBySchema(String schema)
            => Tables.Where(item => item.Schema == schema);

        public virtual IEnumerable<ITable> FindTablesByName(String name)
            => Tables.Where(item => item.Name == name);
    }
}
