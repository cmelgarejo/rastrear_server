
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_historial.
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
	public abstract class _rastreo_historial : PostgreSqlEntity
	{
		public _rastreo_historial()
		{
			this.QuerySource = "rastreo_historial";
			this.MappingName = "rastreo_historial";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_historial_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreo_historial, int Id_cliente)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreo_historial, Idrastreo_historial);

parameters.Add(Parameters.Id_cliente, Id_cliente);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_historial_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreo_historial
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_historial", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_cliente
			{
				get
				{
					return new NpgsqlParameter("Id_cliente", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Vehiculos_involucrados
			{
				get
				{
					return new NpgsqlParameter("Vehiculos_involucrados", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Observacion
			{
				get
				{
					return new NpgsqlParameter("Observacion", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Fecha_verificacion
			{
				get
				{
					return new NpgsqlParameter("Fecha_verificacion", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
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
            public const string Idrastreo_historial = "idrastreo_historial";
            public const string Id_cliente = "id_cliente";
            public const string Vehiculos_involucrados = "vehiculos_involucrados";
            public const string Observacion = "observacion";
            public const string Fecha_verificacion = "fecha_verificacion";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_historial] = _rastreo_historial.PropertyNames.Idrastreo_historial;
					ht[Id_cliente] = _rastreo_historial.PropertyNames.Id_cliente;
					ht[Vehiculos_involucrados] = _rastreo_historial.PropertyNames.Vehiculos_involucrados;
					ht[Observacion] = _rastreo_historial.PropertyNames.Observacion;
					ht[Fecha_verificacion] = _rastreo_historial.PropertyNames.Fecha_verificacion;
					ht[User_ins] = _rastreo_historial.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_historial.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_historial.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_historial.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreo_historial = "Idrastreo_historial";
            public const string Id_cliente = "Id_cliente";
            public const string Vehiculos_involucrados = "Vehiculos_involucrados";
            public const string Observacion = "Observacion";
            public const string Fecha_verificacion = "Fecha_verificacion";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_historial] = _rastreo_historial.ColumnNames.Idrastreo_historial;
					ht[Id_cliente] = _rastreo_historial.ColumnNames.Id_cliente;
					ht[Vehiculos_involucrados] = _rastreo_historial.ColumnNames.Vehiculos_involucrados;
					ht[Observacion] = _rastreo_historial.ColumnNames.Observacion;
					ht[Fecha_verificacion] = _rastreo_historial.ColumnNames.Fecha_verificacion;
					ht[User_ins] = _rastreo_historial.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_historial.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_historial.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_historial.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreo_historial = "s_Idrastreo_historial";
            public const string Id_cliente = "s_Id_cliente";
            public const string Vehiculos_involucrados = "s_Vehiculos_involucrados";
            public const string Observacion = "s_Observacion";
            public const string Fecha_verificacion = "s_Fecha_verificacion";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreo_historial
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_historial);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_historial, value);
			}
		}

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

		public virtual string Vehiculos_involucrados
	    {
			get
	        {
				return base.Getstring(ColumnNames.Vehiculos_involucrados);
			}
			set
	        {
				base.Setstring(ColumnNames.Vehiculos_involucrados, value);
			}
		}

		public virtual string Observacion
	    {
			get
	        {
				return base.Getstring(ColumnNames.Observacion);
			}
			set
	        {
				base.Setstring(ColumnNames.Observacion, value);
			}
		}

		public virtual DateTime Fecha_verificacion
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Fecha_verificacion);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Fecha_verificacion, value);
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
	
		public virtual string s_Idrastreo_historial
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_historial) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_historial);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_historial);
				else
					this.Idrastreo_historial = base.SetintAsString(ColumnNames.Idrastreo_historial, value);
			}
		}

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

		public virtual string s_Vehiculos_involucrados
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Vehiculos_involucrados) ? string.Empty : base.GetstringAsString(ColumnNames.Vehiculos_involucrados);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Vehiculos_involucrados);
				else
					this.Vehiculos_involucrados = base.SetstringAsString(ColumnNames.Vehiculos_involucrados, value);
			}
		}

		public virtual string s_Observacion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Observacion) ? string.Empty : base.GetstringAsString(ColumnNames.Observacion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Observacion);
				else
					this.Observacion = base.SetstringAsString(ColumnNames.Observacion, value);
			}
		}

		public virtual string s_Fecha_verificacion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Fecha_verificacion) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Fecha_verificacion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Fecha_verificacion);
				else
					this.Fecha_verificacion = base.SetDateTimeAsString(ColumnNames.Fecha_verificacion, value);
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
				
				
				public WhereParameter Idrastreo_historial
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_historial, Parameters.Idrastreo_historial);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
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

				public WhereParameter Vehiculos_involucrados
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Vehiculos_involucrados, Parameters.Vehiculos_involucrados);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Observacion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Observacion, Parameters.Observacion);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Fecha_verificacion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Fecha_verificacion, Parameters.Fecha_verificacion);
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
		
			public WhereParameter Idrastreo_historial
		    {
				get
		        {
					if(_Idrastreo_historial_W == null)
	        	    {
						_Idrastreo_historial_W = TearOff.Idrastreo_historial;
					}
					return _Idrastreo_historial_W;
				}
			}

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

			public WhereParameter Vehiculos_involucrados
		    {
				get
		        {
					if(_Vehiculos_involucrados_W == null)
	        	    {
						_Vehiculos_involucrados_W = TearOff.Vehiculos_involucrados;
					}
					return _Vehiculos_involucrados_W;
				}
			}

			public WhereParameter Observacion
		    {
				get
		        {
					if(_Observacion_W == null)
	        	    {
						_Observacion_W = TearOff.Observacion;
					}
					return _Observacion_W;
				}
			}

			public WhereParameter Fecha_verificacion
		    {
				get
		        {
					if(_Fecha_verificacion_W == null)
	        	    {
						_Fecha_verificacion_W = TearOff.Fecha_verificacion;
					}
					return _Fecha_verificacion_W;
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

			private WhereParameter _Idrastreo_historial_W = null;
			private WhereParameter _Id_cliente_W = null;
			private WhereParameter _Vehiculos_involucrados_W = null;
			private WhereParameter _Observacion_W = null;
			private WhereParameter _Fecha_verificacion_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idrastreo_historial_W = null;
				_Id_cliente_W = null;
				_Vehiculos_involucrados_W = null;
				_Observacion_W = null;
				_Fecha_verificacion_W = null;
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
				
				
				public AggregateParameter Idrastreo_historial
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_historial, Parameters.Idrastreo_historial);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
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

				public AggregateParameter Vehiculos_involucrados
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Vehiculos_involucrados, Parameters.Vehiculos_involucrados);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Observacion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Observacion, Parameters.Observacion);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Fecha_verificacion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fecha_verificacion, Parameters.Fecha_verificacion);
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
		
			public AggregateParameter Idrastreo_historial
		    {
				get
		        {
					if(_Idrastreo_historial_W == null)
	        	    {
						_Idrastreo_historial_W = TearOff.Idrastreo_historial;
					}
					return _Idrastreo_historial_W;
				}
			}

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

			public AggregateParameter Vehiculos_involucrados
		    {
				get
		        {
					if(_Vehiculos_involucrados_W == null)
	        	    {
						_Vehiculos_involucrados_W = TearOff.Vehiculos_involucrados;
					}
					return _Vehiculos_involucrados_W;
				}
			}

			public AggregateParameter Observacion
		    {
				get
		        {
					if(_Observacion_W == null)
	        	    {
						_Observacion_W = TearOff.Observacion;
					}
					return _Observacion_W;
				}
			}

			public AggregateParameter Fecha_verificacion
		    {
				get
		        {
					if(_Fecha_verificacion_W == null)
	        	    {
						_Fecha_verificacion_W = TearOff.Fecha_verificacion;
					}
					return _Fecha_verificacion_W;
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

			private AggregateParameter _Idrastreo_historial_W = null;
			private AggregateParameter _Id_cliente_W = null;
			private AggregateParameter _Vehiculos_involucrados_W = null;
			private AggregateParameter _Observacion_W = null;
			private AggregateParameter _Fecha_verificacion_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreo_historial_W = null;
				_Id_cliente_W = null;
				_Vehiculos_involucrados_W = null;
				_Observacion_W = null;
				_Fecha_verificacion_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_historial_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreo_historial.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_historial_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_historial_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreo_historial);
			p.SourceColumn = ColumnNames.Idrastreo_historial;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_cliente);
			p.SourceColumn = ColumnNames.Id_cliente;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreo_historial);
			p.SourceColumn = ColumnNames.Idrastreo_historial;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_cliente);
			p.SourceColumn = ColumnNames.Id_cliente;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Vehiculos_involucrados);
			p.SourceColumn = ColumnNames.Vehiculos_involucrados;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Observacion);
			p.SourceColumn = ColumnNames.Observacion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Fecha_verificacion);
			p.SourceColumn = ColumnNames.Fecha_verificacion;
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
