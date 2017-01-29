using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public class MetadataAttribute
    {
        public MetadataAttribute(String name, params String[] arguments)
        {
            Name = name;
            Arguments.AddRange(arguments);
        }

        public String Name { get; set; }

        private List<String> m_arguments;
        private List<String> m_sets;

        public List<String> Arguments
        {
            get
            {
                return m_arguments ?? (m_arguments = new List<String>());
            }
            set
            {
                m_arguments = value;
            }
        }

        public List<String> Sets
        {
            get
            {
                return m_sets ?? (m_sets = new List<String>());
            }
            set
            {
                m_sets = value;
            }
        }

        public Boolean HasArguments
        {
            get
            {
                return Arguments.Count > 0;
            }
        }

        public Boolean HasSets
        {
            get
            {
                return Sets.Count > 0;
            }
        }

        public Boolean HasMembers
        {
            get
            {
                return HasArguments || HasSets;
            }
        }
    }
}
