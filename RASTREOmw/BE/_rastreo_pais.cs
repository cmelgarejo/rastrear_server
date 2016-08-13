
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_pais.
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
	public abstract class _rastreo_pais : PostgreSqlEntity
	{
		public _rastreo_pais()
		{
			this.QuerySource = "rastreo_pais";
			this.MappingName = "rastreo_pais";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_pais_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreo_pais)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreo_pais, Idrastreo_pais);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_pais_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreo_pais
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_pais", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Pais
			{
				get
				{
					return new NpgsqlParameter("Pais", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
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
            public const string Idrastreo_pais = "idrastreo_pais";
            public const string Pais = "pais";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_pais] = _rastreo_pais.PropertyNames.Idrastreo_pais;
					ht[Pais] = _rastreo_pais.PropertyNames.Pais;
					ht[User_ins] = _rastreo_pais.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_pais.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_pais.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_pais.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreo_pais = "Idrastreo_pais";
            public const string Pais = "Pais";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_pais] = _rastreo_pais.ColumnNames.Idrastreo_pais;
					ht[Pais] = _rastreo_pais.ColumnNames.Pais;
					ht[User_ins] = _rastreo_pais.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_pais.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_pais.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_pais.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreo_pais = "s_Idrastreo_pais";
            public const string Pais = "s_Pais";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreo_pais
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_pais);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_pais, value);
			}
		}

		public virtual string Pais
	    {
			get
	        {
				return base.Getstring(ColumnNames.Pais);
			}
			set
	        {
				base.Setstring(ColumnNames.Pais, value);
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
	
		public virtual string s_Idrastreo_pais
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_pais) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_pais);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_pais);
				else
					this.Idrastreo_pais = base.SetintAsString(ColumnNames.Idrastreo_pais, value);
			}
		}

		public virtual string s_Pais
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pais) ? string.Empty : base.GetstringAsString(ColumnNames.Pais);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pais);
				else
					this.Pais = base.SetstringAsString(ColumnNames.Pais, value);
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
				
				
				public WhereParameter Idrastreo_pais
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_pais, Parameters.Idrastreo_pais);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Pais
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pais, Parameters.Pais);
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
		
			public WhereParameter Idrastreo_pais
		    {
				get
		        {
					if(_Idrastreo_pais_W == null)
	        	    {
						_Idrastreo_pais_W = TearOff.Idrastreo_pais;
					}
					return _Idrastreo_pais_W;
				}
			}

			public WhereParameter Pais
		    {
				get
		        {
					if(_Pais_W == null)
	        	    {
						_Pais_W = TearOff.Pais;
					}
					return _Pais_W;
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

			private WhereParameter _Idrastreo_pais_W = null;
			private WhereParameter _Pais_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idrastreo_pais_W = null;
				_Pais_W = null;
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
				
				
				public AggregateParameter Idrastreo_pais
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_pais, Parameters.Idrastreo_pais);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Pais
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pais, Parameters.Pais);
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
		
			public AggregateParameter Idrastreo_pais
		    {
				get
		        {
					if(_Idrastreo_pais_W == null)
	        	    {
						_Idrastreo_pais_W = TearOff.Idrastreo_pais;
					}
					return _Idrastreo_pais_W;
				}
			}

			public AggregateParameter Pais
		    {
				get
		        {
					if(_Pais_W == null)
	        	    {
						_Pais_W = TearOff.Pais;
					}
					return _Pais_W;
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

			private AggregateParameter _Idrastreo_pais_W = null;
			private AggregateParameter _Pais_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreo_pais_W = null;
				_Pais_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_pais_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreo_pais.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_pais_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_pais_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreo_pais);
			p.SourceColumn = ColumnNames.Idrastreo_pais;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreo_pais);
			p.SourceColumn = ColumnNames.Idrastreo_pais;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Pais);
			p.SourceColumn = ColumnNames.Pais;
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
