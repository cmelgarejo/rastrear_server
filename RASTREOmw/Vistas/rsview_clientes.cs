/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rsview_clientes para la vista rsview_clientes.
'  Base soportada: PostgreSqlEntity.
'  Versión: # (1.3.0.9)
'==============================================================================================================
*/

using System;
using System.Data;
using Npgsql;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace RASTREOmw
{
	public class rsview_clientes : PostgreSqlEntity
	{
		public rsview_clientes(String laCadenaDeConexion)
		{
			this.QuerySource = "rsview_clientes";
			this.MappingName = "rsview_clientes";
			this.ConnectionString = laCadenaDeConexion;
		}	
	
		//=================================================================
		//  	public procedure LoadAll() As Boolean
		//=================================================================
		//  Carga todos los registros en la base de datos, y coloca la propiedad currentRow en la primera fila
		//=================================================================
		public bool LoadAll() 
		{
			return base.Query.Load();
		}
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
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
			
			public static NpgsqlParameter Acceso_sistema
			{
				get
				{
					return new NpgsqlParameter("Acceso_sistema", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Clave_personal
			{
				get
				{
					return new NpgsqlParameter("Clave_personal", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
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
			
			public static NpgsqlParameter Nombre_completo
			{
				get
				{
					return new NpgsqlParameter("Nombre_completo", NpgsqlTypes.NpgsqlDbType.Varchar, 0);
				}
			}
			
			public static NpgsqlParameter Id_pais
			{
				get
				{
					return new NpgsqlParameter("Id_pais", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Pais
			{
				get
				{
					return new NpgsqlParameter("Pais", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Id_distrito
			{
				get
				{
					return new NpgsqlParameter("Id_distrito", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Distrito
			{
				get
				{
					return new NpgsqlParameter("Distrito", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Id_ciudad
			{
				get
				{
					return new NpgsqlParameter("Id_ciudad", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Ciudad
			{
				get
				{
					return new NpgsqlParameter("Ciudad", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Tipo_documento
			{
				get
				{
					return new NpgsqlParameter("Tipo_documento", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Tipo_de_documento
			{
				get
				{
					return new NpgsqlParameter("Tipo_de_documento", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
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
			
			public static NpgsqlParameter Tel_part
			{
				get
				{
					return new NpgsqlParameter("Tel_part", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Tel_ofi
			{
				get
				{
					return new NpgsqlParameter("Tel_ofi", NpgsqlTypes.NpgsqlDbType.Text, 0);
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
            public const string Id_cliente = "id_cliente";
            public const string Acceso_sistema = "acceso_sistema";
            public const string Clave_personal = "clave_personal";
            public const string Estado_cliente = "estado_cliente";
            public const string Estado_fecha = "estado_fecha";
            public const string Nombre_completo = "nombre_completo";
            public const string Id_pais = "id_pais";
            public const string Pais = "pais";
            public const string Id_distrito = "id_distrito";
            public const string Distrito = "distrito";
            public const string Id_ciudad = "id_ciudad";
            public const string Ciudad = "ciudad";
            public const string Tipo_documento = "tipo_documento";
            public const string Tipo_de_documento = "tipo_de_documento";
            public const string Tipo_persona = "tipo_persona";
            public const string Nro_documento = "nro_documento";
            public const string Direccion = "direccion";
            public const string Email = "email";
            public const string Tel_movil = "tel_movil";
            public const string Tel_part = "tel_part";
            public const string Tel_ofi = "tel_ofi";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_cliente] = rsview_clientes.PropertyNames.Id_cliente;
					ht[Acceso_sistema] = rsview_clientes.PropertyNames.Acceso_sistema;
					ht[Clave_personal] = rsview_clientes.PropertyNames.Clave_personal;
					ht[Estado_cliente] = rsview_clientes.PropertyNames.Estado_cliente;
					ht[Estado_fecha] = rsview_clientes.PropertyNames.Estado_fecha;
					ht[Nombre_completo] = rsview_clientes.PropertyNames.Nombre_completo;
					ht[Id_pais] = rsview_clientes.PropertyNames.Id_pais;
					ht[Pais] = rsview_clientes.PropertyNames.Pais;
					ht[Id_distrito] = rsview_clientes.PropertyNames.Id_distrito;
					ht[Distrito] = rsview_clientes.PropertyNames.Distrito;
					ht[Id_ciudad] = rsview_clientes.PropertyNames.Id_ciudad;
					ht[Ciudad] = rsview_clientes.PropertyNames.Ciudad;
					ht[Tipo_documento] = rsview_clientes.PropertyNames.Tipo_documento;
					ht[Tipo_de_documento] = rsview_clientes.PropertyNames.Tipo_de_documento;
					ht[Tipo_persona] = rsview_clientes.PropertyNames.Tipo_persona;
					ht[Nro_documento] = rsview_clientes.PropertyNames.Nro_documento;
					ht[Direccion] = rsview_clientes.PropertyNames.Direccion;
					ht[Email] = rsview_clientes.PropertyNames.Email;
					ht[Tel_movil] = rsview_clientes.PropertyNames.Tel_movil;
					ht[Tel_part] = rsview_clientes.PropertyNames.Tel_part;
					ht[Tel_ofi] = rsview_clientes.PropertyNames.Tel_ofi;
					ht[User_ins] = rsview_clientes.PropertyNames.User_ins;
					ht[Fech_ins] = rsview_clientes.PropertyNames.Fech_ins;
					ht[User_upd] = rsview_clientes.PropertyNames.User_upd;
					ht[Fech_upd] = rsview_clientes.PropertyNames.Fech_upd;

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
            public const string Acceso_sistema = "Acceso_sistema";
            public const string Clave_personal = "Clave_personal";
            public const string Estado_cliente = "Estado_cliente";
            public const string Estado_fecha = "Estado_fecha";
            public const string Nombre_completo = "Nombre_completo";
            public const string Id_pais = "Id_pais";
            public const string Pais = "Pais";
            public const string Id_distrito = "Id_distrito";
            public const string Distrito = "Distrito";
            public const string Id_ciudad = "Id_ciudad";
            public const string Ciudad = "Ciudad";
            public const string Tipo_documento = "Tipo_documento";
            public const string Tipo_de_documento = "Tipo_de_documento";
            public const string Tipo_persona = "Tipo_persona";
            public const string Nro_documento = "Nro_documento";
            public const string Direccion = "Direccion";
            public const string Email = "Email";
            public const string Tel_movil = "Tel_movil";
            public const string Tel_part = "Tel_part";
            public const string Tel_ofi = "Tel_ofi";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_cliente] = rsview_clientes.ColumnNames.Id_cliente;
					ht[Acceso_sistema] = rsview_clientes.ColumnNames.Acceso_sistema;
					ht[Clave_personal] = rsview_clientes.ColumnNames.Clave_personal;
					ht[Estado_cliente] = rsview_clientes.ColumnNames.Estado_cliente;
					ht[Estado_fecha] = rsview_clientes.ColumnNames.Estado_fecha;
					ht[Nombre_completo] = rsview_clientes.ColumnNames.Nombre_completo;
					ht[Id_pais] = rsview_clientes.ColumnNames.Id_pais;
					ht[Pais] = rsview_clientes.ColumnNames.Pais;
					ht[Id_distrito] = rsview_clientes.ColumnNames.Id_distrito;
					ht[Distrito] = rsview_clientes.ColumnNames.Distrito;
					ht[Id_ciudad] = rsview_clientes.ColumnNames.Id_ciudad;
					ht[Ciudad] = rsview_clientes.ColumnNames.Ciudad;
					ht[Tipo_documento] = rsview_clientes.ColumnNames.Tipo_documento;
					ht[Tipo_de_documento] = rsview_clientes.ColumnNames.Tipo_de_documento;
					ht[Tipo_persona] = rsview_clientes.ColumnNames.Tipo_persona;
					ht[Nro_documento] = rsview_clientes.ColumnNames.Nro_documento;
					ht[Direccion] = rsview_clientes.ColumnNames.Direccion;
					ht[Email] = rsview_clientes.ColumnNames.Email;
					ht[Tel_movil] = rsview_clientes.ColumnNames.Tel_movil;
					ht[Tel_part] = rsview_clientes.ColumnNames.Tel_part;
					ht[Tel_ofi] = rsview_clientes.ColumnNames.Tel_ofi;
					ht[User_ins] = rsview_clientes.ColumnNames.User_ins;
					ht[Fech_ins] = rsview_clientes.ColumnNames.Fech_ins;
					ht[User_upd] = rsview_clientes.ColumnNames.User_upd;
					ht[Fech_upd] = rsview_clientes.ColumnNames.Fech_upd;

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
            public const string Acceso_sistema = "s_Acceso_sistema";
            public const string Clave_personal = "s_Clave_personal";
            public const string Estado_cliente = "s_Estado_cliente";
            public const string Estado_fecha = "s_Estado_fecha";
            public const string Nombre_completo = "s_Nombre_completo";
            public const string Id_pais = "s_Id_pais";
            public const string Pais = "s_Pais";
            public const string Id_distrito = "s_Id_distrito";
            public const string Distrito = "s_Distrito";
            public const string Id_ciudad = "s_Id_ciudad";
            public const string Ciudad = "s_Ciudad";
            public const string Tipo_documento = "s_Tipo_documento";
            public const string Tipo_de_documento = "s_Tipo_de_documento";
            public const string Tipo_persona = "s_Tipo_persona";
            public const string Nro_documento = "s_Nro_documento";
            public const string Direccion = "s_Direccion";
            public const string Email = "s_Email";
            public const string Tel_movil = "s_Tel_movil";
            public const string Tel_part = "s_Tel_part";
            public const string Tel_ofi = "s_Tel_ofi";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

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

		public virtual string Nombre_completo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Nombre_completo);
			}
			set
	        {
				base.Setstring(ColumnNames.Nombre_completo, value);
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

		public virtual string Pais
	    {
			get
	        {
				return base.Getstring(ColumnNames.Pais);
			}
			set
	        {
				base.Setstring(ColumnNames.Pais, value);
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

		public virtual string Distrito
	    {
			get
	        {
				return base.Getstring(ColumnNames.Distrito);
			}
			set
	        {
				base.Setstring(ColumnNames.Distrito, value);
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

		public virtual string Ciudad
	    {
			get
	        {
				return base.Getstring(ColumnNames.Ciudad);
			}
			set
	        {
				base.Setstring(ColumnNames.Ciudad, value);
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

		public virtual string Tipo_de_documento
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tipo_de_documento);
			}
			set
	        {
				base.Setstring(ColumnNames.Tipo_de_documento, value);
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

		public virtual string s_Nombre_completo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Nombre_completo) ? string.Empty : base.GetstringAsString(ColumnNames.Nombre_completo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nombre_completo);
				else
					this.Nombre_completo = base.SetstringAsString(ColumnNames.Nombre_completo, value);
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

		public virtual string s_Pais
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Pais) ? string.Empty : base.GetstringAsString(ColumnNames.Pais);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Pais);
				else
					this.Pais = base.SetstringAsString(ColumnNames.Pais, value);
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

		public virtual string s_Distrito
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Distrito) ? string.Empty : base.GetstringAsString(ColumnNames.Distrito);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Distrito);
				else
					this.Distrito = base.SetstringAsString(ColumnNames.Distrito, value);
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

		public virtual string s_Ciudad
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Ciudad) ? string.Empty : base.GetstringAsString(ColumnNames.Ciudad);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Ciudad);
				else
					this.Ciudad = base.SetstringAsString(ColumnNames.Ciudad, value);
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

		public virtual string s_Tipo_de_documento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipo_de_documento) ? string.Empty : base.GetstringAsString(ColumnNames.Tipo_de_documento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipo_de_documento);
				else
					this.Tipo_de_documento = base.SetstringAsString(ColumnNames.Tipo_de_documento, value);
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
				
				
				public WhereParameter Id_cliente
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_cliente, Parameters.Id_cliente);
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

				public WhereParameter Clave_personal
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Clave_personal, Parameters.Clave_personal);
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

				public WhereParameter Nombre_completo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nombre_completo, Parameters.Nombre_completo);
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

				public WhereParameter Pais
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Pais, Parameters.Pais);
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

				public WhereParameter Distrito
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Distrito, Parameters.Distrito);
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

				public WhereParameter Ciudad
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Ciudad, Parameters.Ciudad);
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

				public WhereParameter Tipo_de_documento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipo_de_documento, Parameters.Tipo_de_documento);
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

				public WhereParameter Tel_part
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tel_part, Parameters.Tel_part);
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

			public WhereParameter Nombre_completo
		    {
				get
		        {
					if(_Nombre_completo_W == null)
	        	    {
						_Nombre_completo_W = TearOff.Nombre_completo;
					}
					return _Nombre_completo_W;
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

			public WhereParameter Pais
		    {
				get
		        {
					if(_Pais_W == null)
	        	    {
						_Pais_W = TearOff.Pais;
					}
					return _Pais_W;
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

			public WhereParameter Distrito
		    {
				get
		        {
					if(_Distrito_W == null)
	        	    {
						_Distrito_W = TearOff.Distrito;
					}
					return _Distrito_W;
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

			public WhereParameter Ciudad
		    {
				get
		        {
					if(_Ciudad_W == null)
	        	    {
						_Ciudad_W = TearOff.Ciudad;
					}
					return _Ciudad_W;
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

			public WhereParameter Tipo_de_documento
		    {
				get
		        {
					if(_Tipo_de_documento_W == null)
	        	    {
						_Tipo_de_documento_W = TearOff.Tipo_de_documento;
					}
					return _Tipo_de_documento_W;
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

			private WhereParameter _Id_cliente_W = null;
			private WhereParameter _Acceso_sistema_W = null;
			private WhereParameter _Clave_personal_W = null;
			private WhereParameter _Estado_cliente_W = null;
			private WhereParameter _Estado_fecha_W = null;
			private WhereParameter _Nombre_completo_W = null;
			private WhereParameter _Id_pais_W = null;
			private WhereParameter _Pais_W = null;
			private WhereParameter _Id_distrito_W = null;
			private WhereParameter _Distrito_W = null;
			private WhereParameter _Id_ciudad_W = null;
			private WhereParameter _Ciudad_W = null;
			private WhereParameter _Tipo_documento_W = null;
			private WhereParameter _Tipo_de_documento_W = null;
			private WhereParameter _Tipo_persona_W = null;
			private WhereParameter _Nro_documento_W = null;
			private WhereParameter _Direccion_W = null;
			private WhereParameter _Email_W = null;
			private WhereParameter _Tel_movil_W = null;
			private WhereParameter _Tel_part_W = null;
			private WhereParameter _Tel_ofi_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Id_cliente_W = null;
				_Acceso_sistema_W = null;
				_Clave_personal_W = null;
				_Estado_cliente_W = null;
				_Estado_fecha_W = null;
				_Nombre_completo_W = null;
				_Id_pais_W = null;
				_Pais_W = null;
				_Id_distrito_W = null;
				_Distrito_W = null;
				_Id_ciudad_W = null;
				_Ciudad_W = null;
				_Tipo_documento_W = null;
				_Tipo_de_documento_W = null;
				_Tipo_persona_W = null;
				_Nro_documento_W = null;
				_Direccion_W = null;
				_Email_W = null;
				_Tel_movil_W = null;
				_Tel_part_W = null;
				_Tel_ofi_W = null;
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
				
				
				public AggregateParameter Id_cliente
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_cliente, Parameters.Id_cliente);
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

				public AggregateParameter Clave_personal
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Clave_personal, Parameters.Clave_personal);
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

				public AggregateParameter Nombre_completo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nombre_completo, Parameters.Nombre_completo);
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

				public AggregateParameter Pais
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Pais, Parameters.Pais);
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

				public AggregateParameter Distrito
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Distrito, Parameters.Distrito);
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

				public AggregateParameter Ciudad
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Ciudad, Parameters.Ciudad);
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

				public AggregateParameter Tipo_de_documento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_de_documento, Parameters.Tipo_de_documento);
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

				public AggregateParameter Tel_part
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tel_part, Parameters.Tel_part);
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

			public AggregateParameter Nombre_completo
		    {
				get
		        {
					if(_Nombre_completo_W == null)
	        	    {
						_Nombre_completo_W = TearOff.Nombre_completo;
					}
					return _Nombre_completo_W;
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

			public AggregateParameter Pais
		    {
				get
		        {
					if(_Pais_W == null)
	        	    {
						_Pais_W = TearOff.Pais;
					}
					return _Pais_W;
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

			public AggregateParameter Distrito
		    {
				get
		        {
					if(_Distrito_W == null)
	        	    {
						_Distrito_W = TearOff.Distrito;
					}
					return _Distrito_W;
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

			public AggregateParameter Ciudad
		    {
				get
		        {
					if(_Ciudad_W == null)
	        	    {
						_Ciudad_W = TearOff.Ciudad;
					}
					return _Ciudad_W;
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

			public AggregateParameter Tipo_de_documento
		    {
				get
		        {
					if(_Tipo_de_documento_W == null)
	        	    {
						_Tipo_de_documento_W = TearOff.Tipo_de_documento;
					}
					return _Tipo_de_documento_W;
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

			private AggregateParameter _Id_cliente_W = null;
			private AggregateParameter _Acceso_sistema_W = null;
			private AggregateParameter _Clave_personal_W = null;
			private AggregateParameter _Estado_cliente_W = null;
			private AggregateParameter _Estado_fecha_W = null;
			private AggregateParameter _Nombre_completo_W = null;
			private AggregateParameter _Id_pais_W = null;
			private AggregateParameter _Pais_W = null;
			private AggregateParameter _Id_distrito_W = null;
			private AggregateParameter _Distrito_W = null;
			private AggregateParameter _Id_ciudad_W = null;
			private AggregateParameter _Ciudad_W = null;
			private AggregateParameter _Tipo_documento_W = null;
			private AggregateParameter _Tipo_de_documento_W = null;
			private AggregateParameter _Tipo_persona_W = null;
			private AggregateParameter _Nro_documento_W = null;
			private AggregateParameter _Direccion_W = null;
			private AggregateParameter _Email_W = null;
			private AggregateParameter _Tel_movil_W = null;
			private AggregateParameter _Tel_part_W = null;
			private AggregateParameter _Tel_ofi_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Id_cliente_W = null;
				_Acceso_sistema_W = null;
				_Clave_personal_W = null;
				_Estado_cliente_W = null;
				_Estado_fecha_W = null;
				_Nombre_completo_W = null;
				_Id_pais_W = null;
				_Pais_W = null;
				_Id_distrito_W = null;
				_Distrito_W = null;
				_Id_ciudad_W = null;
				_Ciudad_W = null;
				_Tipo_documento_W = null;
				_Tipo_de_documento_W = null;
				_Tipo_persona_W = null;
				_Nro_documento_W = null;
				_Direccion_W = null;
				_Email_W = null;
				_Tel_movil_W = null;
				_Tel_part_W = null;
				_Tel_ofi_W = null;
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
			return null;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
			return null;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
			return null;
		}
	}
}
