// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.2.2
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace King.Mapper.Generated.Sql
{
    using System;
    using System.Data;
    using King.Mapper.Data;

    /// <summary>
    /// Class that Represents dbo.SelectMultipleStatement Stored Procedure
    /// </summary>
	public partial class dboSelectMultipleStatement : IStoredProcedure
	{
        /// <summary>
        /// Gets Stored Proc name with Schema
        /// </summary>
		public string FullyQualifiedName()
		{
			return "[dbo].[SelectMultipleStatement]";
		}

	}

    /// <summary>
    /// Class that Represents dbo.SimulatedInsertStatement Stored Procedure
    /// </summary>
	public partial class dboSimulatedInsertStatement : IStoredProcedure
	{
        /// <summary>
        /// Gets Stored Proc name with Schema
        /// </summary>
		public string FullyQualifiedName()
		{
			return "[dbo].[SimulatedInsertStatement]";
		}

		#region Parameters
        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestInt", DbType.Int32)]
		public int? TestInt
		{
			get;
			set;
		}

		#endregion
	}

    /// <summary>
    /// Class that Represents dbo.SimulatedSelectStatement Stored Procedure
    /// </summary>
	public partial class dboSimulatedSelectStatement : IStoredProcedure
	{
        /// <summary>
        /// Gets Stored Proc name with Schema
        /// </summary>
		public string FullyQualifiedName()
		{
			return "[dbo].[SimulatedSelectStatement]";
		}

		#region Parameters
        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestInt", DbType.Int32)]
		public int? TestInt
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestBigInt", DbType.Int64)]
		public long? TestBigInt
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestBit", DbType.Boolean)]
		public bool? TestBit
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestDecimal", DbType.Decimal)]
		public decimal? TestDecimal
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestMoney", DbType.Currency)]
		public decimal? TestMoney
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestFloat", DbType.Single)]
		public float? TestFloat
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestDate", DbType.Date)]
		public DateTime? TestDate
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestDateTime2", DbType.DateTime2)]
		public DateTime? TestDateTime2
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestDateTime", DbType.DateTime)]
		public DateTime? TestDateTime
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestChar", DbType.Int16)]
		public char TestChar
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestText", DbType.String)]
		public string TestText
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestNChar", DbType.String)]
		public char TestNChar
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestNText", DbType.String)]
		public string TestNText
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestBinary", DbType.Binary)]
		public byte[] TestBinary
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestImage", DbType.Binary)]
		public byte[] TestImage
		{
			get;
			set;
		}

        /// <summary>
        /// Gets or sets the parameter value
        /// </summary>
		[DataMapper("@TestGuid", DbType.Guid)]
		public Guid? TestGuid
		{
			get;
			set;
		}

		#endregion
	}

}