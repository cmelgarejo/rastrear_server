
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_template_puntos_hoja_de_ruta.
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
	public abstract class _rastreo_template_puntos_hoja_de_ruta : PostgreSqlEntity
	{
		public _rastreo_template_puntos_hoja_de_ruta()
		{
			this.QuerySource = "rastreo_template_puntos_hoja_de_ruta";
			this.MappingName = "rastreo_template_puntos_hoja_de_ruta";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_template_puntos_hoja_de_ruta_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Id_puntostemplate)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Id_puntostemplate, Id_puntostemplate);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_template_puntos_hoja_de_ruta_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Id_puntostemplate
			{
				get
				{
					return new NpgsqlParameter("Id_puntostemplate", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_recorridotemplate
			{
				get
				{
					return new NpgsqlParameter("Id_recorridotemplate", NpgsqlTypes.NpgsqlDbType.Integer, 0);
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
			
			public static NpgsqlParameter Metros
			{
				get
				{
					return new NpgsqlParameter("Metros", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Avisar_ingreso
			{
				get
				{
					return new NpgsqlParameter("Avisar_ingreso", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Emails
			{
				get
				{
					return new NpgsqlParameter("Emails", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Id_puntostemplate = "id_puntostemplate";
            public const string Id_recorridotemplate = "id_recorridotemplate";
            public const string Nombre = "nombre";
            public const string Descripcion = "descripcion";
            public const string Lon = "lon";
            public const string Lat = "lat";
            public const string Metros = "metros";
            public const string Avisar_ingreso = "avisar_ingreso";
            public const string Emails = "emails";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_puntostemplate] = _rastreo_template_puntos_hoja_de_ruta.PropertyNames.Id_puntostemplate;
					ht[Id_recorridotemplate] = _rastreo_template_puntos_hoja_de_ruta.PropertyNames.Id_recorridotemplate;
					ht[Nombre] = _rastreo_template_puntos_hoja_de_ruta.PropertyNames.Nombre;
					ht[Descripcion] = _rastreo_template_puntos_hoja_de_ruta.PropertyNames.Descripcion;
					ht[Lon] = _rastreo_template_puntos_hoja_de_ruta.PropertyNames.Lon;
					ht[Lat] = _rastreo_template_puntos_hoja_de_ruta.PropertyNames.Lat;
					ht[Metros] = _rastreo_template_puntos_hoja_de_ruta.PropertyNames.Metros;
					ht[Avisar_ingreso] = _rastreo_template_puntos_hoja_de_ruta.PropertyNames.Avisar_ingreso;
					ht[Emails] = _rastreo_template_puntos_hoja_de_ruta.PropertyNames.Emails;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Id_puntostemplate = "Id_puntostemplate";
            public const string Id_recorridotemplate = "Id_recorridotemplate";
            public const string Nombre = "Nombre";
            public const string Descripcion = "Descripcion";
            public const string Lon = "Lon";
            public const string Lat = "Lat";
            public const string Metros = "Metros";
            public const string Avisar_ingreso = "Avisar_ingreso";
            public const string Emails = "Emails";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_puntostemplate] = _rastreo_template_puntos_hoja_de_ruta.ColumnNames.Id_puntostemplate;
					ht[Id_recorridotemplate] = _rastreo_template_puntos_hoja_de_ruta.ColumnNames.Id_recorridotemplate;
					ht[Nombre] = _rastreo_template_puntos_hoja_de_ruta.ColumnNames.Nombre;
					ht[Descripcion] = _rastreo_template_puntos_hoja_de_ruta.ColumnNames.Descripcion;
					ht[Lon] = _rastreo_template_puntos_hoja_de_ruta.ColumnNames.Lon;
					ht[Lat] = _rastreo_template_puntos_hoja_de_ruta.ColumnNames.Lat;
					ht[Metros] = _rastreo_template_puntos_hoja_de_ruta.ColumnNames.Metros;
					ht[Avisar_ingreso] = _rastreo_template_puntos_hoja_de_ruta.ColumnNames.Avisar_ingreso;
					ht[Emails] = _rastreo_template_puntos_hoja_de_ruta.ColumnNames.Emails;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Id_puntostemplate = "s_Id_puntostemplate";
            public const string Id_recorridotemplate = "s_Id_recorridotemplate";
            public const string Nombre = "s_Nombre";
            public const string Descripcion = "s_Descripcion";
            public const string Lon = "s_Lon";
            public const string Lat = "s_Lat";
            public const string Metros = "s_Metros";
            public const string Avisar_ingreso = "s_Avisar_ingreso";
            public const string Emails = "s_Emails";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Id_puntostemplate
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_puntostemplate);
			}
			set
	        {
				base.Setint(ColumnNames.Id_puntostemplate, value);
			}
		}

		public virtual int Id_recorridotemplate
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_recorridotemplate);
			}
			set
	        {
				base.Setint(ColumnNames.Id_recorridotemplate, value);
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

		public virtual int Metros
	    {
			get
	        {
				return base.Getint(ColumnNames.Metros);
			}
			set
	        {
				base.Setint(ColumnNames.Metros, value);
			}
		}

		public virtual bool Avisar_ingreso
	    {
			get
	        {
				return base.Getbool(ColumnNames.Avisar_ingreso);
			}
			set
	        {
				base.Setbool(ColumnNames.Avisar_ingreso, value);
			}
		}

		public virtual string Emails
	    {
			get
	        {
				return base.Getstring(ColumnNames.Emails);
			}
			set
	        {
				base.Setstring(ColumnNames.Emails, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Id_puntostemplate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_puntostemplate) ? string.Empty : base.GetintAsString(ColumnNames.Id_puntostemplate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_puntostemplate);
				else
					this.Id_puntostemplate = base.SetintAsString(ColumnNames.Id_puntostemplate, value);
			}
		}

		public virtual string s_Id_recorridotemplate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_recorridotemplate) ? string.Empty : base.GetintAsString(ColumnNames.Id_recorridotemplate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_recorridotemplate);
				else
					this.Id_recorridotemplate = base.SetintAsString(ColumnNames.Id_recorridotemplate, value);
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

		public virtual string s_Metros
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Metros) ? string.Empty : base.GetintAsString(ColumnNames.Metros);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Metros);
				else
					this.Metros = base.SetintAsString(ColumnNames.Metros, value);
			}
		}

		public virtual string s_Avisar_ingreso
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Avisar_ingreso) ? string.Empty : base.GetboolAsString(ColumnNames.Avisar_ingreso);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Avisar_ingreso);
				else
					this.Avisar_ingreso = base.SetboolAsString(ColumnNames.Avisar_ingreso, value);
			}
		}

		public virtual string s_Emails
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Emails) ? string.Empty : base.GetstringAsString(ColumnNames.Emails);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Emails);
				else
					this.Emails = base.SetstringAsString(ColumnNames.Emails, value);
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
				
				
				public WhereParameter Id_puntostemplate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_puntostemplate, Parameters.Id_puntostemplate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_recorridotemplate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_recorridotemplate, Parameters.Id_recorridotemplate);
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

				public WhereParameter Metros
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Metros, Parameters.Metros);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Avisar_ingreso
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Avisar_ingreso, Parameters.Avisar_ingreso);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Emails
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Emails, Parameters.Emails);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Id_puntostemplate
		    {
				get
		        {
					if(_Id_puntostemplate_W == null)
	        	    {
						_Id_puntostemplate_W = TearOff.Id_puntostemplate;
					}
					return _Id_puntostemplate_W;
				}
			}

			public WhereParameter Id_recorridotemplate
		    {
				get
		        {
					if(_Id_recorridotemplate_W == null)
	        	    {
						_Id_recorridotemplate_W = TearOff.Id_recorridotemplate;
					}
					return _Id_recorridotemplate_W;
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

			public WhereParameter Metros
		    {
				get
		        {
					if(_Metros_W == null)
	        	    {
						_Metros_W = TearOff.Metros;
					}
					return _Metros_W;
				}
			}

			public WhereParameter Avisar_ingreso
		    {
				get
		        {
					if(_Avisar_ingreso_W == null)
	        	    {
						_Avisar_ingreso_W = TearOff.Avisar_ingreso;
					}
					return _Avisar_ingreso_W;
				}
			}

			public WhereParameter Emails
		    {
				get
		        {
					if(_Emails_W == null)
	        	    {
						_Emails_W = TearOff.Emails;
					}
					return _Emails_W;
				}
			}

			private WhereParameter _Id_puntostemplate_W = null;
			private WhereParameter _Id_recorridotemplate_W = null;
			private WhereParameter _Nombre_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _Lon_W = null;
			private WhereParameter _Lat_W = null;
			private WhereParameter _Metros_W = null;
			private WhereParameter _Avisar_ingreso_W = null;
			private WhereParameter _Emails_W = null;

			public void WhereClauseReset()
			{
				_Id_puntostemplate_W = null;
				_Id_recorridotemplate_W = null;
				_Nombre_W = null;
				_Descripcion_W = null;
				_Lon_W = null;
				_Lat_W = null;
				_Metros_W = null;
				_Avisar_ingreso_W = null;
				_Emails_W = null;

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
				
				
				public AggregateParameter Id_puntostemplate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_puntostemplate, Parameters.Id_puntostemplate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_recorridotemplate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_recorridotemplate, Parameters.Id_recorridotemplate);
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

				public AggregateParameter Metros
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Metros, Parameters.Metros);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Avisar_ingreso
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Avisar_ingreso, Parameters.Avisar_ingreso);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Emails
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Emails, Parameters.Emails);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Id_puntostemplate
		    {
				get
		        {
					if(_Id_puntostemplate_W == null)
	        	    {
						_Id_puntostemplate_W = TearOff.Id_puntostemplate;
					}
					return _Id_puntostemplate_W;
				}
			}

			public AggregateParameter Id_recorridotemplate
		    {
				get
		        {
					if(_Id_recorridotemplate_W == null)
	        	    {
						_Id_recorridotemplate_W = TearOff.Id_recorridotemplate;
					}
					return _Id_recorridotemplate_W;
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

			public AggregateParameter Metros
		    {
				get
		        {
					if(_Metros_W == null)
	        	    {
						_Metros_W = TearOff.Metros;
					}
					return _Metros_W;
				}
			}

			public AggregateParameter Avisar_ingreso
		    {
				get
		        {
					if(_Avisar_ingreso_W == null)
	        	    {
						_Avisar_ingreso_W = TearOff.Avisar_ingreso;
					}
					return _Avisar_ingreso_W;
				}
			}

			public AggregateParameter Emails
		    {
				get
		        {
					if(_Emails_W == null)
	        	    {
						_Emails_W = TearOff.Emails;
					}
					return _Emails_W;
				}
			}

			private AggregateParameter _Id_puntostemplate_W = null;
			private AggregateParameter _Id_recorridotemplate_W = null;
			private AggregateParameter _Nombre_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _Lon_W = null;
			private AggregateParameter _Lat_W = null;
			private AggregateParameter _Metros_W = null;
			private AggregateParameter _Avisar_ingreso_W = null;
			private AggregateParameter _Emails_W = null;

			public void AggregateClauseReset()
			{
				_Id_puntostemplate_W = null;
				_Id_recorridotemplate_W = null;
				_Nombre_W = null;
				_Descripcion_W = null;
				_Lon_W = null;
				_Lat_W = null;
				_Metros_W = null;
				_Avisar_ingreso_W = null;
				_Emails_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_template_puntos_hoja_de_ruta_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Id_puntostemplate.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_template_puntos_hoja_de_ruta_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_template_puntos_hoja_de_ruta_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Id_puntostemplate);
			p.SourceColumn = ColumnNames.Id_puntostemplate;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Id_puntostemplate);
			p.SourceColumn = ColumnNames.Id_puntostemplate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_recorridotemplate);
			p.SourceColumn = ColumnNames.Id_recorridotemplate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nombre);
			p.SourceColumn = ColumnNames.Nombre;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Descripcion);
			p.SourceColumn = ColumnNames.Descripcion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Lon);
			p.SourceColumn = ColumnNames.Lon;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Lat);
			p.SourceColumn = ColumnNames.Lat;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Metros);
			p.SourceColumn = ColumnNames.Metros;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Avisar_ingreso);
			p.SourceColumn = ColumnNames.Avisar_ingreso;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Emails);
			p.SourceColumn = ColumnNames.Emails;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
