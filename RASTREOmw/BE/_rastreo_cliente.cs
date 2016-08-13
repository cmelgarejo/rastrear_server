
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_cliente.
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
	public abstract class _rastreo_cliente : PostgreSqlEntity
	{
		public _rastreo_cliente()
		{
			this.QuerySource = "rastreo_cliente";
			this.MappingName = "rastreo_cliente";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_cliente_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Id_cliente)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Id_cliente, Id_cliente);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_cliente_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Id_cliente
			{
				get
				{
					return new NpgsqlParameter("Id_cliente", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Clave_personal
			{
				get
				{
					return new NpgsqlParameter("Clave_personal", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Acceso_sistema
			{
				get
				{
					return new NpgsqlParameter("Acceso_sistema", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Estado_cliente
			{
				get
				{
					return new NpgsqlParameter("Estado_cliente", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Estado_fecha
			{
				get
				{
					return new NpgsqlParameter("Estado_fecha", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
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
			
			public static NpgsqlParameter Reporte_automatico
			{
				get
				{
					return new NpgsqlParameter("Reporte_automatico", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Ra_horaenvio
			{
				get
				{
					return new NpgsqlParameter("Ra_horaenvio", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Id_cliente = "id_cliente";
            public const string Clave_personal = "clave_personal";
            public const string Acceso_sistema = "acceso_sistema";
            public const string Estado_cliente = "estado_cliente";
            public const string Estado_fecha = "estado_fecha";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";
            public const string Reporte_automatico = "reporte_automatico";
            public const string Ra_horaenvio = "ra_horaenvio";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_cliente] = _rastreo_cliente.PropertyNames.Id_cliente;
					ht[Clave_personal] = _rastreo_cliente.PropertyNames.Clave_personal;
					ht[Acceso_sistema] = _rastreo_cliente.PropertyNames.Acceso_sistema;
					ht[Estado_cliente] = _rastreo_cliente.PropertyNames.Estado_cliente;
					ht[Estado_fecha] = _rastreo_cliente.PropertyNames.Estado_fecha;
					ht[User_ins] = _rastreo_cliente.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_cliente.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_cliente.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_cliente.PropertyNames.Fech_upd;
					ht[Reporte_automatico] = _rastreo_cliente.PropertyNames.Reporte_automatico;
					ht[Ra_horaenvio] = _rastreo_cliente.PropertyNames.Ra_horaenvio;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Id_cliente = "Id_cliente";
            public const string Clave_personal = "Clave_personal";
            public const string Acceso_sistema = "Acceso_sistema";
            public const string Estado_cliente = "Estado_cliente";
            public const string Estado_fecha = "Estado_fecha";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";
            public const string Reporte_automatico = "Reporte_automatico";
            public const string Ra_horaenvio = "Ra_horaenvio";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_cliente] = _rastreo_cliente.ColumnNames.Id_cliente;
					ht[Clave_personal] = _rastreo_cliente.ColumnNames.Clave_personal;
					ht[Acceso_sistema] = _rastreo_cliente.ColumnNames.Acceso_sistema;
					ht[Estado_cliente] = _rastreo_cliente.ColumnNames.Estado_cliente;
					ht[Estado_fecha] = _rastreo_cliente.ColumnNames.Estado_fecha;
					ht[User_ins] = _rastreo_cliente.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_cliente.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_cliente.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_cliente.ColumnNames.Fech_upd;
					ht[Reporte_automatico] = _rastreo_cliente.ColumnNames.Reporte_automatico;
					ht[Ra_horaenvio] = _rastreo_cliente.ColumnNames.Ra_horaenvio;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Id_cliente = "s_Id_cliente";
            public const string Clave_personal = "s_Clave_personal";
            public const string Acceso_sistema = "s_Acceso_sistema";
            public const string Estado_cliente = "s_Estado_cliente";
            public const string Estado_fecha = "s_Estado_fecha";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";
            public const string Reporte_automatico = "s_Reporte_automatico";
            public const string Ra_horaenvio = "s_Ra_horaenvio";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Id_cliente
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_cliente);
			}
			set
	        {
				base.Setint(ColumnNames.Id_cliente, value);
			}
		}

		public virtual string Clave_personal
	    {
			get
	        {
				return base.Getstring(ColumnNames.Clave_personal);
			}
			set
	        {
				base.Setstring(ColumnNames.Clave_personal, value);
			}
		}

		public virtual bool Acceso_sistema
	    {
			get
	        {
				return base.Getbool(ColumnNames.Acceso_sistema);
			}
			set
	        {
				base.Setbool(ColumnNames.Acceso_sistema, value);
			}
		}

		public virtual bool Estado_cliente
	    {
			get
	        {
				return base.Getbool(ColumnNames.Estado_cliente);
			}
			set
	        {
				base.Setbool(ColumnNames.Estado_cliente, value);
			}
		}

		public virtual DateTime Estado_fecha
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Estado_fecha);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Estado_fecha, value);
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

		public virtual bool Reporte_automatico
	    {
			get
	        {
				return base.Getbool(ColumnNames.Reporte_automatico);
			}
			set
	        {
				base.Setbool(ColumnNames.Reporte_automatico, value);
			}
		}

		public virtual DateTime Ra_horaenvio
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Ra_horaenvio);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Ra_horaenvio, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Id_cliente
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_cliente) ? string.Empty : base.GetintAsString(ColumnNames.Id_cliente);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_cliente);
				else
					this.Id_cliente = base.SetintAsString(ColumnNames.Id_cliente, value);
			}
		}

		public virtual string s_Clave_personal
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Clave_personal) ? string.Empty : base.GetstringAsString(ColumnNames.Clave_personal);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Clave_personal);
				else
					this.Clave_personal = base.SetstringAsString(ColumnNames.Clave_personal, value);
			}
		}

		public virtual string s_Acceso_sistema
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Acceso_sistema) ? string.Empty : base.GetboolAsString(ColumnNames.Acceso_sistema);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Acceso_sistema);
				else
					this.Acceso_sistema = base.SetboolAsString(ColumnNames.Acceso_sistema, value);
			}
		}

		public virtual string s_Estado_cliente
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Estado_cliente) ? string.Empty : base.GetboolAsString(ColumnNames.Estado_cliente);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Estado_cliente);
				else
					this.Estado_cliente = base.SetboolAsString(ColumnNames.Estado_cliente, value);
			}
		}

		public virtual string s_Estado_fecha
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Estado_fecha) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Estado_fecha);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Estado_fecha);
				else
					this.Estado_fecha = base.SetDateTimeAsString(ColumnNames.Estado_fecha, value);
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

		public virtual string s_Reporte_automatico
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Reporte_automatico) ? string.Empty : base.GetboolAsString(ColumnNames.Reporte_automatico);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Reporte_automatico);
				else
					this.Reporte_automatico = base.SetboolAsString(ColumnNames.Reporte_automatico, value);
			}
		}

		public virtual string s_Ra_horaenvio
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Ra_horaenvio) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Ra_horaenvio);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Ra_horaenvio);
				else
					this.Ra_horaenvio = base.SetDateTimeAsString(ColumnNames.Ra_horaenvio, value);
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
				
				
				public WhereParameter Id_cliente
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_cliente, Parameters.Id_cliente);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Clave_personal
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Clave_personal, Parameters.Clave_personal);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Acceso_sistema
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Acceso_sistema, Parameters.Acceso_sistema);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Estado_cliente
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Estado_cliente, Parameters.Estado_cliente);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Estado_fecha
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Estado_fecha, Parameters.Estado_fecha);
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

				public WhereParameter Reporte_automatico
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Reporte_automatico, Parameters.Reporte_automatico);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Ra_horaenvio
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Ra_horaenvio, Parameters.Ra_horaenvio);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Id_cliente
		    {
				get
		        {
					if(_Id_cliente_W == null)
	        	    {
						_Id_cliente_W = TearOff.Id_cliente;
					}
					return _Id_cliente_W;
				}
			}

			public WhereParameter Clave_personal
		    {
				get
		        {
					if(_Clave_personal_W == null)
	        	    {
						_Clave_personal_W = TearOff.Clave_personal;
					}
					return _Clave_personal_W;
				}
			}

			public WhereParameter Acceso_sistema
		    {
				get
		        {
					if(_Acceso_sistema_W == null)
	        	    {
						_Acceso_sistema_W = TearOff.Acceso_sistema;
					}
					return _Acceso_sistema_W;
				}
			}

			public WhereParameter Estado_cliente
		    {
				get
		        {
					if(_Estado_cliente_W == null)
	        	    {
						_Estado_cliente_W = TearOff.Estado_cliente;
					}
					return _Estado_cliente_W;
				}
			}

			public WhereParameter Estado_fecha
		    {
				get
		        {
					if(_Estado_fecha_W == null)
	        	    {
						_Estado_fecha_W = TearOff.Estado_fecha;
					}
					return _Estado_fecha_W;
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

			public WhereParameter Reporte_automatico
		    {
				get
		        {
					if(_Reporte_automatico_W == null)
	        	    {
						_Reporte_automatico_W = TearOff.Reporte_automatico;
					}
					return _Reporte_automatico_W;
				}
			}

			public WhereParameter Ra_horaenvio
		    {
				get
		        {
					if(_Ra_horaenvio_W == null)
	        	    {
						_Ra_horaenvio_W = TearOff.Ra_horaenvio;
					}
					return _Ra_horaenvio_W;
				}
			}

			private WhereParameter _Id_cliente_W = null;
			private WhereParameter _Clave_personal_W = null;
			private WhereParameter _Acceso_sistema_W = null;
			private WhereParameter _Estado_cliente_W = null;
			private WhereParameter _Estado_fecha_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;
			private WhereParameter _Reporte_automatico_W = null;
			private WhereParameter _Ra_horaenvio_W = null;

			public void WhereClauseReset()
			{
				_Id_cliente_W = null;
				_Clave_personal_W = null;
				_Acceso_sistema_W = null;
				_Estado_cliente_W = null;
				_Estado_fecha_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Reporte_automatico_W = null;
				_Ra_horaenvio_W = null;

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
				
				
				public AggregateParameter Id_cliente
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_cliente, Parameters.Id_cliente);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Clave_personal
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Clave_personal, Parameters.Clave_personal);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Acceso_sistema
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Acceso_sistema, Parameters.Acceso_sistema);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Estado_cliente
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Estado_cliente, Parameters.Estado_cliente);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Estado_fecha
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Estado_fecha, Parameters.Estado_fecha);
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

				public AggregateParameter Reporte_automatico
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Reporte_automatico, Parameters.Reporte_automatico);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Ra_horaenvio
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Ra_horaenvio, Parameters.Ra_horaenvio);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Id_cliente
		    {
				get
		        {
					if(_Id_cliente_W == null)
	        	    {
						_Id_cliente_W = TearOff.Id_cliente;
					}
					return _Id_cliente_W;
				}
			}

			public AggregateParameter Clave_personal
		    {
				get
		        {
					if(_Clave_personal_W == null)
	        	    {
						_Clave_personal_W = TearOff.Clave_personal;
					}
					return _Clave_personal_W;
				}
			}

			public AggregateParameter Acceso_sistema
		    {
				get
		        {
					if(_Acceso_sistema_W == null)
	        	    {
						_Acceso_sistema_W = TearOff.Acceso_sistema;
					}
					return _Acceso_sistema_W;
				}
			}

			public AggregateParameter Estado_cliente
		    {
				get
		        {
					if(_Estado_cliente_W == null)
	        	    {
						_Estado_cliente_W = TearOff.Estado_cliente;
					}
					return _Estado_cliente_W;
				}
			}

			public AggregateParameter Estado_fecha
		    {
				get
		        {
					if(_Estado_fecha_W == null)
	        	    {
						_Estado_fecha_W = TearOff.Estado_fecha;
					}
					return _Estado_fecha_W;
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

			public AggregateParameter Reporte_automatico
		    {
				get
		        {
					if(_Reporte_automatico_W == null)
	        	    {
						_Reporte_automatico_W = TearOff.Reporte_automatico;
					}
					return _Reporte_automatico_W;
				}
			}

			public AggregateParameter Ra_horaenvio
		    {
				get
		        {
					if(_Ra_horaenvio_W == null)
	        	    {
						_Ra_horaenvio_W = TearOff.Ra_horaenvio;
					}
					return _Ra_horaenvio_W;
				}
			}

			private AggregateParameter _Id_cliente_W = null;
			private AggregateParameter _Clave_personal_W = null;
			private AggregateParameter _Acceso_sistema_W = null;
			private AggregateParameter _Estado_cliente_W = null;
			private AggregateParameter _Estado_fecha_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;
			private AggregateParameter _Reporte_automatico_W = null;
			private AggregateParameter _Ra_horaenvio_W = null;

			public void AggregateClauseReset()
			{
				_Id_cliente_W = null;
				_Clave_personal_W = null;
				_Acceso_sistema_W = null;
				_Estado_cliente_W = null;
				_Estado_fecha_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Reporte_automatico_W = null;
				_Ra_horaenvio_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_cliente_insert";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_cliente_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_cliente_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Id_cliente);
			p.SourceColumn = ColumnNames.Id_cliente;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Id_cliente);
			p.SourceColumn = ColumnNames.Id_cliente;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Clave_personal);
			p.SourceColumn = ColumnNames.Clave_personal;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Acceso_sistema);
			p.SourceColumn = ColumnNames.Acceso_sistema;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Estado_cliente);
			p.SourceColumn = ColumnNames.Estado_cliente;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Estado_fecha);
			p.SourceColumn = ColumnNames.Estado_fecha;
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

			p = cmd.Parameters.Add(Parameters.Reporte_automatico);
			p.SourceColumn = ColumnNames.Reporte_automatico;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Ra_horaenvio);
			p.SourceColumn = ColumnNames.Ra_horaenvio;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
