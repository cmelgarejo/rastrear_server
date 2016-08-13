
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreogps_cola_de_comandos.
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
	public abstract class _rastreogps_cola_de_comandos : PostgreSqlEntity
	{
		public _rastreogps_cola_de_comandos()
		{
			this.QuerySource = "rastreogps_cola_de_comandos";
			this.MappingName = "rastreogps_cola_de_comandos";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_cola_de_comandos_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreogps_cola_de_comandos)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreogps_cola_de_comandos, Idrastreogps_cola_de_comandos);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_cola_de_comandos_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreogps_cola_de_comandos
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_cola_de_comandos", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Idequipogps
			{
				get
				{
					return new NpgsqlParameter("Idequipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
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
			
			public static NpgsqlParameter Enviado
			{
				get
				{
					return new NpgsqlParameter("Enviado", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Idrastreogps_cola_de_comandos = "idrastreogps_cola_de_comandos";
            public const string Idequipogps = "idequipogps";
            public const string Descripcion = "descripcion";
            public const string Comando = "comando";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string Enviado = "enviado";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_cola_de_comandos] = _rastreogps_cola_de_comandos.PropertyNames.Idrastreogps_cola_de_comandos;
					ht[Idequipogps] = _rastreogps_cola_de_comandos.PropertyNames.Idequipogps;
					ht[Descripcion] = _rastreogps_cola_de_comandos.PropertyNames.Descripcion;
					ht[Comando] = _rastreogps_cola_de_comandos.PropertyNames.Comando;
					ht[User_ins] = _rastreogps_cola_de_comandos.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreogps_cola_de_comandos.PropertyNames.Fech_ins;
					ht[Enviado] = _rastreogps_cola_de_comandos.PropertyNames.Enviado;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreogps_cola_de_comandos = "Idrastreogps_cola_de_comandos";
            public const string Idequipogps = "Idequipogps";
            public const string Descripcion = "Descripcion";
            public const string Comando = "Comando";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string Enviado = "Enviado";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_cola_de_comandos] = _rastreogps_cola_de_comandos.ColumnNames.Idrastreogps_cola_de_comandos;
					ht[Idequipogps] = _rastreogps_cola_de_comandos.ColumnNames.Idequipogps;
					ht[Descripcion] = _rastreogps_cola_de_comandos.ColumnNames.Descripcion;
					ht[Comando] = _rastreogps_cola_de_comandos.ColumnNames.Comando;
					ht[User_ins] = _rastreogps_cola_de_comandos.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreogps_cola_de_comandos.ColumnNames.Fech_ins;
					ht[Enviado] = _rastreogps_cola_de_comandos.ColumnNames.Enviado;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreogps_cola_de_comandos = "s_Idrastreogps_cola_de_comandos";
            public const string Idequipogps = "s_Idequipogps";
            public const string Descripcion = "s_Descripcion";
            public const string Comando = "s_Comando";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string Enviado = "s_Enviado";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreogps_cola_de_comandos
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_cola_de_comandos);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_cola_de_comandos, value);
			}
		}

		public virtual int Idequipogps
	    {
			get
	        {
				return base.Getint(ColumnNames.Idequipogps);
			}
			set
	        {
				base.Setint(ColumnNames.Idequipogps, value);
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

		public virtual bool Enviado
	    {
			get
	        {
				return base.Getbool(ColumnNames.Enviado);
			}
			set
	        {
				base.Setbool(ColumnNames.Enviado, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Idrastreogps_cola_de_comandos
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_cola_de_comandos) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_cola_de_comandos);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_cola_de_comandos);
				else
					this.Idrastreogps_cola_de_comandos = base.SetintAsString(ColumnNames.Idrastreogps_cola_de_comandos, value);
			}
		}

		public virtual string s_Idequipogps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idequipogps) ? string.Empty : base.GetintAsString(ColumnNames.Idequipogps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idequipogps);
				else
					this.Idequipogps = base.SetintAsString(ColumnNames.Idequipogps, value);
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

		public virtual string s_Enviado
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Enviado) ? string.Empty : base.GetboolAsString(ColumnNames.Enviado);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Enviado);
				else
					this.Enviado = base.SetboolAsString(ColumnNames.Enviado, value);
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
				
				
				public WhereParameter Idrastreogps_cola_de_comandos
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_cola_de_comandos, Parameters.Idrastreogps_cola_de_comandos);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Idequipogps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idequipogps, Parameters.Idequipogps);
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

				public WhereParameter Enviado
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Enviado, Parameters.Enviado);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Idrastreogps_cola_de_comandos
		    {
				get
		        {
					if(_Idrastreogps_cola_de_comandos_W == null)
	        	    {
						_Idrastreogps_cola_de_comandos_W = TearOff.Idrastreogps_cola_de_comandos;
					}
					return _Idrastreogps_cola_de_comandos_W;
				}
			}

			public WhereParameter Idequipogps
		    {
				get
		        {
					if(_Idequipogps_W == null)
	        	    {
						_Idequipogps_W = TearOff.Idequipogps;
					}
					return _Idequipogps_W;
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

			public WhereParameter Enviado
		    {
				get
		        {
					if(_Enviado_W == null)
	        	    {
						_Enviado_W = TearOff.Enviado;
					}
					return _Enviado_W;
				}
			}

			private WhereParameter _Idrastreogps_cola_de_comandos_W = null;
			private WhereParameter _Idequipogps_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _Comando_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _Enviado_W = null;

			public void WhereClauseReset()
			{
				_Idrastreogps_cola_de_comandos_W = null;
				_Idequipogps_W = null;
				_Descripcion_W = null;
				_Comando_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_Enviado_W = null;

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
				
				
				public AggregateParameter Idrastreogps_cola_de_comandos
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_cola_de_comandos, Parameters.Idrastreogps_cola_de_comandos);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Idequipogps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idequipogps, Parameters.Idequipogps);
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

				public AggregateParameter Enviado
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Enviado, Parameters.Enviado);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Idrastreogps_cola_de_comandos
		    {
				get
		        {
					if(_Idrastreogps_cola_de_comandos_W == null)
	        	    {
						_Idrastreogps_cola_de_comandos_W = TearOff.Idrastreogps_cola_de_comandos;
					}
					return _Idrastreogps_cola_de_comandos_W;
				}
			}

			public AggregateParameter Idequipogps
		    {
				get
		        {
					if(_Idequipogps_W == null)
	        	    {
						_Idequipogps_W = TearOff.Idequipogps;
					}
					return _Idequipogps_W;
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

			public AggregateParameter Enviado
		    {
				get
		        {
					if(_Enviado_W == null)
	        	    {
						_Enviado_W = TearOff.Enviado;
					}
					return _Enviado_W;
				}
			}

			private AggregateParameter _Idrastreogps_cola_de_comandos_W = null;
			private AggregateParameter _Idequipogps_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _Comando_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _Enviado_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreogps_cola_de_comandos_W = null;
				_Idequipogps_W = null;
				_Descripcion_W = null;
				_Comando_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_Enviado_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_cola_de_comandos_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreogps_cola_de_comandos.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_cola_de_comandos_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_cola_de_comandos_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreogps_cola_de_comandos);
			p.SourceColumn = ColumnNames.Idrastreogps_cola_de_comandos;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreogps_cola_de_comandos);
			p.SourceColumn = ColumnNames.Idrastreogps_cola_de_comandos;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Idequipogps);
			p.SourceColumn = ColumnNames.Idequipogps;
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

			p = cmd.Parameters.Add(Parameters.Enviado);
			p.SourceColumn = ColumnNames.Enviado;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
