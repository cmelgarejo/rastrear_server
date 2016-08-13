
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_cliente_contactos.
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
	public abstract class _rastreo_cliente_contactos : PostgreSqlEntity
	{
		public _rastreo_cliente_contactos()
		{
			this.QuerySource = "rastreo_cliente_contactos";
			this.MappingName = "rastreo_cliente_contactos";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_cliente_contactos_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreo_cliente_contactos, int Rastreo_cliente_id_cliente)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreo_cliente_contactos, Idrastreo_cliente_contactos);

parameters.Add(Parameters.Rastreo_cliente_id_cliente, Rastreo_cliente_id_cliente);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_cliente_contactos_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreo_cliente_contactos
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_cliente_contactos", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Rastreo_cliente_id_cliente
			{
				get
				{
					return new NpgsqlParameter("Rastreo_cliente_id_cliente", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Nombre_apellido_razonsocial
			{
				get
				{
					return new NpgsqlParameter("Nombre_apellido_razonsocial", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Nrodoc_ruc
			{
				get
				{
					return new NpgsqlParameter("Nrodoc_ruc", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Relacion
			{
				get
				{
					return new NpgsqlParameter("Relacion", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Telefono
			{
				get
				{
					return new NpgsqlParameter("Telefono", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Email
			{
				get
				{
					return new NpgsqlParameter("Email", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Titular_secundario
			{
				get
				{
					return new NpgsqlParameter("Titular_secundario", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Autorizado
			{
				get
				{
					return new NpgsqlParameter("Autorizado", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
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
            public const string Idrastreo_cliente_contactos = "idrastreo_cliente_contactos";
            public const string Rastreo_cliente_id_cliente = "rastreo_cliente_id_cliente";
            public const string Nombre_apellido_razonsocial = "nombre_apellido_razonsocial";
            public const string Nrodoc_ruc = "nrodoc_ruc";
            public const string Relacion = "relacion";
            public const string Telefono = "telefono";
            public const string Email = "email";
            public const string Titular_secundario = "titular_secundario";
            public const string Autorizado = "autorizado";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_cliente_contactos] = _rastreo_cliente_contactos.PropertyNames.Idrastreo_cliente_contactos;
					ht[Rastreo_cliente_id_cliente] = _rastreo_cliente_contactos.PropertyNames.Rastreo_cliente_id_cliente;
					ht[Nombre_apellido_razonsocial] = _rastreo_cliente_contactos.PropertyNames.Nombre_apellido_razonsocial;
					ht[Nrodoc_ruc] = _rastreo_cliente_contactos.PropertyNames.Nrodoc_ruc;
					ht[Relacion] = _rastreo_cliente_contactos.PropertyNames.Relacion;
					ht[Telefono] = _rastreo_cliente_contactos.PropertyNames.Telefono;
					ht[Email] = _rastreo_cliente_contactos.PropertyNames.Email;
					ht[Titular_secundario] = _rastreo_cliente_contactos.PropertyNames.Titular_secundario;
					ht[Autorizado] = _rastreo_cliente_contactos.PropertyNames.Autorizado;
					ht[User_ins] = _rastreo_cliente_contactos.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_cliente_contactos.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_cliente_contactos.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_cliente_contactos.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreo_cliente_contactos = "Idrastreo_cliente_contactos";
            public const string Rastreo_cliente_id_cliente = "Rastreo_cliente_id_cliente";
            public const string Nombre_apellido_razonsocial = "Nombre_apellido_razonsocial";
            public const string Nrodoc_ruc = "Nrodoc_ruc";
            public const string Relacion = "Relacion";
            public const string Telefono = "Telefono";
            public const string Email = "Email";
            public const string Titular_secundario = "Titular_secundario";
            public const string Autorizado = "Autorizado";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_cliente_contactos] = _rastreo_cliente_contactos.ColumnNames.Idrastreo_cliente_contactos;
					ht[Rastreo_cliente_id_cliente] = _rastreo_cliente_contactos.ColumnNames.Rastreo_cliente_id_cliente;
					ht[Nombre_apellido_razonsocial] = _rastreo_cliente_contactos.ColumnNames.Nombre_apellido_razonsocial;
					ht[Nrodoc_ruc] = _rastreo_cliente_contactos.ColumnNames.Nrodoc_ruc;
					ht[Relacion] = _rastreo_cliente_contactos.ColumnNames.Relacion;
					ht[Telefono] = _rastreo_cliente_contactos.ColumnNames.Telefono;
					ht[Email] = _rastreo_cliente_contactos.ColumnNames.Email;
					ht[Titular_secundario] = _rastreo_cliente_contactos.ColumnNames.Titular_secundario;
					ht[Autorizado] = _rastreo_cliente_contactos.ColumnNames.Autorizado;
					ht[User_ins] = _rastreo_cliente_contactos.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_cliente_contactos.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_cliente_contactos.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_cliente_contactos.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreo_cliente_contactos = "s_Idrastreo_cliente_contactos";
            public const string Rastreo_cliente_id_cliente = "s_Rastreo_cliente_id_cliente";
            public const string Nombre_apellido_razonsocial = "s_Nombre_apellido_razonsocial";
            public const string Nrodoc_ruc = "s_Nrodoc_ruc";
            public const string Relacion = "s_Relacion";
            public const string Telefono = "s_Telefono";
            public const string Email = "s_Email";
            public const string Titular_secundario = "s_Titular_secundario";
            public const string Autorizado = "s_Autorizado";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreo_cliente_contactos
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_cliente_contactos);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_cliente_contactos, value);
			}
		}

		public virtual int Rastreo_cliente_id_cliente
	    {
			get
	        {
				return base.Getint(ColumnNames.Rastreo_cliente_id_cliente);
			}
			set
	        {
				base.Setint(ColumnNames.Rastreo_cliente_id_cliente, value);
			}
		}

		public virtual string Nombre_apellido_razonsocial
	    {
			get
	        {
				return base.Getstring(ColumnNames.Nombre_apellido_razonsocial);
			}
			set
	        {
				base.Setstring(ColumnNames.Nombre_apellido_razonsocial, value);
			}
		}

		public virtual string Nrodoc_ruc
	    {
			get
	        {
				return base.Getstring(ColumnNames.Nrodoc_ruc);
			}
			set
	        {
				base.Setstring(ColumnNames.Nrodoc_ruc, value);
			}
		}

		public virtual string Relacion
	    {
			get
	        {
				return base.Getstring(ColumnNames.Relacion);
			}
			set
	        {
				base.Setstring(ColumnNames.Relacion, value);
			}
		}

		public virtual string Telefono
	    {
			get
	        {
				return base.Getstring(ColumnNames.Telefono);
			}
			set
	        {
				base.Setstring(ColumnNames.Telefono, value);
			}
		}

		public virtual string Email
	    {
			get
	        {
				return base.Getstring(ColumnNames.Email);
			}
			set
	        {
				base.Setstring(ColumnNames.Email, value);
			}
		}

		public virtual bool Titular_secundario
	    {
			get
	        {
				return base.Getbool(ColumnNames.Titular_secundario);
			}
			set
	        {
				base.Setbool(ColumnNames.Titular_secundario, value);
			}
		}

		public virtual bool Autorizado
	    {
			get
	        {
				return base.Getbool(ColumnNames.Autorizado);
			}
			set
	        {
				base.Setbool(ColumnNames.Autorizado, value);
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
	
		public virtual string s_Idrastreo_cliente_contactos
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_cliente_contactos) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_cliente_contactos);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_cliente_contactos);
				else
					this.Idrastreo_cliente_contactos = base.SetintAsString(ColumnNames.Idrastreo_cliente_contactos, value);
			}
		}

		public virtual string s_Rastreo_cliente_id_cliente
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Rastreo_cliente_id_cliente) ? string.Empty : base.GetintAsString(ColumnNames.Rastreo_cliente_id_cliente);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Rastreo_cliente_id_cliente);
				else
					this.Rastreo_cliente_id_cliente = base.SetintAsString(ColumnNames.Rastreo_cliente_id_cliente, value);
			}
		}

		public virtual string s_Nombre_apellido_razonsocial
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Nombre_apellido_razonsocial) ? string.Empty : base.GetstringAsString(ColumnNames.Nombre_apellido_razonsocial);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nombre_apellido_razonsocial);
				else
					this.Nombre_apellido_razonsocial = base.SetstringAsString(ColumnNames.Nombre_apellido_razonsocial, value);
			}
		}

		public virtual string s_Nrodoc_ruc
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Nrodoc_ruc) ? string.Empty : base.GetstringAsString(ColumnNames.Nrodoc_ruc);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nrodoc_ruc);
				else
					this.Nrodoc_ruc = base.SetstringAsString(ColumnNames.Nrodoc_ruc, value);
			}
		}

		public virtual string s_Relacion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Relacion) ? string.Empty : base.GetstringAsString(ColumnNames.Relacion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Relacion);
				else
					this.Relacion = base.SetstringAsString(ColumnNames.Relacion, value);
			}
		}

		public virtual string s_Telefono
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Telefono) ? string.Empty : base.GetstringAsString(ColumnNames.Telefono);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Telefono);
				else
					this.Telefono = base.SetstringAsString(ColumnNames.Telefono, value);
			}
		}

		public virtual string s_Email
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Email) ? string.Empty : base.GetstringAsString(ColumnNames.Email);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Email);
				else
					this.Email = base.SetstringAsString(ColumnNames.Email, value);
			}
		}

		public virtual string s_Titular_secundario
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Titular_secundario) ? string.Empty : base.GetboolAsString(ColumnNames.Titular_secundario);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Titular_secundario);
				else
					this.Titular_secundario = base.SetboolAsString(ColumnNames.Titular_secundario, value);
			}
		}

		public virtual string s_Autorizado
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Autorizado) ? string.Empty : base.GetboolAsString(ColumnNames.Autorizado);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Autorizado);
				else
					this.Autorizado = base.SetboolAsString(ColumnNames.Autorizado, value);
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
				
				
				public WhereParameter Idrastreo_cliente_contactos
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_cliente_contactos, Parameters.Idrastreo_cliente_contactos);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Rastreo_cliente_id_cliente
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Rastreo_cliente_id_cliente, Parameters.Rastreo_cliente_id_cliente);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Nombre_apellido_razonsocial
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nombre_apellido_razonsocial, Parameters.Nombre_apellido_razonsocial);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Nrodoc_ruc
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nrodoc_ruc, Parameters.Nrodoc_ruc);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Relacion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Relacion, Parameters.Relacion);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Telefono
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Telefono, Parameters.Telefono);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Email
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Email, Parameters.Email);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Titular_secundario
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Titular_secundario, Parameters.Titular_secundario);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Autorizado
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Autorizado, Parameters.Autorizado);
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
		
			public WhereParameter Idrastreo_cliente_contactos
		    {
				get
		        {
					if(_Idrastreo_cliente_contactos_W == null)
	        	    {
						_Idrastreo_cliente_contactos_W = TearOff.Idrastreo_cliente_contactos;
					}
					return _Idrastreo_cliente_contactos_W;
				}
			}

			public WhereParameter Rastreo_cliente_id_cliente
		    {
				get
		        {
					if(_Rastreo_cliente_id_cliente_W == null)
	        	    {
						_Rastreo_cliente_id_cliente_W = TearOff.Rastreo_cliente_id_cliente;
					}
					return _Rastreo_cliente_id_cliente_W;
				}
			}

			public WhereParameter Nombre_apellido_razonsocial
		    {
				get
		        {
					if(_Nombre_apellido_razonsocial_W == null)
	        	    {
						_Nombre_apellido_razonsocial_W = TearOff.Nombre_apellido_razonsocial;
					}
					return _Nombre_apellido_razonsocial_W;
				}
			}

			public WhereParameter Nrodoc_ruc
		    {
				get
		        {
					if(_Nrodoc_ruc_W == null)
	        	    {
						_Nrodoc_ruc_W = TearOff.Nrodoc_ruc;
					}
					return _Nrodoc_ruc_W;
				}
			}

			public WhereParameter Relacion
		    {
				get
		        {
					if(_Relacion_W == null)
	        	    {
						_Relacion_W = TearOff.Relacion;
					}
					return _Relacion_W;
				}
			}

			public WhereParameter Telefono
		    {
				get
		        {
					if(_Telefono_W == null)
	        	    {
						_Telefono_W = TearOff.Telefono;
					}
					return _Telefono_W;
				}
			}

			public WhereParameter Email
		    {
				get
		        {
					if(_Email_W == null)
	        	    {
						_Email_W = TearOff.Email;
					}
					return _Email_W;
				}
			}

			public WhereParameter Titular_secundario
		    {
				get
		        {
					if(_Titular_secundario_W == null)
	        	    {
						_Titular_secundario_W = TearOff.Titular_secundario;
					}
					return _Titular_secundario_W;
				}
			}

			public WhereParameter Autorizado
		    {
				get
		        {
					if(_Autorizado_W == null)
	        	    {
						_Autorizado_W = TearOff.Autorizado;
					}
					return _Autorizado_W;
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

			private WhereParameter _Idrastreo_cliente_contactos_W = null;
			private WhereParameter _Rastreo_cliente_id_cliente_W = null;
			private WhereParameter _Nombre_apellido_razonsocial_W = null;
			private WhereParameter _Nrodoc_ruc_W = null;
			private WhereParameter _Relacion_W = null;
			private WhereParameter _Telefono_W = null;
			private WhereParameter _Email_W = null;
			private WhereParameter _Titular_secundario_W = null;
			private WhereParameter _Autorizado_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idrastreo_cliente_contactos_W = null;
				_Rastreo_cliente_id_cliente_W = null;
				_Nombre_apellido_razonsocial_W = null;
				_Nrodoc_ruc_W = null;
				_Relacion_W = null;
				_Telefono_W = null;
				_Email_W = null;
				_Titular_secundario_W = null;
				_Autorizado_W = null;
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
				
				
				public AggregateParameter Idrastreo_cliente_contactos
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_cliente_contactos, Parameters.Idrastreo_cliente_contactos);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Rastreo_cliente_id_cliente
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Rastreo_cliente_id_cliente, Parameters.Rastreo_cliente_id_cliente);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Nombre_apellido_razonsocial
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nombre_apellido_razonsocial, Parameters.Nombre_apellido_razonsocial);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Nrodoc_ruc
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nrodoc_ruc, Parameters.Nrodoc_ruc);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Relacion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Relacion, Parameters.Relacion);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Telefono
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Telefono, Parameters.Telefono);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Email
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Email, Parameters.Email);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Titular_secundario
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Titular_secundario, Parameters.Titular_secundario);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Autorizado
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Autorizado, Parameters.Autorizado);
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
		
			public AggregateParameter Idrastreo_cliente_contactos
		    {
				get
		        {
					if(_Idrastreo_cliente_contactos_W == null)
	        	    {
						_Idrastreo_cliente_contactos_W = TearOff.Idrastreo_cliente_contactos;
					}
					return _Idrastreo_cliente_contactos_W;
				}
			}

			public AggregateParameter Rastreo_cliente_id_cliente
		    {
				get
		        {
					if(_Rastreo_cliente_id_cliente_W == null)
	        	    {
						_Rastreo_cliente_id_cliente_W = TearOff.Rastreo_cliente_id_cliente;
					}
					return _Rastreo_cliente_id_cliente_W;
				}
			}

			public AggregateParameter Nombre_apellido_razonsocial
		    {
				get
		        {
					if(_Nombre_apellido_razonsocial_W == null)
	        	    {
						_Nombre_apellido_razonsocial_W = TearOff.Nombre_apellido_razonsocial;
					}
					return _Nombre_apellido_razonsocial_W;
				}
			}

			public AggregateParameter Nrodoc_ruc
		    {
				get
		        {
					if(_Nrodoc_ruc_W == null)
	        	    {
						_Nrodoc_ruc_W = TearOff.Nrodoc_ruc;
					}
					return _Nrodoc_ruc_W;
				}
			}

			public AggregateParameter Relacion
		    {
				get
		        {
					if(_Relacion_W == null)
	        	    {
						_Relacion_W = TearOff.Relacion;
					}
					return _Relacion_W;
				}
			}

			public AggregateParameter Telefono
		    {
				get
		        {
					if(_Telefono_W == null)
	        	    {
						_Telefono_W = TearOff.Telefono;
					}
					return _Telefono_W;
				}
			}

			public AggregateParameter Email
		    {
				get
		        {
					if(_Email_W == null)
	        	    {
						_Email_W = TearOff.Email;
					}
					return _Email_W;
				}
			}

			public AggregateParameter Titular_secundario
		    {
				get
		        {
					if(_Titular_secundario_W == null)
	        	    {
						_Titular_secundario_W = TearOff.Titular_secundario;
					}
					return _Titular_secundario_W;
				}
			}

			public AggregateParameter Autorizado
		    {
				get
		        {
					if(_Autorizado_W == null)
	        	    {
						_Autorizado_W = TearOff.Autorizado;
					}
					return _Autorizado_W;
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

			private AggregateParameter _Idrastreo_cliente_contactos_W = null;
			private AggregateParameter _Rastreo_cliente_id_cliente_W = null;
			private AggregateParameter _Nombre_apellido_razonsocial_W = null;
			private AggregateParameter _Nrodoc_ruc_W = null;
			private AggregateParameter _Relacion_W = null;
			private AggregateParameter _Telefono_W = null;
			private AggregateParameter _Email_W = null;
			private AggregateParameter _Titular_secundario_W = null;
			private AggregateParameter _Autorizado_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreo_cliente_contactos_W = null;
				_Rastreo_cliente_id_cliente_W = null;
				_Nombre_apellido_razonsocial_W = null;
				_Nrodoc_ruc_W = null;
				_Relacion_W = null;
				_Telefono_W = null;
				_Email_W = null;
				_Titular_secundario_W = null;
				_Autorizado_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_cliente_contactos_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreo_cliente_contactos.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_cliente_contactos_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_cliente_contactos_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreo_cliente_contactos);
			p.SourceColumn = ColumnNames.Idrastreo_cliente_contactos;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Rastreo_cliente_id_cliente);
			p.SourceColumn = ColumnNames.Rastreo_cliente_id_cliente;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreo_cliente_contactos);
			p.SourceColumn = ColumnNames.Idrastreo_cliente_contactos;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Rastreo_cliente_id_cliente);
			p.SourceColumn = ColumnNames.Rastreo_cliente_id_cliente;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nombre_apellido_razonsocial);
			p.SourceColumn = ColumnNames.Nombre_apellido_razonsocial;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nrodoc_ruc);
			p.SourceColumn = ColumnNames.Nrodoc_ruc;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Relacion);
			p.SourceColumn = ColumnNames.Relacion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Telefono);
			p.SourceColumn = ColumnNames.Telefono;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Email);
			p.SourceColumn = ColumnNames.Email;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Titular_secundario);
			p.SourceColumn = ColumnNames.Titular_secundario;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Autorizado);
			p.SourceColumn = ColumnNames.Autorizado;
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
