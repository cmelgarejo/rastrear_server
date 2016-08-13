
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_referencias.
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
	public abstract class _rastreo_referencias : PostgreSqlEntity
	{
		public _rastreo_referencias()
		{
			this.QuerySource = "rastreo_referencias";
			this.MappingName = "rastreo_referencias";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_referencias_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreo_referencias)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreo_referencias, Idrastreo_referencias);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_referencias_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreo_referencias
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_referencias", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_cliente
			{
				get
				{
					return new NpgsqlParameter("Id_cliente", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Nombre
			{
				get
				{
					return new NpgsqlParameter("Nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
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
			
			public static NpgsqlParameter Descripcion
			{
				get
				{
					return new NpgsqlParameter("Descripcion", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Visible
			{
				get
				{
					return new NpgsqlParameter("Visible", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter User_in
			{
				get
				{
					return new NpgsqlParameter("User_in", NpgsqlTypes.NpgsqlDbType.Integer, 0);
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
            public const string Idrastreo_referencias = "idrastreo_referencias";
            public const string Id_cliente = "id_cliente";
            public const string Nombre = "nombre";
            public const string Lon = "lon";
            public const string Lat = "lat";
            public const string Descripcion = "descripcion";
            public const string Visible = "visible";
            public const string User_in = "user_in";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_referencias] = _rastreo_referencias.PropertyNames.Idrastreo_referencias;
					ht[Id_cliente] = _rastreo_referencias.PropertyNames.Id_cliente;
					ht[Nombre] = _rastreo_referencias.PropertyNames.Nombre;
					ht[Lon] = _rastreo_referencias.PropertyNames.Lon;
					ht[Lat] = _rastreo_referencias.PropertyNames.Lat;
					ht[Descripcion] = _rastreo_referencias.PropertyNames.Descripcion;
					ht[Visible] = _rastreo_referencias.PropertyNames.Visible;
					ht[User_in] = _rastreo_referencias.PropertyNames.User_in;
					ht[Fech_ins] = _rastreo_referencias.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_referencias.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_referencias.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreo_referencias = "Idrastreo_referencias";
            public const string Id_cliente = "Id_cliente";
            public const string Nombre = "Nombre";
            public const string Lon = "Lon";
            public const string Lat = "Lat";
            public const string Descripcion = "Descripcion";
            public const string Visible = "Visible";
            public const string User_in = "User_in";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_referencias] = _rastreo_referencias.ColumnNames.Idrastreo_referencias;
					ht[Id_cliente] = _rastreo_referencias.ColumnNames.Id_cliente;
					ht[Nombre] = _rastreo_referencias.ColumnNames.Nombre;
					ht[Lon] = _rastreo_referencias.ColumnNames.Lon;
					ht[Lat] = _rastreo_referencias.ColumnNames.Lat;
					ht[Descripcion] = _rastreo_referencias.ColumnNames.Descripcion;
					ht[Visible] = _rastreo_referencias.ColumnNames.Visible;
					ht[User_in] = _rastreo_referencias.ColumnNames.User_in;
					ht[Fech_ins] = _rastreo_referencias.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_referencias.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_referencias.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreo_referencias = "s_Idrastreo_referencias";
            public const string Id_cliente = "s_Id_cliente";
            public const string Nombre = "s_Nombre";
            public const string Lon = "s_Lon";
            public const string Lat = "s_Lat";
            public const string Descripcion = "s_Descripcion";
            public const string Visible = "s_Visible";
            public const string User_in = "s_User_in";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreo_referencias
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_referencias);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_referencias, value);
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

		public virtual int Descripcion
	    {
			get
	        {
				return base.Getint(ColumnNames.Descripcion);
			}
			set
	        {
				base.Setint(ColumnNames.Descripcion, value);
			}
		}

		public virtual bool Visible
	    {
			get
	        {
				return base.Getbool(ColumnNames.Visible);
			}
			set
	        {
				base.Setbool(ColumnNames.Visible, value);
			}
		}

		public virtual int User_in
	    {
			get
	        {
				return base.Getint(ColumnNames.User_in);
			}
			set
	        {
				base.Setint(ColumnNames.User_in, value);
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
	
		public virtual string s_Idrastreo_referencias
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_referencias) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_referencias);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_referencias);
				else
					this.Idrastreo_referencias = base.SetintAsString(ColumnNames.Idrastreo_referencias, value);
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

		public virtual string s_Descripcion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Descripcion) ? string.Empty : base.GetintAsString(ColumnNames.Descripcion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Descripcion);
				else
					this.Descripcion = base.SetintAsString(ColumnNames.Descripcion, value);
			}
		}

		public virtual string s_Visible
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Visible) ? string.Empty : base.GetboolAsString(ColumnNames.Visible);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Visible);
				else
					this.Visible = base.SetboolAsString(ColumnNames.Visible, value);
			}
		}

		public virtual string s_User_in
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.User_in) ? string.Empty : base.GetintAsString(ColumnNames.User_in);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.User_in);
				else
					this.User_in = base.SetintAsString(ColumnNames.User_in, value);
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
				
				
				public WhereParameter Idrastreo_referencias
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_referencias, Parameters.Idrastreo_referencias);
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

				public WhereParameter Nombre
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nombre, Parameters.Nombre);
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

				public WhereParameter Descripcion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Descripcion, Parameters.Descripcion);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Visible
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Visible, Parameters.Visible);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter User_in
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.User_in, Parameters.User_in);
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
		
			public WhereParameter Idrastreo_referencias
		    {
				get
		        {
					if(_Idrastreo_referencias_W == null)
	        	    {
						_Idrastreo_referencias_W = TearOff.Idrastreo_referencias;
					}
					return _Idrastreo_referencias_W;
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

			public WhereParameter Visible
		    {
				get
		        {
					if(_Visible_W == null)
	        	    {
						_Visible_W = TearOff.Visible;
					}
					return _Visible_W;
				}
			}

			public WhereParameter User_in
		    {
				get
		        {
					if(_User_in_W == null)
	        	    {
						_User_in_W = TearOff.User_in;
					}
					return _User_in_W;
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

			private WhereParameter _Idrastreo_referencias_W = null;
			private WhereParameter _Id_cliente_W = null;
			private WhereParameter _Nombre_W = null;
			private WhereParameter _Lon_W = null;
			private WhereParameter _Lat_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _Visible_W = null;
			private WhereParameter _User_in_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idrastreo_referencias_W = null;
				_Id_cliente_W = null;
				_Nombre_W = null;
				_Lon_W = null;
				_Lat_W = null;
				_Descripcion_W = null;
				_Visible_W = null;
				_User_in_W = null;
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
				
				
				public AggregateParameter Idrastreo_referencias
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_referencias, Parameters.Idrastreo_referencias);
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

				public AggregateParameter Nombre
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nombre, Parameters.Nombre);
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

				public AggregateParameter Descripcion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Descripcion, Parameters.Descripcion);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Visible
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Visible, Parameters.Visible);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter User_in
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.User_in, Parameters.User_in);
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
		
			public AggregateParameter Idrastreo_referencias
		    {
				get
		        {
					if(_Idrastreo_referencias_W == null)
	        	    {
						_Idrastreo_referencias_W = TearOff.Idrastreo_referencias;
					}
					return _Idrastreo_referencias_W;
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

			public AggregateParameter Visible
		    {
				get
		        {
					if(_Visible_W == null)
	        	    {
						_Visible_W = TearOff.Visible;
					}
					return _Visible_W;
				}
			}

			public AggregateParameter User_in
		    {
				get
		        {
					if(_User_in_W == null)
	        	    {
						_User_in_W = TearOff.User_in;
					}
					return _User_in_W;
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

			private AggregateParameter _Idrastreo_referencias_W = null;
			private AggregateParameter _Id_cliente_W = null;
			private AggregateParameter _Nombre_W = null;
			private AggregateParameter _Lon_W = null;
			private AggregateParameter _Lat_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _Visible_W = null;
			private AggregateParameter _User_in_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreo_referencias_W = null;
				_Id_cliente_W = null;
				_Nombre_W = null;
				_Lon_W = null;
				_Lat_W = null;
				_Descripcion_W = null;
				_Visible_W = null;
				_User_in_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_referencias_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreo_referencias.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_referencias_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_referencias_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreo_referencias);
			p.SourceColumn = ColumnNames.Idrastreo_referencias;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreo_referencias);
			p.SourceColumn = ColumnNames.Idrastreo_referencias;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_cliente);
			p.SourceColumn = ColumnNames.Id_cliente;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nombre);
			p.SourceColumn = ColumnNames.Nombre;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Lon);
			p.SourceColumn = ColumnNames.Lon;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Lat);
			p.SourceColumn = ColumnNames.Lat;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Descripcion);
			p.SourceColumn = ColumnNames.Descripcion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Visible);
			p.SourceColumn = ColumnNames.Visible;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.User_in);
			p.SourceColumn = ColumnNames.User_in;
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
