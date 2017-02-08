using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private IDatabaseNamingConvention m_namingConvention;
        private List<DbObject> m_dbObjects;
        private List<Table> m_tables;
        private List<View> m_views;
        private List<StoredProcedure> m_storedProcedures;
        private List<ScalarFunction> m_scalarFunctions;
        private List<TableFunction> m_tableFunctions;

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
    }
}
