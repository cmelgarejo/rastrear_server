/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rs_select_equipogps para la vista rs_select_equipogps.
'  Base soportada: PostgreSqlEntity.
'  Versión: # (1.3.0.9)
'==============================================================================================================
*/

using System;
using System.Data;
using Npgsql;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace RASTREOmw
{
	public class rs_select_equipogps : PostgreSqlEntity
	{
		public rs_select_equipogps(String laCadenaDeConexion)
		{
			this.QuerySource = "rs_select_equipogps";
			this.MappingName = "rs_select_equipogps";
			this.ConnectionString = laCadenaDeConexion;
		}	
	
		//=================================================================
		//  	public procedure LoadAll() As Boolean
		//=================================================================
		//  Carga todos los registros en la base de datos, y coloca la propiedad currentRow en la primera fila
		//=================================================================
		public bool LoadAll() 
		{
			return base.Query.Load();
		}
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
	
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreogps_equipogps
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Ddlequipogps_desc
			{
				get
				{
					return new NpgsqlParameter("Ddlequipogps_desc", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Idrastreogps_equipogps = "idrastreogps_equipogps";
            public const string Ddlequipogps_desc = "ddlequipogps_desc";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_equipogps] = rs_select_equipogps.PropertyNames.Idrastreogps_equipogps;
					ht[Ddlequipogps_desc] = rs_select_equipogps.PropertyNames.Ddlequipogps_desc;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreogps_equipogps = "Idrastreogps_equipogps";
            public const string Ddlequipogps_desc = "Ddlequipogps_desc";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_equipogps] = rs_select_equipogps.ColumnNames.Idrastreogps_equipogps;
					ht[Ddlequipogps_desc] = rs_select_equipogps.ColumnNames.Ddlequipogps_desc;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreogps_equipogps = "s_Idrastreogps_equipogps";
            public const string Ddlequipogps_desc = "s_Ddlequipogps_desc";

		}
		#endregion	
		
		#region Properties
			public virtual int Idrastreogps_equipogps
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_equipogps);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_equipogps, value);
			}
		}

		public virtual string Ddlequipogps_desc
	    {
			get
	        {
				return base.Getstring(ColumnNames.Ddlequipogps_desc);
			}
			set
	        {
				base.Setstring(ColumnNames.Ddlequipogps_desc, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Idrastreogps_equipogps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_equipogps) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_equipogps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_equipogps);
				else
					this.Idrastreogps_equipogps = base.SetintAsString(ColumnNames.Idrastreogps_equipogps, value);
			}
		}

		public virtual string s_Ddlequipogps_desc
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Ddlequipogps_desc) ? string.Empty : base.GetstringAsString(ColumnNames.Ddlequipogps_desc);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Ddlequipogps_desc);
				else
					this.Ddlequipogps_desc = base.SetstringAsString(ColumnNames.Ddlequipogps_desc, value);
			}
		}


		#endregion			
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter Idrastreogps_equipogps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_equipogps, Parameters.Idrastreogps_equipogps);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Ddlequipogps_desc
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Ddlequipogps_desc, Parameters.Ddlequipogps_desc);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Idrastreogps_equipogps
		    {
				get
		        {
					if(_Idrastreogps_equipogps_W == null)
	        	    {
						_Idrastreogps_equipogps_W = TearOff.Idrastreogps_equipogps;
					}
					return _Idrastreogps_equipogps_W;
				}
			}

			public WhereParameter Ddlequipogps_desc
		    {
				get
		        {
					if(_Ddlequipogps_desc_W == null)
	        	    {
						_Ddlequipogps_desc_W = TearOff.Ddlequipogps_desc;
					}
					return _Ddlequipogps_desc_W;
				}
			}

			private WhereParameter _Idrastreogps_equipogps_W = null;
			private WhereParameter _Ddlequipogps_desc_W = null;

			public void WhereClauseReset()
			{
				_Idrastreogps_equipogps_W = null;
				_Ddlequipogps_desc_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter Idrastreogps_equipogps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_equipogps, Parameters.Idrastreogps_equipogps);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Ddlequipogps_desc
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Ddlequipogps_desc, Parameters.Ddlequipogps_desc);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Idrastreogps_equipogps
		    {
				get
		        {
					if(_Idrastreogps_equipogps_W == null)
	        	    {
						_Idrastreogps_equipogps_W = TearOff.Idrastreogps_equipogps;
					}
					return _Idrastreogps_equipogps_W;
				}
			}

			public AggregateParameter Ddlequipogps_desc
		    {
				get
		        {
					if(_Ddlequipogps_desc_W == null)
	        	    {
						_Ddlequipogps_desc_W = TearOff.Ddlequipogps_desc;
					}
					return _Ddlequipogps_desc_W;
				}
			}

			private AggregateParameter _Idrastreogps_equipogps_W = null;
			private AggregateParameter _Ddlequipogps_desc_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreogps_equipogps_W = null;
				_Ddlequipogps_desc_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
			return null;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
			return null;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
			return null;
		}
	}
}
