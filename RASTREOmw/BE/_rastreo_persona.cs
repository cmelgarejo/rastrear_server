
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_persona.
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
	public abstract class _rastreo_persona : PostgreSqlEntity
	{
		public _rastreo_persona()
		{
			this.QuerySource = "rastreo_persona";
			this.MappingName = "rastreo_persona";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_persona_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreo_persona)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreo_persona, Idrastreo_persona);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_persona_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreo_persona
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_persona", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_distrito
			{
				get
				{
					return new NpgsqlParameter("Id_distrito", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_pais
			{
				get
				{
					return new NpgsqlParameter("Id_pais", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_ciudad
			{
				get
				{
					return new NpgsqlParameter("Id_ciudad", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Tipo_documento
			{
				get
				{
					return new NpgsqlParameter("Tipo_documento", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Tipo_persona
			{
				get
				{
					return new NpgsqlParameter("Tipo_persona", NpgsqlTypes.NpgsqlDbType.Text, 1);
				}
			}
			
			public static NpgsqlParameter Nro_documento
			{
				get
				{
					return new NpgsqlParameter("Nro_documento", NpgsqlTypes.NpgsqlDbType.Varchar, 100);
				}
			}
			
			public static NpgsqlParameter Razon_social
			{
				get
				{
					return new NpgsqlParameter("Razon_social", NpgsqlTypes.NpgsqlDbType.Varchar, 255);
				}
			}
			
			public static NpgsqlParameter Nombre
			{
				get
				{
					return new NpgsqlParameter("Nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 255);
				}
			}
			
			public static NpgsqlParameter Apellido
			{
				get
				{
					return new NpgsqlParameter("Apellido", NpgsqlTypes.NpgsqlDbType.Varchar, 255);
				}
			}
			
			public static NpgsqlParameter Direccion
			{
				get
				{
					return new NpgsqlParameter("Direccion", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Email
			{
				get
				{
					return new NpgsqlParameter("Email", NpgsqlTypes.NpgsqlDbType.Text, 0);
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
			
			public static NpgsqlParameter Tel_ofi
			{
				get
				{
					return new NpgsqlParameter("Tel_ofi", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Tel_part
			{
				get
				{
					return new NpgsqlParameter("Tel_part", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Fecha_nacimiento
			{
				get
				{
					return new NpgsqlParameter("Fecha_nacimiento", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
			public static NpgsqlParameter Id_seguro
			{
				get
				{
					return new NpgsqlParameter("Id_seguro", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Idrastreo_persona = "idrastreo_persona";
            public const string Id_distrito = "id_distrito";
            public const string Id_pais = "id_pais";
            public const string Id_ciudad = "id_ciudad";
            public const string Tipo_documento = "tipo_documento";
            public const string Tipo_persona = "tipo_persona";
            public const string Nro_documento = "nro_documento";
            public const string Razon_social = "razon_social";
            public const string Nombre = "nombre";
            public const string Apellido = "apellido";
            public const string Direccion = "direccion";
            public const string Email = "email";
            public const string Tel_movil = "tel_movil";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";
            public const string Tel_ofi = "tel_ofi";
            public const string Tel_part = "tel_part";
            public const string Fecha_nacimiento = "fecha_nacimiento";
            public const string Id_seguro = "id_seguro";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_persona] = _rastreo_persona.PropertyNames.Idrastreo_persona;
					ht[Id_distrito] = _rastreo_persona.PropertyNames.Id_distrito;
					ht[Id_pais] = _rastreo_persona.PropertyNames.Id_pais;
					ht[Id_ciudad] = _rastreo_persona.PropertyNames.Id_ciudad;
					ht[Tipo_documento] = _rastreo_persona.PropertyNames.Tipo_documento;
					ht[Tipo_persona] = _rastreo_persona.PropertyNames.Tipo_persona;
					ht[Nro_documento] = _rastreo_persona.PropertyNames.Nro_documento;
					ht[Razon_social] = _rastreo_persona.PropertyNames.Razon_social;
					ht[Nombre] = _rastreo_persona.PropertyNames.Nombre;
					ht[Apellido] = _rastreo_persona.PropertyNames.Apellido;
					ht[Direccion] = _rastreo_persona.PropertyNames.Direccion;
					ht[Email] = _rastreo_persona.PropertyNames.Email;
					ht[Tel_movil] = _rastreo_persona.PropertyNames.Tel_movil;
					ht[User_ins] = _rastreo_persona.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_persona.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_persona.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_persona.PropertyNames.Fech_upd;
					ht[Tel_ofi] = _rastreo_persona.PropertyNames.Tel_ofi;
					ht[Tel_part] = _rastreo_persona.PropertyNames.Tel_part;
					ht[Fecha_nacimiento] = _rastreo_persona.PropertyNames.Fecha_nacimiento;
					ht[Id_seguro] = _rastreo_persona.PropertyNames.Id_seguro;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreo_persona = "Idrastreo_persona";
            public const string Id_distrito = "Id_distrito";
            public const string Id_pais = "Id_pais";
            public const string Id_ciudad = "Id_ciudad";
            public const string Tipo_documento = "Tipo_documento";
            public const string Tipo_persona = "Tipo_persona";
            public const string Nro_documento = "Nro_documento";
            public const string Razon_social = "Razon_social";
            public const string Nombre = "Nombre";
            public const string Apellido = "Apellido";
            public const string Direccion = "Direccion";
            public const string Email = "Email";
            public const string Tel_movil = "Tel_movil";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";
            public const string Tel_ofi = "Tel_ofi";
            public const string Tel_part = "Tel_part";
            public const string Fecha_nacimiento = "Fecha_nacimiento";
            public const string Id_seguro = "Id_seguro";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_persona] = _rastreo_persona.ColumnNames.Idrastreo_persona;
					ht[Id_distrito] = _rastreo_persona.ColumnNames.Id_distrito;
					ht[Id_pais] = _rastreo_persona.ColumnNames.Id_pais;
					ht[Id_ciudad] = _rastreo_persona.ColumnNames.Id_ciudad;
					ht[Tipo_documento] = _rastreo_persona.ColumnNames.Tipo_documento;
					ht[Tipo_persona] = _rastreo_persona.ColumnNames.Tipo_persona;
					ht[Nro_documento] = _rastreo_persona.ColumnNames.Nro_documento;
					ht[Razon_social] = _rastreo_persona.ColumnNames.Razon_social;
					ht[Nombre] = _rastreo_persona.ColumnNames.Nombre;
					ht[Apellido] = _rastreo_persona.ColumnNames.Apellido;
					ht[Direccion] = _rastreo_persona.ColumnNames.Direccion;
					ht[Email] = _rastreo_persona.ColumnNames.Email;
					ht[Tel_movil] = _rastreo_persona.ColumnNames.Tel_movil;
					ht[User_ins] = _rastreo_persona.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_persona.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_persona.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_persona.ColumnNames.Fech_upd;
					ht[Tel_ofi] = _rastreo_persona.ColumnNames.Tel_ofi;
					ht[Tel_part] = _rastreo_persona.ColumnNames.Tel_part;
					ht[Fecha_nacimiento] = _rastreo_persona.ColumnNames.Fecha_nacimiento;
					ht[Id_seguro] = _rastreo_persona.ColumnNames.Id_seguro;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreo_persona = "s_Idrastreo_persona";
            public const string Id_distrito = "s_Id_distrito";
            public const string Id_pais = "s_Id_pais";
            public const string Id_ciudad = "s_Id_ciudad";
            public const string Tipo_documento = "s_Tipo_documento";
            public const string Tipo_persona = "s_Tipo_persona";
            public const string Nro_documento = "s_Nro_documento";
            public const string Razon_social = "s_Razon_social";
            public const string Nombre = "s_Nombre";
            public const string Apellido = "s_Apellido";
            public const string Direccion = "s_Direccion";
            public const string Email = "s_Email";
            public const string Tel_movil = "s_Tel_movil";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";
            public const string Tel_ofi = "s_Tel_ofi";
            public const string Tel_part = "s_Tel_part";
            public const string Fecha_nacimiento = "s_Fecha_nacimiento";
            public const string Id_seguro = "s_Id_seguro";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreo_persona
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_persona);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_persona, value);
			}
		}

		public virtual int Id_distrito
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_distrito);
			}
			set
	        {
				base.Setint(ColumnNames.Id_distrito, value);
			}
		}

		public virtual int Id_pais
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_pais);
			}
			set
	        {
				base.Setint(ColumnNames.Id_pais, value);
			}
		}

		public virtual int Id_ciudad
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_ciudad);
			}
			set
	        {
				base.Setint(ColumnNames.Id_ciudad, value);
			}
		}

		public virtual int Tipo_documento
	    {
			get
	        {
				return base.Getint(ColumnNames.Tipo_documento);
			}
			set
	        {
				base.Setint(ColumnNames.Tipo_documento, value);
			}
		}

		public virtual string Tipo_persona
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tipo_persona);
			}
			set
	        {
				base.Setstring(ColumnNames.Tipo_persona, value);
			}
		}

		public virtual string Nro_documento
	    {
			get
	        {
				return base.Getstring(ColumnNames.Nro_documento);
			}
			set
	        {
				base.Setstring(ColumnNames.Nro_documento, value);
			}
		}

		public virtual string Razon_social
	    {
			get
	        {
				return base.Getstring(ColumnNames.Razon_social);
			}
			set
	        {
				base.Setstring(ColumnNames.Razon_social, value);
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

		public virtual string Apellido
	    {
			get
	        {
				return base.Getstring(ColumnNames.Apellido);
			}
			set
	        {
				base.Setstring(ColumnNames.Apellido, value);
			}
		}

		public virtual string Direccion
	    {
			get
	        {
				return base.Getstring(ColumnNames.Direccion);
			}
			set
	        {
				base.Setstring(ColumnNames.Direccion, value);
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

		public virtual string Tel_ofi
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tel_ofi);
			}
			set
	        {
				base.Setstring(ColumnNames.Tel_ofi, value);
			}
		}

		public virtual string Tel_part
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tel_part);
			}
			set
	        {
				base.Setstring(ColumnNames.Tel_part, value);
			}
		}

		public virtual DateTime Fecha_nacimiento
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Fecha_nacimiento);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Fecha_nacimiento, value);
			}
		}

		public virtual int Id_seguro
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_seguro);
			}
			set
	        {
				base.Setint(ColumnNames.Id_seguro, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Idrastreo_persona
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_persona) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_persona);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_persona);
				else
					this.Idrastreo_persona = base.SetintAsString(ColumnNames.Idrastreo_persona, value);
			}
		}

		public virtual string s_Id_distrito
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_distrito) ? string.Empty : base.GetintAsString(ColumnNames.Id_distrito);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_distrito);
				else
					this.Id_distrito = base.SetintAsString(ColumnNames.Id_distrito, value);
			}
		}

		public virtual string s_Id_pais
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_pais) ? string.Empty : base.GetintAsString(ColumnNames.Id_pais);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_pais);
				else
					this.Id_pais = base.SetintAsString(ColumnNames.Id_pais, value);
			}
		}

		public virtual string s_Id_ciudad
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_ciudad) ? string.Empty : base.GetintAsString(ColumnNames.Id_ciudad);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_ciudad);
				else
					this.Id_ciudad = base.SetintAsString(ColumnNames.Id_ciudad, value);
			}
		}

		public virtual string s_Tipo_documento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipo_documento) ? string.Empty : base.GetintAsString(ColumnNames.Tipo_documento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipo_documento);
				else
					this.Tipo_documento = base.SetintAsString(ColumnNames.Tipo_documento, value);
			}
		}

		public virtual string s_Tipo_persona
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipo_persona) ? string.Empty : base.GetstringAsString(ColumnNames.Tipo_persona);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipo_persona);
				else
					this.Tipo_persona = base.SetstringAsString(ColumnNames.Tipo_persona, value);
			}
		}

		public virtual string s_Nro_documento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Nro_documento) ? string.Empty : base.GetstringAsString(ColumnNames.Nro_documento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nro_documento);
				else
					this.Nro_documento = base.SetstringAsString(ColumnNames.Nro_documento, value);
			}
		}

		public virtual string s_Razon_social
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Razon_social) ? string.Empty : base.GetstringAsString(ColumnNames.Razon_social);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Razon_social);
				else
					this.Razon_social = base.SetstringAsString(ColumnNames.Razon_social, value);
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

		public virtual string s_Apellido
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Apellido) ? string.Empty : base.GetstringAsString(ColumnNames.Apellido);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Apellido);
				else
					this.Apellido = base.SetstringAsString(ColumnNames.Apellido, value);
			}
		}

		public virtual string s_Direccion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Direccion) ? string.Empty : base.GetstringAsString(ColumnNames.Direccion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Direccion);
				else
					this.Direccion = base.SetstringAsString(ColumnNames.Direccion, value);
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

		public virtual string s_Tel_ofi
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tel_ofi) ? string.Empty : base.GetstringAsString(ColumnNames.Tel_ofi);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tel_ofi);
				else
					this.Tel_ofi = base.SetstringAsString(ColumnNames.Tel_ofi, value);
			}
		}

		public virtual string s_Tel_part
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tel_part) ? string.Empty : base.GetstringAsString(ColumnNames.Tel_part);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tel_part);
				else
					this.Tel_part = base.SetstringAsString(ColumnNames.Tel_part, value);
			}
		}

		public virtual string s_Fecha_nacimiento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Fecha_nacimiento) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Fecha_nacimiento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Fecha_nacimiento);
				else
					this.Fecha_nacimiento = base.SetDateTimeAsString(ColumnNames.Fecha_nacimiento, value);
			}
		}

		public virtual string s_Id_seguro
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_seguro) ? string.Empty : base.GetintAsString(ColumnNames.Id_seguro);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_seguro);
				else
					this.Id_seguro = base.SetintAsString(ColumnNames.Id_seguro, value);
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
				
				
				public WhereParameter Idrastreo_persona
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_persona, Parameters.Idrastreo_persona);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_distrito
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_distrito, Parameters.Id_distrito);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_pais
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_pais, Parameters.Id_pais);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_ciudad
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_ciudad, Parameters.Id_ciudad);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Tipo_documento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipo_documento, Parameters.Tipo_documento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Tipo_persona
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipo_persona, Parameters.Tipo_persona);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Nro_documento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nro_documento, Parameters.Nro_documento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Razon_social
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Razon_social, Parameters.Razon_social);
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

				public WhereParameter Apellido
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Apellido, Parameters.Apellido);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Direccion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Direccion, Parameters.Direccion);
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

				public WhereParameter Tel_ofi
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tel_ofi, Parameters.Tel_ofi);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Tel_part
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tel_part, Parameters.Tel_part);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Fecha_nacimiento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Fecha_nacimiento, Parameters.Fecha_nacimiento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_seguro
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_seguro, Parameters.Id_seguro);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Idrastreo_persona
		    {
				get
		        {
					if(_Idrastreo_persona_W == null)
	        	    {
						_Idrastreo_persona_W = TearOff.Idrastreo_persona;
					}
					return _Idrastreo_persona_W;
				}
			}

			public WhereParameter Id_distrito
		    {
				get
		        {
					if(_Id_distrito_W == null)
	        	    {
						_Id_distrito_W = TearOff.Id_distrito;
					}
					return _Id_distrito_W;
				}
			}

			public WhereParameter Id_pais
		    {
				get
		        {
					if(_Id_pais_W == null)
	        	    {
						_Id_pais_W = TearOff.Id_pais;
					}
					return _Id_pais_W;
				}
			}

			public WhereParameter Id_ciudad
		    {
				get
		        {
					if(_Id_ciudad_W == null)
	        	    {
						_Id_ciudad_W = TearOff.Id_ciudad;
					}
					return _Id_ciudad_W;
				}
			}

			public WhereParameter Tipo_documento
		    {
				get
		        {
					if(_Tipo_documento_W == null)
	        	    {
						_Tipo_documento_W = TearOff.Tipo_documento;
					}
					return _Tipo_documento_W;
				}
			}

			public WhereParameter Tipo_persona
		    {
				get
		        {
					if(_Tipo_persona_W == null)
	        	    {
						_Tipo_persona_W = TearOff.Tipo_persona;
					}
					return _Tipo_persona_W;
				}
			}

			public WhereParameter Nro_documento
		    {
				get
		        {
					if(_Nro_documento_W == null)
	        	    {
						_Nro_documento_W = TearOff.Nro_documento;
					}
					return _Nro_documento_W;
				}
			}

			public WhereParameter Razon_social
		    {
				get
		        {
					if(_Razon_social_W == null)
	        	    {
						_Razon_social_W = TearOff.Razon_social;
					}
					return _Razon_social_W;
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

			public WhereParameter Apellido
		    {
				get
		        {
					if(_Apellido_W == null)
	        	    {
						_Apellido_W = TearOff.Apellido;
					}
					return _Apellido_W;
				}
			}

			public WhereParameter Direccion
		    {
				get
		        {
					if(_Direccion_W == null)
	        	    {
						_Direccion_W = TearOff.Direccion;
					}
					return _Direccion_W;
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

			public WhereParameter Tel_ofi
		    {
				get
		        {
					if(_Tel_ofi_W == null)
	        	    {
						_Tel_ofi_W = TearOff.Tel_ofi;
					}
					return _Tel_ofi_W;
				}
			}

			public WhereParameter Tel_part
		    {
				get
		        {
					if(_Tel_part_W == null)
	        	    {
						_Tel_part_W = TearOff.Tel_part;
					}
					return _Tel_part_W;
				}
			}

			public WhereParameter Fecha_nacimiento
		    {
				get
		        {
					if(_Fecha_nacimiento_W == null)
	        	    {
						_Fecha_nacimiento_W = TearOff.Fecha_nacimiento;
					}
					return _Fecha_nacimiento_W;
				}
			}

			public WhereParameter Id_seguro
		    {
				get
		        {
					if(_Id_seguro_W == null)
	        	    {
						_Id_seguro_W = TearOff.Id_seguro;
					}
					return _Id_seguro_W;
				}
			}

			private WhereParameter _Idrastreo_persona_W = null;
			private WhereParameter _Id_distrito_W = null;
			private WhereParameter _Id_pais_W = null;
			private WhereParameter _Id_ciudad_W = null;
			private WhereParameter _Tipo_documento_W = null;
			private WhereParameter _Tipo_persona_W = null;
			private WhereParameter _Nro_documento_W = null;
			private WhereParameter _Razon_social_W = null;
			private WhereParameter _Nombre_W = null;
			private WhereParameter _Apellido_W = null;
			private WhereParameter _Direccion_W = null;
			private WhereParameter _Email_W = null;
			private WhereParameter _Tel_movil_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;
			private WhereParameter _Tel_ofi_W = null;
			private WhereParameter _Tel_part_W = null;
			private WhereParameter _Fecha_nacimiento_W = null;
			private WhereParameter _Id_seguro_W = null;

			public void WhereClauseReset()
			{
				_Idrastreo_persona_W = null;
				_Id_distrito_W = null;
				_Id_pais_W = null;
				_Id_ciudad_W = null;
				_Tipo_documento_W = null;
				_Tipo_persona_W = null;
				_Nro_documento_W = null;
				_Razon_social_W = null;
				_Nombre_W = null;
				_Apellido_W = null;
				_Direccion_W = null;
				_Email_W = null;
				_Tel_movil_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Tel_ofi_W = null;
				_Tel_part_W = null;
				_Fecha_nacimiento_W = null;
				_Id_seguro_W = null;

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
				
				
				public AggregateParameter Idrastreo_persona
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_persona, Parameters.Idrastreo_persona);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_distrito
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_distrito, Parameters.Id_distrito);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_pais
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_pais, Parameters.Id_pais);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_ciudad
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_ciudad, Parameters.Id_ciudad);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Tipo_documento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_documento, Parameters.Tipo_documento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Tipo_persona
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_persona, Parameters.Tipo_persona);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Nro_documento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nro_documento, Parameters.Nro_documento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Razon_social
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Razon_social, Parameters.Razon_social);
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

				public AggregateParameter Apellido
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Apellido, Parameters.Apellido);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Direccion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Direccion, Parameters.Direccion);
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

				public AggregateParameter Tel_ofi
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tel_ofi, Parameters.Tel_ofi);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Tel_part
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tel_part, Parameters.Tel_part);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Fecha_nacimiento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fecha_nacimiento, Parameters.Fecha_nacimiento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_seguro
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_seguro, Parameters.Id_seguro);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Idrastreo_persona
		    {
				get
		        {
					if(_Idrastreo_persona_W == null)
	        	    {
						_Idrastreo_persona_W = TearOff.Idrastreo_persona;
					}
					return _Idrastreo_persona_W;
				}
			}

			public AggregateParameter Id_distrito
		    {
				get
		        {
					if(_Id_distrito_W == null)
	        	    {
						_Id_distrito_W = TearOff.Id_distrito;
					}
					return _Id_distrito_W;
				}
			}

			public AggregateParameter Id_pais
		    {
				get
		        {
					if(_Id_pais_W == null)
	        	    {
						_Id_pais_W = TearOff.Id_pais;
					}
					return _Id_pais_W;
				}
			}

			public AggregateParameter Id_ciudad
		    {
				get
		        {
					if(_Id_ciudad_W == null)
	        	    {
						_Id_ciudad_W = TearOff.Id_ciudad;
					}
					return _Id_ciudad_W;
				}
			}

			public AggregateParameter Tipo_documento
		    {
				get
		        {
					if(_Tipo_documento_W == null)
	        	    {
						_Tipo_documento_W = TearOff.Tipo_documento;
					}
					return _Tipo_documento_W;
				}
			}

			public AggregateParameter Tipo_persona
		    {
				get
		        {
					if(_Tipo_persona_W == null)
	        	    {
						_Tipo_persona_W = TearOff.Tipo_persona;
					}
					return _Tipo_persona_W;
				}
			}

			public AggregateParameter Nro_documento
		    {
				get
		        {
					if(_Nro_documento_W == null)
	        	    {
						_Nro_documento_W = TearOff.Nro_documento;
					}
					return _Nro_documento_W;
				}
			}

			public AggregateParameter Razon_social
		    {
				get
		        {
					if(_Razon_social_W == null)
	        	    {
						_Razon_social_W = TearOff.Razon_social;
					}
					return _Razon_social_W;
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

			public AggregateParameter Apellido
		    {
				get
		        {
					if(_Apellido_W == null)
	        	    {
						_Apellido_W = TearOff.Apellido;
					}
					return _Apellido_W;
				}
			}

			public AggregateParameter Direccion
		    {
				get
		        {
					if(_Direccion_W == null)
	        	    {
						_Direccion_W = TearOff.Direccion;
					}
					return _Direccion_W;
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

			public AggregateParameter Tel_ofi
		    {
				get
		        {
					if(_Tel_ofi_W == null)
	        	    {
						_Tel_ofi_W = TearOff.Tel_ofi;
					}
					return _Tel_ofi_W;
				}
			}

			public AggregateParameter Tel_part
		    {
				get
		        {
					if(_Tel_part_W == null)
	        	    {
						_Tel_part_W = TearOff.Tel_part;
					}
					return _Tel_part_W;
				}
			}

			public AggregateParameter Fecha_nacimiento
		    {
				get
		        {
					if(_Fecha_nacimiento_W == null)
	        	    {
						_Fecha_nacimiento_W = TearOff.Fecha_nacimiento;
					}
					return _Fecha_nacimiento_W;
				}
			}

			public AggregateParameter Id_seguro
		    {
				get
		        {
					if(_Id_seguro_W == null)
	        	    {
						_Id_seguro_W = TearOff.Id_seguro;
					}
					return _Id_seguro_W;
				}
			}

			private AggregateParameter _Idrastreo_persona_W = null;
			private AggregateParameter _Id_distrito_W = null;
			private AggregateParameter _Id_pais_W = null;
			private AggregateParameter _Id_ciudad_W = null;
			private AggregateParameter _Tipo_documento_W = null;
			private AggregateParameter _Tipo_persona_W = null;
			private AggregateParameter _Nro_documento_W = null;
			private AggregateParameter _Razon_social_W = null;
			private AggregateParameter _Nombre_W = null;
			private AggregateParameter _Apellido_W = null;
			private AggregateParameter _Direccion_W = null;
			private AggregateParameter _Email_W = null;
			private AggregateParameter _Tel_movil_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;
			private AggregateParameter _Tel_ofi_W = null;
			private AggregateParameter _Tel_part_W = null;
			private AggregateParameter _Fecha_nacimiento_W = null;
			private AggregateParameter _Id_seguro_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreo_persona_W = null;
				_Id_distrito_W = null;
				_Id_pais_W = null;
				_Id_ciudad_W = null;
				_Tipo_documento_W = null;
				_Tipo_persona_W = null;
				_Nro_documento_W = null;
				_Razon_social_W = null;
				_Nombre_W = null;
				_Apellido_W = null;
				_Direccion_W = null;
				_Email_W = null;
				_Tel_movil_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Tel_ofi_W = null;
				_Tel_part_W = null;
				_Fecha_nacimiento_W = null;
				_Id_seguro_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_persona_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreo_persona.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_persona_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_persona_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreo_persona);
			p.SourceColumn = ColumnNames.Idrastreo_persona;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreo_persona);
			p.SourceColumn = ColumnNames.Idrastreo_persona;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_distrito);
			p.SourceColumn = ColumnNames.Id_distrito;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_pais);
			p.SourceColumn = ColumnNames.Id_pais;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_ciudad);
			p.SourceColumn = ColumnNames.Id_ciudad;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Tipo_documento);
			p.SourceColumn = ColumnNames.Tipo_documento;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Tipo_persona);
			p.SourceColumn = ColumnNames.Tipo_persona;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nro_documento);
			p.SourceColumn = ColumnNames.Nro_documento;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Razon_social);
			p.SourceColumn = ColumnNames.Razon_social;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nombre);
			p.SourceColumn = ColumnNames.Nombre;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Apellido);
			p.SourceColumn = ColumnNames.Apellido;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Direccion);
			p.SourceColumn = ColumnNames.Direccion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Email);
			p.SourceColumn = ColumnNames.Email;
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

			p = cmd.Parameters.Add(Parameters.Tel_ofi);
			p.SourceColumn = ColumnNames.Tel_ofi;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Tel_part);
			p.SourceColumn = ColumnNames.Tel_part;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Fecha_nacimiento);
			p.SourceColumn = ColumnNames.Fecha_nacimiento;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_seguro);
			p.SourceColumn = ColumnNames.Id_seguro;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
