using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}, DbObjects={DbObjects.Count}")]
    public class Database
    {
        public Database()
        {
        }

        public String Name { get; set; }

        private List<DbObject> m_dbObjects;
        private List<Table> m_tables;
        private List<View> m_views;
        private List<Procedure> m_procedures;

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

        public List<Procedure> Procedures
        {
            get
            {
                return m_procedures ?? (m_procedures = new List<Procedure>());
            }
            set
            {
                m_procedures = value;
            }
        }

        public virtual void LinkTables()
        {
            foreach (var table in Tables)
            {
                foreach (var column in table.Columns)
                {
                    if (!table.PrimaryKey.Key.Contains(column.Name))
                    {
                        foreach (var parentTable in Tables)
                        {
                            if (table.FullName == parentTable.FullName)
                            {
                                continue;
                            }

                            if (parentTable.PrimaryKey != null && parentTable.PrimaryKey.Key.Contains(column.Name))
                            {
                                table.ForeignKeys.Add(new ForeignKey { Key = new List<String>() { column.Name }, References = parentTable.FullName });
                            }
                        }
                    }
                }
            }
        }
    }
}
