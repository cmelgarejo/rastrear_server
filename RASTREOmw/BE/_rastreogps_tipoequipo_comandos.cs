
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreogps_tipoequipo_comandos.
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
	public abstract class _rastreogps_tipoequipo_comandos : PostgreSqlEntity
	{
		public _rastreogps_tipoequipo_comandos()
		{
			this.QuerySource = "rastreogps_tipoequipo_comandos";
			this.MappingName = "rastreogps_tipoequipo_comandos";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_tipoequipo_comandos_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreogps_tipoequipo_comandos)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreogps_tipoequipo_comandos, Idrastreogps_tipoequipo_comandos);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_tipoequipo_comandos_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreogps_tipoequipo_comandos
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_tipoequipo_comandos", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_tipoequipo
			{
				get
				{
					return new NpgsqlParameter("Id_tipoequipo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Descripcion
			{
				get
				{
					return new NpgsqlParameter("Descripcion", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Comando
			{
				get
				{
					return new NpgsqlParameter("Comando", NpgsqlTypes.NpgsqlDbType.Text, 0);
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
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Idrastreogps_tipoequipo_comandos = "idrastreogps_tipoequipo_comandos";
            public const string Id_tipoequipo = "id_tipoequipo";
            public const string Descripcion = "descripcion";
            public const string Comando = "comando";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_tipoequipo_comandos] = _rastreogps_tipoequipo_comandos.PropertyNames.Idrastreogps_tipoequipo_comandos;
					ht[Id_tipoequipo] = _rastreogps_tipoequipo_comandos.PropertyNames.Id_tipoequipo;
					ht[Descripcion] = _rastreogps_tipoequipo_comandos.PropertyNames.Descripcion;
					ht[Comando] = _rastreogps_tipoequipo_comandos.PropertyNames.Comando;
					ht[User_ins] = _rastreogps_tipoequipo_comandos.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreogps_tipoequipo_comandos.PropertyNames.Fech_ins;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreogps_tipoequipo_comandos = "Idrastreogps_tipoequipo_comandos";
            public const string Id_tipoequipo = "Id_tipoequipo";
            public const string Descripcion = "Descripcion";
            public const string Comando = "Comando";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_tipoequipo_comandos] = _rastreogps_tipoequipo_comandos.ColumnNames.Idrastreogps_tipoequipo_comandos;
					ht[Id_tipoequipo] = _rastreogps_tipoequipo_comandos.ColumnNames.Id_tipoequipo;
					ht[Descripcion] = _rastreogps_tipoequipo_comandos.ColumnNames.Descripcion;
					ht[Comando] = _rastreogps_tipoequipo_comandos.ColumnNames.Comando;
					ht[User_ins] = _rastreogps_tipoequipo_comandos.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreogps_tipoequipo_comandos.ColumnNames.Fech_ins;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreogps_tipoequipo_comandos = "s_Idrastreogps_tipoequipo_comandos";
            public const string Id_tipoequipo = "s_Id_tipoequipo";
            public const string Descripcion = "s_Descripcion";
            public const string Comando = "s_Comando";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreogps_tipoequipo_comandos
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_tipoequipo_comandos);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_tipoequipo_comandos, value);
			}
		}

		public virtual int Id_tipoequipo
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_tipoequipo);
			}
			set
	        {
				base.Setint(ColumnNames.Id_tipoequipo, value);
			}
		}

		public virtual string Descripcion
	    {
			get
	        {
				return base.Getstring(ColumnNames.Descripcion);
			}
			set
	        {
				base.Setstring(ColumnNames.Descripcion, value);
			}
		}

		public virtual string Comando
	    {
			get
	        {
				return base.Getstring(ColumnNames.Comando);
			}
			set
	        {
				base.Setstring(ColumnNames.Comando, value);
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


		#endregion
		
		#region String Properties
	
		public virtual string s_Idrastreogps_tipoequipo_comandos
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_tipoequipo_comandos) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_tipoequipo_comandos);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_tipoequipo_comandos);
				else
					this.Idrastreogps_tipoequipo_comandos = base.SetintAsString(ColumnNames.Idrastreogps_tipoequipo_comandos, value);
			}
		}

		public virtual string s_Id_tipoequipo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_tipoequipo) ? string.Empty : base.GetintAsString(ColumnNames.Id_tipoequipo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_tipoequipo);
				else
					this.Id_tipoequipo = base.SetintAsString(ColumnNames.Id_tipoequipo, value);
			}
		}

		public virtual string s_Descripcion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Descripcion) ? string.Empty : base.GetstringAsString(ColumnNames.Descripcion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Descripcion);
				else
					this.Descripcion = base.SetstringAsString(ColumnNames.Descripcion, value);
			}
		}

		public virtual string s_Comando
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Comando) ? string.Empty : base.GetstringAsString(ColumnNames.Comando);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Comando);
				else
					this.Comando = base.SetstringAsString(ColumnNames.Comando, value);
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
				
				
				public WhereParameter Idrastreogps_tipoequipo_comandos
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_tipoequipo_comandos, Parameters.Idrastreogps_tipoequipo_comandos);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_tipoequipo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_tipoequipo, Parameters.Id_tipoequipo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Descripcion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Descripcion, Parameters.Descripcion);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Comando
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Comando, Parameters.Comando);
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


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Idrastreogps_tipoequipo_comandos
		    {
				get
		        {
					if(_Idrastreogps_tipoequipo_comandos_W == null)
	        	    {
						_Idrastreogps_tipoequipo_comandos_W = TearOff.Idrastreogps_tipoequipo_comandos;
					}
					return _Idrastreogps_tipoequipo_comandos_W;
				}
			}

			public WhereParameter Id_tipoequipo
		    {
				get
		        {
					if(_Id_tipoequipo_W == null)
	        	    {
						_Id_tipoequipo_W = TearOff.Id_tipoequipo;
					}
					return _Id_tipoequipo_W;
				}
			}

			public WhereParameter Descripcion
		    {
				get
		        {
					if(_Descripcion_W == null)
	        	    {
						_Descripcion_W = TearOff.Descripcion;
					}
					return _Descripcion_W;
				}
			}

			public WhereParameter Comando
		    {
				get
		        {
					if(_Comando_W == null)
	        	    {
						_Comando_W = TearOff.Comando;
					}
					return _Comando_W;
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

			private WhereParameter _Idrastreogps_tipoequipo_comandos_W = null;
			private WhereParameter _Id_tipoequipo_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _Comando_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;

			public void WhereClauseReset()
			{
				_Idrastreogps_tipoequipo_comandos_W = null;
				_Id_tipoequipo_W = null;
				_Descripcion_W = null;
				_Comando_W = null;
				_User_ins_W = null;
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
				
				
				public AggregateParameter Idrastreogps_tipoequipo_comandos
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_tipoequipo_comandos, Parameters.Idrastreogps_tipoequipo_comandos);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_tipoequipo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_tipoequipo, Parameters.Id_tipoequipo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Descripcion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Descripcion, Parameters.Descripcion);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Comando
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Comando, Parameters.Comando);
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


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Idrastreogps_tipoequipo_comandos
		    {
				get
		        {
					if(_Idrastreogps_tipoequipo_comandos_W == null)
	        	    {
						_Idrastreogps_tipoequipo_comandos_W = TearOff.Idrastreogps_tipoequipo_comandos;
					}
					return _Idrastreogps_tipoequipo_comandos_W;
				}
			}

			public AggregateParameter Id_tipoequipo
		    {
				get
		        {
					if(_Id_tipoequipo_W == null)
	        	    {
						_Id_tipoequipo_W = TearOff.Id_tipoequipo;
					}
					return _Id_tipoequipo_W;
				}
			}

			public AggregateParameter Descripcion
		    {
				get
		        {
					if(_Descripcion_W == null)
	        	    {
						_Descripcion_W = TearOff.Descripcion;
					}
					return _Descripcion_W;
				}
			}

			public AggregateParameter Comando
		    {
				get
		        {
					if(_Comando_W == null)
	        	    {
						_Comando_W = TearOff.Comando;
					}
					return _Comando_W;
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

			private AggregateParameter _Idrastreogps_tipoequipo_comandos_W = null;
			private AggregateParameter _Id_tipoequipo_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _Comando_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreogps_tipoequipo_comandos_W = null;
				_Id_tipoequipo_W = null;
				_Descripcion_W = null;
				_Comando_W = null;
				_User_ins_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_tipoequipo_comandos_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreogps_tipoequipo_comandos.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_tipoequipo_comandos_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_tipoequipo_comandos_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreogps_tipoequipo_comandos);
			p.SourceColumn = ColumnNames.Idrastreogps_tipoequipo_comandos;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreogps_tipoequipo_comandos);
			p.SourceColumn = ColumnNames.Idrastreogps_tipoequipo_comandos;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_tipoequipo);
			p.SourceColumn = ColumnNames.Id_tipoequipo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Descripcion);
			p.SourceColumn = ColumnNames.Descripcion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Comando);
			p.SourceColumn = ColumnNames.Comando;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.User_ins);
			p.SourceColumn = ColumnNames.User_ins;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Fech_ins);
			p.SourceColumn = ColumnNames.Fech_ins;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
