
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_ciudad.
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
	public abstract class _rastreo_ciudad : PostgreSqlEntity
	{
		public _rastreo_ciudad()
		{
			this.QuerySource = "rastreo_ciudad";
			this.MappingName = "rastreo_ciudad";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_ciudad_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreo_ciudad, int Id_pais, int Id_distrito)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreo_ciudad, Idrastreo_ciudad);

parameters.Add(Parameters.Id_pais, Id_pais);

parameters.Add(Parameters.Id_distrito, Id_distrito);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_ciudad_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreo_ciudad
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_ciudad", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_pais
			{
				get
				{
					return new NpgsqlParameter("Id_pais", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_distrito
			{
				get
				{
					return new NpgsqlParameter("Id_distrito", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Ciudad
			{
				get
				{
					return new NpgsqlParameter("Ciudad", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter User_ins
			{
				get
				{
					return new NpgsqlParameter("User_ins", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Fech_ins
			{
				get
				{
					return new NpgsqlParameter("Fech_ins", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
			public static NpgsqlParameter User_upd
			{
				get
				{
					return new NpgsqlParameter("User_upd", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Fech_upd
			{
				get
				{
					return new NpgsqlParameter("Fech_upd", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Idrastreo_ciudad = "idrastreo_ciudad";
            public const string Id_pais = "id_pais";
            public const string Id_distrito = "id_distrito";
            public const string Ciudad = "ciudad";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_ciudad] = _rastreo_ciudad.PropertyNames.Idrastreo_ciudad;
					ht[Id_pais] = _rastreo_ciudad.PropertyNames.Id_pais;
					ht[Id_distrito] = _rastreo_ciudad.PropertyNames.Id_distrito;
					ht[Ciudad] = _rastreo_ciudad.PropertyNames.Ciudad;
					ht[User_ins] = _rastreo_ciudad.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_ciudad.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_ciudad.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_ciudad.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreo_ciudad = "Idrastreo_ciudad";
            public const string Id_pais = "Id_pais";
            public const string Id_distrito = "Id_distrito";
            public const string Ciudad = "Ciudad";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_ciudad] = _rastreo_ciudad.ColumnNames.Idrastreo_ciudad;
					ht[Id_pais] = _rastreo_ciudad.ColumnNames.Id_pais;
					ht[Id_distrito] = _rastreo_ciudad.ColumnNames.Id_distrito;
					ht[Ciudad] = _rastreo_ciudad.ColumnNames.Ciudad;
					ht[User_ins] = _rastreo_ciudad.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_ciudad.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_ciudad.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_ciudad.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreo_ciudad = "s_Idrastreo_ciudad";
            public const string Id_pais = "s_Id_pais";
            public const string Id_distrito = "s_Id_distrito";
            public const string Ciudad = "s_Ciudad";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreo_ciudad
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_ciudad);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_ciudad, value);
			}
		}

		public virtual int Id_pais
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_pais);
			}
			set
	        {
				base.Setint(ColumnNames.Id_pais, value);
			}
		}

		public virtual int Id_distrito
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_distrito);
			}
			set
	        {
				base.Setint(ColumnNames.Id_distrito, value);
			}
		}

		public virtual string Ciudad
	    {
			get
	        {
				return base.Getstring(ColumnNames.Ciudad);
			}
			set
	        {
				base.Setstring(ColumnNames.Ciudad, value);
			}
		}

		public virtual int User_ins
	    {
			get
	        {
				return base.Getint(ColumnNames.User_ins);
			}
			set
	        {
				base.Setint(ColumnNames.User_ins, value);
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

		public virtual int User_upd
	    {
			get
	        {
				return base.Getint(ColumnNames.User_upd);
			}
			set
	        {
				base.Setint(ColumnNames.User_upd, value);
			}
		}

		public virtual DateTime Fech_upd
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Fech_upd);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Fech_upd, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Idrastreo_ciudad
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_ciudad) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_ciudad);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_ciudad);
				else
					this.Idrastreo_ciudad = base.SetintAsString(ColumnNames.Idrastreo_ciudad, value);
			}
		}

		public virtual string s_Id_pais
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_pais) ? string.Empty : base.GetintAsString(ColumnNames.Id_pais);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_pais);
				else
					this.Id_pais = base.SetintAsString(ColumnNames.Id_pais, value);
			}
		}

		public virtual string s_Id_distrito
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_distrito) ? string.Empty : base.GetintAsString(ColumnNames.Id_distrito);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_distrito);
				else
					this.Id_distrito = base.SetintAsString(ColumnNames.Id_distrito, value);
			}
		}

		public virtual string s_Ciudad
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Ciudad) ? string.Empty : base.GetstringAsString(ColumnNames.Ciudad);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Ciudad);
				else
					this.Ciudad = base.SetstringAsString(ColumnNames.Ciudad, value);
			}
		}

		public virtual string s_User_ins
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.User_ins) ? string.Empty : base.GetintAsString(ColumnNames.User_ins);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.User_ins);
				else
					this.User_ins = base.SetintAsString(ColumnNames.User_ins, value);
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

		public virtual string s_User_upd
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.User_upd) ? string.Empty : base.GetintAsString(ColumnNames.User_upd);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.User_upd);
				else
					this.User_upd = base.SetintAsString(ColumnNames.User_upd, value);
			}
		}

		public virtual string s_Fech_upd
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Fech_upd) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Fech_upd);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Fech_upd);
				else
					this.Fech_upd = base.SetDateTimeAsString(ColumnNames.Fech_upd, value);
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
				
				
				public WhereParameter Idrastreo_ciudad
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_ciudad, Parameters.Idrastreo_ciudad);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_pais
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_pais, Parameters.Id_pais);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_distrito
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_distrito, Parameters.Id_distrito);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Ciudad
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Ciudad, Parameters.Ciudad);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter User_ins
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.User_ins, Parameters.User_ins);
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

				public WhereParameter User_upd
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.User_upd, Parameters.User_upd);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Fech_upd
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Fech_upd, Parameters.Fech_upd);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Idrastreo_ciudad
		    {
				get
		        {
					if(_Idrastreo_ciudad_W == null)
	        	    {
						_Idrastreo_ciudad_W = TearOff.Idrastreo_ciudad;
					}
					return _Idrastreo_ciudad_W;
				}
			}

			public WhereParameter Id_pais
		    {
				get
		        {
					if(_Id_pais_W == null)
	        	    {
						_Id_pais_W = TearOff.Id_pais;
					}
					return _Id_pais_W;
				}
			}

			public WhereParameter Id_distrito
		    {
				get
		        {
					if(_Id_distrito_W == null)
	        	    {
						_Id_distrito_W = TearOff.Id_distrito;
					}
					return _Id_distrito_W;
				}
			}

			public WhereParameter Ciudad
		    {
				get
		        {
					if(_Ciudad_W == null)
	        	    {
						_Ciudad_W = TearOff.Ciudad;
					}
					return _Ciudad_W;
				}
			}

			public WhereParameter User_ins
		    {
				get
		        {
					if(_User_ins_W == null)
	        	    {
						_User_ins_W = TearOff.User_ins;
					}
					return _User_ins_W;
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

			public WhereParameter User_upd
		    {
				get
		        {
					if(_User_upd_W == null)
	        	    {
						_User_upd_W = TearOff.User_upd;
					}
					return _User_upd_W;
				}
			}

			public WhereParameter Fech_upd
		    {
				get
		        {
					if(_Fech_upd_W == null)
	        	    {
						_Fech_upd_W = TearOff.Fech_upd;
					}
					return _Fech_upd_W;
				}
			}

			private WhereParameter _Idrastreo_ciudad_W = null;
			private WhereParameter _Id_pais_W = null;
			private WhereParameter _Id_distrito_W = null;
			private WhereParameter _Ciudad_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idrastreo_ciudad_W = null;
				_Id_pais_W = null;
				_Id_distrito_W = null;
				_Ciudad_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;

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
				
				
				public AggregateParameter Idrastreo_ciudad
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_ciudad, Parameters.Idrastreo_ciudad);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_pais
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_pais, Parameters.Id_pais);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_distrito
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_distrito, Parameters.Id_distrito);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Ciudad
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Ciudad, Parameters.Ciudad);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter User_ins
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.User_ins, Parameters.User_ins);
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

				public AggregateParameter User_upd
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.User_upd, Parameters.User_upd);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Fech_upd
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fech_upd, Parameters.Fech_upd);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Idrastreo_ciudad
		    {
				get
		        {
					if(_Idrastreo_ciudad_W == null)
	        	    {
						_Idrastreo_ciudad_W = TearOff.Idrastreo_ciudad;
					}
					return _Idrastreo_ciudad_W;
				}
			}

			public AggregateParameter Id_pais
		    {
				get
		        {
					if(_Id_pais_W == null)
	        	    {
						_Id_pais_W = TearOff.Id_pais;
					}
					return _Id_pais_W;
				}
			}

			public AggregateParameter Id_distrito
		    {
				get
		        {
					if(_Id_distrito_W == null)
	        	    {
						_Id_distrito_W = TearOff.Id_distrito;
					}
					return _Id_distrito_W;
				}
			}

			public AggregateParameter Ciudad
		    {
				get
		        {
					if(_Ciudad_W == null)
	        	    {
						_Ciudad_W = TearOff.Ciudad;
					}
					return _Ciudad_W;
				}
			}

			public AggregateParameter User_ins
		    {
				get
		        {
					if(_User_ins_W == null)
	        	    {
						_User_ins_W = TearOff.User_ins;
					}
					return _User_ins_W;
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

			public AggregateParameter User_upd
		    {
				get
		        {
					if(_User_upd_W == null)
	        	    {
						_User_upd_W = TearOff.User_upd;
					}
					return _User_upd_W;
				}
			}

			public AggregateParameter Fech_upd
		    {
				get
		        {
					if(_Fech_upd_W == null)
	        	    {
						_Fech_upd_W = TearOff.Fech_upd;
					}
					return _Fech_upd_W;
				}
			}

			private AggregateParameter _Idrastreo_ciudad_W = null;
			private AggregateParameter _Id_pais_W = null;
			private AggregateParameter _Id_distrito_W = null;
			private AggregateParameter _Ciudad_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreo_ciudad_W = null;
				_Id_pais_W = null;
				_Id_distrito_W = null;
				_Ciudad_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_ciudad_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreo_ciudad.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_ciudad_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_ciudad_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreo_ciudad);
			p.SourceColumn = ColumnNames.Idrastreo_ciudad;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_pais);
			p.SourceColumn = ColumnNames.Id_pais;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_distrito);
			p.SourceColumn = ColumnNames.Id_distrito;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreo_ciudad);
			p.SourceColumn = ColumnNames.Idrastreo_ciudad;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_pais);
			p.SourceColumn = ColumnNames.Id_pais;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_distrito);
			p.SourceColumn = ColumnNames.Id_distrito;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Ciudad);
			p.SourceColumn = ColumnNames.Ciudad;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.User_ins);
			p.SourceColumn = ColumnNames.User_ins;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Fech_ins);
			p.SourceColumn = ColumnNames.Fech_ins;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.User_upd);
			p.SourceColumn = ColumnNames.User_upd;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Fech_upd);
			p.SourceColumn = ColumnNames.Fech_upd;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
