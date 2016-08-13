
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreogps_avisos.
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
	public abstract class _rastreogps_avisos : PostgreSqlEntity
	{
		public _rastreogps_avisos()
		{
			this.QuerySource = "rastreogps_avisos";
			this.MappingName = "rastreogps_avisos";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_avisos_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreogps_avisos)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreogps_avisos, Idrastreogps_avisos);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_avisos_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreogps_avisos
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_avisos", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_equipogps
			{
				get
				{
					return new NpgsqlParameter("Id_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Evento
			{
				get
				{
					return new NpgsqlParameter("Evento", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Evento_fechahora
			{
				get
				{
					return new NpgsqlParameter("Evento_fechahora", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
			public static NpgsqlParameter Atendido
			{
				get
				{
					return new NpgsqlParameter("Atendido", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Gps_fechahora_reporte
			{
				get
				{
					return new NpgsqlParameter("Gps_fechahora_reporte", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
			public static NpgsqlParameter Gps_latitud
			{
				get
				{
					return new NpgsqlParameter("Gps_latitud", NpgsqlTypes.NpgsqlDbType.Double, 0);
				}
			}
			
			public static NpgsqlParameter Gps_longitud
			{
				get
				{
					return new NpgsqlParameter("Gps_longitud", NpgsqlTypes.NpgsqlDbType.Double, 0);
				}
			}
			
			public static NpgsqlParameter Gps_velocidad
			{
				get
				{
					return new NpgsqlParameter("Gps_velocidad", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Gps_rumbo
			{
				get
				{
					return new NpgsqlParameter("Gps_rumbo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Gps_dir
			{
				get
				{
					return new NpgsqlParameter("Gps_dir", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Idrastreogps_avisos = "idrastreogps_avisos";
            public const string Id_equipogps = "id_equipogps";
            public const string Evento = "evento";
            public const string Evento_fechahora = "evento_fechahora";
            public const string Atendido = "atendido";
            public const string Gps_fechahora_reporte = "gps_fechahora_reporte";
            public const string Gps_latitud = "gps_latitud";
            public const string Gps_longitud = "gps_longitud";
            public const string Gps_velocidad = "gps_velocidad";
            public const string Gps_rumbo = "gps_rumbo";
            public const string Gps_dir = "gps_dir";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_avisos] = _rastreogps_avisos.PropertyNames.Idrastreogps_avisos;
					ht[Id_equipogps] = _rastreogps_avisos.PropertyNames.Id_equipogps;
					ht[Evento] = _rastreogps_avisos.PropertyNames.Evento;
					ht[Evento_fechahora] = _rastreogps_avisos.PropertyNames.Evento_fechahora;
					ht[Atendido] = _rastreogps_avisos.PropertyNames.Atendido;
					ht[Gps_fechahora_reporte] = _rastreogps_avisos.PropertyNames.Gps_fechahora_reporte;
					ht[Gps_latitud] = _rastreogps_avisos.PropertyNames.Gps_latitud;
					ht[Gps_longitud] = _rastreogps_avisos.PropertyNames.Gps_longitud;
					ht[Gps_velocidad] = _rastreogps_avisos.PropertyNames.Gps_velocidad;
					ht[Gps_rumbo] = _rastreogps_avisos.PropertyNames.Gps_rumbo;
					ht[Gps_dir] = _rastreogps_avisos.PropertyNames.Gps_dir;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreogps_avisos = "Idrastreogps_avisos";
            public const string Id_equipogps = "Id_equipogps";
            public const string Evento = "Evento";
            public const string Evento_fechahora = "Evento_fechahora";
            public const string Atendido = "Atendido";
            public const string Gps_fechahora_reporte = "Gps_fechahora_reporte";
            public const string Gps_latitud = "Gps_latitud";
            public const string Gps_longitud = "Gps_longitud";
            public const string Gps_velocidad = "Gps_velocidad";
            public const string Gps_rumbo = "Gps_rumbo";
            public const string Gps_dir = "Gps_dir";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_avisos] = _rastreogps_avisos.ColumnNames.Idrastreogps_avisos;
					ht[Id_equipogps] = _rastreogps_avisos.ColumnNames.Id_equipogps;
					ht[Evento] = _rastreogps_avisos.ColumnNames.Evento;
					ht[Evento_fechahora] = _rastreogps_avisos.ColumnNames.Evento_fechahora;
					ht[Atendido] = _rastreogps_avisos.ColumnNames.Atendido;
					ht[Gps_fechahora_reporte] = _rastreogps_avisos.ColumnNames.Gps_fechahora_reporte;
					ht[Gps_latitud] = _rastreogps_avisos.ColumnNames.Gps_latitud;
					ht[Gps_longitud] = _rastreogps_avisos.ColumnNames.Gps_longitud;
					ht[Gps_velocidad] = _rastreogps_avisos.ColumnNames.Gps_velocidad;
					ht[Gps_rumbo] = _rastreogps_avisos.ColumnNames.Gps_rumbo;
					ht[Gps_dir] = _rastreogps_avisos.ColumnNames.Gps_dir;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreogps_avisos = "s_Idrastreogps_avisos";
            public const string Id_equipogps = "s_Id_equipogps";
            public const string Evento = "s_Evento";
            public const string Evento_fechahora = "s_Evento_fechahora";
            public const string Atendido = "s_Atendido";
            public const string Gps_fechahora_reporte = "s_Gps_fechahora_reporte";
            public const string Gps_latitud = "s_Gps_latitud";
            public const string Gps_longitud = "s_Gps_longitud";
            public const string Gps_velocidad = "s_Gps_velocidad";
            public const string Gps_rumbo = "s_Gps_rumbo";
            public const string Gps_dir = "s_Gps_dir";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreogps_avisos
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_avisos);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_avisos, value);
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

		public virtual string Evento
	    {
			get
	        {
				return base.Getstring(ColumnNames.Evento);
			}
			set
	        {
				base.Setstring(ColumnNames.Evento, value);
			}
		}

		public virtual DateTime Evento_fechahora
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Evento_fechahora);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Evento_fechahora, value);
			}
		}

		public virtual bool Atendido
	    {
			get
	        {
				return base.Getbool(ColumnNames.Atendido);
			}
			set
	        {
				base.Setbool(ColumnNames.Atendido, value);
			}
		}

		public virtual DateTime Gps_fechahora_reporte
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Gps_fechahora_reporte);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Gps_fechahora_reporte, value);
			}
		}

		public virtual double Gps_latitud
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Gps_latitud);
			}
			set
	        {
				base.Setdouble(ColumnNames.Gps_latitud, value);
			}
		}

		public virtual double Gps_longitud
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Gps_longitud);
			}
			set
	        {
				base.Setdouble(ColumnNames.Gps_longitud, value);
			}
		}

		public virtual int Gps_velocidad
	    {
			get
	        {
				return base.Getint(ColumnNames.Gps_velocidad);
			}
			set
	        {
				base.Setint(ColumnNames.Gps_velocidad, value);
			}
		}

		public virtual int Gps_rumbo
	    {
			get
	        {
				return base.Getint(ColumnNames.Gps_rumbo);
			}
			set
	        {
				base.Setint(ColumnNames.Gps_rumbo, value);
			}
		}

		public virtual string Gps_dir
	    {
			get
	        {
				return base.Getstring(ColumnNames.Gps_dir);
			}
			set
	        {
				base.Setstring(ColumnNames.Gps_dir, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Idrastreogps_avisos
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_avisos) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_avisos);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_avisos);
				else
					this.Idrastreogps_avisos = base.SetintAsString(ColumnNames.Idrastreogps_avisos, value);
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

		public virtual string s_Evento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Evento) ? string.Empty : base.GetstringAsString(ColumnNames.Evento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Evento);
				else
					this.Evento = base.SetstringAsString(ColumnNames.Evento, value);
			}
		}

		public virtual string s_Evento_fechahora
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Evento_fechahora) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Evento_fechahora);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Evento_fechahora);
				else
					this.Evento_fechahora = base.SetDateTimeAsString(ColumnNames.Evento_fechahora, value);
			}
		}

		public virtual string s_Atendido
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Atendido) ? string.Empty : base.GetboolAsString(ColumnNames.Atendido);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Atendido);
				else
					this.Atendido = base.SetboolAsString(ColumnNames.Atendido, value);
			}
		}

		public virtual string s_Gps_fechahora_reporte
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Gps_fechahora_reporte) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Gps_fechahora_reporte);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Gps_fechahora_reporte);
				else
					this.Gps_fechahora_reporte = base.SetDateTimeAsString(ColumnNames.Gps_fechahora_reporte, value);
			}
		}

		public virtual string s_Gps_latitud
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Gps_latitud) ? string.Empty : base.GetdoubleAsString(ColumnNames.Gps_latitud);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Gps_latitud);
				else
					this.Gps_latitud = base.SetdoubleAsString(ColumnNames.Gps_latitud, value);
			}
		}

		public virtual string s_Gps_longitud
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Gps_longitud) ? string.Empty : base.GetdoubleAsString(ColumnNames.Gps_longitud);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Gps_longitud);
				else
					this.Gps_longitud = base.SetdoubleAsString(ColumnNames.Gps_longitud, value);
			}
		}

		public virtual string s_Gps_velocidad
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Gps_velocidad) ? string.Empty : base.GetintAsString(ColumnNames.Gps_velocidad);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Gps_velocidad);
				else
					this.Gps_velocidad = base.SetintAsString(ColumnNames.Gps_velocidad, value);
			}
		}

		public virtual string s_Gps_rumbo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Gps_rumbo) ? string.Empty : base.GetintAsString(ColumnNames.Gps_rumbo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Gps_rumbo);
				else
					this.Gps_rumbo = base.SetintAsString(ColumnNames.Gps_rumbo, value);
			}
		}

		public virtual string s_Gps_dir
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Gps_dir) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_dir);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Gps_dir);
				else
					this.Gps_dir = base.SetstringAsString(ColumnNames.Gps_dir, value);
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
				
				
				public WhereParameter Idrastreogps_avisos
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_avisos, Parameters.Idrastreogps_avisos);
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

				public WhereParameter Evento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Evento, Parameters.Evento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Evento_fechahora
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Evento_fechahora, Parameters.Evento_fechahora);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Atendido
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Atendido, Parameters.Atendido);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Gps_fechahora_reporte
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Gps_fechahora_reporte, Parameters.Gps_fechahora_reporte);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Gps_latitud
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Gps_latitud, Parameters.Gps_latitud);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Gps_longitud
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Gps_longitud, Parameters.Gps_longitud);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Gps_velocidad
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Gps_velocidad, Parameters.Gps_velocidad);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Gps_rumbo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Gps_rumbo, Parameters.Gps_rumbo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Gps_dir
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Gps_dir, Parameters.Gps_dir);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Idrastreogps_avisos
		    {
				get
		        {
					if(_Idrastreogps_avisos_W == null)
	        	    {
						_Idrastreogps_avisos_W = TearOff.Idrastreogps_avisos;
					}
					return _Idrastreogps_avisos_W;
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

			public WhereParameter Evento
		    {
				get
		        {
					if(_Evento_W == null)
	        	    {
						_Evento_W = TearOff.Evento;
					}
					return _Evento_W;
				}
			}

			public WhereParameter Evento_fechahora
		    {
				get
		        {
					if(_Evento_fechahora_W == null)
	        	    {
						_Evento_fechahora_W = TearOff.Evento_fechahora;
					}
					return _Evento_fechahora_W;
				}
			}

			public WhereParameter Atendido
		    {
				get
		        {
					if(_Atendido_W == null)
	        	    {
						_Atendido_W = TearOff.Atendido;
					}
					return _Atendido_W;
				}
			}

			public WhereParameter Gps_fechahora_reporte
		    {
				get
		        {
					if(_Gps_fechahora_reporte_W == null)
	        	    {
						_Gps_fechahora_reporte_W = TearOff.Gps_fechahora_reporte;
					}
					return _Gps_fechahora_reporte_W;
				}
			}

			public WhereParameter Gps_latitud
		    {
				get
		        {
					if(_Gps_latitud_W == null)
	        	    {
						_Gps_latitud_W = TearOff.Gps_latitud;
					}
					return _Gps_latitud_W;
				}
			}

			public WhereParameter Gps_longitud
		    {
				get
		        {
					if(_Gps_longitud_W == null)
	        	    {
						_Gps_longitud_W = TearOff.Gps_longitud;
					}
					return _Gps_longitud_W;
				}
			}

			public WhereParameter Gps_velocidad
		    {
				get
		        {
					if(_Gps_velocidad_W == null)
	        	    {
						_Gps_velocidad_W = TearOff.Gps_velocidad;
					}
					return _Gps_velocidad_W;
				}
			}

			public WhereParameter Gps_rumbo
		    {
				get
		        {
					if(_Gps_rumbo_W == null)
	        	    {
						_Gps_rumbo_W = TearOff.Gps_rumbo;
					}
					return _Gps_rumbo_W;
				}
			}

			public WhereParameter Gps_dir
		    {
				get
		        {
					if(_Gps_dir_W == null)
	        	    {
						_Gps_dir_W = TearOff.Gps_dir;
					}
					return _Gps_dir_W;
				}
			}

			private WhereParameter _Idrastreogps_avisos_W = null;
			private WhereParameter _Id_equipogps_W = null;
			private WhereParameter _Evento_W = null;
			private WhereParameter _Evento_fechahora_W = null;
			private WhereParameter _Atendido_W = null;
			private WhereParameter _Gps_fechahora_reporte_W = null;
			private WhereParameter _Gps_latitud_W = null;
			private WhereParameter _Gps_longitud_W = null;
			private WhereParameter _Gps_velocidad_W = null;
			private WhereParameter _Gps_rumbo_W = null;
			private WhereParameter _Gps_dir_W = null;

			public void WhereClauseReset()
			{
				_Idrastreogps_avisos_W = null;
				_Id_equipogps_W = null;
				_Evento_W = null;
				_Evento_fechahora_W = null;
				_Atendido_W = null;
				_Gps_fechahora_reporte_W = null;
				_Gps_latitud_W = null;
				_Gps_longitud_W = null;
				_Gps_velocidad_W = null;
				_Gps_rumbo_W = null;
				_Gps_dir_W = null;

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
				
				
				public AggregateParameter Idrastreogps_avisos
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_avisos, Parameters.Idrastreogps_avisos);
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

				public AggregateParameter Evento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Evento, Parameters.Evento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Evento_fechahora
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Evento_fechahora, Parameters.Evento_fechahora);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Atendido
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Atendido, Parameters.Atendido);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Gps_fechahora_reporte
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_fechahora_reporte, Parameters.Gps_fechahora_reporte);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Gps_latitud
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_latitud, Parameters.Gps_latitud);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Gps_longitud
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_longitud, Parameters.Gps_longitud);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Gps_velocidad
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_velocidad, Parameters.Gps_velocidad);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Gps_rumbo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_rumbo, Parameters.Gps_rumbo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Gps_dir
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_dir, Parameters.Gps_dir);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Idrastreogps_avisos
		    {
				get
		        {
					if(_Idrastreogps_avisos_W == null)
	        	    {
						_Idrastreogps_avisos_W = TearOff.Idrastreogps_avisos;
					}
					return _Idrastreogps_avisos_W;
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

			public AggregateParameter Evento
		    {
				get
		        {
					if(_Evento_W == null)
	        	    {
						_Evento_W = TearOff.Evento;
					}
					return _Evento_W;
				}
			}

			public AggregateParameter Evento_fechahora
		    {
				get
		        {
					if(_Evento_fechahora_W == null)
	        	    {
						_Evento_fechahora_W = TearOff.Evento_fechahora;
					}
					return _Evento_fechahora_W;
				}
			}

			public AggregateParameter Atendido
		    {
				get
		        {
					if(_Atendido_W == null)
	        	    {
						_Atendido_W = TearOff.Atendido;
					}
					return _Atendido_W;
				}
			}

			public AggregateParameter Gps_fechahora_reporte
		    {
				get
		        {
					if(_Gps_fechahora_reporte_W == null)
	        	    {
						_Gps_fechahora_reporte_W = TearOff.Gps_fechahora_reporte;
					}
					return _Gps_fechahora_reporte_W;
				}
			}

			public AggregateParameter Gps_latitud
		    {
				get
		        {
					if(_Gps_latitud_W == null)
	        	    {
						_Gps_latitud_W = TearOff.Gps_latitud;
					}
					return _Gps_latitud_W;
				}
			}

			public AggregateParameter Gps_longitud
		    {
				get
		        {
					if(_Gps_longitud_W == null)
	        	    {
						_Gps_longitud_W = TearOff.Gps_longitud;
					}
					return _Gps_longitud_W;
				}
			}

			public AggregateParameter Gps_velocidad
		    {
				get
		        {
					if(_Gps_velocidad_W == null)
	        	    {
						_Gps_velocidad_W = TearOff.Gps_velocidad;
					}
					return _Gps_velocidad_W;
				}
			}

			public AggregateParameter Gps_rumbo
		    {
				get
		        {
					if(_Gps_rumbo_W == null)
	        	    {
						_Gps_rumbo_W = TearOff.Gps_rumbo;
					}
					return _Gps_rumbo_W;
				}
			}

			public AggregateParameter Gps_dir
		    {
				get
		        {
					if(_Gps_dir_W == null)
	        	    {
						_Gps_dir_W = TearOff.Gps_dir;
					}
					return _Gps_dir_W;
				}
			}

			private AggregateParameter _Idrastreogps_avisos_W = null;
			private AggregateParameter _Id_equipogps_W = null;
			private AggregateParameter _Evento_W = null;
			private AggregateParameter _Evento_fechahora_W = null;
			private AggregateParameter _Atendido_W = null;
			private AggregateParameter _Gps_fechahora_reporte_W = null;
			private AggregateParameter _Gps_latitud_W = null;
			private AggregateParameter _Gps_longitud_W = null;
			private AggregateParameter _Gps_velocidad_W = null;
			private AggregateParameter _Gps_rumbo_W = null;
			private AggregateParameter _Gps_dir_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreogps_avisos_W = null;
				_Id_equipogps_W = null;
				_Evento_W = null;
				_Evento_fechahora_W = null;
				_Atendido_W = null;
				_Gps_fechahora_reporte_W = null;
				_Gps_latitud_W = null;
				_Gps_longitud_W = null;
				_Gps_velocidad_W = null;
				_Gps_rumbo_W = null;
				_Gps_dir_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_avisos_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreogps_avisos.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_avisos_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_avisos_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreogps_avisos);
			p.SourceColumn = ColumnNames.Idrastreogps_avisos;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreogps_avisos);
			p.SourceColumn = ColumnNames.Idrastreogps_avisos;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_equipogps);
			p.SourceColumn = ColumnNames.Id_equipogps;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Evento);
			p.SourceColumn = ColumnNames.Evento;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Evento_fechahora);
			p.SourceColumn = ColumnNames.Evento_fechahora;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Atendido);
			p.SourceColumn = ColumnNames.Atendido;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Gps_fechahora_reporte);
			p.SourceColumn = ColumnNames.Gps_fechahora_reporte;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Gps_latitud);
			p.SourceColumn = ColumnNames.Gps_latitud;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Gps_longitud);
			p.SourceColumn = ColumnNames.Gps_longitud;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Gps_velocidad);
			p.SourceColumn = ColumnNames.Gps_velocidad;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Gps_rumbo);
			p.SourceColumn = ColumnNames.Gps_rumbo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Gps_dir);
			p.SourceColumn = ColumnNames.Gps_dir;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
