
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_hoja_de_ruta_puntos.
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
	public abstract class _rastreo_hoja_de_ruta_puntos : PostgreSqlEntity
	{
		public _rastreo_hoja_de_ruta_puntos()
		{
			this.QuerySource = "rastreo_hoja_de_ruta_puntos";
			this.MappingName = "rastreo_hoja_de_ruta_puntos";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_hoja_de_ruta_puntos_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Id_punto)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Id_punto, Id_punto);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_hoja_de_ruta_puntos_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Id_punto
			{
				get
				{
					return new NpgsqlParameter("Id_punto", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Idhoja_de_ruta
			{
				get
				{
					return new NpgsqlParameter("Idhoja_de_ruta", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Nombre
			{
				get
				{
					return new NpgsqlParameter("Nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
				}
			}
			
			public static NpgsqlParameter Descripcion
			{
				get
				{
					return new NpgsqlParameter("Descripcion", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Orden
			{
				get
				{
					return new NpgsqlParameter("Orden", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Lon
			{
				get
				{
					return new NpgsqlParameter("Lon", NpgsqlTypes.NpgsqlDbType.Double, 0);
				}
			}
			
			public static NpgsqlParameter Lat
			{
				get
				{
					return new NpgsqlParameter("Lat", NpgsqlTypes.NpgsqlDbType.Double, 0);
				}
			}
			
			public static NpgsqlParameter Hora_llegada
			{
				get
				{
					return new NpgsqlParameter("Hora_llegada", NpgsqlTypes.NpgsqlDbType.Time, 0);
				}
			}
			
			public static NpgsqlParameter Minutos_demora
			{
				get
				{
					return new NpgsqlParameter("Minutos_demora", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Id_punto = "id_punto";
            public const string Idhoja_de_ruta = "idhoja_de_ruta";
            public const string Nombre = "nombre";
            public const string Descripcion = "descripcion";
            public const string Orden = "orden";
            public const string Lon = "lon";
            public const string Lat = "lat";
            public const string Hora_llegada = "hora_llegada";
            public const string Minutos_demora = "minutos_demora";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_punto] = _rastreo_hoja_de_ruta_puntos.PropertyNames.Id_punto;
					ht[Idhoja_de_ruta] = _rastreo_hoja_de_ruta_puntos.PropertyNames.Idhoja_de_ruta;
					ht[Nombre] = _rastreo_hoja_de_ruta_puntos.PropertyNames.Nombre;
					ht[Descripcion] = _rastreo_hoja_de_ruta_puntos.PropertyNames.Descripcion;
					ht[Orden] = _rastreo_hoja_de_ruta_puntos.PropertyNames.Orden;
					ht[Lon] = _rastreo_hoja_de_ruta_puntos.PropertyNames.Lon;
					ht[Lat] = _rastreo_hoja_de_ruta_puntos.PropertyNames.Lat;
					ht[Hora_llegada] = _rastreo_hoja_de_ruta_puntos.PropertyNames.Hora_llegada;
					ht[Minutos_demora] = _rastreo_hoja_de_ruta_puntos.PropertyNames.Minutos_demora;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Id_punto = "Id_punto";
            public const string Idhoja_de_ruta = "Idhoja_de_ruta";
            public const string Nombre = "Nombre";
            public const string Descripcion = "Descripcion";
            public const string Orden = "Orden";
            public const string Lon = "Lon";
            public const string Lat = "Lat";
            public const string Hora_llegada = "Hora_llegada";
            public const string Minutos_demora = "Minutos_demora";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_punto] = _rastreo_hoja_de_ruta_puntos.ColumnNames.Id_punto;
					ht[Idhoja_de_ruta] = _rastreo_hoja_de_ruta_puntos.ColumnNames.Idhoja_de_ruta;
					ht[Nombre] = _rastreo_hoja_de_ruta_puntos.ColumnNames.Nombre;
					ht[Descripcion] = _rastreo_hoja_de_ruta_puntos.ColumnNames.Descripcion;
					ht[Orden] = _rastreo_hoja_de_ruta_puntos.ColumnNames.Orden;
					ht[Lon] = _rastreo_hoja_de_ruta_puntos.ColumnNames.Lon;
					ht[Lat] = _rastreo_hoja_de_ruta_puntos.ColumnNames.Lat;
					ht[Hora_llegada] = _rastreo_hoja_de_ruta_puntos.ColumnNames.Hora_llegada;
					ht[Minutos_demora] = _rastreo_hoja_de_ruta_puntos.ColumnNames.Minutos_demora;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Id_punto = "s_Id_punto";
            public const string Idhoja_de_ruta = "s_Idhoja_de_ruta";
            public const string Nombre = "s_Nombre";
            public const string Descripcion = "s_Descripcion";
            public const string Orden = "s_Orden";
            public const string Lon = "s_Lon";
            public const string Lat = "s_Lat";
            public const string Hora_llegada = "s_Hora_llegada";
            public const string Minutos_demora = "s_Minutos_demora";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Id_punto
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_punto);
			}
			set
	        {
				base.Setint(ColumnNames.Id_punto, value);
			}
		}

		public virtual int Idhoja_de_ruta
	    {
			get
	        {
				return base.Getint(ColumnNames.Idhoja_de_ruta);
			}
			set
	        {
				base.Setint(ColumnNames.Idhoja_de_ruta, value);
			}
		}

		public virtual string Nombre
	    {
			get
	        {
				return base.Getstring(ColumnNames.Nombre);
			}
			set
	        {
				base.Setstring(ColumnNames.Nombre, value);
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

		public virtual int Orden
	    {
			get
	        {
				return base.Getint(ColumnNames.Orden);
			}
			set
	        {
				base.Setint(ColumnNames.Orden, value);
			}
		}

		public virtual double Lon
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Lon);
			}
			set
	        {
				base.Setdouble(ColumnNames.Lon, value);
			}
		}

		public virtual double Lat
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Lat);
			}
			set
	        {
				base.Setdouble(ColumnNames.Lat, value);
			}
		}

		public virtual DateTime Hora_llegada
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Hora_llegada);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Hora_llegada, value);
			}
		}

		public virtual int Minutos_demora
	    {
			get
	        {
				return base.Getint(ColumnNames.Minutos_demora);
			}
			set
	        {
				base.Setint(ColumnNames.Minutos_demora, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Id_punto
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_punto) ? string.Empty : base.GetintAsString(ColumnNames.Id_punto);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_punto);
				else
					this.Id_punto = base.SetintAsString(ColumnNames.Id_punto, value);
			}
		}

		public virtual string s_Idhoja_de_ruta
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idhoja_de_ruta) ? string.Empty : base.GetintAsString(ColumnNames.Idhoja_de_ruta);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idhoja_de_ruta);
				else
					this.Idhoja_de_ruta = base.SetintAsString(ColumnNames.Idhoja_de_ruta, value);
			}
		}

		public virtual string s_Nombre
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Nombre) ? string.Empty : base.GetstringAsString(ColumnNames.Nombre);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nombre);
				else
					this.Nombre = base.SetstringAsString(ColumnNames.Nombre, value);
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

		public virtual string s_Orden
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Orden) ? string.Empty : base.GetintAsString(ColumnNames.Orden);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Orden);
				else
					this.Orden = base.SetintAsString(ColumnNames.Orden, value);
			}
		}

		public virtual string s_Lon
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Lon) ? string.Empty : base.GetdoubleAsString(ColumnNames.Lon);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Lon);
				else
					this.Lon = base.SetdoubleAsString(ColumnNames.Lon, value);
			}
		}

		public virtual string s_Lat
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Lat) ? string.Empty : base.GetdoubleAsString(ColumnNames.Lat);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Lat);
				else
					this.Lat = base.SetdoubleAsString(ColumnNames.Lat, value);
			}
		}

		public virtual string s_Hora_llegada
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Hora_llegada) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Hora_llegada);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Hora_llegada);
				else
					this.Hora_llegada = base.SetDateTimeAsString(ColumnNames.Hora_llegada, value);
			}
		}

		public virtual string s_Minutos_demora
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Minutos_demora) ? string.Empty : base.GetintAsString(ColumnNames.Minutos_demora);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Minutos_demora);
				else
					this.Minutos_demora = base.SetintAsString(ColumnNames.Minutos_demora, value);
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
				
				
				public WhereParameter Id_punto
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_punto, Parameters.Id_punto);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Idhoja_de_ruta
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idhoja_de_ruta, Parameters.Idhoja_de_ruta);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Nombre
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nombre, Parameters.Nombre);
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

				public WhereParameter Orden
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Orden, Parameters.Orden);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Lon
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Lon, Parameters.Lon);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Lat
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Lat, Parameters.Lat);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Hora_llegada
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Hora_llegada, Parameters.Hora_llegada);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Minutos_demora
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Minutos_demora, Parameters.Minutos_demora);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Id_punto
		    {
				get
		        {
					if(_Id_punto_W == null)
	        	    {
						_Id_punto_W = TearOff.Id_punto;
					}
					return _Id_punto_W;
				}
			}

			public WhereParameter Idhoja_de_ruta
		    {
				get
		        {
					if(_Idhoja_de_ruta_W == null)
	        	    {
						_Idhoja_de_ruta_W = TearOff.Idhoja_de_ruta;
					}
					return _Idhoja_de_ruta_W;
				}
			}

			public WhereParameter Nombre
		    {
				get
		        {
					if(_Nombre_W == null)
	        	    {
						_Nombre_W = TearOff.Nombre;
					}
					return _Nombre_W;
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

			public WhereParameter Orden
		    {
				get
		        {
					if(_Orden_W == null)
	        	    {
						_Orden_W = TearOff.Orden;
					}
					return _Orden_W;
				}
			}

			public WhereParameter Lon
		    {
				get
		        {
					if(_Lon_W == null)
	        	    {
						_Lon_W = TearOff.Lon;
					}
					return _Lon_W;
				}
			}

			public WhereParameter Lat
		    {
				get
		        {
					if(_Lat_W == null)
	        	    {
						_Lat_W = TearOff.Lat;
					}
					return _Lat_W;
				}
			}

			public WhereParameter Hora_llegada
		    {
				get
		        {
					if(_Hora_llegada_W == null)
	        	    {
						_Hora_llegada_W = TearOff.Hora_llegada;
					}
					return _Hora_llegada_W;
				}
			}

			public WhereParameter Minutos_demora
		    {
				get
		        {
					if(_Minutos_demora_W == null)
	        	    {
						_Minutos_demora_W = TearOff.Minutos_demora;
					}
					return _Minutos_demora_W;
				}
			}

			private WhereParameter _Id_punto_W = null;
			private WhereParameter _Idhoja_de_ruta_W = null;
			private WhereParameter _Nombre_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _Orden_W = null;
			private WhereParameter _Lon_W = null;
			private WhereParameter _Lat_W = null;
			private WhereParameter _Hora_llegada_W = null;
			private WhereParameter _Minutos_demora_W = null;

			public void WhereClauseReset()
			{
				_Id_punto_W = null;
				_Idhoja_de_ruta_W = null;
				_Nombre_W = null;
				_Descripcion_W = null;
				_Orden_W = null;
				_Lon_W = null;
				_Lat_W = null;
				_Hora_llegada_W = null;
				_Minutos_demora_W = null;

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
				
				
				public AggregateParameter Id_punto
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_punto, Parameters.Id_punto);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Idhoja_de_ruta
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idhoja_de_ruta, Parameters.Idhoja_de_ruta);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Nombre
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nombre, Parameters.Nombre);
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

				public AggregateParameter Orden
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Orden, Parameters.Orden);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Lon
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Lon, Parameters.Lon);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Lat
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Lat, Parameters.Lat);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Hora_llegada
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Hora_llegada, Parameters.Hora_llegada);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Minutos_demora
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Minutos_demora, Parameters.Minutos_demora);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Id_punto
		    {
				get
		        {
					if(_Id_punto_W == null)
	        	    {
						_Id_punto_W = TearOff.Id_punto;
					}
					return _Id_punto_W;
				}
			}

			public AggregateParameter Idhoja_de_ruta
		    {
				get
		        {
					if(_Idhoja_de_ruta_W == null)
	        	    {
						_Idhoja_de_ruta_W = TearOff.Idhoja_de_ruta;
					}
					return _Idhoja_de_ruta_W;
				}
			}

			public AggregateParameter Nombre
		    {
				get
		        {
					if(_Nombre_W == null)
	        	    {
						_Nombre_W = TearOff.Nombre;
					}
					return _Nombre_W;
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

			public AggregateParameter Orden
		    {
				get
		        {
					if(_Orden_W == null)
	        	    {
						_Orden_W = TearOff.Orden;
					}
					return _Orden_W;
				}
			}

			public AggregateParameter Lon
		    {
				get
		        {
					if(_Lon_W == null)
	        	    {
						_Lon_W = TearOff.Lon;
					}
					return _Lon_W;
				}
			}

			public AggregateParameter Lat
		    {
				get
		        {
					if(_Lat_W == null)
	        	    {
						_Lat_W = TearOff.Lat;
					}
					return _Lat_W;
				}
			}

			public AggregateParameter Hora_llegada
		    {
				get
		        {
					if(_Hora_llegada_W == null)
	        	    {
						_Hora_llegada_W = TearOff.Hora_llegada;
					}
					return _Hora_llegada_W;
				}
			}

			public AggregateParameter Minutos_demora
		    {
				get
		        {
					if(_Minutos_demora_W == null)
	        	    {
						_Minutos_demora_W = TearOff.Minutos_demora;
					}
					return _Minutos_demora_W;
				}
			}

			private AggregateParameter _Id_punto_W = null;
			private AggregateParameter _Idhoja_de_ruta_W = null;
			private AggregateParameter _Nombre_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _Orden_W = null;
			private AggregateParameter _Lon_W = null;
			private AggregateParameter _Lat_W = null;
			private AggregateParameter _Hora_llegada_W = null;
			private AggregateParameter _Minutos_demora_W = null;

			public void AggregateClauseReset()
			{
				_Id_punto_W = null;
				_Idhoja_de_ruta_W = null;
				_Nombre_W = null;
				_Descripcion_W = null;
				_Orden_W = null;
				_Lon_W = null;
				_Lat_W = null;
				_Hora_llegada_W = null;
				_Minutos_demora_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_hoja_de_ruta_puntos_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Id_punto.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_hoja_de_ruta_puntos_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_hoja_de_ruta_puntos_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Id_punto);
			p.SourceColumn = ColumnNames.Id_punto;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Id_punto);
			p.SourceColumn = ColumnNames.Id_punto;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Idhoja_de_ruta);
			p.SourceColumn = ColumnNames.Idhoja_de_ruta;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nombre);
			p.SourceColumn = ColumnNames.Nombre;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Descripcion);
			p.SourceColumn = ColumnNames.Descripcion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Orden);
			p.SourceColumn = ColumnNames.Orden;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Lon);
			p.SourceColumn = ColumnNames.Lon;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Lat);
			p.SourceColumn = ColumnNames.Lat;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Hora_llegada);
			p.SourceColumn = ColumnNames.Hora_llegada;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Minutos_demora);
			p.SourceColumn = ColumnNames.Minutos_demora;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
