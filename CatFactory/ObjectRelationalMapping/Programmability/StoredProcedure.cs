﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Xml.Serialization;

namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents a stored procedure
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Parameters={Parameters.Count}")]
    public class StoredProcedure : DbObject, IStoredProcedure
    {
        #region [ Fields ]

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private dynamic m_importBag;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Parameter> m_parameters;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ResultSet> m_resultSets;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="StoredProcedure"/> class
        /// </summary>
        public StoredProcedure()
            : base()
        {
        }

        #endregion

        #region [ Properties ]

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

        #region [ Members of IStoredProcedure ]

        /// <summary>
        /// Gets or sets the parameters list
        /// </summary>
        public List<Parameter> Parameters
        {
            get => m_parameters ??= new List<Parameter>();
            set => m_parameters = value;
        }

        /// <summary>
        /// Gets or sets the result sets
        /// </summary>
        public List<ResultSet> ResultSets
        {
            get => m_resultSets ??= new List<ResultSet>();
            set => m_resultSets = value;
        }

        #endregion
    }
}
