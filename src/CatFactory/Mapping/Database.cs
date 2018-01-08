using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}, DbObjects={DbObjects.Count}, Tables={Tables.Count}, Views={Views.Count}")]
    public class Database
    {
        public Database()
        {
        }

        public string Name { get; set; }

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
        private List<DatabaseTypeMap> m_mappings = new List<DatabaseTypeMap>();

        public List<DatabaseTypeMap> Mappings
        {
            get
            {
                return m_mappings ?? (m_mappings = new List<DatabaseTypeMap>());
            }
            set
            {
                m_mappings = value;
            }
        }

        public virtual List<DbObject> GetDbObjectsBySchema(string schema)
            => DbObjects.Where(item => item.Schema == schema).ToList();

        public virtual ITable FindTable(string name)
        {
            var table = Tables.FirstOrDefault(item => string.Join(".", new string[] { item.Schema, item.Name }) == name);

            if (table == null)
            {
                table = Tables.FirstOrDefault(item => string.Join(".", new string[] { Name, item.Schema, item.Name }) == name);
            }

            return table;
        }

        public virtual IEnumerable<ITable> FindTablesBySchema(string schema)
            => Tables.Where(item => item.Schema == schema);

        public virtual IEnumerable<ITable> FindTablesByName(string name)
            => Tables.Where(item => item.Name == name);

        public virtual IView FindView(string name)
        {
            var view = Views.FirstOrDefault(item => string.Join(".", new string[] { item.Schema, item.Name }) == name);

            if (view == null)
            {
                view = Views.FirstOrDefault(item => string.Join(".", new string[] { Name, item.Schema, item.Name }) == name);
            }

            return view;
        }

        public virtual IEnumerable<IView> FindViewsBySchema(string schema)
            => Views.Where(item => item.Schema == schema);

        public virtual IEnumerable<IView> FindViewsByName(string name)
            => Views.Where(item => item.Name == name);
    }
}
