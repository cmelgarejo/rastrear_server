/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rsview_equipogps_comandos para la vista rsview_equipogps_comandos.
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
	public class rsview_equipogps_comandos : PostgreSqlEntity
	{
		public rsview_equipogps_comandos(String laCadenaDeConexion)
		{
			this.QuerySource = "rsview_equipogps_comandos";
			this.MappingName = "rsview_equipogps_comandos";
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
			
			public static NpgsqlParameter Identificador_rastreo
			{
				get
				{
					return new NpgsqlParameter("Identificador_rastreo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Idrastreogps_cola_de_comandos
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_cola_de_comandos", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Idrastreogps_equipogps
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_equipo_gps
			{
				get
				{
					return new NpgsqlParameter("Id_equipo_gps", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Id_simcard
			{
				get
				{
					return new NpgsqlParameter("Id_simcard", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Tipoequipo
			{
				get
				{
					return new NpgsqlParameter("Tipoequipo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Tipo_equipo
			{
				get
				{
					return new NpgsqlParameter("Tipo_equipo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Sim_nro
			{
				get
				{
					return new NpgsqlParameter("Sim_nro", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Comando
			{
				get
				{
					return new NpgsqlParameter("Comando", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Descripcion
			{
				get
				{
					return new NpgsqlParameter("Descripcion", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Enviado
			{
				get
				{
					return new NpgsqlParameter("Enviado", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Gps_ip
			{
				get
				{
					return new NpgsqlParameter("Gps_ip", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
				}
			}
			
			public static NpgsqlParameter User_ins
			{
				get
				{
					return new NpgsqlParameter("User_ins", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Usuario
			{
				get
				{
					return new NpgsqlParameter("Usuario", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
				}
			}
			
			public static NpgsqlParameter Fech_ins
			{
				get
				{
					return new NpgsqlParameter("Fech_ins", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Identificador_rastreo = "identificador_rastreo";
            public const string Idrastreogps_cola_de_comandos = "idrastreogps_cola_de_comandos";
            public const string Idrastreogps_equipogps = "idrastreogps_equipogps";
            public const string Id_equipo_gps = "id_equipo_gps";
            public const string Id_simcard = "id_simcard";
            public const string Tipoequipo = "tipoequipo";
            public const string Tipo_equipo = "tipo_equipo";
            public const string Sim_nro = "sim_nro";
            public const string Comando = "comando";
            public const string Descripcion = "descripcion";
            public const string Enviado = "enviado";
            public const string Gps_ip = "gps_ip";
            public const string User_ins = "user_ins";
            public const string Usuario = "usuario";
            public const string Fech_ins = "fech_ins";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Identificador_rastreo] = rsview_equipogps_comandos.PropertyNames.Identificador_rastreo;
					ht[Idrastreogps_cola_de_comandos] = rsview_equipogps_comandos.PropertyNames.Idrastreogps_cola_de_comandos;
					ht[Idrastreogps_equipogps] = rsview_equipogps_comandos.PropertyNames.Idrastreogps_equipogps;
					ht[Id_equipo_gps] = rsview_equipogps_comandos.PropertyNames.Id_equipo_gps;
					ht[Id_simcard] = rsview_equipogps_comandos.PropertyNames.Id_simcard;
					ht[Tipoequipo] = rsview_equipogps_comandos.PropertyNames.Tipoequipo;
					ht[Tipo_equipo] = rsview_equipogps_comandos.PropertyNames.Tipo_equipo;
					ht[Sim_nro] = rsview_equipogps_comandos.PropertyNames.Sim_nro;
					ht[Comando] = rsview_equipogps_comandos.PropertyNames.Comando;
					ht[Descripcion] = rsview_equipogps_comandos.PropertyNames.Descripcion;
					ht[Enviado] = rsview_equipogps_comandos.PropertyNames.Enviado;
					ht[Gps_ip] = rsview_equipogps_comandos.PropertyNames.Gps_ip;
					ht[User_ins] = rsview_equipogps_comandos.PropertyNames.User_ins;
					ht[Usuario] = rsview_equipogps_comandos.PropertyNames.Usuario;
					ht[Fech_ins] = rsview_equipogps_comandos.PropertyNames.Fech_ins;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Identificador_rastreo = "Identificador_rastreo";
            public const string Idrastreogps_cola_de_comandos = "Idrastreogps_cola_de_comandos";
            public const string Idrastreogps_equipogps = "Idrastreogps_equipogps";
            public const string Id_equipo_gps = "Id_equipo_gps";
            public const string Id_simcard = "Id_simcard";
            public const string Tipoequipo = "Tipoequipo";
            public const string Tipo_equipo = "Tipo_equipo";
            public const string Sim_nro = "Sim_nro";
            public const string Comando = "Comando";
            public const string Descripcion = "Descripcion";
            public const string Enviado = "Enviado";
            public const string Gps_ip = "Gps_ip";
            public const string User_ins = "User_ins";
            public const string Usuario = "Usuario";
            public const string Fech_ins = "Fech_ins";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Identificador_rastreo] = rsview_equipogps_comandos.ColumnNames.Identificador_rastreo;
					ht[Idrastreogps_cola_de_comandos] = rsview_equipogps_comandos.ColumnNames.Idrastreogps_cola_de_comandos;
					ht[Idrastreogps_equipogps] = rsview_equipogps_comandos.ColumnNames.Idrastreogps_equipogps;
					ht[Id_equipo_gps] = rsview_equipogps_comandos.ColumnNames.Id_equipo_gps;
					ht[Id_simcard] = rsview_equipogps_comandos.ColumnNames.Id_simcard;
					ht[Tipoequipo] = rsview_equipogps_comandos.ColumnNames.Tipoequipo;
					ht[Tipo_equipo] = rsview_equipogps_comandos.ColumnNames.Tipo_equipo;
					ht[Sim_nro] = rsview_equipogps_comandos.ColumnNames.Sim_nro;
					ht[Comando] = rsview_equipogps_comandos.ColumnNames.Comando;
					ht[Descripcion] = rsview_equipogps_comandos.ColumnNames.Descripcion;
					ht[Enviado] = rsview_equipogps_comandos.ColumnNames.Enviado;
					ht[Gps_ip] = rsview_equipogps_comandos.ColumnNames.Gps_ip;
					ht[User_ins] = rsview_equipogps_comandos.ColumnNames.User_ins;
					ht[Usuario] = rsview_equipogps_comandos.ColumnNames.Usuario;
					ht[Fech_ins] = rsview_equipogps_comandos.ColumnNames.Fech_ins;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Identificador_rastreo = "s_Identificador_rastreo";
            public const string Idrastreogps_cola_de_comandos = "s_Idrastreogps_cola_de_comandos";
            public const string Idrastreogps_equipogps = "s_Idrastreogps_equipogps";
            public const string Id_equipo_gps = "s_Id_equipo_gps";
            public const string Id_simcard = "s_Id_simcard";
            public const string Tipoequipo = "s_Tipoequipo";
            public const string Tipo_equipo = "s_Tipo_equipo";
            public const string Sim_nro = "s_Sim_nro";
            public const string Comando = "s_Comando";
            public const string Descripcion = "s_Descripcion";
            public const string Enviado = "s_Enviado";
            public const string Gps_ip = "s_Gps_ip";
            public const string User_ins = "s_User_ins";
            public const string Usuario = "s_Usuario";
            public const string Fech_ins = "s_Fech_ins";

		}
		#endregion	
		
		#region Properties
			public virtual string Identificador_rastreo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Identificador_rastreo);
			}
			set
	        {
				base.Setstring(ColumnNames.Identificador_rastreo, value);
			}
		}

		public virtual int Idrastreogps_cola_de_comandos
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_cola_de_comandos);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_cola_de_comandos, value);
			}
		}

		public virtual int Idrastreogps_equipogps
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_equipogps);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_equipogps, value);
			}
		}

		public virtual string Id_equipo_gps
	    {
			get
	        {
				return base.Getstring(ColumnNames.Id_equipo_gps);
			}
			set
	        {
				base.Setstring(ColumnNames.Id_equipo_gps, value);
			}
		}

		public virtual int Id_simcard
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_simcard);
			}
			set
	        {
				base.Setint(ColumnNames.Id_simcard, value);
			}
		}

		public virtual int Tipoequipo
	    {
			get
	        {
				return base.Getint(ColumnNames.Tipoequipo);
			}
			set
	        {
				base.Setint(ColumnNames.Tipoequipo, value);
			}
		}

		public virtual string Tipo_equipo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tipo_equipo);
			}
			set
	        {
				base.Setstring(ColumnNames.Tipo_equipo, value);
			}
		}

		public virtual string Sim_nro
	    {
			get
	        {
				return base.Getstring(ColumnNames.Sim_nro);
			}
			set
	        {
				base.Setstring(ColumnNames.Sim_nro, value);
			}
		}

		public virtual string Comando
	    {
			get
	        {
				return base.Getstring(ColumnNames.Comando);
			}
			set
	        {
				base.Setstring(ColumnNames.Comando, value);
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

		public virtual bool Enviado
	    {
			get
	        {
				return base.Getbool(ColumnNames.Enviado);
			}
			set
	        {
				base.Setbool(ColumnNames.Enviado, value);
			}
		}

		public virtual string Gps_ip
	    {
			get
	        {
				return base.Getstring(ColumnNames.Gps_ip);
			}
			set
	        {
				base.Setstring(ColumnNames.Gps_ip, value);
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

		public virtual string Usuario
	    {
			get
	        {
				return base.Getstring(ColumnNames.Usuario);
			}
			set
	        {
				base.Setstring(ColumnNames.Usuario, value);
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


		#endregion
		
		#region String Properties
	
		public virtual string s_Identificador_rastreo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Identificador_rastreo) ? string.Empty : base.GetstringAsString(ColumnNames.Identificador_rastreo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Identificador_rastreo);
				else
					this.Identificador_rastreo = base.SetstringAsString(ColumnNames.Identificador_rastreo, value);
			}
		}

		public virtual string s_Idrastreogps_cola_de_comandos
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_cola_de_comandos) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_cola_de_comandos);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_cola_de_comandos);
				else
					this.Idrastreogps_cola_de_comandos = base.SetintAsString(ColumnNames.Idrastreogps_cola_de_comandos, value);
			}
		}

		public virtual string s_Idrastreogps_equipogps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_equipogps) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_equipogps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_equipogps);
				else
					this.Idrastreogps_equipogps = base.SetintAsString(ColumnNames.Idrastreogps_equipogps, value);
			}
		}

		public virtual string s_Id_equipo_gps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_equipo_gps) ? string.Empty : base.GetstringAsString(ColumnNames.Id_equipo_gps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_equipo_gps);
				else
					this.Id_equipo_gps = base.SetstringAsString(ColumnNames.Id_equipo_gps, value);
			}
		}

		public virtual string s_Id_simcard
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_simcard) ? string.Empty : base.GetintAsString(ColumnNames.Id_simcard);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_simcard);
				else
					this.Id_simcard = base.SetintAsString(ColumnNames.Id_simcard, value);
			}
		}

		public virtual string s_Tipoequipo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipoequipo) ? string.Empty : base.GetintAsString(ColumnNames.Tipoequipo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipoequipo);
				else
					this.Tipoequipo = base.SetintAsString(ColumnNames.Tipoequipo, value);
			}
		}

		public virtual string s_Tipo_equipo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipo_equipo) ? string.Empty : base.GetstringAsString(ColumnNames.Tipo_equipo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipo_equipo);
				else
					this.Tipo_equipo = base.SetstringAsString(ColumnNames.Tipo_equipo, value);
			}
		}

		public virtual string s_Sim_nro
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sim_nro) ? string.Empty : base.GetstringAsString(ColumnNames.Sim_nro);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sim_nro);
				else
					this.Sim_nro = base.SetstringAsString(ColumnNames.Sim_nro, value);
			}
		}

		public virtual string s_Comando
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Comando) ? string.Empty : base.GetstringAsString(ColumnNames.Comando);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Comando);
				else
					this.Comando = base.SetstringAsString(ColumnNames.Comando, value);
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

		public virtual string s_Enviado
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Enviado) ? string.Empty : base.GetboolAsString(ColumnNames.Enviado);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Enviado);
				else
					this.Enviado = base.SetboolAsString(ColumnNames.Enviado, value);
			}
		}

		public virtual string s_Gps_ip
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Gps_ip) ? string.Empty : base.GetstringAsString(ColumnNames.Gps_ip);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Gps_ip);
				else
					this.Gps_ip = base.SetstringAsString(ColumnNames.Gps_ip, value);
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

		public virtual string s_Usuario
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Usuario) ? string.Empty : base.GetstringAsString(ColumnNames.Usuario);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Usuario);
				else
					this.Usuario = base.SetstringAsString(ColumnNames.Usuario, value);
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
				
				
				public WhereParameter Identificador_rastreo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Identificador_rastreo, Parameters.Identificador_rastreo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Idrastreogps_cola_de_comandos
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_cola_de_comandos, Parameters.Idrastreogps_cola_de_comandos);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Idrastreogps_equipogps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_equipogps, Parameters.Idrastreogps_equipogps);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_equipo_gps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_equipo_gps, Parameters.Id_equipo_gps);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_simcard
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_simcard, Parameters.Id_simcard);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Tipoequipo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipoequipo, Parameters.Tipoequipo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Tipo_equipo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipo_equipo, Parameters.Tipo_equipo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sim_nro
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sim_nro, Parameters.Sim_nro);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Comando
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Comando, Parameters.Comando);
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

				public WhereParameter Enviado
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Enviado, Parameters.Enviado);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Gps_ip
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Gps_ip, Parameters.Gps_ip);
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

				public WhereParameter Usuario
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Usuario, Parameters.Usuario);
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


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Identificador_rastreo
		    {
				get
		        {
					if(_Identificador_rastreo_W == null)
	        	    {
						_Identificador_rastreo_W = TearOff.Identificador_rastreo;
					}
					return _Identificador_rastreo_W;
				}
			}

			public WhereParameter Idrastreogps_cola_de_comandos
		    {
				get
		        {
					if(_Idrastreogps_cola_de_comandos_W == null)
	        	    {
						_Idrastreogps_cola_de_comandos_W = TearOff.Idrastreogps_cola_de_comandos;
					}
					return _Idrastreogps_cola_de_comandos_W;
				}
			}

			public WhereParameter Idrastreogps_equipogps
		    {
				get
		        {
					if(_Idrastreogps_equipogps_W == null)
	        	    {
						_Idrastreogps_equipogps_W = TearOff.Idrastreogps_equipogps;
					}
					return _Idrastreogps_equipogps_W;
				}
			}

			public WhereParameter Id_equipo_gps
		    {
				get
		        {
					if(_Id_equipo_gps_W == null)
	        	    {
						_Id_equipo_gps_W = TearOff.Id_equipo_gps;
					}
					return _Id_equipo_gps_W;
				}
			}

			public WhereParameter Id_simcard
		    {
				get
		        {
					if(_Id_simcard_W == null)
	        	    {
						_Id_simcard_W = TearOff.Id_simcard;
					}
					return _Id_simcard_W;
				}
			}

			public WhereParameter Tipoequipo
		    {
				get
		        {
					if(_Tipoequipo_W == null)
	        	    {
						_Tipoequipo_W = TearOff.Tipoequipo;
					}
					return _Tipoequipo_W;
				}
			}

			public WhereParameter Tipo_equipo
		    {
				get
		        {
					if(_Tipo_equipo_W == null)
	        	    {
						_Tipo_equipo_W = TearOff.Tipo_equipo;
					}
					return _Tipo_equipo_W;
				}
			}

			public WhereParameter Sim_nro
		    {
				get
		        {
					if(_Sim_nro_W == null)
	        	    {
						_Sim_nro_W = TearOff.Sim_nro;
					}
					return _Sim_nro_W;
				}
			}

			public WhereParameter Comando
		    {
				get
		        {
					if(_Comando_W == null)
	        	    {
						_Comando_W = TearOff.Comando;
					}
					return _Comando_W;
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

			public WhereParameter Enviado
		    {
				get
		        {
					if(_Enviado_W == null)
	        	    {
						_Enviado_W = TearOff.Enviado;
					}
					return _Enviado_W;
				}
			}

			public WhereParameter Gps_ip
		    {
				get
		        {
					if(_Gps_ip_W == null)
	        	    {
						_Gps_ip_W = TearOff.Gps_ip;
					}
					return _Gps_ip_W;
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

			public WhereParameter Usuario
		    {
				get
		        {
					if(_Usuario_W == null)
	        	    {
						_Usuario_W = TearOff.Usuario;
					}
					return _Usuario_W;
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

			private WhereParameter _Identificador_rastreo_W = null;
			private WhereParameter _Idrastreogps_cola_de_comandos_W = null;
			private WhereParameter _Idrastreogps_equipogps_W = null;
			private WhereParameter _Id_equipo_gps_W = null;
			private WhereParameter _Id_simcard_W = null;
			private WhereParameter _Tipoequipo_W = null;
			private WhereParameter _Tipo_equipo_W = null;
			private WhereParameter _Sim_nro_W = null;
			private WhereParameter _Comando_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _Enviado_W = null;
			private WhereParameter _Gps_ip_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Usuario_W = null;
			private WhereParameter _Fech_ins_W = null;

			public void WhereClauseReset()
			{
				_Identificador_rastreo_W = null;
				_Idrastreogps_cola_de_comandos_W = null;
				_Idrastreogps_equipogps_W = null;
				_Id_equipo_gps_W = null;
				_Id_simcard_W = null;
				_Tipoequipo_W = null;
				_Tipo_equipo_W = null;
				_Sim_nro_W = null;
				_Comando_W = null;
				_Descripcion_W = null;
				_Enviado_W = null;
				_Gps_ip_W = null;
				_User_ins_W = null;
				_Usuario_W = null;
				_Fech_ins_W = null;

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
				
				
				public AggregateParameter Identificador_rastreo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Identificador_rastreo, Parameters.Identificador_rastreo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Idrastreogps_cola_de_comandos
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_cola_de_comandos, Parameters.Idrastreogps_cola_de_comandos);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Idrastreogps_equipogps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_equipogps, Parameters.Idrastreogps_equipogps);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_equipo_gps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_equipo_gps, Parameters.Id_equipo_gps);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_simcard
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_simcard, Parameters.Id_simcard);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Tipoequipo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipoequipo, Parameters.Tipoequipo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Tipo_equipo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_equipo, Parameters.Tipo_equipo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sim_nro
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sim_nro, Parameters.Sim_nro);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Comando
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Comando, Parameters.Comando);
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

				public AggregateParameter Enviado
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Enviado, Parameters.Enviado);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Gps_ip
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gps_ip, Parameters.Gps_ip);
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

				public AggregateParameter Usuario
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Usuario, Parameters.Usuario);
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


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Identificador_rastreo
		    {
				get
		        {
					if(_Identificador_rastreo_W == null)
	        	    {
						_Identificador_rastreo_W = TearOff.Identificador_rastreo;
					}
					return _Identificador_rastreo_W;
				}
			}

			public AggregateParameter Idrastreogps_cola_de_comandos
		    {
				get
		        {
					if(_Idrastreogps_cola_de_comandos_W == null)
	        	    {
						_Idrastreogps_cola_de_comandos_W = TearOff.Idrastreogps_cola_de_comandos;
					}
					return _Idrastreogps_cola_de_comandos_W;
				}
			}

			public AggregateParameter Idrastreogps_equipogps
		    {
				get
		        {
					if(_Idrastreogps_equipogps_W == null)
	        	    {
						_Idrastreogps_equipogps_W = TearOff.Idrastreogps_equipogps;
					}
					return _Idrastreogps_equipogps_W;
				}
			}

			public AggregateParameter Id_equipo_gps
		    {
				get
		        {
					if(_Id_equipo_gps_W == null)
	        	    {
						_Id_equipo_gps_W = TearOff.Id_equipo_gps;
					}
					return _Id_equipo_gps_W;
				}
			}

			public AggregateParameter Id_simcard
		    {
				get
		        {
					if(_Id_simcard_W == null)
	        	    {
						_Id_simcard_W = TearOff.Id_simcard;
					}
					return _Id_simcard_W;
				}
			}

			public AggregateParameter Tipoequipo
		    {
				get
		        {
					if(_Tipoequipo_W == null)
	        	    {
						_Tipoequipo_W = TearOff.Tipoequipo;
					}
					return _Tipoequipo_W;
				}
			}

			public AggregateParameter Tipo_equipo
		    {
				get
		        {
					if(_Tipo_equipo_W == null)
	        	    {
						_Tipo_equipo_W = TearOff.Tipo_equipo;
					}
					return _Tipo_equipo_W;
				}
			}

			public AggregateParameter Sim_nro
		    {
				get
		        {
					if(_Sim_nro_W == null)
	        	    {
						_Sim_nro_W = TearOff.Sim_nro;
					}
					return _Sim_nro_W;
				}
			}

			public AggregateParameter Comando
		    {
				get
		        {
					if(_Comando_W == null)
	        	    {
						_Comando_W = TearOff.Comando;
					}
					return _Comando_W;
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

			public AggregateParameter Enviado
		    {
				get
		        {
					if(_Enviado_W == null)
	        	    {
						_Enviado_W = TearOff.Enviado;
					}
					return _Enviado_W;
				}
			}

			public AggregateParameter Gps_ip
		    {
				get
		        {
					if(_Gps_ip_W == null)
	        	    {
						_Gps_ip_W = TearOff.Gps_ip;
					}
					return _Gps_ip_W;
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

			public AggregateParameter Usuario
		    {
				get
		        {
					if(_Usuario_W == null)
	        	    {
						_Usuario_W = TearOff.Usuario;
					}
					return _Usuario_W;
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

			private AggregateParameter _Identificador_rastreo_W = null;
			private AggregateParameter _Idrastreogps_cola_de_comandos_W = null;
			private AggregateParameter _Idrastreogps_equipogps_W = null;
			private AggregateParameter _Id_equipo_gps_W = null;
			private AggregateParameter _Id_simcard_W = null;
			private AggregateParameter _Tipoequipo_W = null;
			private AggregateParameter _Tipo_equipo_W = null;
			private AggregateParameter _Sim_nro_W = null;
			private AggregateParameter _Comando_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _Enviado_W = null;
			private AggregateParameter _Gps_ip_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Usuario_W = null;
			private AggregateParameter _Fech_ins_W = null;

			public void AggregateClauseReset()
			{
				_Identificador_rastreo_W = null;
				_Idrastreogps_cola_de_comandos_W = null;
				_Idrastreogps_equipogps_W = null;
				_Id_equipo_gps_W = null;
				_Id_simcard_W = null;
				_Tipoequipo_W = null;
				_Tipo_equipo_W = null;
				_Sim_nro_W = null;
				_Comando_W = null;
				_Descripcion_W = null;
				_Enviado_W = null;
				_Gps_ip_W = null;
				_User_ins_W = null;
				_Usuario_W = null;
				_Fech_ins_W = null;

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
