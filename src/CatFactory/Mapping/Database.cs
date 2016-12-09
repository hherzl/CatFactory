using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public class Database
    {
        public Database()
        {

        }

        public String Name { get; set; }

        private List<DbObject> m_dbObjects;
        private List<Table> m_tables;
        private List<View> m_views;

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
    }
}
