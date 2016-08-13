
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_hoja_de_ruta.
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
	public abstract class _rastreo_hoja_de_ruta : PostgreSqlEntity
	{
		public _rastreo_hoja_de_ruta()
		{
			this.QuerySource = "rastreo_hoja_de_ruta";
			this.MappingName = "rastreo_hoja_de_ruta";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_hoja_de_ruta_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idhoja_de_ruta)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idhoja_de_ruta, Idhoja_de_ruta);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_hoja_de_ruta_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idhoja_de_ruta
			{
				get
				{
					return new NpgsqlParameter("Idhoja_de_ruta", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_usuario
			{
				get
				{
					return new NpgsqlParameter("Id_usuario", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Descripcion
			{
				get
				{
					return new NpgsqlParameter("Descripcion", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Activa
			{
				get
				{
					return new NpgsqlParameter("Activa", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Hora_activacion
			{
				get
				{
					return new NpgsqlParameter("Hora_activacion", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
			public static NpgsqlParameter Hora_desactivacion
			{
				get
				{
					return new NpgsqlParameter("Hora_desactivacion", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
			public static NpgsqlParameter Mails
			{
				get
				{
					return new NpgsqlParameter("Mails", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Tel_movil
			{
				get
				{
					return new NpgsqlParameter("Tel_movil", NpgsqlTypes.NpgsqlDbType.Text, 0);
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
            public const string Idhoja_de_ruta = "idhoja_de_ruta";
            public const string Id_usuario = "id_usuario";
            public const string Descripcion = "descripcion";
            public const string Activa = "activa";
            public const string Hora_activacion = "hora_activacion";
            public const string Hora_desactivacion = "hora_desactivacion";
            public const string Mails = "mails";
            public const string Tel_movil = "tel_movil";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idhoja_de_ruta] = _rastreo_hoja_de_ruta.PropertyNames.Idhoja_de_ruta;
					ht[Id_usuario] = _rastreo_hoja_de_ruta.PropertyNames.Id_usuario;
					ht[Descripcion] = _rastreo_hoja_de_ruta.PropertyNames.Descripcion;
					ht[Activa] = _rastreo_hoja_de_ruta.PropertyNames.Activa;
					ht[Hora_activacion] = _rastreo_hoja_de_ruta.PropertyNames.Hora_activacion;
					ht[Hora_desactivacion] = _rastreo_hoja_de_ruta.PropertyNames.Hora_desactivacion;
					ht[Mails] = _rastreo_hoja_de_ruta.PropertyNames.Mails;
					ht[Tel_movil] = _rastreo_hoja_de_ruta.PropertyNames.Tel_movil;
					ht[User_ins] = _rastreo_hoja_de_ruta.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_hoja_de_ruta.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_hoja_de_ruta.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_hoja_de_ruta.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idhoja_de_ruta = "Idhoja_de_ruta";
            public const string Id_usuario = "Id_usuario";
            public const string Descripcion = "Descripcion";
            public const string Activa = "Activa";
            public const string Hora_activacion = "Hora_activacion";
            public const string Hora_desactivacion = "Hora_desactivacion";
            public const string Mails = "Mails";
            public const string Tel_movil = "Tel_movil";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idhoja_de_ruta] = _rastreo_hoja_de_ruta.ColumnNames.Idhoja_de_ruta;
					ht[Id_usuario] = _rastreo_hoja_de_ruta.ColumnNames.Id_usuario;
					ht[Descripcion] = _rastreo_hoja_de_ruta.ColumnNames.Descripcion;
					ht[Activa] = _rastreo_hoja_de_ruta.ColumnNames.Activa;
					ht[Hora_activacion] = _rastreo_hoja_de_ruta.ColumnNames.Hora_activacion;
					ht[Hora_desactivacion] = _rastreo_hoja_de_ruta.ColumnNames.Hora_desactivacion;
					ht[Mails] = _rastreo_hoja_de_ruta.ColumnNames.Mails;
					ht[Tel_movil] = _rastreo_hoja_de_ruta.ColumnNames.Tel_movil;
					ht[User_ins] = _rastreo_hoja_de_ruta.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_hoja_de_ruta.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_hoja_de_ruta.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_hoja_de_ruta.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idhoja_de_ruta = "s_Idhoja_de_ruta";
            public const string Id_usuario = "s_Id_usuario";
            public const string Descripcion = "s_Descripcion";
            public const string Activa = "s_Activa";
            public const string Hora_activacion = "s_Hora_activacion";
            public const string Hora_desactivacion = "s_Hora_desactivacion";
            public const string Mails = "s_Mails";
            public const string Tel_movil = "s_Tel_movil";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
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

		public virtual int Id_usuario
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_usuario);
			}
			set
	        {
				base.Setint(ColumnNames.Id_usuario, value);
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

		public virtual bool Activa
	    {
			get
	        {
				return base.Getbool(ColumnNames.Activa);
			}
			set
	        {
				base.Setbool(ColumnNames.Activa, value);
			}
		}

		public virtual DateTime Hora_activacion
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Hora_activacion);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Hora_activacion, value);
			}
		}

		public virtual DateTime Hora_desactivacion
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Hora_desactivacion);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Hora_desactivacion, value);
			}
		}

		public virtual string Mails
	    {
			get
	        {
				return base.Getstring(ColumnNames.Mails);
			}
			set
	        {
				base.Setstring(ColumnNames.Mails, value);
			}
		}

		public virtual string Tel_movil
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tel_movil);
			}
			set
	        {
				base.Setstring(ColumnNames.Tel_movil, value);
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

		public virtual string s_Id_usuario
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_usuario) ? string.Empty : base.GetintAsString(ColumnNames.Id_usuario);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_usuario);
				else
					this.Id_usuario = base.SetintAsString(ColumnNames.Id_usuario, value);
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

		public virtual string s_Activa
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Activa) ? string.Empty : base.GetboolAsString(ColumnNames.Activa);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Activa);
				else
					this.Activa = base.SetboolAsString(ColumnNames.Activa, value);
			}
		}

		public virtual string s_Hora_activacion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Hora_activacion) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Hora_activacion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Hora_activacion);
				else
					this.Hora_activacion = base.SetDateTimeAsString(ColumnNames.Hora_activacion, value);
			}
		}

		public virtual string s_Hora_desactivacion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Hora_desactivacion) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Hora_desactivacion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Hora_desactivacion);
				else
					this.Hora_desactivacion = base.SetDateTimeAsString(ColumnNames.Hora_desactivacion, value);
			}
		}

		public virtual string s_Mails
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Mails) ? string.Empty : base.GetstringAsString(ColumnNames.Mails);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Mails);
				else
					this.Mails = base.SetstringAsString(ColumnNames.Mails, value);
			}
		}

		public virtual string s_Tel_movil
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tel_movil) ? string.Empty : base.GetstringAsString(ColumnNames.Tel_movil);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tel_movil);
				else
					this.Tel_movil = base.SetstringAsString(ColumnNames.Tel_movil, value);
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
				
				
				public WhereParameter Idhoja_de_ruta
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idhoja_de_ruta, Parameters.Idhoja_de_ruta);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_usuario
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_usuario, Parameters.Id_usuario);
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

				public WhereParameter Activa
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Activa, Parameters.Activa);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Hora_activacion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Hora_activacion, Parameters.Hora_activacion);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Hora_desactivacion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Hora_desactivacion, Parameters.Hora_desactivacion);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Mails
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Mails, Parameters.Mails);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Tel_movil
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tel_movil, Parameters.Tel_movil);
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

			public WhereParameter Id_usuario
		    {
				get
		        {
					if(_Id_usuario_W == null)
	        	    {
						_Id_usuario_W = TearOff.Id_usuario;
					}
					return _Id_usuario_W;
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

			public WhereParameter Activa
		    {
				get
		        {
					if(_Activa_W == null)
	        	    {
						_Activa_W = TearOff.Activa;
					}
					return _Activa_W;
				}
			}

			public WhereParameter Hora_activacion
		    {
				get
		        {
					if(_Hora_activacion_W == null)
	        	    {
						_Hora_activacion_W = TearOff.Hora_activacion;
					}
					return _Hora_activacion_W;
				}
			}

			public WhereParameter Hora_desactivacion
		    {
				get
		        {
					if(_Hora_desactivacion_W == null)
	        	    {
						_Hora_desactivacion_W = TearOff.Hora_desactivacion;
					}
					return _Hora_desactivacion_W;
				}
			}

			public WhereParameter Mails
		    {
				get
		        {
					if(_Mails_W == null)
	        	    {
						_Mails_W = TearOff.Mails;
					}
					return _Mails_W;
				}
			}

			public WhereParameter Tel_movil
		    {
				get
		        {
					if(_Tel_movil_W == null)
	        	    {
						_Tel_movil_W = TearOff.Tel_movil;
					}
					return _Tel_movil_W;
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

			private WhereParameter _Idhoja_de_ruta_W = null;
			private WhereParameter _Id_usuario_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _Activa_W = null;
			private WhereParameter _Hora_activacion_W = null;
			private WhereParameter _Hora_desactivacion_W = null;
			private WhereParameter _Mails_W = null;
			private WhereParameter _Tel_movil_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idhoja_de_ruta_W = null;
				_Id_usuario_W = null;
				_Descripcion_W = null;
				_Activa_W = null;
				_Hora_activacion_W = null;
				_Hora_desactivacion_W = null;
				_Mails_W = null;
				_Tel_movil_W = null;
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
				
				
				public AggregateParameter Idhoja_de_ruta
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idhoja_de_ruta, Parameters.Idhoja_de_ruta);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_usuario
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_usuario, Parameters.Id_usuario);
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

				public AggregateParameter Activa
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Activa, Parameters.Activa);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Hora_activacion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Hora_activacion, Parameters.Hora_activacion);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Hora_desactivacion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Hora_desactivacion, Parameters.Hora_desactivacion);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Mails
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Mails, Parameters.Mails);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Tel_movil
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tel_movil, Parameters.Tel_movil);
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

			public AggregateParameter Id_usuario
		    {
				get
		        {
					if(_Id_usuario_W == null)
	        	    {
						_Id_usuario_W = TearOff.Id_usuario;
					}
					return _Id_usuario_W;
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

			public AggregateParameter Activa
		    {
				get
		        {
					if(_Activa_W == null)
	        	    {
						_Activa_W = TearOff.Activa;
					}
					return _Activa_W;
				}
			}

			public AggregateParameter Hora_activacion
		    {
				get
		        {
					if(_Hora_activacion_W == null)
	        	    {
						_Hora_activacion_W = TearOff.Hora_activacion;
					}
					return _Hora_activacion_W;
				}
			}

			public AggregateParameter Hora_desactivacion
		    {
				get
		        {
					if(_Hora_desactivacion_W == null)
	        	    {
						_Hora_desactivacion_W = TearOff.Hora_desactivacion;
					}
					return _Hora_desactivacion_W;
				}
			}

			public AggregateParameter Mails
		    {
				get
		        {
					if(_Mails_W == null)
	        	    {
						_Mails_W = TearOff.Mails;
					}
					return _Mails_W;
				}
			}

			public AggregateParameter Tel_movil
		    {
				get
		        {
					if(_Tel_movil_W == null)
	        	    {
						_Tel_movil_W = TearOff.Tel_movil;
					}
					return _Tel_movil_W;
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

			private AggregateParameter _Idhoja_de_ruta_W = null;
			private AggregateParameter _Id_usuario_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _Activa_W = null;
			private AggregateParameter _Hora_activacion_W = null;
			private AggregateParameter _Hora_desactivacion_W = null;
			private AggregateParameter _Mails_W = null;
			private AggregateParameter _Tel_movil_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idhoja_de_ruta_W = null;
				_Id_usuario_W = null;
				_Descripcion_W = null;
				_Activa_W = null;
				_Hora_activacion_W = null;
				_Hora_desactivacion_W = null;
				_Mails_W = null;
				_Tel_movil_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_hoja_de_ruta_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idhoja_de_ruta.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_hoja_de_ruta_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_hoja_de_ruta_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idhoja_de_ruta);
			p.SourceColumn = ColumnNames.Idhoja_de_ruta;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idhoja_de_ruta);
			p.SourceColumn = ColumnNames.Idhoja_de_ruta;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_usuario);
			p.SourceColumn = ColumnNames.Id_usuario;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Descripcion);
			p.SourceColumn = ColumnNames.Descripcion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Activa);
			p.SourceColumn = ColumnNames.Activa;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Hora_activacion);
			p.SourceColumn = ColumnNames.Hora_activacion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Hora_desactivacion);
			p.SourceColumn = ColumnNames.Hora_desactivacion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Mails);
			p.SourceColumn = ColumnNames.Mails;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Tel_movil);
			p.SourceColumn = ColumnNames.Tel_movil;
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
