
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_tipo_vehiculo.
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
	public abstract class _rastreo_tipo_vehiculo : PostgreSqlEntity
	{
		public _rastreo_tipo_vehiculo()
		{
			this.QuerySource = "rastreo_tipo_vehiculo";
			this.MappingName = "rastreo_tipo_vehiculo";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_tipo_vehiculo_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreo_tipo_vehiculo)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreo_tipo_vehiculo, Idrastreo_tipo_vehiculo);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_tipo_vehiculo_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreo_tipo_vehiculo
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_tipo_vehiculo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Tipo_de_vehiculo
			{
				get
				{
					return new NpgsqlParameter("Tipo_de_vehiculo", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Icono
			{
				get
				{
					return new NpgsqlParameter("Icono", NpgsqlTypes.NpgsqlDbType.Text, 0);
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
            public const string Idrastreo_tipo_vehiculo = "idrastreo_tipo_vehiculo";
            public const string Tipo_de_vehiculo = "tipo_de_vehiculo";
            public const string Icono = "icono";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_tipo_vehiculo] = _rastreo_tipo_vehiculo.PropertyNames.Idrastreo_tipo_vehiculo;
					ht[Tipo_de_vehiculo] = _rastreo_tipo_vehiculo.PropertyNames.Tipo_de_vehiculo;
					ht[Icono] = _rastreo_tipo_vehiculo.PropertyNames.Icono;
					ht[User_ins] = _rastreo_tipo_vehiculo.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_tipo_vehiculo.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_tipo_vehiculo.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_tipo_vehiculo.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreo_tipo_vehiculo = "Idrastreo_tipo_vehiculo";
            public const string Tipo_de_vehiculo = "Tipo_de_vehiculo";
            public const string Icono = "Icono";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_tipo_vehiculo] = _rastreo_tipo_vehiculo.ColumnNames.Idrastreo_tipo_vehiculo;
					ht[Tipo_de_vehiculo] = _rastreo_tipo_vehiculo.ColumnNames.Tipo_de_vehiculo;
					ht[Icono] = _rastreo_tipo_vehiculo.ColumnNames.Icono;
					ht[User_ins] = _rastreo_tipo_vehiculo.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_tipo_vehiculo.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_tipo_vehiculo.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_tipo_vehiculo.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreo_tipo_vehiculo = "s_Idrastreo_tipo_vehiculo";
            public const string Tipo_de_vehiculo = "s_Tipo_de_vehiculo";
            public const string Icono = "s_Icono";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreo_tipo_vehiculo
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_tipo_vehiculo);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_tipo_vehiculo, value);
			}
		}

		public virtual string Tipo_de_vehiculo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tipo_de_vehiculo);
			}
			set
	        {
				base.Setstring(ColumnNames.Tipo_de_vehiculo, value);
			}
		}

		public virtual string Icono
	    {
			get
	        {
				return base.Getstring(ColumnNames.Icono);
			}
			set
	        {
				base.Setstring(ColumnNames.Icono, value);
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
	
		public virtual string s_Idrastreo_tipo_vehiculo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_tipo_vehiculo) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_tipo_vehiculo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_tipo_vehiculo);
				else
					this.Idrastreo_tipo_vehiculo = base.SetintAsString(ColumnNames.Idrastreo_tipo_vehiculo, value);
			}
		}

		public virtual string s_Tipo_de_vehiculo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipo_de_vehiculo) ? string.Empty : base.GetstringAsString(ColumnNames.Tipo_de_vehiculo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipo_de_vehiculo);
				else
					this.Tipo_de_vehiculo = base.SetstringAsString(ColumnNames.Tipo_de_vehiculo, value);
			}
		}

		public virtual string s_Icono
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Icono) ? string.Empty : base.GetstringAsString(ColumnNames.Icono);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Icono);
				else
					this.Icono = base.SetstringAsString(ColumnNames.Icono, value);
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
				
				
				public WhereParameter Idrastreo_tipo_vehiculo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_tipo_vehiculo, Parameters.Idrastreo_tipo_vehiculo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Tipo_de_vehiculo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipo_de_vehiculo, Parameters.Tipo_de_vehiculo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Icono
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Icono, Parameters.Icono);
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
		
			public WhereParameter Idrastreo_tipo_vehiculo
		    {
				get
		        {
					if(_Idrastreo_tipo_vehiculo_W == null)
	        	    {
						_Idrastreo_tipo_vehiculo_W = TearOff.Idrastreo_tipo_vehiculo;
					}
					return _Idrastreo_tipo_vehiculo_W;
				}
			}

			public WhereParameter Tipo_de_vehiculo
		    {
				get
		        {
					if(_Tipo_de_vehiculo_W == null)
	        	    {
						_Tipo_de_vehiculo_W = TearOff.Tipo_de_vehiculo;
					}
					return _Tipo_de_vehiculo_W;
				}
			}

			public WhereParameter Icono
		    {
				get
		        {
					if(_Icono_W == null)
	        	    {
						_Icono_W = TearOff.Icono;
					}
					return _Icono_W;
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

			private WhereParameter _Idrastreo_tipo_vehiculo_W = null;
			private WhereParameter _Tipo_de_vehiculo_W = null;
			private WhereParameter _Icono_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idrastreo_tipo_vehiculo_W = null;
				_Tipo_de_vehiculo_W = null;
				_Icono_W = null;
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
				
				
				public AggregateParameter Idrastreo_tipo_vehiculo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_tipo_vehiculo, Parameters.Idrastreo_tipo_vehiculo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Tipo_de_vehiculo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_de_vehiculo, Parameters.Tipo_de_vehiculo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Icono
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Icono, Parameters.Icono);
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
		
			public AggregateParameter Idrastreo_tipo_vehiculo
		    {
				get
		        {
					if(_Idrastreo_tipo_vehiculo_W == null)
	        	    {
						_Idrastreo_tipo_vehiculo_W = TearOff.Idrastreo_tipo_vehiculo;
					}
					return _Idrastreo_tipo_vehiculo_W;
				}
			}

			public AggregateParameter Tipo_de_vehiculo
		    {
				get
		        {
					if(_Tipo_de_vehiculo_W == null)
	        	    {
						_Tipo_de_vehiculo_W = TearOff.Tipo_de_vehiculo;
					}
					return _Tipo_de_vehiculo_W;
				}
			}

			public AggregateParameter Icono
		    {
				get
		        {
					if(_Icono_W == null)
	        	    {
						_Icono_W = TearOff.Icono;
					}
					return _Icono_W;
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

			private AggregateParameter _Idrastreo_tipo_vehiculo_W = null;
			private AggregateParameter _Tipo_de_vehiculo_W = null;
			private AggregateParameter _Icono_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreo_tipo_vehiculo_W = null;
				_Tipo_de_vehiculo_W = null;
				_Icono_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_tipo_vehiculo_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreo_tipo_vehiculo.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_tipo_vehiculo_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_tipo_vehiculo_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreo_tipo_vehiculo);
			p.SourceColumn = ColumnNames.Idrastreo_tipo_vehiculo;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreo_tipo_vehiculo);
			p.SourceColumn = ColumnNames.Idrastreo_tipo_vehiculo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Tipo_de_vehiculo);
			p.SourceColumn = ColumnNames.Tipo_de_vehiculo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Icono);
			p.SourceColumn = ColumnNames.Icono;
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
