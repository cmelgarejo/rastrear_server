/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rsview_cliente_vehiculo_equipogps para la vista rsview_cliente_vehiculo_equipogps.
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
	public class rsview_cliente_vehiculo_equipogps : PostgreSqlEntity
	{
		public rsview_cliente_vehiculo_equipogps(String laCadenaDeConexion)
		{
			this.QuerySource = "rsview_cliente_vehiculo_equipogps";
			this.MappingName = "rsview_cliente_vehiculo_equipogps";
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
			
			public static NpgsqlParameter Idrastreo_vehiculo
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_vehiculo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Proviene_de
			{
				get
				{
					return new NpgsqlParameter("Proviene_de", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Idrastreo_persona
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_persona", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Idrastreo_usuarios
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_usuarios", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_usuarios
			{
				get
				{
					return new NpgsqlParameter("Id_usuarios", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_cliente
			{
				get
				{
					return new NpgsqlParameter("Id_cliente", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_vehiculo
			{
				get
				{
					return new NpgsqlParameter("Id_vehiculo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Visible
			{
				get
				{
					return new NpgsqlParameter("Visible", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Usuario
			{
				get
				{
					return new NpgsqlParameter("Usuario", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
				}
			}
			
			public static NpgsqlParameter Cliente
			{
				get
				{
					return new NpgsqlParameter("Cliente", NpgsqlTypes.NpgsqlDbType.Varchar, 0);
				}
			}
			
			public static NpgsqlParameter Estado_cliente
			{
				get
				{
					return new NpgsqlParameter("Estado_cliente", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Id_instalador
			{
				get
				{
					return new NpgsqlParameter("Id_instalador", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Instalador
			{
				get
				{
					return new NpgsqlParameter("Instalador", NpgsqlTypes.NpgsqlDbType.Varchar, 0);
				}
			}
			
			public static NpgsqlParameter Anho
			{
				get
				{
					return new NpgsqlParameter("Anho", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Poliza_nroorden
			{
				get
				{
					return new NpgsqlParameter("Poliza_nroorden", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Chasis
			{
				get
				{
					return new NpgsqlParameter("Chasis", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Color
			{
				get
				{
					return new NpgsqlParameter("Color", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
				}
			}
			
			public static NpgsqlParameter Matricula
			{
				get
				{
					return new NpgsqlParameter("Matricula", NpgsqlTypes.NpgsqlDbType.Varchar, 128);
				}
			}
			
			public static NpgsqlParameter Kilometraje
			{
				get
				{
					return new NpgsqlParameter("Kilometraje", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Activo
			{
				get
				{
					return new NpgsqlParameter("Activo", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
			public static NpgsqlParameter Consumo_aprox
			{
				get
				{
					return new NpgsqlParameter("Consumo_aprox", NpgsqlTypes.NpgsqlDbType.Double, 0);
				}
			}
			
			public static NpgsqlParameter Instalacion_fechahora
			{
				get
				{
					return new NpgsqlParameter("Instalacion_fechahora", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}
			
			public static NpgsqlParameter Idmarca
			{
				get
				{
					return new NpgsqlParameter("Idmarca", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Idmodelo
			{
				get
				{
					return new NpgsqlParameter("Idmodelo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Marca
			{
				get
				{
					return new NpgsqlParameter("Marca", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Modelo
			{
				get
				{
					return new NpgsqlParameter("Modelo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Idequipogps
			{
				get
				{
					return new NpgsqlParameter("Idequipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_tipoequipogps
			{
				get
				{
					return new NpgsqlParameter("Id_tipoequipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Tipoequipogps
			{
				get
				{
					return new NpgsqlParameter("Tipoequipogps", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Tipo_de_reportegps
			{
				get
				{
					return new NpgsqlParameter("Tipo_de_reportegps", NpgsqlTypes.NpgsqlDbType.Varchar, 64);
				}
			}
			
			public static NpgsqlParameter Id_equipo_gps
			{
				get
				{
					return new NpgsqlParameter("Id_equipo_gps", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Nro_serie_gps
			{
				get
				{
					return new NpgsqlParameter("Nro_serie_gps", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Idsimcard
			{
				get
				{
					return new NpgsqlParameter("Idsimcard", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Sim_nro
			{
				get
				{
					return new NpgsqlParameter("Sim_nro", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Empleado_insert
			{
				get
				{
					return new NpgsqlParameter("Empleado_insert", NpgsqlTypes.NpgsqlDbType.Varchar, 0);
				}
			}
			
			public static NpgsqlParameter Id_persona
			{
				get
				{
					return new NpgsqlParameter("Id_persona", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Sucursal_instalacion
			{
				get
				{
					return new NpgsqlParameter("Sucursal_instalacion", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Sucursal
			{
				get
				{
					return new NpgsqlParameter("Sucursal", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Identificador_rastreo = "identificador_rastreo";
            public const string Idrastreo_vehiculo = "idrastreo_vehiculo";
            public const string Proviene_de = "proviene_de";
            public const string Idrastreo_persona = "idrastreo_persona";
            public const string Idrastreo_usuarios = "idrastreo_usuarios";
            public const string Id_usuarios = "id_usuarios";
            public const string Id_cliente = "id_cliente";
            public const string Id_vehiculo = "id_vehiculo";
            public const string Visible = "visible";
            public const string Usuario = "usuario";
            public const string Cliente = "cliente";
            public const string Estado_cliente = "estado_cliente";
            public const string Id_instalador = "id_instalador";
            public const string Instalador = "instalador";
            public const string Anho = "anho";
            public const string Poliza_nroorden = "poliza_nroorden";
            public const string Chasis = "chasis";
            public const string Color = "color";
            public const string Matricula = "matricula";
            public const string Kilometraje = "kilometraje";
            public const string Activo = "activo";
            public const string Consumo_aprox = "consumo_aprox";
            public const string Instalacion_fechahora = "instalacion_fechahora";
            public const string Idmarca = "idmarca";
            public const string Idmodelo = "idmodelo";
            public const string Marca = "marca";
            public const string Modelo = "modelo";
            public const string Idequipogps = "idequipogps";
            public const string Id_tipoequipogps = "id_tipoequipogps";
            public const string Tipoequipogps = "tipoequipogps";
            public const string Tipo_de_reportegps = "tipo_de_reportegps";
            public const string Id_equipo_gps = "id_equipo_gps";
            public const string Nro_serie_gps = "nro_serie_gps";
            public const string Idsimcard = "idsimcard";
            public const string Sim_nro = "sim_nro";
            public const string Empleado_insert = "empleado_insert";
            public const string Id_persona = "id_persona";
            public const string Sucursal_instalacion = "sucursal_instalacion";
            public const string Sucursal = "sucursal";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Identificador_rastreo] = rsview_cliente_vehiculo_equipogps.PropertyNames.Identificador_rastreo;
					ht[Idrastreo_vehiculo] = rsview_cliente_vehiculo_equipogps.PropertyNames.Idrastreo_vehiculo;
					ht[Proviene_de] = rsview_cliente_vehiculo_equipogps.PropertyNames.Proviene_de;
					ht[Idrastreo_persona] = rsview_cliente_vehiculo_equipogps.PropertyNames.Idrastreo_persona;
					ht[Idrastreo_usuarios] = rsview_cliente_vehiculo_equipogps.PropertyNames.Idrastreo_usuarios;
					ht[Id_usuarios] = rsview_cliente_vehiculo_equipogps.PropertyNames.Id_usuarios;
					ht[Id_cliente] = rsview_cliente_vehiculo_equipogps.PropertyNames.Id_cliente;
					ht[Id_vehiculo] = rsview_cliente_vehiculo_equipogps.PropertyNames.Id_vehiculo;
					ht[Visible] = rsview_cliente_vehiculo_equipogps.PropertyNames.Visible;
					ht[Usuario] = rsview_cliente_vehiculo_equipogps.PropertyNames.Usuario;
					ht[Cliente] = rsview_cliente_vehiculo_equipogps.PropertyNames.Cliente;
					ht[Estado_cliente] = rsview_cliente_vehiculo_equipogps.PropertyNames.Estado_cliente;
					ht[Id_instalador] = rsview_cliente_vehiculo_equipogps.PropertyNames.Id_instalador;
					ht[Instalador] = rsview_cliente_vehiculo_equipogps.PropertyNames.Instalador;
					ht[Anho] = rsview_cliente_vehiculo_equipogps.PropertyNames.Anho;
					ht[Poliza_nroorden] = rsview_cliente_vehiculo_equipogps.PropertyNames.Poliza_nroorden;
					ht[Chasis] = rsview_cliente_vehiculo_equipogps.PropertyNames.Chasis;
					ht[Color] = rsview_cliente_vehiculo_equipogps.PropertyNames.Color;
					ht[Matricula] = rsview_cliente_vehiculo_equipogps.PropertyNames.Matricula;
					ht[Kilometraje] = rsview_cliente_vehiculo_equipogps.PropertyNames.Kilometraje;
					ht[Activo] = rsview_cliente_vehiculo_equipogps.PropertyNames.Activo;
					ht[Consumo_aprox] = rsview_cliente_vehiculo_equipogps.PropertyNames.Consumo_aprox;
					ht[Instalacion_fechahora] = rsview_cliente_vehiculo_equipogps.PropertyNames.Instalacion_fechahora;
					ht[Idmarca] = rsview_cliente_vehiculo_equipogps.PropertyNames.Idmarca;
					ht[Idmodelo] = rsview_cliente_vehiculo_equipogps.PropertyNames.Idmodelo;
					ht[Marca] = rsview_cliente_vehiculo_equipogps.PropertyNames.Marca;
					ht[Modelo] = rsview_cliente_vehiculo_equipogps.PropertyNames.Modelo;
					ht[Idequipogps] = rsview_cliente_vehiculo_equipogps.PropertyNames.Idequipogps;
					ht[Id_tipoequipogps] = rsview_cliente_vehiculo_equipogps.PropertyNames.Id_tipoequipogps;
					ht[Tipoequipogps] = rsview_cliente_vehiculo_equipogps.PropertyNames.Tipoequipogps;
					ht[Tipo_de_reportegps] = rsview_cliente_vehiculo_equipogps.PropertyNames.Tipo_de_reportegps;
					ht[Id_equipo_gps] = rsview_cliente_vehiculo_equipogps.PropertyNames.Id_equipo_gps;
					ht[Nro_serie_gps] = rsview_cliente_vehiculo_equipogps.PropertyNames.Nro_serie_gps;
					ht[Idsimcard] = rsview_cliente_vehiculo_equipogps.PropertyNames.Idsimcard;
					ht[Sim_nro] = rsview_cliente_vehiculo_equipogps.PropertyNames.Sim_nro;
					ht[Empleado_insert] = rsview_cliente_vehiculo_equipogps.PropertyNames.Empleado_insert;
					ht[Id_persona] = rsview_cliente_vehiculo_equipogps.PropertyNames.Id_persona;
					ht[Sucursal_instalacion] = rsview_cliente_vehiculo_equipogps.PropertyNames.Sucursal_instalacion;
					ht[Sucursal] = rsview_cliente_vehiculo_equipogps.PropertyNames.Sucursal;

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
            public const string Idrastreo_vehiculo = "Idrastreo_vehiculo";
            public const string Proviene_de = "Proviene_de";
            public const string Idrastreo_persona = "Idrastreo_persona";
            public const string Idrastreo_usuarios = "Idrastreo_usuarios";
            public const string Id_usuarios = "Id_usuarios";
            public const string Id_cliente = "Id_cliente";
            public const string Id_vehiculo = "Id_vehiculo";
            public const string Visible = "Visible";
            public const string Usuario = "Usuario";
            public const string Cliente = "Cliente";
            public const string Estado_cliente = "Estado_cliente";
            public const string Id_instalador = "Id_instalador";
            public const string Instalador = "Instalador";
            public const string Anho = "Anho";
            public const string Poliza_nroorden = "Poliza_nroorden";
            public const string Chasis = "Chasis";
            public const string Color = "Color";
            public const string Matricula = "Matricula";
            public const string Kilometraje = "Kilometraje";
            public const string Activo = "Activo";
            public const string Consumo_aprox = "Consumo_aprox";
            public const string Instalacion_fechahora = "Instalacion_fechahora";
            public const string Idmarca = "Idmarca";
            public const string Idmodelo = "Idmodelo";
            public const string Marca = "Marca";
            public const string Modelo = "Modelo";
            public const string Idequipogps = "Idequipogps";
            public const string Id_tipoequipogps = "Id_tipoequipogps";
            public const string Tipoequipogps = "Tipoequipogps";
            public const string Tipo_de_reportegps = "Tipo_de_reportegps";
            public const string Id_equipo_gps = "Id_equipo_gps";
            public const string Nro_serie_gps = "Nro_serie_gps";
            public const string Idsimcard = "Idsimcard";
            public const string Sim_nro = "Sim_nro";
            public const string Empleado_insert = "Empleado_insert";
            public const string Id_persona = "Id_persona";
            public const string Sucursal_instalacion = "Sucursal_instalacion";
            public const string Sucursal = "Sucursal";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Identificador_rastreo] = rsview_cliente_vehiculo_equipogps.ColumnNames.Identificador_rastreo;
					ht[Idrastreo_vehiculo] = rsview_cliente_vehiculo_equipogps.ColumnNames.Idrastreo_vehiculo;
					ht[Proviene_de] = rsview_cliente_vehiculo_equipogps.ColumnNames.Proviene_de;
					ht[Idrastreo_persona] = rsview_cliente_vehiculo_equipogps.ColumnNames.Idrastreo_persona;
					ht[Idrastreo_usuarios] = rsview_cliente_vehiculo_equipogps.ColumnNames.Idrastreo_usuarios;
					ht[Id_usuarios] = rsview_cliente_vehiculo_equipogps.ColumnNames.Id_usuarios;
					ht[Id_cliente] = rsview_cliente_vehiculo_equipogps.ColumnNames.Id_cliente;
					ht[Id_vehiculo] = rsview_cliente_vehiculo_equipogps.ColumnNames.Id_vehiculo;
					ht[Visible] = rsview_cliente_vehiculo_equipogps.ColumnNames.Visible;
					ht[Usuario] = rsview_cliente_vehiculo_equipogps.ColumnNames.Usuario;
					ht[Cliente] = rsview_cliente_vehiculo_equipogps.ColumnNames.Cliente;
					ht[Estado_cliente] = rsview_cliente_vehiculo_equipogps.ColumnNames.Estado_cliente;
					ht[Id_instalador] = rsview_cliente_vehiculo_equipogps.ColumnNames.Id_instalador;
					ht[Instalador] = rsview_cliente_vehiculo_equipogps.ColumnNames.Instalador;
					ht[Anho] = rsview_cliente_vehiculo_equipogps.ColumnNames.Anho;
					ht[Poliza_nroorden] = rsview_cliente_vehiculo_equipogps.ColumnNames.Poliza_nroorden;
					ht[Chasis] = rsview_cliente_vehiculo_equipogps.ColumnNames.Chasis;
					ht[Color] = rsview_cliente_vehiculo_equipogps.ColumnNames.Color;
					ht[Matricula] = rsview_cliente_vehiculo_equipogps.ColumnNames.Matricula;
					ht[Kilometraje] = rsview_cliente_vehiculo_equipogps.ColumnNames.Kilometraje;
					ht[Activo] = rsview_cliente_vehiculo_equipogps.ColumnNames.Activo;
					ht[Consumo_aprox] = rsview_cliente_vehiculo_equipogps.ColumnNames.Consumo_aprox;
					ht[Instalacion_fechahora] = rsview_cliente_vehiculo_equipogps.ColumnNames.Instalacion_fechahora;
					ht[Idmarca] = rsview_cliente_vehiculo_equipogps.ColumnNames.Idmarca;
					ht[Idmodelo] = rsview_cliente_vehiculo_equipogps.ColumnNames.Idmodelo;
					ht[Marca] = rsview_cliente_vehiculo_equipogps.ColumnNames.Marca;
					ht[Modelo] = rsview_cliente_vehiculo_equipogps.ColumnNames.Modelo;
					ht[Idequipogps] = rsview_cliente_vehiculo_equipogps.ColumnNames.Idequipogps;
					ht[Id_tipoequipogps] = rsview_cliente_vehiculo_equipogps.ColumnNames.Id_tipoequipogps;
					ht[Tipoequipogps] = rsview_cliente_vehiculo_equipogps.ColumnNames.Tipoequipogps;
					ht[Tipo_de_reportegps] = rsview_cliente_vehiculo_equipogps.ColumnNames.Tipo_de_reportegps;
					ht[Id_equipo_gps] = rsview_cliente_vehiculo_equipogps.ColumnNames.Id_equipo_gps;
					ht[Nro_serie_gps] = rsview_cliente_vehiculo_equipogps.ColumnNames.Nro_serie_gps;
					ht[Idsimcard] = rsview_cliente_vehiculo_equipogps.ColumnNames.Idsimcard;
					ht[Sim_nro] = rsview_cliente_vehiculo_equipogps.ColumnNames.Sim_nro;
					ht[Empleado_insert] = rsview_cliente_vehiculo_equipogps.ColumnNames.Empleado_insert;
					ht[Id_persona] = rsview_cliente_vehiculo_equipogps.ColumnNames.Id_persona;
					ht[Sucursal_instalacion] = rsview_cliente_vehiculo_equipogps.ColumnNames.Sucursal_instalacion;
					ht[Sucursal] = rsview_cliente_vehiculo_equipogps.ColumnNames.Sucursal;

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
            public const string Idrastreo_vehiculo = "s_Idrastreo_vehiculo";
            public const string Proviene_de = "s_Proviene_de";
            public const string Idrastreo_persona = "s_Idrastreo_persona";
            public const string Idrastreo_usuarios = "s_Idrastreo_usuarios";
            public const string Id_usuarios = "s_Id_usuarios";
            public const string Id_cliente = "s_Id_cliente";
            public const string Id_vehiculo = "s_Id_vehiculo";
            public const string Visible = "s_Visible";
            public const string Usuario = "s_Usuario";
            public const string Cliente = "s_Cliente";
            public const string Estado_cliente = "s_Estado_cliente";
            public const string Id_instalador = "s_Id_instalador";
            public const string Instalador = "s_Instalador";
            public const string Anho = "s_Anho";
            public const string Poliza_nroorden = "s_Poliza_nroorden";
            public const string Chasis = "s_Chasis";
            public const string Color = "s_Color";
            public const string Matricula = "s_Matricula";
            public const string Kilometraje = "s_Kilometraje";
            public const string Activo = "s_Activo";
            public const string Consumo_aprox = "s_Consumo_aprox";
            public const string Instalacion_fechahora = "s_Instalacion_fechahora";
            public const string Idmarca = "s_Idmarca";
            public const string Idmodelo = "s_Idmodelo";
            public const string Marca = "s_Marca";
            public const string Modelo = "s_Modelo";
            public const string Idequipogps = "s_Idequipogps";
            public const string Id_tipoequipogps = "s_Id_tipoequipogps";
            public const string Tipoequipogps = "s_Tipoequipogps";
            public const string Tipo_de_reportegps = "s_Tipo_de_reportegps";
            public const string Id_equipo_gps = "s_Id_equipo_gps";
            public const string Nro_serie_gps = "s_Nro_serie_gps";
            public const string Idsimcard = "s_Idsimcard";
            public const string Sim_nro = "s_Sim_nro";
            public const string Empleado_insert = "s_Empleado_insert";
            public const string Id_persona = "s_Id_persona";
            public const string Sucursal_instalacion = "s_Sucursal_instalacion";
            public const string Sucursal = "s_Sucursal";

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

		public virtual int Idrastreo_vehiculo
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_vehiculo);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_vehiculo, value);
			}
		}

		public virtual int Proviene_de
	    {
			get
	        {
				return base.Getint(ColumnNames.Proviene_de);
			}
			set
	        {
				base.Setint(ColumnNames.Proviene_de, value);
			}
		}

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

		public virtual int Idrastreo_usuarios
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_usuarios);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_usuarios, value);
			}
		}

		public virtual int Id_usuarios
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_usuarios);
			}
			set
	        {
				base.Setint(ColumnNames.Id_usuarios, value);
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

		public virtual int Id_instalador
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_instalador);
			}
			set
	        {
				base.Setint(ColumnNames.Id_instalador, value);
			}
		}

		public virtual string Instalador
	    {
			get
	        {
				return base.Getstring(ColumnNames.Instalador);
			}
			set
	        {
				base.Setstring(ColumnNames.Instalador, value);
			}
		}

		public virtual int Anho
	    {
			get
	        {
				return base.Getint(ColumnNames.Anho);
			}
			set
	        {
				base.Setint(ColumnNames.Anho, value);
			}
		}

		public virtual string Poliza_nroorden
	    {
			get
	        {
				return base.Getstring(ColumnNames.Poliza_nroorden);
			}
			set
	        {
				base.Setstring(ColumnNames.Poliza_nroorden, value);
			}
		}

		public virtual string Chasis
	    {
			get
	        {
				return base.Getstring(ColumnNames.Chasis);
			}
			set
	        {
				base.Setstring(ColumnNames.Chasis, value);
			}
		}

		public virtual string Color
	    {
			get
	        {
				return base.Getstring(ColumnNames.Color);
			}
			set
	        {
				base.Setstring(ColumnNames.Color, value);
			}
		}

		public virtual string Matricula
	    {
			get
	        {
				return base.Getstring(ColumnNames.Matricula);
			}
			set
	        {
				base.Setstring(ColumnNames.Matricula, value);
			}
		}

		public virtual int Kilometraje
	    {
			get
	        {
				return base.Getint(ColumnNames.Kilometraje);
			}
			set
	        {
				base.Setint(ColumnNames.Kilometraje, value);
			}
		}

		public virtual bool Activo
	    {
			get
	        {
				return base.Getbool(ColumnNames.Activo);
			}
			set
	        {
				base.Setbool(ColumnNames.Activo, value);
			}
		}

		public virtual double Consumo_aprox
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Consumo_aprox);
			}
			set
	        {
				base.Setdouble(ColumnNames.Consumo_aprox, value);
			}
		}

		public virtual DateTime Instalacion_fechahora
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Instalacion_fechahora);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Instalacion_fechahora, value);
			}
		}

		public virtual int Idmarca
	    {
			get
	        {
				return base.Getint(ColumnNames.Idmarca);
			}
			set
	        {
				base.Setint(ColumnNames.Idmarca, value);
			}
		}

		public virtual int Idmodelo
	    {
			get
	        {
				return base.Getint(ColumnNames.Idmodelo);
			}
			set
	        {
				base.Setint(ColumnNames.Idmodelo, value);
			}
		}

		public virtual string Marca
	    {
			get
	        {
				return base.Getstring(ColumnNames.Marca);
			}
			set
	        {
				base.Setstring(ColumnNames.Marca, value);
			}
		}

		public virtual string Modelo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Modelo);
			}
			set
	        {
				base.Setstring(ColumnNames.Modelo, value);
			}
		}

		public virtual int Idequipogps
	    {
			get
	        {
				return base.Getint(ColumnNames.Idequipogps);
			}
			set
	        {
				base.Setint(ColumnNames.Idequipogps, value);
			}
		}

		public virtual int Id_tipoequipogps
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_tipoequipogps);
			}
			set
	        {
				base.Setint(ColumnNames.Id_tipoequipogps, value);
			}
		}

		public virtual string Tipoequipogps
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tipoequipogps);
			}
			set
	        {
				base.Setstring(ColumnNames.Tipoequipogps, value);
			}
		}

		public virtual string Tipo_de_reportegps
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tipo_de_reportegps);
			}
			set
	        {
				base.Setstring(ColumnNames.Tipo_de_reportegps, value);
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

		public virtual string Nro_serie_gps
	    {
			get
	        {
				return base.Getstring(ColumnNames.Nro_serie_gps);
			}
			set
	        {
				base.Setstring(ColumnNames.Nro_serie_gps, value);
			}
		}

		public virtual int Idsimcard
	    {
			get
	        {
				return base.Getint(ColumnNames.Idsimcard);
			}
			set
	        {
				base.Setint(ColumnNames.Idsimcard, value);
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

		public virtual string Empleado_insert
	    {
			get
	        {
				return base.Getstring(ColumnNames.Empleado_insert);
			}
			set
	        {
				base.Setstring(ColumnNames.Empleado_insert, value);
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

		public virtual int Sucursal_instalacion
	    {
			get
	        {
				return base.Getint(ColumnNames.Sucursal_instalacion);
			}
			set
	        {
				base.Setint(ColumnNames.Sucursal_instalacion, value);
			}
		}

		public virtual string Sucursal
	    {
			get
	        {
				return base.Getstring(ColumnNames.Sucursal);
			}
			set
	        {
				base.Setstring(ColumnNames.Sucursal, value);
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

		public virtual string s_Idrastreo_vehiculo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_vehiculo) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_vehiculo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_vehiculo);
				else
					this.Idrastreo_vehiculo = base.SetintAsString(ColumnNames.Idrastreo_vehiculo, value);
			}
		}

		public virtual string s_Proviene_de
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Proviene_de) ? string.Empty : base.GetintAsString(ColumnNames.Proviene_de);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Proviene_de);
				else
					this.Proviene_de = base.SetintAsString(ColumnNames.Proviene_de, value);
			}
		}

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

		public virtual string s_Idrastreo_usuarios
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_usuarios) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_usuarios);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_usuarios);
				else
					this.Idrastreo_usuarios = base.SetintAsString(ColumnNames.Idrastreo_usuarios, value);
			}
		}

		public virtual string s_Id_usuarios
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_usuarios) ? string.Empty : base.GetintAsString(ColumnNames.Id_usuarios);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_usuarios);
				else
					this.Id_usuarios = base.SetintAsString(ColumnNames.Id_usuarios, value);
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

		public virtual string s_Id_instalador
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_instalador) ? string.Empty : base.GetintAsString(ColumnNames.Id_instalador);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_instalador);
				else
					this.Id_instalador = base.SetintAsString(ColumnNames.Id_instalador, value);
			}
		}

		public virtual string s_Instalador
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Instalador) ? string.Empty : base.GetstringAsString(ColumnNames.Instalador);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Instalador);
				else
					this.Instalador = base.SetstringAsString(ColumnNames.Instalador, value);
			}
		}

		public virtual string s_Anho
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Anho) ? string.Empty : base.GetintAsString(ColumnNames.Anho);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Anho);
				else
					this.Anho = base.SetintAsString(ColumnNames.Anho, value);
			}
		}

		public virtual string s_Poliza_nroorden
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Poliza_nroorden) ? string.Empty : base.GetstringAsString(ColumnNames.Poliza_nroorden);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Poliza_nroorden);
				else
					this.Poliza_nroorden = base.SetstringAsString(ColumnNames.Poliza_nroorden, value);
			}
		}

		public virtual string s_Chasis
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Chasis) ? string.Empty : base.GetstringAsString(ColumnNames.Chasis);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Chasis);
				else
					this.Chasis = base.SetstringAsString(ColumnNames.Chasis, value);
			}
		}

		public virtual string s_Color
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Color) ? string.Empty : base.GetstringAsString(ColumnNames.Color);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Color);
				else
					this.Color = base.SetstringAsString(ColumnNames.Color, value);
			}
		}

		public virtual string s_Matricula
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Matricula) ? string.Empty : base.GetstringAsString(ColumnNames.Matricula);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Matricula);
				else
					this.Matricula = base.SetstringAsString(ColumnNames.Matricula, value);
			}
		}

		public virtual string s_Kilometraje
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Kilometraje) ? string.Empty : base.GetintAsString(ColumnNames.Kilometraje);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Kilometraje);
				else
					this.Kilometraje = base.SetintAsString(ColumnNames.Kilometraje, value);
			}
		}

		public virtual string s_Activo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Activo) ? string.Empty : base.GetboolAsString(ColumnNames.Activo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Activo);
				else
					this.Activo = base.SetboolAsString(ColumnNames.Activo, value);
			}
		}

		public virtual string s_Consumo_aprox
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Consumo_aprox) ? string.Empty : base.GetdoubleAsString(ColumnNames.Consumo_aprox);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Consumo_aprox);
				else
					this.Consumo_aprox = base.SetdoubleAsString(ColumnNames.Consumo_aprox, value);
			}
		}

		public virtual string s_Instalacion_fechahora
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Instalacion_fechahora) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Instalacion_fechahora);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Instalacion_fechahora);
				else
					this.Instalacion_fechahora = base.SetDateTimeAsString(ColumnNames.Instalacion_fechahora, value);
			}
		}

		public virtual string s_Idmarca
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idmarca) ? string.Empty : base.GetintAsString(ColumnNames.Idmarca);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idmarca);
				else
					this.Idmarca = base.SetintAsString(ColumnNames.Idmarca, value);
			}
		}

		public virtual string s_Idmodelo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idmodelo) ? string.Empty : base.GetintAsString(ColumnNames.Idmodelo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idmodelo);
				else
					this.Idmodelo = base.SetintAsString(ColumnNames.Idmodelo, value);
			}
		}

		public virtual string s_Marca
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Marca) ? string.Empty : base.GetstringAsString(ColumnNames.Marca);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Marca);
				else
					this.Marca = base.SetstringAsString(ColumnNames.Marca, value);
			}
		}

		public virtual string s_Modelo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Modelo) ? string.Empty : base.GetstringAsString(ColumnNames.Modelo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Modelo);
				else
					this.Modelo = base.SetstringAsString(ColumnNames.Modelo, value);
			}
		}

		public virtual string s_Idequipogps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idequipogps) ? string.Empty : base.GetintAsString(ColumnNames.Idequipogps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idequipogps);
				else
					this.Idequipogps = base.SetintAsString(ColumnNames.Idequipogps, value);
			}
		}

		public virtual string s_Id_tipoequipogps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_tipoequipogps) ? string.Empty : base.GetintAsString(ColumnNames.Id_tipoequipogps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_tipoequipogps);
				else
					this.Id_tipoequipogps = base.SetintAsString(ColumnNames.Id_tipoequipogps, value);
			}
		}

		public virtual string s_Tipoequipogps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipoequipogps) ? string.Empty : base.GetstringAsString(ColumnNames.Tipoequipogps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipoequipogps);
				else
					this.Tipoequipogps = base.SetstringAsString(ColumnNames.Tipoequipogps, value);
			}
		}

		public virtual string s_Tipo_de_reportegps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipo_de_reportegps) ? string.Empty : base.GetstringAsString(ColumnNames.Tipo_de_reportegps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipo_de_reportegps);
				else
					this.Tipo_de_reportegps = base.SetstringAsString(ColumnNames.Tipo_de_reportegps, value);
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

		public virtual string s_Nro_serie_gps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Nro_serie_gps) ? string.Empty : base.GetstringAsString(ColumnNames.Nro_serie_gps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nro_serie_gps);
				else
					this.Nro_serie_gps = base.SetstringAsString(ColumnNames.Nro_serie_gps, value);
			}
		}

		public virtual string s_Idsimcard
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idsimcard) ? string.Empty : base.GetintAsString(ColumnNames.Idsimcard);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idsimcard);
				else
					this.Idsimcard = base.SetintAsString(ColumnNames.Idsimcard, value);
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

		public virtual string s_Empleado_insert
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Empleado_insert) ? string.Empty : base.GetstringAsString(ColumnNames.Empleado_insert);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Empleado_insert);
				else
					this.Empleado_insert = base.SetstringAsString(ColumnNames.Empleado_insert, value);
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

		public virtual string s_Sucursal_instalacion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sucursal_instalacion) ? string.Empty : base.GetintAsString(ColumnNames.Sucursal_instalacion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sucursal_instalacion);
				else
					this.Sucursal_instalacion = base.SetintAsString(ColumnNames.Sucursal_instalacion, value);
			}
		}

		public virtual string s_Sucursal
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sucursal) ? string.Empty : base.GetstringAsString(ColumnNames.Sucursal);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sucursal);
				else
					this.Sucursal = base.SetstringAsString(ColumnNames.Sucursal, value);
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

				public WhereParameter Idrastreo_vehiculo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_vehiculo, Parameters.Idrastreo_vehiculo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Proviene_de
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Proviene_de, Parameters.Proviene_de);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
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

				public WhereParameter Idrastreo_usuarios
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_usuarios, Parameters.Idrastreo_usuarios);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_usuarios
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_usuarios, Parameters.Id_usuarios);
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

				public WhereParameter Id_vehiculo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_vehiculo, Parameters.Id_vehiculo);
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

				public WhereParameter Usuario
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Usuario, Parameters.Usuario);
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

				public WhereParameter Estado_cliente
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Estado_cliente, Parameters.Estado_cliente);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_instalador
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_instalador, Parameters.Id_instalador);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Instalador
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Instalador, Parameters.Instalador);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Anho
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Anho, Parameters.Anho);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Poliza_nroorden
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Poliza_nroorden, Parameters.Poliza_nroorden);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Chasis
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Chasis, Parameters.Chasis);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Color
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Color, Parameters.Color);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Matricula
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Matricula, Parameters.Matricula);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Kilometraje
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Kilometraje, Parameters.Kilometraje);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Activo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Activo, Parameters.Activo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Consumo_aprox
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Consumo_aprox, Parameters.Consumo_aprox);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Instalacion_fechahora
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Instalacion_fechahora, Parameters.Instalacion_fechahora);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Idmarca
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idmarca, Parameters.Idmarca);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Idmodelo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idmodelo, Parameters.Idmodelo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Marca
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Marca, Parameters.Marca);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Modelo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Modelo, Parameters.Modelo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Idequipogps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idequipogps, Parameters.Idequipogps);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_tipoequipogps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_tipoequipogps, Parameters.Id_tipoequipogps);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Tipoequipogps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipoequipogps, Parameters.Tipoequipogps);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Tipo_de_reportegps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipo_de_reportegps, Parameters.Tipo_de_reportegps);
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

				public WhereParameter Nro_serie_gps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nro_serie_gps, Parameters.Nro_serie_gps);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Idsimcard
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idsimcard, Parameters.Idsimcard);
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

				public WhereParameter Empleado_insert
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Empleado_insert, Parameters.Empleado_insert);
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

				public WhereParameter Sucursal_instalacion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sucursal_instalacion, Parameters.Sucursal_instalacion);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sucursal
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sucursal, Parameters.Sucursal);
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

			public WhereParameter Idrastreo_vehiculo
		    {
				get
		        {
					if(_Idrastreo_vehiculo_W == null)
	        	    {
						_Idrastreo_vehiculo_W = TearOff.Idrastreo_vehiculo;
					}
					return _Idrastreo_vehiculo_W;
				}
			}

			public WhereParameter Proviene_de
		    {
				get
		        {
					if(_Proviene_de_W == null)
	        	    {
						_Proviene_de_W = TearOff.Proviene_de;
					}
					return _Proviene_de_W;
				}
			}

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

			public WhereParameter Idrastreo_usuarios
		    {
				get
		        {
					if(_Idrastreo_usuarios_W == null)
	        	    {
						_Idrastreo_usuarios_W = TearOff.Idrastreo_usuarios;
					}
					return _Idrastreo_usuarios_W;
				}
			}

			public WhereParameter Id_usuarios
		    {
				get
		        {
					if(_Id_usuarios_W == null)
	        	    {
						_Id_usuarios_W = TearOff.Id_usuarios;
					}
					return _Id_usuarios_W;
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

			public WhereParameter Id_instalador
		    {
				get
		        {
					if(_Id_instalador_W == null)
	        	    {
						_Id_instalador_W = TearOff.Id_instalador;
					}
					return _Id_instalador_W;
				}
			}

			public WhereParameter Instalador
		    {
				get
		        {
					if(_Instalador_W == null)
	        	    {
						_Instalador_W = TearOff.Instalador;
					}
					return _Instalador_W;
				}
			}

			public WhereParameter Anho
		    {
				get
		        {
					if(_Anho_W == null)
	        	    {
						_Anho_W = TearOff.Anho;
					}
					return _Anho_W;
				}
			}

			public WhereParameter Poliza_nroorden
		    {
				get
		        {
					if(_Poliza_nroorden_W == null)
	        	    {
						_Poliza_nroorden_W = TearOff.Poliza_nroorden;
					}
					return _Poliza_nroorden_W;
				}
			}

			public WhereParameter Chasis
		    {
				get
		        {
					if(_Chasis_W == null)
	        	    {
						_Chasis_W = TearOff.Chasis;
					}
					return _Chasis_W;
				}
			}

			public WhereParameter Color
		    {
				get
		        {
					if(_Color_W == null)
	        	    {
						_Color_W = TearOff.Color;
					}
					return _Color_W;
				}
			}

			public WhereParameter Matricula
		    {
				get
		        {
					if(_Matricula_W == null)
	        	    {
						_Matricula_W = TearOff.Matricula;
					}
					return _Matricula_W;
				}
			}

			public WhereParameter Kilometraje
		    {
				get
		        {
					if(_Kilometraje_W == null)
	        	    {
						_Kilometraje_W = TearOff.Kilometraje;
					}
					return _Kilometraje_W;
				}
			}

			public WhereParameter Activo
		    {
				get
		        {
					if(_Activo_W == null)
	        	    {
						_Activo_W = TearOff.Activo;
					}
					return _Activo_W;
				}
			}

			public WhereParameter Consumo_aprox
		    {
				get
		        {
					if(_Consumo_aprox_W == null)
	        	    {
						_Consumo_aprox_W = TearOff.Consumo_aprox;
					}
					return _Consumo_aprox_W;
				}
			}

			public WhereParameter Instalacion_fechahora
		    {
				get
		        {
					if(_Instalacion_fechahora_W == null)
	        	    {
						_Instalacion_fechahora_W = TearOff.Instalacion_fechahora;
					}
					return _Instalacion_fechahora_W;
				}
			}

			public WhereParameter Idmarca
		    {
				get
		        {
					if(_Idmarca_W == null)
	        	    {
						_Idmarca_W = TearOff.Idmarca;
					}
					return _Idmarca_W;
				}
			}

			public WhereParameter Idmodelo
		    {
				get
		        {
					if(_Idmodelo_W == null)
	        	    {
						_Idmodelo_W = TearOff.Idmodelo;
					}
					return _Idmodelo_W;
				}
			}

			public WhereParameter Marca
		    {
				get
		        {
					if(_Marca_W == null)
	        	    {
						_Marca_W = TearOff.Marca;
					}
					return _Marca_W;
				}
			}

			public WhereParameter Modelo
		    {
				get
		        {
					if(_Modelo_W == null)
	        	    {
						_Modelo_W = TearOff.Modelo;
					}
					return _Modelo_W;
				}
			}

			public WhereParameter Idequipogps
		    {
				get
		        {
					if(_Idequipogps_W == null)
	        	    {
						_Idequipogps_W = TearOff.Idequipogps;
					}
					return _Idequipogps_W;
				}
			}

			public WhereParameter Id_tipoequipogps
		    {
				get
		        {
					if(_Id_tipoequipogps_W == null)
	        	    {
						_Id_tipoequipogps_W = TearOff.Id_tipoequipogps;
					}
					return _Id_tipoequipogps_W;
				}
			}

			public WhereParameter Tipoequipogps
		    {
				get
		        {
					if(_Tipoequipogps_W == null)
	        	    {
						_Tipoequipogps_W = TearOff.Tipoequipogps;
					}
					return _Tipoequipogps_W;
				}
			}

			public WhereParameter Tipo_de_reportegps
		    {
				get
		        {
					if(_Tipo_de_reportegps_W == null)
	        	    {
						_Tipo_de_reportegps_W = TearOff.Tipo_de_reportegps;
					}
					return _Tipo_de_reportegps_W;
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

			public WhereParameter Nro_serie_gps
		    {
				get
		        {
					if(_Nro_serie_gps_W == null)
	        	    {
						_Nro_serie_gps_W = TearOff.Nro_serie_gps;
					}
					return _Nro_serie_gps_W;
				}
			}

			public WhereParameter Idsimcard
		    {
				get
		        {
					if(_Idsimcard_W == null)
	        	    {
						_Idsimcard_W = TearOff.Idsimcard;
					}
					return _Idsimcard_W;
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

			public WhereParameter Empleado_insert
		    {
				get
		        {
					if(_Empleado_insert_W == null)
	        	    {
						_Empleado_insert_W = TearOff.Empleado_insert;
					}
					return _Empleado_insert_W;
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

			public WhereParameter Sucursal_instalacion
		    {
				get
		        {
					if(_Sucursal_instalacion_W == null)
	        	    {
						_Sucursal_instalacion_W = TearOff.Sucursal_instalacion;
					}
					return _Sucursal_instalacion_W;
				}
			}

			public WhereParameter Sucursal
		    {
				get
		        {
					if(_Sucursal_W == null)
	        	    {
						_Sucursal_W = TearOff.Sucursal;
					}
					return _Sucursal_W;
				}
			}

			private WhereParameter _Identificador_rastreo_W = null;
			private WhereParameter _Idrastreo_vehiculo_W = null;
			private WhereParameter _Proviene_de_W = null;
			private WhereParameter _Idrastreo_persona_W = null;
			private WhereParameter _Idrastreo_usuarios_W = null;
			private WhereParameter _Id_usuarios_W = null;
			private WhereParameter _Id_cliente_W = null;
			private WhereParameter _Id_vehiculo_W = null;
			private WhereParameter _Visible_W = null;
			private WhereParameter _Usuario_W = null;
			private WhereParameter _Cliente_W = null;
			private WhereParameter _Estado_cliente_W = null;
			private WhereParameter _Id_instalador_W = null;
			private WhereParameter _Instalador_W = null;
			private WhereParameter _Anho_W = null;
			private WhereParameter _Poliza_nroorden_W = null;
			private WhereParameter _Chasis_W = null;
			private WhereParameter _Color_W = null;
			private WhereParameter _Matricula_W = null;
			private WhereParameter _Kilometraje_W = null;
			private WhereParameter _Activo_W = null;
			private WhereParameter _Consumo_aprox_W = null;
			private WhereParameter _Instalacion_fechahora_W = null;
			private WhereParameter _Idmarca_W = null;
			private WhereParameter _Idmodelo_W = null;
			private WhereParameter _Marca_W = null;
			private WhereParameter _Modelo_W = null;
			private WhereParameter _Idequipogps_W = null;
			private WhereParameter _Id_tipoequipogps_W = null;
			private WhereParameter _Tipoequipogps_W = null;
			private WhereParameter _Tipo_de_reportegps_W = null;
			private WhereParameter _Id_equipo_gps_W = null;
			private WhereParameter _Nro_serie_gps_W = null;
			private WhereParameter _Idsimcard_W = null;
			private WhereParameter _Sim_nro_W = null;
			private WhereParameter _Empleado_insert_W = null;
			private WhereParameter _Id_persona_W = null;
			private WhereParameter _Sucursal_instalacion_W = null;
			private WhereParameter _Sucursal_W = null;

			public void WhereClauseReset()
			{
				_Identificador_rastreo_W = null;
				_Idrastreo_vehiculo_W = null;
				_Proviene_de_W = null;
				_Idrastreo_persona_W = null;
				_Idrastreo_usuarios_W = null;
				_Id_usuarios_W = null;
				_Id_cliente_W = null;
				_Id_vehiculo_W = null;
				_Visible_W = null;
				_Usuario_W = null;
				_Cliente_W = null;
				_Estado_cliente_W = null;
				_Id_instalador_W = null;
				_Instalador_W = null;
				_Anho_W = null;
				_Poliza_nroorden_W = null;
				_Chasis_W = null;
				_Color_W = null;
				_Matricula_W = null;
				_Kilometraje_W = null;
				_Activo_W = null;
				_Consumo_aprox_W = null;
				_Instalacion_fechahora_W = null;
				_Idmarca_W = null;
				_Idmodelo_W = null;
				_Marca_W = null;
				_Modelo_W = null;
				_Idequipogps_W = null;
				_Id_tipoequipogps_W = null;
				_Tipoequipogps_W = null;
				_Tipo_de_reportegps_W = null;
				_Id_equipo_gps_W = null;
				_Nro_serie_gps_W = null;
				_Idsimcard_W = null;
				_Sim_nro_W = null;
				_Empleado_insert_W = null;
				_Id_persona_W = null;
				_Sucursal_instalacion_W = null;
				_Sucursal_W = null;

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

				public AggregateParameter Idrastreo_vehiculo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_vehiculo, Parameters.Idrastreo_vehiculo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Proviene_de
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Proviene_de, Parameters.Proviene_de);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
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

				public AggregateParameter Idrastreo_usuarios
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_usuarios, Parameters.Idrastreo_usuarios);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_usuarios
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_usuarios, Parameters.Id_usuarios);
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

				public AggregateParameter Id_vehiculo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_vehiculo, Parameters.Id_vehiculo);
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

				public AggregateParameter Usuario
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Usuario, Parameters.Usuario);
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

				public AggregateParameter Estado_cliente
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Estado_cliente, Parameters.Estado_cliente);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_instalador
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_instalador, Parameters.Id_instalador);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Instalador
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Instalador, Parameters.Instalador);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Anho
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Anho, Parameters.Anho);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Poliza_nroorden
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Poliza_nroorden, Parameters.Poliza_nroorden);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Chasis
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Chasis, Parameters.Chasis);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Color
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Color, Parameters.Color);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Matricula
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Matricula, Parameters.Matricula);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Kilometraje
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Kilometraje, Parameters.Kilometraje);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Activo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Activo, Parameters.Activo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Consumo_aprox
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Consumo_aprox, Parameters.Consumo_aprox);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Instalacion_fechahora
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Instalacion_fechahora, Parameters.Instalacion_fechahora);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Idmarca
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idmarca, Parameters.Idmarca);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Idmodelo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idmodelo, Parameters.Idmodelo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Marca
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Marca, Parameters.Marca);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Modelo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Modelo, Parameters.Modelo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Idequipogps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idequipogps, Parameters.Idequipogps);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_tipoequipogps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_tipoequipogps, Parameters.Id_tipoequipogps);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Tipoequipogps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipoequipogps, Parameters.Tipoequipogps);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Tipo_de_reportegps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_de_reportegps, Parameters.Tipo_de_reportegps);
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

				public AggregateParameter Nro_serie_gps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nro_serie_gps, Parameters.Nro_serie_gps);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Idsimcard
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idsimcard, Parameters.Idsimcard);
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

				public AggregateParameter Empleado_insert
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Empleado_insert, Parameters.Empleado_insert);
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

				public AggregateParameter Sucursal_instalacion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sucursal_instalacion, Parameters.Sucursal_instalacion);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sucursal
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sucursal, Parameters.Sucursal);
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

			public AggregateParameter Idrastreo_vehiculo
		    {
				get
		        {
					if(_Idrastreo_vehiculo_W == null)
	        	    {
						_Idrastreo_vehiculo_W = TearOff.Idrastreo_vehiculo;
					}
					return _Idrastreo_vehiculo_W;
				}
			}

			public AggregateParameter Proviene_de
		    {
				get
		        {
					if(_Proviene_de_W == null)
	        	    {
						_Proviene_de_W = TearOff.Proviene_de;
					}
					return _Proviene_de_W;
				}
			}

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

			public AggregateParameter Idrastreo_usuarios
		    {
				get
		        {
					if(_Idrastreo_usuarios_W == null)
	        	    {
						_Idrastreo_usuarios_W = TearOff.Idrastreo_usuarios;
					}
					return _Idrastreo_usuarios_W;
				}
			}

			public AggregateParameter Id_usuarios
		    {
				get
		        {
					if(_Id_usuarios_W == null)
	        	    {
						_Id_usuarios_W = TearOff.Id_usuarios;
					}
					return _Id_usuarios_W;
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

			public AggregateParameter Id_instalador
		    {
				get
		        {
					if(_Id_instalador_W == null)
	        	    {
						_Id_instalador_W = TearOff.Id_instalador;
					}
					return _Id_instalador_W;
				}
			}

			public AggregateParameter Instalador
		    {
				get
		        {
					if(_Instalador_W == null)
	        	    {
						_Instalador_W = TearOff.Instalador;
					}
					return _Instalador_W;
				}
			}

			public AggregateParameter Anho
		    {
				get
		        {
					if(_Anho_W == null)
	        	    {
						_Anho_W = TearOff.Anho;
					}
					return _Anho_W;
				}
			}

			public AggregateParameter Poliza_nroorden
		    {
				get
		        {
					if(_Poliza_nroorden_W == null)
	        	    {
						_Poliza_nroorden_W = TearOff.Poliza_nroorden;
					}
					return _Poliza_nroorden_W;
				}
			}

			public AggregateParameter Chasis
		    {
				get
		        {
					if(_Chasis_W == null)
	        	    {
						_Chasis_W = TearOff.Chasis;
					}
					return _Chasis_W;
				}
			}

			public AggregateParameter Color
		    {
				get
		        {
					if(_Color_W == null)
	        	    {
						_Color_W = TearOff.Color;
					}
					return _Color_W;
				}
			}

			public AggregateParameter Matricula
		    {
				get
		        {
					if(_Matricula_W == null)
	        	    {
						_Matricula_W = TearOff.Matricula;
					}
					return _Matricula_W;
				}
			}

			public AggregateParameter Kilometraje
		    {
				get
		        {
					if(_Kilometraje_W == null)
	        	    {
						_Kilometraje_W = TearOff.Kilometraje;
					}
					return _Kilometraje_W;
				}
			}

			public AggregateParameter Activo
		    {
				get
		        {
					if(_Activo_W == null)
	        	    {
						_Activo_W = TearOff.Activo;
					}
					return _Activo_W;
				}
			}

			public AggregateParameter Consumo_aprox
		    {
				get
		        {
					if(_Consumo_aprox_W == null)
	        	    {
						_Consumo_aprox_W = TearOff.Consumo_aprox;
					}
					return _Consumo_aprox_W;
				}
			}

			public AggregateParameter Instalacion_fechahora
		    {
				get
		        {
					if(_Instalacion_fechahora_W == null)
	        	    {
						_Instalacion_fechahora_W = TearOff.Instalacion_fechahora;
					}
					return _Instalacion_fechahora_W;
				}
			}

			public AggregateParameter Idmarca
		    {
				get
		        {
					if(_Idmarca_W == null)
	        	    {
						_Idmarca_W = TearOff.Idmarca;
					}
					return _Idmarca_W;
				}
			}

			public AggregateParameter Idmodelo
		    {
				get
		        {
					if(_Idmodelo_W == null)
	        	    {
						_Idmodelo_W = TearOff.Idmodelo;
					}
					return _Idmodelo_W;
				}
			}

			public AggregateParameter Marca
		    {
				get
		        {
					if(_Marca_W == null)
	        	    {
						_Marca_W = TearOff.Marca;
					}
					return _Marca_W;
				}
			}

			public AggregateParameter Modelo
		    {
				get
		        {
					if(_Modelo_W == null)
	        	    {
						_Modelo_W = TearOff.Modelo;
					}
					return _Modelo_W;
				}
			}

			public AggregateParameter Idequipogps
		    {
				get
		        {
					if(_Idequipogps_W == null)
	        	    {
						_Idequipogps_W = TearOff.Idequipogps;
					}
					return _Idequipogps_W;
				}
			}

			public AggregateParameter Id_tipoequipogps
		    {
				get
		        {
					if(_Id_tipoequipogps_W == null)
	        	    {
						_Id_tipoequipogps_W = TearOff.Id_tipoequipogps;
					}
					return _Id_tipoequipogps_W;
				}
			}

			public AggregateParameter Tipoequipogps
		    {
				get
		        {
					if(_Tipoequipogps_W == null)
	        	    {
						_Tipoequipogps_W = TearOff.Tipoequipogps;
					}
					return _Tipoequipogps_W;
				}
			}

			public AggregateParameter Tipo_de_reportegps
		    {
				get
		        {
					if(_Tipo_de_reportegps_W == null)
	        	    {
						_Tipo_de_reportegps_W = TearOff.Tipo_de_reportegps;
					}
					return _Tipo_de_reportegps_W;
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

			public AggregateParameter Nro_serie_gps
		    {
				get
		        {
					if(_Nro_serie_gps_W == null)
	        	    {
						_Nro_serie_gps_W = TearOff.Nro_serie_gps;
					}
					return _Nro_serie_gps_W;
				}
			}

			public AggregateParameter Idsimcard
		    {
				get
		        {
					if(_Idsimcard_W == null)
	        	    {
						_Idsimcard_W = TearOff.Idsimcard;
					}
					return _Idsimcard_W;
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

			public AggregateParameter Empleado_insert
		    {
				get
		        {
					if(_Empleado_insert_W == null)
	        	    {
						_Empleado_insert_W = TearOff.Empleado_insert;
					}
					return _Empleado_insert_W;
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

			public AggregateParameter Sucursal_instalacion
		    {
				get
		        {
					if(_Sucursal_instalacion_W == null)
	        	    {
						_Sucursal_instalacion_W = TearOff.Sucursal_instalacion;
					}
					return _Sucursal_instalacion_W;
				}
			}

			public AggregateParameter Sucursal
		    {
				get
		        {
					if(_Sucursal_W == null)
	        	    {
						_Sucursal_W = TearOff.Sucursal;
					}
					return _Sucursal_W;
				}
			}

			private AggregateParameter _Identificador_rastreo_W = null;
			private AggregateParameter _Idrastreo_vehiculo_W = null;
			private AggregateParameter _Proviene_de_W = null;
			private AggregateParameter _Idrastreo_persona_W = null;
			private AggregateParameter _Idrastreo_usuarios_W = null;
			private AggregateParameter _Id_usuarios_W = null;
			private AggregateParameter _Id_cliente_W = null;
			private AggregateParameter _Id_vehiculo_W = null;
			private AggregateParameter _Visible_W = null;
			private AggregateParameter _Usuario_W = null;
			private AggregateParameter _Cliente_W = null;
			private AggregateParameter _Estado_cliente_W = null;
			private AggregateParameter _Id_instalador_W = null;
			private AggregateParameter _Instalador_W = null;
			private AggregateParameter _Anho_W = null;
			private AggregateParameter _Poliza_nroorden_W = null;
			private AggregateParameter _Chasis_W = null;
			private AggregateParameter _Color_W = null;
			private AggregateParameter _Matricula_W = null;
			private AggregateParameter _Kilometraje_W = null;
			private AggregateParameter _Activo_W = null;
			private AggregateParameter _Consumo_aprox_W = null;
			private AggregateParameter _Instalacion_fechahora_W = null;
			private AggregateParameter _Idmarca_W = null;
			private AggregateParameter _Idmodelo_W = null;
			private AggregateParameter _Marca_W = null;
			private AggregateParameter _Modelo_W = null;
			private AggregateParameter _Idequipogps_W = null;
			private AggregateParameter _Id_tipoequipogps_W = null;
			private AggregateParameter _Tipoequipogps_W = null;
			private AggregateParameter _Tipo_de_reportegps_W = null;
			private AggregateParameter _Id_equipo_gps_W = null;
			private AggregateParameter _Nro_serie_gps_W = null;
			private AggregateParameter _Idsimcard_W = null;
			private AggregateParameter _Sim_nro_W = null;
			private AggregateParameter _Empleado_insert_W = null;
			private AggregateParameter _Id_persona_W = null;
			private AggregateParameter _Sucursal_instalacion_W = null;
			private AggregateParameter _Sucursal_W = null;

			public void AggregateClauseReset()
			{
				_Identificador_rastreo_W = null;
				_Idrastreo_vehiculo_W = null;
				_Proviene_de_W = null;
				_Idrastreo_persona_W = null;
				_Idrastreo_usuarios_W = null;
				_Id_usuarios_W = null;
				_Id_cliente_W = null;
				_Id_vehiculo_W = null;
				_Visible_W = null;
				_Usuario_W = null;
				_Cliente_W = null;
				_Estado_cliente_W = null;
				_Id_instalador_W = null;
				_Instalador_W = null;
				_Anho_W = null;
				_Poliza_nroorden_W = null;
				_Chasis_W = null;
				_Color_W = null;
				_Matricula_W = null;
				_Kilometraje_W = null;
				_Activo_W = null;
				_Consumo_aprox_W = null;
				_Instalacion_fechahora_W = null;
				_Idmarca_W = null;
				_Idmodelo_W = null;
				_Marca_W = null;
				_Modelo_W = null;
				_Idequipogps_W = null;
				_Id_tipoequipogps_W = null;
				_Tipoequipogps_W = null;
				_Tipo_de_reportegps_W = null;
				_Id_equipo_gps_W = null;
				_Nro_serie_gps_W = null;
				_Idsimcard_W = null;
				_Sim_nro_W = null;
				_Empleado_insert_W = null;
				_Id_persona_W = null;
				_Sucursal_instalacion_W = null;
				_Sucursal_W = null;

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
