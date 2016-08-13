/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rsview_avisos_equipo_vehiculo_cliente para la vista rsview_avisos_equipo_vehiculo_cliente.
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
	public class rsview_avisos_equipo_vehiculo_cliente : PostgreSqlEntity
	{
		public rsview_avisos_equipo_vehiculo_cliente(String laCadenaDeConexion)
		{
			this.QuerySource = "rsview_avisos_equipo_vehiculo_cliente";
			this.MappingName = "rsview_avisos_equipo_vehiculo_cliente";
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
			
			public static NpgsqlParameter Habilitado
			{
				get
				{
					return new NpgsqlParameter("Habilitado", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Descripcion
			{
				get
				{
					return new NpgsqlParameter("Descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Idrastreogps_tipo_evento
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_tipo_evento", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
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
			
			public static NpgsqlParameter Color_evento
			{
				get
				{
					return new NpgsqlParameter("Color_evento", NpgsqlTypes.NpgsqlDbType.Varchar, 16);
				}
			}
			
			public static NpgsqlParameter Sonoro
			{
				get
				{
					return new NpgsqlParameter("Sonoro", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Arch_sonido
			{
				get
				{
					return new NpgsqlParameter("Arch_sonido", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Sonoro_tipoevento
			{
				get
				{
					return new NpgsqlParameter("Sonoro_tipoevento", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Soundfile_sonoro_tipoevento
			{
				get
				{
					return new NpgsqlParameter("Soundfile_sonoro_tipoevento", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Id_persona
			{
				get
				{
					return new NpgsqlParameter("Id_persona", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_vehiculo
			{
				get
				{
					return new NpgsqlParameter("Id_vehiculo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_equipo_gps
			{
				get
				{
					return new NpgsqlParameter("Id_equipo_gps", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Identificador_rastreo
			{
				get
				{
					return new NpgsqlParameter("Identificador_rastreo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
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
			
			public static NpgsqlParameter Rumbo
			{
				get
				{
					return new NpgsqlParameter("Rumbo", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Cliente
			{
				get
				{
					return new NpgsqlParameter("Cliente", NpgsqlTypes.NpgsqlDbType.Varchar, 0);
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
			
			public static NpgsqlParameter Email
			{
				get
				{
					return new NpgsqlParameter("Email", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Estado_cliente
			{
				get
				{
					return new NpgsqlParameter("Estado_cliente", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Clave_personal
			{
				get
				{
					return new NpgsqlParameter("Clave_personal", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Sendmail
			{
				get
				{
					return new NpgsqlParameter("Sendmail", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Habilitado = "habilitado";
            public const string Descripcion = "descripcion";
            public const string Idrastreogps_tipo_evento = "idrastreogps_tipo_evento";
            public const string Idrastreogps_avisos = "idrastreogps_avisos";
            public const string Id_equipogps = "id_equipogps";
            public const string Evento = "evento";
            public const string Evento_fechahora = "evento_fechahora";
            public const string Atendido = "atendido";
            public const string Color_evento = "color_evento";
            public const string Sonoro = "sonoro";
            public const string Arch_sonido = "arch_sonido";
            public const string Sonoro_tipoevento = "sonoro_tipoevento";
            public const string Soundfile_sonoro_tipoevento = "soundfile_sonoro_tipoevento";
            public const string Id_persona = "id_persona";
            public const string Id_vehiculo = "id_vehiculo";
            public const string Id_equipo_gps = "id_equipo_gps";
            public const string Identificador_rastreo = "identificador_rastreo";
            public const string Gps_fechahora_reporte = "gps_fechahora_reporte";
            public const string Gps_latitud = "gps_latitud";
            public const string Gps_longitud = "gps_longitud";
            public const string Gps_velocidad = "gps_velocidad";
            public const string Gps_rumbo = "gps_rumbo";
            public const string Gps_dir = "gps_dir";
            public const string Rumbo = "rumbo";
            public const string Cliente = "cliente";
            public const string Tel_movil = "tel_movil";
            public const string Tel_part = "tel_part";
            public const string Tel_ofi = "tel_ofi";
            public const string Email = "email";
            public const string Estado_cliente = "estado_cliente";
            public const string Clave_personal = "clave_personal";
            public const string Sendmail = "sendmail";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Habilitado] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Habilitado;
					ht[Descripcion] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Descripcion;
					ht[Idrastreogps_tipo_evento] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Idrastreogps_tipo_evento;
					ht[Idrastreogps_avisos] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Idrastreogps_avisos;
					ht[Id_equipogps] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Id_equipogps;
					ht[Evento] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Evento;
					ht[Evento_fechahora] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Evento_fechahora;
					ht[Atendido] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Atendido;
					ht[Color_evento] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Color_evento;
					ht[Sonoro] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Sonoro;
					ht[Arch_sonido] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Arch_sonido;
					ht[Sonoro_tipoevento] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Sonoro_tipoevento;
					ht[Soundfile_sonoro_tipoevento] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Soundfile_sonoro_tipoevento;
					ht[Id_persona] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Id_persona;
					ht[Id_vehiculo] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Id_vehiculo;
					ht[Id_equipo_gps] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Id_equipo_gps;
					ht[Identificador_rastreo] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Identificador_rastreo;
					ht[Gps_fechahora_reporte] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Gps_fechahora_reporte;
					ht[Gps_latitud] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Gps_latitud;
					ht[Gps_longitud] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Gps_longitud;
					ht[Gps_velocidad] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Gps_velocidad;
					ht[Gps_rumbo] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Gps_rumbo;
					ht[Gps_dir] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Gps_dir;
					ht[Rumbo] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Rumbo;
					ht[Cliente] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Cliente;
					ht[Tel_movil] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Tel_movil;
					ht[Tel_part] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Tel_part;
					ht[Tel_ofi] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Tel_ofi;
					ht[Email] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Email;
					ht[Estado_cliente] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Estado_cliente;
					ht[Clave_personal] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Clave_personal;
					ht[Sendmail] = rsview_avisos_equipo_vehiculo_cliente.PropertyNames.Sendmail;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Habilitado = "Habilitado";
            public const string Descripcion = "Descripcion";
            public const string Idrastreogps_tipo_evento = "Idrastreogps_tipo_evento";
            public const string Idrastreogps_avisos = "Idrastreogps_avisos";
            public const string Id_equipogps = "Id_equipogps";
            public const string Evento = "Evento";
            public const string Evento_fechahora = "Evento_fechahora";
            public const string Atendido = "Atendido";
            public const string Color_evento = "Color_evento";
            public const string Sonoro = "Sonoro";
            public const string Arch_sonido = "Arch_sonido";
            public const string Sonoro_tipoevento = "Sonoro_tipoevento";
            public const string Soundfile_sonoro_tipoevento = "Soundfile_sonoro_tipoevento";
            public const string Id_persona = "Id_persona";
            public const string Id_vehiculo = "Id_vehiculo";
            public const string Id_equipo_gps = "Id_equipo_gps";
            public const string Identificador_rastreo = "Identificador_rastreo";
            public const string Gps_fechahora_reporte = "Gps_fechahora_reporte";
            public const string Gps_latitud = "Gps_latitud";
            public const string Gps_longitud = "Gps_longitud";
            public const string Gps_velocidad = "Gps_velocidad";
            public const string Gps_rumbo = "Gps_rumbo";
            public const string Gps_dir = "Gps_dir";
            public const string Rumbo = "Rumbo";
            public const string Cliente = "Cliente";
            public const string Tel_movil = "Tel_movil";
            public const string Tel_part = "Tel_part";
            public const string Tel_ofi = "Tel_ofi";
            public const string Email = "Email";
            public const string Estado_cliente = "Estado_cliente";
            public const string Clave_personal = "Clave_personal";
            public const string Sendmail = "Sendmail";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Habilitado] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Habilitado;
					ht[Descripcion] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Descripcion;
					ht[Idrastreogps_tipo_evento] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Idrastreogps_tipo_evento;
					ht[Idrastreogps_avisos] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Idrastreogps_avisos;
					ht[Id_equipogps] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_equipogps;
					ht[Evento] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Evento;
					ht[Evento_fechahora] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Evento_fechahora;
					ht[Atendido] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Atendido;
					ht[Color_evento] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Color_evento;
					ht[Sonoro] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sonoro;
					ht[Arch_sonido] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Arch_sonido;
					ht[Sonoro_tipoevento] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sonoro_tipoevento;
					ht[Soundfile_sonoro_tipoevento] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Soundfile_sonoro_tipoevento;
					ht[Id_persona] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_persona;
					ht[Id_vehiculo] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_vehiculo;
					ht[Id_equipo_gps] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_equipo_gps;
					ht[Identificador_rastreo] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Identificador_rastreo;
					ht[Gps_fechahora_reporte] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_fechahora_reporte;
					ht[Gps_latitud] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_latitud;
					ht[Gps_longitud] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_longitud;
					ht[Gps_velocidad] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_velocidad;
					ht[Gps_rumbo] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_rumbo;
					ht[Gps_dir] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_dir;
					ht[Rumbo] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Rumbo;
					ht[Cliente] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Cliente;
					ht[Tel_movil] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Tel_movil;
					ht[Tel_part] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Tel_part;
					ht[Tel_ofi] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Tel_ofi;
					ht[Email] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Email;
					ht[Estado_cliente] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Estado_cliente;
					ht[Clave_personal] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Clave_personal;
					ht[Sendmail] = rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sendmail;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Habilitado = "s_Habilitado";
            public const string Descripcion = "s_Descripcion";
            public const string Idrastreogps_tipo_evento = "s_Idrastreogps_tipo_evento";
            public const string Idrastreogps_avisos = "s_Idrastreogps_avisos";
            public const string Id_equipogps = "s_Id_equipogps";
            public const string Evento = "s_Evento";
            public const string Evento_fechahora = "s_Evento_fechahora";
            public const string Atendido = "s_Atendido";
            public const string Color_evento = "s_Color_evento";
            public const string Sonoro = "s_Sonoro";
            public const string Arch_sonido = "s_Arch_sonido";
            public const string Sonoro_tipoevento = "s_Sonoro_tipoevento";
            public const string Soundfile_sonoro_tipoevento = "s_Soundfile_sonoro_tipoevento";
            public const string Id_persona = "s_Id_persona";
            public const string Id_vehiculo = "s_Id_vehiculo";
            public const string Id_equipo_gps = "s_Id_equipo_gps";
            public const string Identificador_rastreo = "s_Identificador_rastreo";
            public const string Gps_fechahora_reporte = "s_Gps_fechahora_reporte";
            public const string Gps_latitud = "s_Gps_latitud";
            public const string Gps_longitud = "s_Gps_longitud";
            public const string Gps_velocidad = "s_Gps_velocidad";
            public const string Gps_rumbo = "s_Gps_rumbo";
            public const string Gps_dir = "s_Gps_dir";
            public const string Rumbo = "s_Rumbo";
            public const string Cliente = "s_Cliente";
            public const string Tel_movil = "s_Tel_movil";
            public const string Tel_part = "s_Tel_part";
            public const string Tel_ofi = "s_Tel_ofi";
            public const string Email = "s_Email";
            public const string Estado_cliente = "s_Estado_cliente";
            public const string Clave_personal = "s_Clave_personal";
            public const string Sendmail = "s_Sendmail";

		}
		#endregion	
		
		#region Properties
			public virtual bool Habilitado
	    {
			get
	        {
				return base.Getbool(ColumnNames.Habilitado);
			}
			set
	        {
				base.Setbool(ColumnNames.Habilitado, value);
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

		public virtual int Idrastreogps_tipo_evento
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_tipo_evento);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_tipo_evento, value);
			}
		}

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

		public virtual string Color_evento
	    {
			get
	        {
				return base.Getstring(ColumnNames.Color_evento);
			}
			set
	        {
				base.Setstring(ColumnNames.Color_evento, value);
			}
		}

		public virtual bool Sonoro
	    {
			get
	        {
				return base.Getbool(ColumnNames.Sonoro);
			}
			set
	        {
				base.Setbool(ColumnNames.Sonoro, value);
			}
		}

		public virtual string Arch_sonido
	    {
			get
	        {
				return base.Getstring(ColumnNames.Arch_sonido);
			}
			set
	        {
				base.Setstring(ColumnNames.Arch_sonido, value);
			}
		}

		public virtual bool Sonoro_tipoevento
	    {
			get
	        {
				return base.Getbool(ColumnNames.Sonoro_tipoevento);
			}
			set
	        {
				base.Setbool(ColumnNames.Sonoro_tipoevento, value);
			}
		}

		public virtual string Soundfile_sonoro_tipoevento
	    {
			get
	        {
				return base.Getstring(ColumnNames.Soundfile_sonoro_tipoevento);
			}
			set
	        {
				base.Setstring(ColumnNames.Soundfile_sonoro_tipoevento, value);
			}
		}

		public virtual int Id_persona
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_persona);
			}
			set
	        {
				base.Setint(ColumnNames.Id_persona, value);
			}
		}

		public virtual int Id_vehiculo
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_vehiculo);
			}
			set
	        {
				base.Setint(ColumnNames.Id_vehiculo, value);
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

		public virtual string Rumbo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Rumbo);
			}
			set
	        {
				base.Setstring(ColumnNames.Rumbo, value);
			}
		}

		public virtual string Cliente
	    {
			get
	        {
				return base.Getstring(ColumnNames.Cliente);
			}
			set
	        {
				base.Setstring(ColumnNames.Cliente, value);
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

		public virtual string Sendmail
	    {
			get
	        {
				return base.Getstring(ColumnNames.Sendmail);
			}
			set
	        {
				base.Setstring(ColumnNames.Sendmail, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Habilitado
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Habilitado) ? string.Empty : base.GetboolAsString(ColumnNames.Habilitado);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Habilitado);
				else
					this.Habilitado = base.SetboolAsString(ColumnNames.Habilitado, value);
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

		public virtual string s_Idrastreogps_tipo_evento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_tipo_evento) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_tipo_evento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_tipo_evento);
				else
					this.Idrastreogps_tipo_evento = base.SetintAsString(ColumnNames.Idrastreogps_tipo_evento, value);
			}
		}

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

		public virtual string s_Color_evento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Color_evento) ? string.Empty : base.GetstringAsString(ColumnNames.Color_evento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Color_evento);
				else
					this.Color_evento = base.SetstringAsString(ColumnNames.Color_evento, value);
			}
		}

		public virtual string s_Sonoro
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sonoro) ? string.Empty : base.GetboolAsString(ColumnNames.Sonoro);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sonoro);
				else
					this.Sonoro = base.SetboolAsString(ColumnNames.Sonoro, value);
			}
		}

		public virtual string s_Arch_sonido
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Arch_sonido) ? string.Empty : base.GetstringAsString(ColumnNames.Arch_sonido);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Arch_sonido);
				else
					this.Arch_sonido = base.SetstringAsString(ColumnNames.Arch_sonido, value);
			}
		}

		public virtual string s_Sonoro_tipoevento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sonoro_tipoevento) ? string.Empty : base.GetboolAsString(ColumnNames.Sonoro_tipoevento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sonoro_tipoevento);
				else
					this.Sonoro_tipoevento = base.SetboolAsString(ColumnNames.Sonoro_tipoevento, value);
			}
		}

		public virtual string s_Soundfile_sonoro_tipoevento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Soundfile_sonoro_tipoevento) ? string.Empty : base.GetstringAsString(ColumnNames.Soundfile_sonoro_tipoevento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Soundfile_sonoro_tipoevento);
				else
					this.Soundfile_sonoro_tipoevento = base.SetstringAsString(ColumnNames.Soundfile_sonoro_tipoevento, value);
			}
		}

		public virtual string s_Id_persona
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_persona) ? string.Empty : base.GetintAsString(ColumnNames.Id_persona);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_persona);
				else
					this.Id_persona = base.SetintAsString(ColumnNames.Id_persona, value);
			}
		}

		public virtual string s_Id_vehiculo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_vehiculo) ? string.Empty : base.GetintAsString(ColumnNames.Id_vehiculo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_vehiculo);
				else
					this.Id_vehiculo = base.SetintAsString(ColumnNames.Id_vehiculo, value);
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

		public virtual string s_Rumbo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Rumbo) ? string.Empty : base.GetstringAsString(ColumnNames.Rumbo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Rumbo);
				else
					this.Rumbo = base.SetstringAsString(ColumnNames.Rumbo, value);
			}
		}

		public virtual string s_Cliente
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Cliente) ? string.Empty : base.GetstringAsString(ColumnNames.Cliente);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Cliente);
				else
					this.Cliente = base.SetstringAsString(ColumnNames.Cliente, value);
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

		public virtual string s_Sendmail
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sendmail) ? string.Empty : base.GetstringAsString(ColumnNames.Sendmail);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sendmail);
				else
					this.Sendmail = base.SetstringAsString(ColumnNames.Sendmail, value);
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
				
				
				public WhereParameter Habilitado
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Habilitado, Parameters.Habilitado);
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

				public WhereParameter Idrastreogps_tipo_evento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_tipo_evento, Parameters.Idrastreogps_tipo_evento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
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

				public WhereParameter Color_evento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Color_evento, Parameters.Color_evento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sonoro
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sonoro, Parameters.Sonoro);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Arch_sonido
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Arch_sonido, Parameters.Arch_sonido);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sonoro_tipoevento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sonoro_tipoevento, Parameters.Sonoro_tipoevento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Soundfile_sonoro_tipoevento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Soundfile_sonoro_tipoevento, Parameters.Soundfile_sonoro_tipoevento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_persona
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_persona, Parameters.Id_persona);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_vehiculo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_vehiculo, Parameters.Id_vehiculo);
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

				public WhereParameter Identificador_rastreo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Identificador_rastreo, Parameters.Identificador_rastreo);
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

				public WhereParameter Rumbo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Rumbo, Parameters.Rumbo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Cliente
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Cliente, Parameters.Cliente);
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

				public WhereParameter Email
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Email, Parameters.Email);
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

				public WhereParameter Clave_personal
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Clave_personal, Parameters.Clave_personal);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sendmail
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sendmail, Parameters.Sendmail);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Habilitado
		    {
				get
		        {
					if(_Habilitado_W == null)
	        	    {
						_Habilitado_W = TearOff.Habilitado;
					}
					return _Habilitado_W;
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

			public WhereParameter Idrastreogps_tipo_evento
		    {
				get
		        {
					if(_Idrastreogps_tipo_evento_W == null)
	        	    {
						_Idrastreogps_tipo_evento_W = TearOff.Idrastreogps_tipo_evento;
					}
					return _Idrastreogps_tipo_evento_W;
				}
			}

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

			public WhereParameter Color_evento
		    {
				get
		        {
					if(_Color_evento_W == null)
	        	    {
						_Color_evento_W = TearOff.Color_evento;
					}
					return _Color_evento_W;
				}
			}

			public WhereParameter Sonoro
		    {
				get
		        {
					if(_Sonoro_W == null)
	        	    {
						_Sonoro_W = TearOff.Sonoro;
					}
					return _Sonoro_W;
				}
			}

			public WhereParameter Arch_sonido
		    {
				get
		        {
					if(_Arch_sonido_W == null)
	        	    {
						_Arch_sonido_W = TearOff.Arch_sonido;
					}
					return _Arch_sonido_W;
				}
			}

			public WhereParameter Sonoro_tipoevento
		    {
				get
		        {
					if(_Sonoro_tipoevento_W == null)
	        	    {
						_Sonoro_tipoevento_W = TearOff.Sonoro_tipoevento;
					}
					return _Sonoro_tipoevento_W;
				}
			}

			public WhereParameter Soundfile_sonoro_tipoevento
		    {
				get
		        {
					if(_Soundfile_sonoro_tipoevento_W == null)
	        	    {
						_Soundfile_sonoro_tipoevento_W = TearOff.Soundfile_sonoro_tipoevento;
					}
					return _Soundfile_sonoro_tipoevento_W;
				}
			}

			public WhereParameter Id_persona
		    {
				get
		        {
					if(_Id_persona_W == null)
	        	    {
						_Id_persona_W = TearOff.Id_persona;
					}
					return _Id_persona_W;
				}
			}

			public WhereParameter Id_vehiculo
		    {
				get
		        {
					if(_Id_vehiculo_W == null)
	        	    {
						_Id_vehiculo_W = TearOff.Id_vehiculo;
					}
					return _Id_vehiculo_W;
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

			public WhereParameter Rumbo
		    {
				get
		        {
					if(_Rumbo_W == null)
	        	    {
						_Rumbo_W = TearOff.Rumbo;
					}
					return _Rumbo_W;
				}
			}

			public WhereParameter Cliente
		    {
				get
		        {
					if(_Cliente_W == null)
	        	    {
						_Cliente_W = TearOff.Cliente;
					}
					return _Cliente_W;
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

			public WhereParameter Sendmail
		    {
				get
		        {
					if(_Sendmail_W == null)
	        	    {
						_Sendmail_W = TearOff.Sendmail;
					}
					return _Sendmail_W;
				}
			}

			private WhereParameter _Habilitado_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _Idrastreogps_tipo_evento_W = null;
			private WhereParameter _Idrastreogps_avisos_W = null;
			private WhereParameter _Id_equipogps_W = null;
			private WhereParameter _Evento_W = null;
			private WhereParameter _Evento_fechahora_W = null;
			private WhereParameter _Atendido_W = null;
			private WhereParameter _Color_evento_W = null;
			private WhereParameter _Sonoro_W = null;
			private WhereParameter _Arch_sonido_W = null;
			private WhereParameter _Sonoro_tipoevento_W = null;
			private WhereParameter _Soundfile_sonoro_tipoevento_W = null;
			private WhereParameter _Id_persona_W = null;
			private WhereParameter _Id_vehiculo_W = null;
			private WhereParameter _Id_equipo_gps_W = null;
			private WhereParameter _Identificador_rastreo_W = null;
			private WhereParameter _Gps_fechahora_reporte_W = null;
			private WhereParameter _Gps_latitud_W = null;
			private WhereParameter _Gps_longitud_W = null;
			private WhereParameter _Gps_velocidad_W = null;
			private WhereParameter _Gps_rumbo_W = null;
			private WhereParameter _Gps_dir_W = null;
			private WhereParameter _Rumbo_W = null;
			private WhereParameter _Cliente_W = null;
			private WhereParameter _Tel_movil_W = null;
			private WhereParameter _Tel_part_W = null;
			private WhereParameter _Tel_ofi_W = null;
			private WhereParameter _Email_W = null;
			private WhereParameter _Estado_cliente_W = null;
			private WhereParameter _Clave_personal_W = null;
			private WhereParameter _Sendmail_W = null;

			public void WhereClauseReset()
			{
				_Habilitado_W = null;
				_Descripcion_W = null;
				_Idrastreogps_tipo_evento_W = null;
				_Idrastreogps_avisos_W = null;
				_Id_equipogps_W = null;
				_Evento_W = null;
				_Evento_fechahora_W = null;
				_Atendido_W = null;
				_Color_evento_W = null;
				_Sonoro_W = null;
				_Arch_sonido_W = null;
				_Sonoro_tipoevento_W = null;
				_Soundfile_sonoro_tipoevento_W = null;
				_Id_persona_W = null;
				_Id_vehiculo_W = null;
				_Id_equipo_gps_W = null;
				_Identificador_rastreo_W = null;
				_Gps_fechahora_reporte_W = null;
				_Gps_latitud_W = null;
				_Gps_longitud_W = null;
				_Gps_velocidad_W = null;
				_Gps_rumbo_W = null;
				_Gps_dir_W = null;
				_Rumbo_W = null;
				_Cliente_W = null;
				_Tel_movil_W = null;
				_Tel_part_W = null;
				_Tel_ofi_W = null;
				_Email_W = null;
				_Estado_cliente_W = null;
				_Clave_personal_W = null;
				_Sendmail_W = null;

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
				
				
				public AggregateParameter Habilitado
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Habilitado, Parameters.Habilitado);
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

				public AggregateParameter Idrastreogps_tipo_evento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_tipo_evento, Parameters.Idrastreogps_tipo_evento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
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

				public AggregateParameter Color_evento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Color_evento, Parameters.Color_evento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sonoro
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sonoro, Parameters.Sonoro);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Arch_sonido
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Arch_sonido, Parameters.Arch_sonido);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sonoro_tipoevento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sonoro_tipoevento, Parameters.Sonoro_tipoevento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Soundfile_sonoro_tipoevento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Soundfile_sonoro_tipoevento, Parameters.Soundfile_sonoro_tipoevento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_persona
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_persona, Parameters.Id_persona);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_vehiculo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_vehiculo, Parameters.Id_vehiculo);
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

				public AggregateParameter Identificador_rastreo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Identificador_rastreo, Parameters.Identificador_rastreo);
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

				public AggregateParameter Rumbo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Rumbo, Parameters.Rumbo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Cliente
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Cliente, Parameters.Cliente);
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

				public AggregateParameter Email
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Email, Parameters.Email);
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

				public AggregateParameter Clave_personal
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Clave_personal, Parameters.Clave_personal);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sendmail
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sendmail, Parameters.Sendmail);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Habilitado
		    {
				get
		        {
					if(_Habilitado_W == null)
	        	    {
						_Habilitado_W = TearOff.Habilitado;
					}
					return _Habilitado_W;
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

			public AggregateParameter Idrastreogps_tipo_evento
		    {
				get
		        {
					if(_Idrastreogps_tipo_evento_W == null)
	        	    {
						_Idrastreogps_tipo_evento_W = TearOff.Idrastreogps_tipo_evento;
					}
					return _Idrastreogps_tipo_evento_W;
				}
			}

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

			public AggregateParameter Color_evento
		    {
				get
		        {
					if(_Color_evento_W == null)
	        	    {
						_Color_evento_W = TearOff.Color_evento;
					}
					return _Color_evento_W;
				}
			}

			public AggregateParameter Sonoro
		    {
				get
		        {
					if(_Sonoro_W == null)
	        	    {
						_Sonoro_W = TearOff.Sonoro;
					}
					return _Sonoro_W;
				}
			}

			public AggregateParameter Arch_sonido
		    {
				get
		        {
					if(_Arch_sonido_W == null)
	        	    {
						_Arch_sonido_W = TearOff.Arch_sonido;
					}
					return _Arch_sonido_W;
				}
			}

			public AggregateParameter Sonoro_tipoevento
		    {
				get
		        {
					if(_Sonoro_tipoevento_W == null)
	        	    {
						_Sonoro_tipoevento_W = TearOff.Sonoro_tipoevento;
					}
					return _Sonoro_tipoevento_W;
				}
			}

			public AggregateParameter Soundfile_sonoro_tipoevento
		    {
				get
		        {
					if(_Soundfile_sonoro_tipoevento_W == null)
	        	    {
						_Soundfile_sonoro_tipoevento_W = TearOff.Soundfile_sonoro_tipoevento;
					}
					return _Soundfile_sonoro_tipoevento_W;
				}
			}

			public AggregateParameter Id_persona
		    {
				get
		        {
					if(_Id_persona_W == null)
	        	    {
						_Id_persona_W = TearOff.Id_persona;
					}
					return _Id_persona_W;
				}
			}

			public AggregateParameter Id_vehiculo
		    {
				get
		        {
					if(_Id_vehiculo_W == null)
	        	    {
						_Id_vehiculo_W = TearOff.Id_vehiculo;
					}
					return _Id_vehiculo_W;
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

			public AggregateParameter Rumbo
		    {
				get
		        {
					if(_Rumbo_W == null)
	        	    {
						_Rumbo_W = TearOff.Rumbo;
					}
					return _Rumbo_W;
				}
			}

			public AggregateParameter Cliente
		    {
				get
		        {
					if(_Cliente_W == null)
	        	    {
						_Cliente_W = TearOff.Cliente;
					}
					return _Cliente_W;
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

			public AggregateParameter Sendmail
		    {
				get
		        {
					if(_Sendmail_W == null)
	        	    {
						_Sendmail_W = TearOff.Sendmail;
					}
					return _Sendmail_W;
				}
			}

			private AggregateParameter _Habilitado_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _Idrastreogps_tipo_evento_W = null;
			private AggregateParameter _Idrastreogps_avisos_W = null;
			private AggregateParameter _Id_equipogps_W = null;
			private AggregateParameter _Evento_W = null;
			private AggregateParameter _Evento_fechahora_W = null;
			private AggregateParameter _Atendido_W = null;
			private AggregateParameter _Color_evento_W = null;
			private AggregateParameter _Sonoro_W = null;
			private AggregateParameter _Arch_sonido_W = null;
			private AggregateParameter _Sonoro_tipoevento_W = null;
			private AggregateParameter _Soundfile_sonoro_tipoevento_W = null;
			private AggregateParameter _Id_persona_W = null;
			private AggregateParameter _Id_vehiculo_W = null;
			private AggregateParameter _Id_equipo_gps_W = null;
			private AggregateParameter _Identificador_rastreo_W = null;
			private AggregateParameter _Gps_fechahora_reporte_W = null;
			private AggregateParameter _Gps_latitud_W = null;
			private AggregateParameter _Gps_longitud_W = null;
			private AggregateParameter _Gps_velocidad_W = null;
			private AggregateParameter _Gps_rumbo_W = null;
			private AggregateParameter _Gps_dir_W = null;
			private AggregateParameter _Rumbo_W = null;
			private AggregateParameter _Cliente_W = null;
			private AggregateParameter _Tel_movil_W = null;
			private AggregateParameter _Tel_part_W = null;
			private AggregateParameter _Tel_ofi_W = null;
			private AggregateParameter _Email_W = null;
			private AggregateParameter _Estado_cliente_W = null;
			private AggregateParameter _Clave_personal_W = null;
			private AggregateParameter _Sendmail_W = null;

			public void AggregateClauseReset()
			{
				_Habilitado_W = null;
				_Descripcion_W = null;
				_Idrastreogps_tipo_evento_W = null;
				_Idrastreogps_avisos_W = null;
				_Id_equipogps_W = null;
				_Evento_W = null;
				_Evento_fechahora_W = null;
				_Atendido_W = null;
				_Color_evento_W = null;
				_Sonoro_W = null;
				_Arch_sonido_W = null;
				_Sonoro_tipoevento_W = null;
				_Soundfile_sonoro_tipoevento_W = null;
				_Id_persona_W = null;
				_Id_vehiculo_W = null;
				_Id_equipo_gps_W = null;
				_Identificador_rastreo_W = null;
				_Gps_fechahora_reporte_W = null;
				_Gps_latitud_W = null;
				_Gps_longitud_W = null;
				_Gps_velocidad_W = null;
				_Gps_rumbo_W = null;
				_Gps_dir_W = null;
				_Rumbo_W = null;
				_Cliente_W = null;
				_Tel_movil_W = null;
				_Tel_part_W = null;
				_Tel_ofi_W = null;
				_Email_W = null;
				_Estado_cliente_W = null;
				_Clave_personal_W = null;
				_Sendmail_W = null;

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
