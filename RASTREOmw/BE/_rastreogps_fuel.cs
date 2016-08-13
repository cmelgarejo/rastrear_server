
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreogps_fuel.
'  Base soportada:PostgreSqlEntity.
'  Versión: # (1.3.0.9).
'
'  Este objeto es abstracto, por ello, necesita ser heredado para poder instanciarlo.
'  Las propiedades y métodos pueden ser sobreescritas en la clase derivada.
'  (Clase Concreta)
'
'  NUNCA EDITE ESTE ARCHIVO.
'===============================================================================
*/

using System;
using System.Data;
using Npgsql;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace RASTREOmw
{
	public abstract class _rastreogps_fuel : PostgreSqlEntity
	{
		public _rastreogps_fuel()
		{
			this.QuerySource = "rastreogps_fuel";
			this.MappingName = "rastreogps_fuel";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_fuel_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreogps_fuel, int Id_equipogps)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreogps_fuel, Idrastreogps_fuel);

parameters.Add(Parameters.Id_equipogps, Id_equipogps);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_fuel_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreogps_fuel
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_fuel", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_equipogps
			{
				get
				{
					return new NpgsqlParameter("Id_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Fuel
			{
				get
				{
					return new NpgsqlParameter("Fuel", NpgsqlTypes.NpgsqlDbType.Varchar, 64);
				}
			}
			
			public static NpgsqlParameter Consumo
			{
				get
				{
					return new NpgsqlParameter("Consumo", NpgsqlTypes.NpgsqlDbType.Varchar, 64);
				}
			}
			
			public static NpgsqlParameter Estado
			{
				get
				{
					return new NpgsqlParameter("Estado", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Fech_ins
			{
				get
				{
					return new NpgsqlParameter("Fech_ins", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Idrastreogps_fuel = "idrastreogps_fuel";
            public const string Id_equipogps = "id_equipogps";
            public const string Fuel = "fuel";
            public const string Consumo = "consumo";
            public const string Estado = "estado";
            public const string Fech_ins = "fech_ins";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_fuel] = _rastreogps_fuel.PropertyNames.Idrastreogps_fuel;
					ht[Id_equipogps] = _rastreogps_fuel.PropertyNames.Id_equipogps;
					ht[Fuel] = _rastreogps_fuel.PropertyNames.Fuel;
					ht[Consumo] = _rastreogps_fuel.PropertyNames.Consumo;
					ht[Estado] = _rastreogps_fuel.PropertyNames.Estado;
					ht[Fech_ins] = _rastreogps_fuel.PropertyNames.Fech_ins;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreogps_fuel = "Idrastreogps_fuel";
            public const string Id_equipogps = "Id_equipogps";
            public const string Fuel = "Fuel";
            public const string Consumo = "Consumo";
            public const string Estado = "Estado";
            public const string Fech_ins = "Fech_ins";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_fuel] = _rastreogps_fuel.ColumnNames.Idrastreogps_fuel;
					ht[Id_equipogps] = _rastreogps_fuel.ColumnNames.Id_equipogps;
					ht[Fuel] = _rastreogps_fuel.ColumnNames.Fuel;
					ht[Consumo] = _rastreogps_fuel.ColumnNames.Consumo;
					ht[Estado] = _rastreogps_fuel.ColumnNames.Estado;
					ht[Fech_ins] = _rastreogps_fuel.ColumnNames.Fech_ins;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreogps_fuel = "s_Idrastreogps_fuel";
            public const string Id_equipogps = "s_Id_equipogps";
            public const string Fuel = "s_Fuel";
            public const string Consumo = "s_Consumo";
            public const string Estado = "s_Estado";
            public const string Fech_ins = "s_Fech_ins";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreogps_fuel
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_fuel);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_fuel, value);
			}
		}

		public virtual int Id_equipogps
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_equipogps);
			}
			set
	        {
				base.Setint(ColumnNames.Id_equipogps, value);
			}
		}

		public virtual string Fuel
	    {
			get
	        {
				return base.Getstring(ColumnNames.Fuel);
			}
			set
	        {
				base.Setstring(ColumnNames.Fuel, value);
			}
		}

		public virtual string Consumo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Consumo);
			}
			set
	        {
				base.Setstring(ColumnNames.Consumo, value);
			}
		}

		public virtual bool Estado
	    {
			get
	        {
				return base.Getbool(ColumnNames.Estado);
			}
			set
	        {
				base.Setbool(ColumnNames.Estado, value);
			}
		}

		public virtual DateTime Fech_ins
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Fech_ins);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Fech_ins, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Idrastreogps_fuel
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_fuel) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_fuel);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_fuel);
				else
					this.Idrastreogps_fuel = base.SetintAsString(ColumnNames.Idrastreogps_fuel, value);
			}
		}

		public virtual string s_Id_equipogps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_equipogps) ? string.Empty : base.GetintAsString(ColumnNames.Id_equipogps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_equipogps);
				else
					this.Id_equipogps = base.SetintAsString(ColumnNames.Id_equipogps, value);
			}
		}

		public virtual string s_Fuel
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Fuel) ? string.Empty : base.GetstringAsString(ColumnNames.Fuel);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Fuel);
				else
					this.Fuel = base.SetstringAsString(ColumnNames.Fuel, value);
			}
		}

		public virtual string s_Consumo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Consumo) ? string.Empty : base.GetstringAsString(ColumnNames.Consumo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Consumo);
				else
					this.Consumo = base.SetstringAsString(ColumnNames.Consumo, value);
			}
		}

		public virtual string s_Estado
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Estado) ? string.Empty : base.GetboolAsString(ColumnNames.Estado);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Estado);
				else
					this.Estado = base.SetboolAsString(ColumnNames.Estado, value);
			}
		}

		public virtual string s_Fech_ins
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Fech_ins) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Fech_ins);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Fech_ins);
				else
					this.Fech_ins = base.SetDateTimeAsString(ColumnNames.Fech_ins, value);
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
				
				
				public WhereParameter Idrastreogps_fuel
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_fuel, Parameters.Idrastreogps_fuel);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_equipogps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_equipogps, Parameters.Id_equipogps);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Fuel
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Fuel, Parameters.Fuel);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Consumo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Consumo, Parameters.Consumo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Estado
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Estado, Parameters.Estado);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Fech_ins
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Fech_ins, Parameters.Fech_ins);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Idrastreogps_fuel
		    {
				get
		        {
					if(_Idrastreogps_fuel_W == null)
	        	    {
						_Idrastreogps_fuel_W = TearOff.Idrastreogps_fuel;
					}
					return _Idrastreogps_fuel_W;
				}
			}

			public WhereParameter Id_equipogps
		    {
				get
		        {
					if(_Id_equipogps_W == null)
	        	    {
						_Id_equipogps_W = TearOff.Id_equipogps;
					}
					return _Id_equipogps_W;
				}
			}

			public WhereParameter Fuel
		    {
				get
		        {
					if(_Fuel_W == null)
	        	    {
						_Fuel_W = TearOff.Fuel;
					}
					return _Fuel_W;
				}
			}

			public WhereParameter Consumo
		    {
				get
		        {
					if(_Consumo_W == null)
	        	    {
						_Consumo_W = TearOff.Consumo;
					}
					return _Consumo_W;
				}
			}

			public WhereParameter Estado
		    {
				get
		        {
					if(_Estado_W == null)
	        	    {
						_Estado_W = TearOff.Estado;
					}
					return _Estado_W;
				}
			}

			public WhereParameter Fech_ins
		    {
				get
		        {
					if(_Fech_ins_W == null)
	        	    {
						_Fech_ins_W = TearOff.Fech_ins;
					}
					return _Fech_ins_W;
				}
			}

			private WhereParameter _Idrastreogps_fuel_W = null;
			private WhereParameter _Id_equipogps_W = null;
			private WhereParameter _Fuel_W = null;
			private WhereParameter _Consumo_W = null;
			private WhereParameter _Estado_W = null;
			private WhereParameter _Fech_ins_W = null;

			public void WhereClauseReset()
			{
				_Idrastreogps_fuel_W = null;
				_Id_equipogps_W = null;
				_Fuel_W = null;
				_Consumo_W = null;
				_Estado_W = null;
				_Fech_ins_W = null;

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
				
				
				public AggregateParameter Idrastreogps_fuel
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_fuel, Parameters.Idrastreogps_fuel);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_equipogps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_equipogps, Parameters.Id_equipogps);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Fuel
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fuel, Parameters.Fuel);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Consumo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Consumo, Parameters.Consumo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Estado
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Estado, Parameters.Estado);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Fech_ins
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fech_ins, Parameters.Fech_ins);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Idrastreogps_fuel
		    {
				get
		        {
					if(_Idrastreogps_fuel_W == null)
	        	    {
						_Idrastreogps_fuel_W = TearOff.Idrastreogps_fuel;
					}
					return _Idrastreogps_fuel_W;
				}
			}

			public AggregateParameter Id_equipogps
		    {
				get
		        {
					if(_Id_equipogps_W == null)
	        	    {
						_Id_equipogps_W = TearOff.Id_equipogps;
					}
					return _Id_equipogps_W;
				}
			}

			public AggregateParameter Fuel
		    {
				get
		        {
					if(_Fuel_W == null)
	        	    {
						_Fuel_W = TearOff.Fuel;
					}
					return _Fuel_W;
				}
			}

			public AggregateParameter Consumo
		    {
				get
		        {
					if(_Consumo_W == null)
	        	    {
						_Consumo_W = TearOff.Consumo;
					}
					return _Consumo_W;
				}
			}

			public AggregateParameter Estado
		    {
				get
		        {
					if(_Estado_W == null)
	        	    {
						_Estado_W = TearOff.Estado;
					}
					return _Estado_W;
				}
			}

			public AggregateParameter Fech_ins
		    {
				get
		        {
					if(_Fech_ins_W == null)
	        	    {
						_Fech_ins_W = TearOff.Fech_ins;
					}
					return _Fech_ins_W;
				}
			}

			private AggregateParameter _Idrastreogps_fuel_W = null;
			private AggregateParameter _Id_equipogps_W = null;
			private AggregateParameter _Fuel_W = null;
			private AggregateParameter _Consumo_W = null;
			private AggregateParameter _Estado_W = null;
			private AggregateParameter _Fech_ins_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreogps_fuel_W = null;
				_Id_equipogps_W = null;
				_Fuel_W = null;
				_Consumo_W = null;
				_Estado_W = null;
				_Fech_ins_W = null;

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
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_fuel_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreogps_fuel.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_fuel_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_fuel_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreogps_fuel);
			p.SourceColumn = ColumnNames.Idrastreogps_fuel;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_equipogps);
			p.SourceColumn = ColumnNames.Id_equipogps;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreogps_fuel);
			p.SourceColumn = ColumnNames.Idrastreogps_fuel;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_equipogps);
			p.SourceColumn = ColumnNames.Id_equipogps;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Fuel);
			p.SourceColumn = ColumnNames.Fuel;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Consumo);
			p.SourceColumn = ColumnNames.Consumo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Estado);
			p.SourceColumn = ColumnNames.Estado;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Fech_ins);
			p.SourceColumn = ColumnNames.Fech_ins;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
