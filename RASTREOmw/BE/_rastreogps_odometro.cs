
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreogps_odometro.
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
	public abstract class _rastreogps_odometro : PostgreSqlEntity
	{
		public _rastreogps_odometro()
		{
			this.QuerySource = "rastreogps_odometro";
			this.MappingName = "rastreogps_odometro";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_odometro_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreogps_odometro, int Id_equipogps)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreogps_odometro, Idrastreogps_odometro);

parameters.Add(Parameters.Id_equipogps, Id_equipogps);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_odometro_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreogps_odometro
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_odometro", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_equipogps
			{
				get
				{
					return new NpgsqlParameter("Id_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Odometro
			{
				get
				{
					return new NpgsqlParameter("Odometro", NpgsqlTypes.NpgsqlDbType.Integer, 0);
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
            public const string Idrastreogps_odometro = "idrastreogps_odometro";
            public const string Id_equipogps = "id_equipogps";
            public const string Odometro = "odometro";
            public const string Fech_ins = "fech_ins";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_odometro] = _rastreogps_odometro.PropertyNames.Idrastreogps_odometro;
					ht[Id_equipogps] = _rastreogps_odometro.PropertyNames.Id_equipogps;
					ht[Odometro] = _rastreogps_odometro.PropertyNames.Odometro;
					ht[Fech_ins] = _rastreogps_odometro.PropertyNames.Fech_ins;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreogps_odometro = "Idrastreogps_odometro";
            public const string Id_equipogps = "Id_equipogps";
            public const string Odometro = "Odometro";
            public const string Fech_ins = "Fech_ins";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_odometro] = _rastreogps_odometro.ColumnNames.Idrastreogps_odometro;
					ht[Id_equipogps] = _rastreogps_odometro.ColumnNames.Id_equipogps;
					ht[Odometro] = _rastreogps_odometro.ColumnNames.Odometro;
					ht[Fech_ins] = _rastreogps_odometro.ColumnNames.Fech_ins;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreogps_odometro = "s_Idrastreogps_odometro";
            public const string Id_equipogps = "s_Id_equipogps";
            public const string Odometro = "s_Odometro";
            public const string Fech_ins = "s_Fech_ins";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreogps_odometro
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_odometro);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_odometro, value);
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

		public virtual int Odometro
	    {
			get
	        {
				return base.Getint(ColumnNames.Odometro);
			}
			set
	        {
				base.Setint(ColumnNames.Odometro, value);
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
	
		public virtual string s_Idrastreogps_odometro
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_odometro) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_odometro);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_odometro);
				else
					this.Idrastreogps_odometro = base.SetintAsString(ColumnNames.Idrastreogps_odometro, value);
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

		public virtual string s_Odometro
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Odometro) ? string.Empty : base.GetintAsString(ColumnNames.Odometro);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Odometro);
				else
					this.Odometro = base.SetintAsString(ColumnNames.Odometro, value);
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
				
				
				public WhereParameter Idrastreogps_odometro
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_odometro, Parameters.Idrastreogps_odometro);
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

				public WhereParameter Odometro
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Odometro, Parameters.Odometro);
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
		
			public WhereParameter Idrastreogps_odometro
		    {
				get
		        {
					if(_Idrastreogps_odometro_W == null)
	        	    {
						_Idrastreogps_odometro_W = TearOff.Idrastreogps_odometro;
					}
					return _Idrastreogps_odometro_W;
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

			public WhereParameter Odometro
		    {
				get
		        {
					if(_Odometro_W == null)
	        	    {
						_Odometro_W = TearOff.Odometro;
					}
					return _Odometro_W;
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

			private WhereParameter _Idrastreogps_odometro_W = null;
			private WhereParameter _Id_equipogps_W = null;
			private WhereParameter _Odometro_W = null;
			private WhereParameter _Fech_ins_W = null;

			public void WhereClauseReset()
			{
				_Idrastreogps_odometro_W = null;
				_Id_equipogps_W = null;
				_Odometro_W = null;
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
				
				
				public AggregateParameter Idrastreogps_odometro
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_odometro, Parameters.Idrastreogps_odometro);
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

				public AggregateParameter Odometro
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Odometro, Parameters.Odometro);
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
		
			public AggregateParameter Idrastreogps_odometro
		    {
				get
		        {
					if(_Idrastreogps_odometro_W == null)
	        	    {
						_Idrastreogps_odometro_W = TearOff.Idrastreogps_odometro;
					}
					return _Idrastreogps_odometro_W;
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

			public AggregateParameter Odometro
		    {
				get
		        {
					if(_Odometro_W == null)
	        	    {
						_Odometro_W = TearOff.Odometro;
					}
					return _Odometro_W;
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

			private AggregateParameter _Idrastreogps_odometro_W = null;
			private AggregateParameter _Id_equipogps_W = null;
			private AggregateParameter _Odometro_W = null;
			private AggregateParameter _Fech_ins_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreogps_odometro_W = null;
				_Id_equipogps_W = null;
				_Odometro_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_odometro_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreogps_odometro.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_odometro_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_odometro_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreogps_odometro);
			p.SourceColumn = ColumnNames.Idrastreogps_odometro;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_equipogps);
			p.SourceColumn = ColumnNames.Id_equipogps;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreogps_odometro);
			p.SourceColumn = ColumnNames.Idrastreogps_odometro;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_equipogps);
			p.SourceColumn = ColumnNames.Id_equipogps;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Odometro);
			p.SourceColumn = ColumnNames.Odometro;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Fech_ins);
			p.SourceColumn = ColumnNames.Fech_ins;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
