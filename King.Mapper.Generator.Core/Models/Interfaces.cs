﻿namespace King.Mapper.Generator.Models
{
    using System.Collections.Generic;

    public interface IVariable
    {
        #region Properties
        /// <summary>
        /// Data Type
        /// </summary>
        string DataType
        {
            get;
        }

        /// <summary>
        /// Parameter Name
        /// </summary>
        string ParameterName
        {
            get;
        }

        /// <summary>
        /// Maximum Length
        /// </summary>
        int MaxLength
        {
            get;
        }
        #endregion
    }

    public interface ISchema
    {
        #region Properties
        /// <summary>
        /// Parameter
        /// </summary>
        string Parameter
        {
            get;
        }

        /// <summary>
        /// Data Type
        /// </summary>
        string DataType
        {
            get;
        }

        /// <summary>
        /// Preface
        /// </summary>
        string Preface
        {
            get;
        }

        /// <summary>
        /// Name
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// Maximum Length
        /// </summary>
        string MaxLength
        {
            get;
        }
        #endregion
    }

    public interface IDefinition
    {
        #region Properties
        /// <summary>
        /// Preface
        /// </summary>
        string Preface
        {
            get;
        }

        /// <summary>
        /// Name
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// Variables
        /// </summary>
        IEnumerable<IVariable> Variables
        {
            get;
            set;
        }
        #endregion
    }
}