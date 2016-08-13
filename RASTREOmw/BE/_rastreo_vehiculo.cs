/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_vehiculo.
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
	public abstract class _rastreo_vehiculo : PostgreSqlEntity
	{
		public _rastreo_vehiculo()
		{
			this.QuerySource = "rastreo_vehiculo";
			this.MappingName = "rastreo_vehiculo";

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

			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_vehiculo_load_all", parameters);
		}

		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreo_vehiculo, int Id_cliente)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreo_vehiculo, Idrastreo_vehiculo);

			parameters.Add(Parameters.Id_cliente, Id_cliente);


			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_vehiculo_load_by_primarykey", parameters);
		}

		#region Parameters
		protected class Parameters
		{

			public static NpgsqlParameter Idrastreo_vehiculo
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_vehiculo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Id_cliente
			{
				get
				{
					return new NpgsqlParameter("Id_cliente", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Id_instalador
			{
				get
				{
					return new NpgsqlParameter("Id_instalador", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Proviene_de
			{
				get
				{
					return new NpgsqlParameter("Proviene_de", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Id_equipogps
			{
				get
				{
					return new NpgsqlParameter("Id_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Identificador_rastreo
			{
				get
				{
					return new NpgsqlParameter("Identificador_rastreo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}

			public static NpgsqlParameter Poliza_nroorden
			{
				get
				{
					return new NpgsqlParameter("Poliza_nroorden", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}

			public static NpgsqlParameter Poliza_emision
			{
				get
				{
					return new NpgsqlParameter("Poliza_emision", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}

			public static NpgsqlParameter Poliza_venc
			{
				get
				{
					return new NpgsqlParameter("Poliza_venc", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}

			public static NpgsqlParameter Instalacion_fechahora
			{
				get
				{
					return new NpgsqlParameter("Instalacion_fechahora", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}

			public static NpgsqlParameter Desinstalacion_fechahora
			{
				get
				{
					return new NpgsqlParameter("Desinstalacion_fechahora", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}

			public static NpgsqlParameter Marca
			{
				get
				{
					return new NpgsqlParameter("Marca", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Modelo
			{
				get
				{
					return new NpgsqlParameter("Modelo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Tipo_vehiculo
			{
				get
				{
					return new NpgsqlParameter("Tipo_vehiculo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Anho
			{
				get
				{
					return new NpgsqlParameter("Anho", NpgsqlTypes.NpgsqlDbType.Integer, 0);
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

			public static NpgsqlParameter Motor
			{
				get
				{
					return new NpgsqlParameter("Motor", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
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

			public static NpgsqlParameter Activo_fecha
			{
				get
				{
					return new NpgsqlParameter("Activo_fecha", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
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

			public static NpgsqlParameter Consumo_aprox
			{
				get
				{
					return new NpgsqlParameter("Consumo_aprox", NpgsqlTypes.NpgsqlDbType.Double, 0);
				}
			}

			public static NpgsqlParameter Chofer
			{
				get
				{
					return new NpgsqlParameter("Chofer", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}

			public static NpgsqlParameter Chofer_contacto
			{
				get
				{
					return new NpgsqlParameter("Chofer_contacto", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}

			public static NpgsqlParameter Observacion
			{
				get
				{
					return new NpgsqlParameter("Observacion", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}

			public static NpgsqlParameter Sucursal_instalacion
			{
				get
				{
					return new NpgsqlParameter("Sucursal_instalacion", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Demo
			{
				get
				{
					return new NpgsqlParameter("Demo", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}

			public static NpgsqlParameter Sucursal
			{
				get
				{
					return new NpgsqlParameter("Sucursal", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}

			public static NpgsqlParameter Id_vendedor
			{
				get
				{
					return new NpgsqlParameter("Id_vendedor", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Nroordeninstal
			{
				get
				{
					return new NpgsqlParameter("Nroordeninstal", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Reinstalacion_fechahora
			{
				get
				{
					return new NpgsqlParameter("Reinstalacion_fechahora", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
				}
			}

			public static NpgsqlParameter Activo_ra
			{
				get
				{
					return new NpgsqlParameter("Activo_ra", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}

		}
		#endregion

		#region ColumnNames
		public class ColumnNames
		{
			public const string Idrastreo_vehiculo = "idrastreo_vehiculo";
			public const string Id_cliente = "id_cliente";
			public const string Id_instalador = "id_instalador";
			public const string Proviene_de = "proviene_de";
			public const string Id_equipogps = "id_equipogps";
			public const string Identificador_rastreo = "identificador_rastreo";
			public const string Poliza_nroorden = "poliza_nroorden";
			public const string Poliza_emision = "poliza_emision";
			public const string Poliza_venc = "poliza_venc";
			public const string Instalacion_fechahora = "instalacion_fechahora";
			public const string Desinstalacion_fechahora = "desinstalacion_fechahora";
			public const string Marca = "marca";
			public const string Modelo = "modelo";
			public const string Tipo_vehiculo = "tipo_vehiculo";
			public const string Anho = "anho";
			public const string Chasis = "chasis";
			public const string Color = "color";
			public const string Motor = "motor";
			public const string Matricula = "matricula";
			public const string Kilometraje = "kilometraje";
			public const string Activo = "activo";
			public const string Activo_fecha = "activo_fecha";
			public const string User_ins = "user_ins";
			public const string Fech_ins = "fech_ins";
			public const string User_upd = "user_upd";
			public const string Fech_upd = "fech_upd";
			public const string Consumo_aprox = "consumo_aprox";
			public const string Chofer = "chofer";
			public const string Chofer_contacto = "chofer_contacto";
			public const string Observacion = "observacion";
			public const string Sucursal_instalacion = "sucursal_instalacion";
			public const string Demo = "demo";
			public const string Sucursal = "sucursal";
			public const string Id_vendedor = "id_vendedor";
			public const string Nroordeninstal = "nroordeninstal";
			public const string Reinstalacion_fechahora = "reinstalacion_fechahora";
			public const string Activo_ra = "activo_ra";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();

					ht[Idrastreo_vehiculo] = _rastreo_vehiculo.PropertyNames.Idrastreo_vehiculo;
					ht[Id_cliente] = _rastreo_vehiculo.PropertyNames.Id_cliente;
					ht[Id_instalador] = _rastreo_vehiculo.PropertyNames.Id_instalador;
					ht[Proviene_de] = _rastreo_vehiculo.PropertyNames.Proviene_de;
					ht[Id_equipogps] = _rastreo_vehiculo.PropertyNames.Id_equipogps;
					ht[Identificador_rastreo] = _rastreo_vehiculo.PropertyNames.Identificador_rastreo;
					ht[Poliza_nroorden] = _rastreo_vehiculo.PropertyNames.Poliza_nroorden;
					ht[Poliza_emision] = _rastreo_vehiculo.PropertyNames.Poliza_emision;
					ht[Poliza_venc] = _rastreo_vehiculo.PropertyNames.Poliza_venc;
					ht[Instalacion_fechahora] = _rastreo_vehiculo.PropertyNames.Instalacion_fechahora;
					ht[Desinstalacion_fechahora] = _rastreo_vehiculo.PropertyNames.Desinstalacion_fechahora;
					ht[Marca] = _rastreo_vehiculo.PropertyNames.Marca;
					ht[Modelo] = _rastreo_vehiculo.PropertyNames.Modelo;
					ht[Tipo_vehiculo] = _rastreo_vehiculo.PropertyNames.Tipo_vehiculo;
					ht[Anho] = _rastreo_vehiculo.PropertyNames.Anho;
					ht[Chasis] = _rastreo_vehiculo.PropertyNames.Chasis;
					ht[Color] = _rastreo_vehiculo.PropertyNames.Color;
					ht[Motor] = _rastreo_vehiculo.PropertyNames.Motor;
					ht[Matricula] = _rastreo_vehiculo.PropertyNames.Matricula;
					ht[Kilometraje] = _rastreo_vehiculo.PropertyNames.Kilometraje;
					ht[Activo] = _rastreo_vehiculo.PropertyNames.Activo;
					ht[Activo_fecha] = _rastreo_vehiculo.PropertyNames.Activo_fecha;
					ht[User_ins] = _rastreo_vehiculo.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_vehiculo.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_vehiculo.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_vehiculo.PropertyNames.Fech_upd;
					ht[Consumo_aprox] = _rastreo_vehiculo.PropertyNames.Consumo_aprox;
					ht[Chofer] = _rastreo_vehiculo.PropertyNames.Chofer;
					ht[Chofer_contacto] = _rastreo_vehiculo.PropertyNames.Chofer_contacto;
					ht[Observacion] = _rastreo_vehiculo.PropertyNames.Observacion;
					ht[Sucursal_instalacion] = _rastreo_vehiculo.PropertyNames.Sucursal_instalacion;
					ht[Demo] = _rastreo_vehiculo.PropertyNames.Demo;
					ht[Sucursal] = _rastreo_vehiculo.PropertyNames.Sucursal;
					ht[Id_vendedor] = _rastreo_vehiculo.PropertyNames.Id_vendedor;
					ht[Nroordeninstal] = _rastreo_vehiculo.PropertyNames.Nroordeninstal;
					ht[Reinstalacion_fechahora] = _rastreo_vehiculo.PropertyNames.Reinstalacion_fechahora;
					ht[Activo_ra] = _rastreo_vehiculo.PropertyNames.Activo_ra;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string Idrastreo_vehiculo = "Idrastreo_vehiculo";
			public const string Id_cliente = "Id_cliente";
			public const string Id_instalador = "Id_instalador";
			public const string Proviene_de = "Proviene_de";
			public const string Id_equipogps = "Id_equipogps";
			public const string Identificador_rastreo = "Identificador_rastreo";
			public const string Poliza_nroorden = "Poliza_nroorden";
			public const string Poliza_emision = "Poliza_emision";
			public const string Poliza_venc = "Poliza_venc";
			public const string Instalacion_fechahora = "Instalacion_fechahora";
			public const string Desinstalacion_fechahora = "Desinstalacion_fechahora";
			public const string Marca = "Marca";
			public const string Modelo = "Modelo";
			public const string Tipo_vehiculo = "Tipo_vehiculo";
			public const string Anho = "Anho";
			public const string Chasis = "Chasis";
			public const string Color = "Color";
			public const string Motor = "Motor";
			public const string Matricula = "Matricula";
			public const string Kilometraje = "Kilometraje";
			public const string Activo = "Activo";
			public const string Activo_fecha = "Activo_fecha";
			public const string User_ins = "User_ins";
			public const string Fech_ins = "Fech_ins";
			public const string User_upd = "User_upd";
			public const string Fech_upd = "Fech_upd";
			public const string Consumo_aprox = "Consumo_aprox";
			public const string Chofer = "Chofer";
			public const string Chofer_contacto = "Chofer_contacto";
			public const string Observacion = "Observacion";
			public const string Sucursal_instalacion = "Sucursal_instalacion";
			public const string Demo = "Demo";
			public const string Sucursal = "Sucursal";
			public const string Id_vendedor = "Id_vendedor";
			public const string Nroordeninstal = "Nroordeninstal";
			public const string Reinstalacion_fechahora = "Reinstalacion_fechahora";
			public const string Activo_ra = "Activo_ra";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();

					ht[Idrastreo_vehiculo] = _rastreo_vehiculo.ColumnNames.Idrastreo_vehiculo;
					ht[Id_cliente] = _rastreo_vehiculo.ColumnNames.Id_cliente;
					ht[Id_instalador] = _rastreo_vehiculo.ColumnNames.Id_instalador;
					ht[Proviene_de] = _rastreo_vehiculo.ColumnNames.Proviene_de;
					ht[Id_equipogps] = _rastreo_vehiculo.ColumnNames.Id_equipogps;
					ht[Identificador_rastreo] = _rastreo_vehiculo.ColumnNames.Identificador_rastreo;
					ht[Poliza_nroorden] = _rastreo_vehiculo.ColumnNames.Poliza_nroorden;
					ht[Poliza_emision] = _rastreo_vehiculo.ColumnNames.Poliza_emision;
					ht[Poliza_venc] = _rastreo_vehiculo.ColumnNames.Poliza_venc;
					ht[Instalacion_fechahora] = _rastreo_vehiculo.ColumnNames.Instalacion_fechahora;
					ht[Desinstalacion_fechahora] = _rastreo_vehiculo.ColumnNames.Desinstalacion_fechahora;
					ht[Marca] = _rastreo_vehiculo.ColumnNames.Marca;
					ht[Modelo] = _rastreo_vehiculo.ColumnNames.Modelo;
					ht[Tipo_vehiculo] = _rastreo_vehiculo.ColumnNames.Tipo_vehiculo;
					ht[Anho] = _rastreo_vehiculo.ColumnNames.Anho;
					ht[Chasis] = _rastreo_vehiculo.ColumnNames.Chasis;
					ht[Color] = _rastreo_vehiculo.ColumnNames.Color;
					ht[Motor] = _rastreo_vehiculo.ColumnNames.Motor;
					ht[Matricula] = _rastreo_vehiculo.ColumnNames.Matricula;
					ht[Kilometraje] = _rastreo_vehiculo.ColumnNames.Kilometraje;
					ht[Activo] = _rastreo_vehiculo.ColumnNames.Activo;
					ht[Activo_fecha] = _rastreo_vehiculo.ColumnNames.Activo_fecha;
					ht[User_ins] = _rastreo_vehiculo.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_vehiculo.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_vehiculo.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_vehiculo.ColumnNames.Fech_upd;
					ht[Consumo_aprox] = _rastreo_vehiculo.ColumnNames.Consumo_aprox;
					ht[Chofer] = _rastreo_vehiculo.ColumnNames.Chofer;
					ht[Chofer_contacto] = _rastreo_vehiculo.ColumnNames.Chofer_contacto;
					ht[Observacion] = _rastreo_vehiculo.ColumnNames.Observacion;
					ht[Sucursal_instalacion] = _rastreo_vehiculo.ColumnNames.Sucursal_instalacion;
					ht[Demo] = _rastreo_vehiculo.ColumnNames.Demo;
					ht[Sucursal] = _rastreo_vehiculo.ColumnNames.Sucursal;
					ht[Id_vendedor] = _rastreo_vehiculo.ColumnNames.Id_vendedor;
					ht[Nroordeninstal] = _rastreo_vehiculo.ColumnNames.Nroordeninstal;
					ht[Reinstalacion_fechahora] = _rastreo_vehiculo.ColumnNames.Reinstalacion_fechahora;
					ht[Activo_ra] = _rastreo_vehiculo.ColumnNames.Activo_ra;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;
		}
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{
			public const string Idrastreo_vehiculo = "s_Idrastreo_vehiculo";
			public const string Id_cliente = "s_Id_cliente";
			public const string Id_instalador = "s_Id_instalador";
			public const string Proviene_de = "s_Proviene_de";
			public const string Id_equipogps = "s_Id_equipogps";
			public const string Identificador_rastreo = "s_Identificador_rastreo";
			public const string Poliza_nroorden = "s_Poliza_nroorden";
			public const string Poliza_emision = "s_Poliza_emision";
			public const string Poliza_venc = "s_Poliza_venc";
			public const string Instalacion_fechahora = "s_Instalacion_fechahora";
			public const string Desinstalacion_fechahora = "s_Desinstalacion_fechahora";
			public const string Marca = "s_Marca";
			public const string Modelo = "s_Modelo";
			public const string Tipo_vehiculo = "s_Tipo_vehiculo";
			public const string Anho = "s_Anho";
			public const string Chasis = "s_Chasis";
			public const string Color = "s_Color";
			public const string Motor = "s_Motor";
			public const string Matricula = "s_Matricula";
			public const string Kilometraje = "s_Kilometraje";
			public const string Activo = "s_Activo";
			public const string Activo_fecha = "s_Activo_fecha";
			public const string User_ins = "s_User_ins";
			public const string Fech_ins = "s_Fech_ins";
			public const string User_upd = "s_User_upd";
			public const string Fech_upd = "s_Fech_upd";
			public const string Consumo_aprox = "s_Consumo_aprox";
			public const string Chofer = "s_Chofer";
			public const string Chofer_contacto = "s_Chofer_contacto";
			public const string Observacion = "s_Observacion";
			public const string Sucursal_instalacion = "s_Sucursal_instalacion";
			public const string Demo = "s_Demo";
			public const string Sucursal = "s_Sucursal";
			public const string Id_vendedor = "s_Id_vendedor";
			public const string Nroordeninstal = "s_Nroordeninstal";
			public const string Reinstalacion_fechahora = "s_Reinstalacion_fechahora";
			public const string Activo_ra = "s_Activo_ra";

		}
		#endregion

		#region Properties

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

		public virtual DateTime Poliza_emision
		{
			get
			{
				return base.GetDateTime(ColumnNames.Poliza_emision);
			}
			set
			{
				base.SetDateTime(ColumnNames.Poliza_emision, value);
			}
		}

		public virtual DateTime Poliza_venc
		{
			get
			{
				return base.GetDateTime(ColumnNames.Poliza_venc);
			}
			set
			{
				base.SetDateTime(ColumnNames.Poliza_venc, value);
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

		public virtual DateTime Desinstalacion_fechahora
		{
			get
			{
				return base.GetDateTime(ColumnNames.Desinstalacion_fechahora);
			}
			set
			{
				base.SetDateTime(ColumnNames.Desinstalacion_fechahora, value);
			}
		}

		public virtual int Marca
		{
			get
			{
				return base.Getint(ColumnNames.Marca);
			}
			set
			{
				base.Setint(ColumnNames.Marca, value);
			}
		}

		public virtual int Modelo
		{
			get
			{
				return base.Getint(ColumnNames.Modelo);
			}
			set
			{
				base.Setint(ColumnNames.Modelo, value);
			}
		}

		public virtual int Tipo_vehiculo
		{
			get
			{
				return base.Getint(ColumnNames.Tipo_vehiculo);
			}
			set
			{
				base.Setint(ColumnNames.Tipo_vehiculo, value);
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

		public virtual string Motor
		{
			get
			{
				return base.Getstring(ColumnNames.Motor);
			}
			set
			{
				base.Setstring(ColumnNames.Motor, value);
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

		public virtual DateTime Activo_fecha
		{
			get
			{
				return base.GetDateTime(ColumnNames.Activo_fecha);
			}
			set
			{
				base.SetDateTime(ColumnNames.Activo_fecha, value);
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

		public virtual string Chofer
		{
			get
			{
				return base.Getstring(ColumnNames.Chofer);
			}
			set
			{
				base.Setstring(ColumnNames.Chofer, value);
			}
		}

		public virtual string Chofer_contacto
		{
			get
			{
				return base.Getstring(ColumnNames.Chofer_contacto);
			}
			set
			{
				base.Setstring(ColumnNames.Chofer_contacto, value);
			}
		}

		public virtual string Observacion
		{
			get
			{
				return base.Getstring(ColumnNames.Observacion);
			}
			set
			{
				base.Setstring(ColumnNames.Observacion, value);
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

		public virtual bool Demo
		{
			get
			{
				return base.Getbool(ColumnNames.Demo);
			}
			set
			{
				base.Setbool(ColumnNames.Demo, value);
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

		public virtual int Id_vendedor
		{
			get
			{
				return base.Getint(ColumnNames.Id_vendedor);
			}
			set
			{
				base.Setint(ColumnNames.Id_vendedor, value);
			}
		}

		public virtual int Nroordeninstal
		{
			get
			{
				return base.Getint(ColumnNames.Nroordeninstal);
			}
			set
			{
				base.Setint(ColumnNames.Nroordeninstal, value);
			}
		}

		public virtual DateTime Reinstalacion_fechahora
		{
			get
			{
				return base.GetDateTime(ColumnNames.Reinstalacion_fechahora);
			}
			set
			{
				base.SetDateTime(ColumnNames.Reinstalacion_fechahora, value);
			}
		}

		public virtual bool Activo_ra
		{
			get
			{
				return base.Getbool(ColumnNames.Activo_ra);
			}
			set
			{
				base.Setbool(ColumnNames.Activo_ra, value);
			}
		}


		#endregion

		#region String Properties

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

		public virtual string s_Poliza_emision
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Poliza_emision) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Poliza_emision);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Poliza_emision);
				else
					this.Poliza_emision = base.SetDateTimeAsString(ColumnNames.Poliza_emision, value);
			}
		}

		public virtual string s_Poliza_venc
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Poliza_venc) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Poliza_venc);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Poliza_venc);
				else
					this.Poliza_venc = base.SetDateTimeAsString(ColumnNames.Poliza_venc, value);
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

		public virtual string s_Desinstalacion_fechahora
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Desinstalacion_fechahora) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Desinstalacion_fechahora);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Desinstalacion_fechahora);
				else
					this.Desinstalacion_fechahora = base.SetDateTimeAsString(ColumnNames.Desinstalacion_fechahora, value);
			}
		}

		public virtual string s_Marca
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Marca) ? string.Empty : base.GetintAsString(ColumnNames.Marca);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Marca);
				else
					this.Marca = base.SetintAsString(ColumnNames.Marca, value);
			}
		}

		public virtual string s_Modelo
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Modelo) ? string.Empty : base.GetintAsString(ColumnNames.Modelo);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Modelo);
				else
					this.Modelo = base.SetintAsString(ColumnNames.Modelo, value);
			}
		}

		public virtual string s_Tipo_vehiculo
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Tipo_vehiculo) ? string.Empty : base.GetintAsString(ColumnNames.Tipo_vehiculo);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipo_vehiculo);
				else
					this.Tipo_vehiculo = base.SetintAsString(ColumnNames.Tipo_vehiculo, value);
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

		public virtual string s_Motor
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Motor) ? string.Empty : base.GetstringAsString(ColumnNames.Motor);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Motor);
				else
					this.Motor = base.SetstringAsString(ColumnNames.Motor, value);
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

		public virtual string s_Activo_fecha
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Activo_fecha) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Activo_fecha);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Activo_fecha);
				else
					this.Activo_fecha = base.SetDateTimeAsString(ColumnNames.Activo_fecha, value);
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

		public virtual string s_Chofer
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Chofer) ? string.Empty : base.GetstringAsString(ColumnNames.Chofer);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Chofer);
				else
					this.Chofer = base.SetstringAsString(ColumnNames.Chofer, value);
			}
		}

		public virtual string s_Chofer_contacto
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Chofer_contacto) ? string.Empty : base.GetstringAsString(ColumnNames.Chofer_contacto);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Chofer_contacto);
				else
					this.Chofer_contacto = base.SetstringAsString(ColumnNames.Chofer_contacto, value);
			}
		}

		public virtual string s_Observacion
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Observacion) ? string.Empty : base.GetstringAsString(ColumnNames.Observacion);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Observacion);
				else
					this.Observacion = base.SetstringAsString(ColumnNames.Observacion, value);
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

		public virtual string s_Demo
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Demo) ? string.Empty : base.GetboolAsString(ColumnNames.Demo);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Demo);
				else
					this.Demo = base.SetboolAsString(ColumnNames.Demo, value);
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

		public virtual string s_Id_vendedor
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Id_vendedor) ? string.Empty : base.GetintAsString(ColumnNames.Id_vendedor);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_vendedor);
				else
					this.Id_vendedor = base.SetintAsString(ColumnNames.Id_vendedor, value);
			}
		}

		public virtual string s_Nroordeninstal
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Nroordeninstal) ? string.Empty : base.GetintAsString(ColumnNames.Nroordeninstal);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nroordeninstal);
				else
					this.Nroordeninstal = base.SetintAsString(ColumnNames.Nroordeninstal, value);
			}
		}

		public virtual string s_Reinstalacion_fechahora
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Reinstalacion_fechahora) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Reinstalacion_fechahora);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Reinstalacion_fechahora);
				else
					this.Reinstalacion_fechahora = base.SetDateTimeAsString(ColumnNames.Reinstalacion_fechahora, value);
			}
		}

		public virtual string s_Activo_ra
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Activo_ra) ? string.Empty : base.GetboolAsString(ColumnNames.Activo_ra);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Activo_ra);
				else
					this.Activo_ra = base.SetboolAsString(ColumnNames.Activo_ra, value);
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


				public WhereParameter Idrastreo_vehiculo
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_vehiculo, Parameters.Idrastreo_vehiculo);
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

				public WhereParameter Id_instalador
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Id_instalador, Parameters.Id_instalador);
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

				public WhereParameter Id_equipogps
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Id_equipogps, Parameters.Id_equipogps);
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

				public WhereParameter Poliza_nroorden
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Poliza_nroorden, Parameters.Poliza_nroorden);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Poliza_emision
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Poliza_emision, Parameters.Poliza_emision);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Poliza_venc
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Poliza_venc, Parameters.Poliza_venc);
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

				public WhereParameter Desinstalacion_fechahora
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Desinstalacion_fechahora, Parameters.Desinstalacion_fechahora);
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

				public WhereParameter Tipo_vehiculo
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Tipo_vehiculo, Parameters.Tipo_vehiculo);
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

				public WhereParameter Motor
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Motor, Parameters.Motor);
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

				public WhereParameter Activo_fecha
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Activo_fecha, Parameters.Activo_fecha);
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

				public WhereParameter Consumo_aprox
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Consumo_aprox, Parameters.Consumo_aprox);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Chofer
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Chofer, Parameters.Chofer);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Chofer_contacto
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Chofer_contacto, Parameters.Chofer_contacto);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Observacion
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Observacion, Parameters.Observacion);
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

				public WhereParameter Demo
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Demo, Parameters.Demo);
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

				public WhereParameter Id_vendedor
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Id_vendedor, Parameters.Id_vendedor);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Nroordeninstal
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Nroordeninstal, Parameters.Nroordeninstal);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Reinstalacion_fechahora
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Reinstalacion_fechahora, Parameters.Reinstalacion_fechahora);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Activo_ra
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Activo_ra, Parameters.Activo_ra);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion

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

			public WhereParameter Poliza_emision
			{
				get
				{
					if(_Poliza_emision_W == null)
					{
						_Poliza_emision_W = TearOff.Poliza_emision;
					}
					return _Poliza_emision_W;
				}
			}

			public WhereParameter Poliza_venc
			{
				get
				{
					if(_Poliza_venc_W == null)
					{
						_Poliza_venc_W = TearOff.Poliza_venc;
					}
					return _Poliza_venc_W;
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

			public WhereParameter Desinstalacion_fechahora
			{
				get
				{
					if(_Desinstalacion_fechahora_W == null)
					{
						_Desinstalacion_fechahora_W = TearOff.Desinstalacion_fechahora;
					}
					return _Desinstalacion_fechahora_W;
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

			public WhereParameter Tipo_vehiculo
			{
				get
				{
					if(_Tipo_vehiculo_W == null)
					{
						_Tipo_vehiculo_W = TearOff.Tipo_vehiculo;
					}
					return _Tipo_vehiculo_W;
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

			public WhereParameter Motor
			{
				get
				{
					if(_Motor_W == null)
					{
						_Motor_W = TearOff.Motor;
					}
					return _Motor_W;
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

			public WhereParameter Activo_fecha
			{
				get
				{
					if(_Activo_fecha_W == null)
					{
						_Activo_fecha_W = TearOff.Activo_fecha;
					}
					return _Activo_fecha_W;
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

			public WhereParameter Chofer
			{
				get
				{
					if(_Chofer_W == null)
					{
						_Chofer_W = TearOff.Chofer;
					}
					return _Chofer_W;
				}
			}

			public WhereParameter Chofer_contacto
			{
				get
				{
					if(_Chofer_contacto_W == null)
					{
						_Chofer_contacto_W = TearOff.Chofer_contacto;
					}
					return _Chofer_contacto_W;
				}
			}

			public WhereParameter Observacion
			{
				get
				{
					if(_Observacion_W == null)
					{
						_Observacion_W = TearOff.Observacion;
					}
					return _Observacion_W;
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

			public WhereParameter Demo
			{
				get
				{
					if(_Demo_W == null)
					{
						_Demo_W = TearOff.Demo;
					}
					return _Demo_W;
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

			public WhereParameter Id_vendedor
			{
				get
				{
					if(_Id_vendedor_W == null)
					{
						_Id_vendedor_W = TearOff.Id_vendedor;
					}
					return _Id_vendedor_W;
				}
			}

			public WhereParameter Nroordeninstal
			{
				get
				{
					if(_Nroordeninstal_W == null)
					{
						_Nroordeninstal_W = TearOff.Nroordeninstal;
					}
					return _Nroordeninstal_W;
				}
			}

			public WhereParameter Reinstalacion_fechahora
			{
				get
				{
					if(_Reinstalacion_fechahora_W == null)
					{
						_Reinstalacion_fechahora_W = TearOff.Reinstalacion_fechahora;
					}
					return _Reinstalacion_fechahora_W;
				}
			}

			public WhereParameter Activo_ra
			{
				get
				{
					if(_Activo_ra_W == null)
					{
						_Activo_ra_W = TearOff.Activo_ra;
					}
					return _Activo_ra_W;
				}
			}

			private WhereParameter _Idrastreo_vehiculo_W = null;
			private WhereParameter _Id_cliente_W = null;
			private WhereParameter _Id_instalador_W = null;
			private WhereParameter _Proviene_de_W = null;
			private WhereParameter _Id_equipogps_W = null;
			private WhereParameter _Identificador_rastreo_W = null;
			private WhereParameter _Poliza_nroorden_W = null;
			private WhereParameter _Poliza_emision_W = null;
			private WhereParameter _Poliza_venc_W = null;
			private WhereParameter _Instalacion_fechahora_W = null;
			private WhereParameter _Desinstalacion_fechahora_W = null;
			private WhereParameter _Marca_W = null;
			private WhereParameter _Modelo_W = null;
			private WhereParameter _Tipo_vehiculo_W = null;
			private WhereParameter _Anho_W = null;
			private WhereParameter _Chasis_W = null;
			private WhereParameter _Color_W = null;
			private WhereParameter _Motor_W = null;
			private WhereParameter _Matricula_W = null;
			private WhereParameter _Kilometraje_W = null;
			private WhereParameter _Activo_W = null;
			private WhereParameter _Activo_fecha_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;
			private WhereParameter _Consumo_aprox_W = null;
			private WhereParameter _Chofer_W = null;
			private WhereParameter _Chofer_contacto_W = null;
			private WhereParameter _Observacion_W = null;
			private WhereParameter _Sucursal_instalacion_W = null;
			private WhereParameter _Demo_W = null;
			private WhereParameter _Sucursal_W = null;
			private WhereParameter _Id_vendedor_W = null;
			private WhereParameter _Nroordeninstal_W = null;
			private WhereParameter _Reinstalacion_fechahora_W = null;
			private WhereParameter _Activo_ra_W = null;

			public void WhereClauseReset()
			{
				_Idrastreo_vehiculo_W = null;
				_Id_cliente_W = null;
				_Id_instalador_W = null;
				_Proviene_de_W = null;
				_Id_equipogps_W = null;
				_Identificador_rastreo_W = null;
				_Poliza_nroorden_W = null;
				_Poliza_emision_W = null;
				_Poliza_venc_W = null;
				_Instalacion_fechahora_W = null;
				_Desinstalacion_fechahora_W = null;
				_Marca_W = null;
				_Modelo_W = null;
				_Tipo_vehiculo_W = null;
				_Anho_W = null;
				_Chasis_W = null;
				_Color_W = null;
				_Motor_W = null;
				_Matricula_W = null;
				_Kilometraje_W = null;
				_Activo_W = null;
				_Activo_fecha_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Consumo_aprox_W = null;
				_Chofer_W = null;
				_Chofer_contacto_W = null;
				_Observacion_W = null;
				_Sucursal_instalacion_W = null;
				_Demo_W = null;
				_Sucursal_W = null;
				_Id_vendedor_W = null;
				_Nroordeninstal_W = null;
				_Reinstalacion_fechahora_W = null;
				_Activo_ra_W = null;

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


				public AggregateParameter Idrastreo_vehiculo
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_vehiculo, Parameters.Idrastreo_vehiculo);
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

				public AggregateParameter Id_instalador
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_instalador, Parameters.Id_instalador);
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

				public AggregateParameter Id_equipogps
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_equipogps, Parameters.Id_equipogps);
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

				public AggregateParameter Poliza_nroorden
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Poliza_nroorden, Parameters.Poliza_nroorden);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Poliza_emision
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Poliza_emision, Parameters.Poliza_emision);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Poliza_venc
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Poliza_venc, Parameters.Poliza_venc);
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

				public AggregateParameter Desinstalacion_fechahora
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Desinstalacion_fechahora, Parameters.Desinstalacion_fechahora);
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

				public AggregateParameter Tipo_vehiculo
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_vehiculo, Parameters.Tipo_vehiculo);
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

				public AggregateParameter Motor
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Motor, Parameters.Motor);
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

				public AggregateParameter Activo_fecha
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Activo_fecha, Parameters.Activo_fecha);
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

				public AggregateParameter Consumo_aprox
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Consumo_aprox, Parameters.Consumo_aprox);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Chofer
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Chofer, Parameters.Chofer);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Chofer_contacto
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Chofer_contacto, Parameters.Chofer_contacto);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Observacion
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Observacion, Parameters.Observacion);
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

				public AggregateParameter Demo
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Demo, Parameters.Demo);
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

				public AggregateParameter Id_vendedor
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_vendedor, Parameters.Id_vendedor);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Nroordeninstal
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nroordeninstal, Parameters.Nroordeninstal);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Reinstalacion_fechahora
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Reinstalacion_fechahora, Parameters.Reinstalacion_fechahora);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Activo_ra
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Activo_ra, Parameters.Activo_ra);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion

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

			public AggregateParameter Poliza_emision
			{
				get
				{
					if(_Poliza_emision_W == null)
					{
						_Poliza_emision_W = TearOff.Poliza_emision;
					}
					return _Poliza_emision_W;
				}
			}

			public AggregateParameter Poliza_venc
			{
				get
				{
					if(_Poliza_venc_W == null)
					{
						_Poliza_venc_W = TearOff.Poliza_venc;
					}
					return _Poliza_venc_W;
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

			public AggregateParameter Desinstalacion_fechahora
			{
				get
				{
					if(_Desinstalacion_fechahora_W == null)
					{
						_Desinstalacion_fechahora_W = TearOff.Desinstalacion_fechahora;
					}
					return _Desinstalacion_fechahora_W;
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

			public AggregateParameter Tipo_vehiculo
			{
				get
				{
					if(_Tipo_vehiculo_W == null)
					{
						_Tipo_vehiculo_W = TearOff.Tipo_vehiculo;
					}
					return _Tipo_vehiculo_W;
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

			public AggregateParameter Motor
			{
				get
				{
					if(_Motor_W == null)
					{
						_Motor_W = TearOff.Motor;
					}
					return _Motor_W;
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

			public AggregateParameter Activo_fecha
			{
				get
				{
					if(_Activo_fecha_W == null)
					{
						_Activo_fecha_W = TearOff.Activo_fecha;
					}
					return _Activo_fecha_W;
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

			public AggregateParameter Chofer
			{
				get
				{
					if(_Chofer_W == null)
					{
						_Chofer_W = TearOff.Chofer;
					}
					return _Chofer_W;
				}
			}

			public AggregateParameter Chofer_contacto
			{
				get
				{
					if(_Chofer_contacto_W == null)
					{
						_Chofer_contacto_W = TearOff.Chofer_contacto;
					}
					return _Chofer_contacto_W;
				}
			}

			public AggregateParameter Observacion
			{
				get
				{
					if(_Observacion_W == null)
					{
						_Observacion_W = TearOff.Observacion;
					}
					return _Observacion_W;
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

			public AggregateParameter Demo
			{
				get
				{
					if(_Demo_W == null)
					{
						_Demo_W = TearOff.Demo;
					}
					return _Demo_W;
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

			public AggregateParameter Id_vendedor
			{
				get
				{
					if(_Id_vendedor_W == null)
					{
						_Id_vendedor_W = TearOff.Id_vendedor;
					}
					return _Id_vendedor_W;
				}
			}

			public AggregateParameter Nroordeninstal
			{
				get
				{
					if(_Nroordeninstal_W == null)
					{
						_Nroordeninstal_W = TearOff.Nroordeninstal;
					}
					return _Nroordeninstal_W;
				}
			}

			public AggregateParameter Reinstalacion_fechahora
			{
				get
				{
					if(_Reinstalacion_fechahora_W == null)
					{
						_Reinstalacion_fechahora_W = TearOff.Reinstalacion_fechahora;
					}
					return _Reinstalacion_fechahora_W;
				}
			}

			public AggregateParameter Activo_ra
			{
				get
				{
					if(_Activo_ra_W == null)
					{
						_Activo_ra_W = TearOff.Activo_ra;
					}
					return _Activo_ra_W;
				}
			}

			private AggregateParameter _Idrastreo_vehiculo_W = null;
			private AggregateParameter _Id_cliente_W = null;
			private AggregateParameter _Id_instalador_W = null;
			private AggregateParameter _Proviene_de_W = null;
			private AggregateParameter _Id_equipogps_W = null;
			private AggregateParameter _Identificador_rastreo_W = null;
			private AggregateParameter _Poliza_nroorden_W = null;
			private AggregateParameter _Poliza_emision_W = null;
			private AggregateParameter _Poliza_venc_W = null;
			private AggregateParameter _Instalacion_fechahora_W = null;
			private AggregateParameter _Desinstalacion_fechahora_W = null;
			private AggregateParameter _Marca_W = null;
			private AggregateParameter _Modelo_W = null;
			private AggregateParameter _Tipo_vehiculo_W = null;
			private AggregateParameter _Anho_W = null;
			private AggregateParameter _Chasis_W = null;
			private AggregateParameter _Color_W = null;
			private AggregateParameter _Motor_W = null;
			private AggregateParameter _Matricula_W = null;
			private AggregateParameter _Kilometraje_W = null;
			private AggregateParameter _Activo_W = null;
			private AggregateParameter _Activo_fecha_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;
			private AggregateParameter _Consumo_aprox_W = null;
			private AggregateParameter _Chofer_W = null;
			private AggregateParameter _Chofer_contacto_W = null;
			private AggregateParameter _Observacion_W = null;
			private AggregateParameter _Sucursal_instalacion_W = null;
			private AggregateParameter _Demo_W = null;
			private AggregateParameter _Sucursal_W = null;
			private AggregateParameter _Id_vendedor_W = null;
			private AggregateParameter _Nroordeninstal_W = null;
			private AggregateParameter _Reinstalacion_fechahora_W = null;
			private AggregateParameter _Activo_ra_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreo_vehiculo_W = null;
				_Id_cliente_W = null;
				_Id_instalador_W = null;
				_Proviene_de_W = null;
				_Id_equipogps_W = null;
				_Identificador_rastreo_W = null;
				_Poliza_nroorden_W = null;
				_Poliza_emision_W = null;
				_Poliza_venc_W = null;
				_Instalacion_fechahora_W = null;
				_Desinstalacion_fechahora_W = null;
				_Marca_W = null;
				_Modelo_W = null;
				_Tipo_vehiculo_W = null;
				_Anho_W = null;
				_Chasis_W = null;
				_Color_W = null;
				_Motor_W = null;
				_Matricula_W = null;
				_Kilometraje_W = null;
				_Activo_W = null;
				_Activo_fecha_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Consumo_aprox_W = null;
				_Chofer_W = null;
				_Chofer_contacto_W = null;
				_Observacion_W = null;
				_Sucursal_instalacion_W = null;
				_Demo_W = null;
				_Sucursal_W = null;
				_Id_vendedor_W = null;
				_Nroordeninstal_W = null;
				_Reinstalacion_fechahora_W = null;
				_Activo_ra_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_vehiculo_insert";

			CreateParameters(cmd);

			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreo_vehiculo.ParameterName];
			p.Direction = ParameterDirection.Output;

			return cmd;
		}

		protected override IDbCommand GetUpdateCommand()
		{

			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_vehiculo_update";

			CreateParameters(cmd);

			return cmd;
		}

		protected override IDbCommand GetDeleteCommand()
		{

			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_vehiculo_delete";

			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreo_vehiculo);
			p.SourceColumn = ColumnNames.Idrastreo_vehiculo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_cliente);
			p.SourceColumn = ColumnNames.Id_cliente;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}

		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;

			p = cmd.Parameters.Add(Parameters.Idrastreo_vehiculo);
			p.SourceColumn = ColumnNames.Idrastreo_vehiculo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_cliente);
			p.SourceColumn = ColumnNames.Id_cliente;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_instalador);
			p.SourceColumn = ColumnNames.Id_instalador;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Proviene_de);
			p.SourceColumn = ColumnNames.Proviene_de;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_equipogps);
			p.SourceColumn = ColumnNames.Id_equipogps;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Identificador_rastreo);
			p.SourceColumn = ColumnNames.Identificador_rastreo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Poliza_nroorden);
			p.SourceColumn = ColumnNames.Poliza_nroorden;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Poliza_emision);
			p.SourceColumn = ColumnNames.Poliza_emision;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Poliza_venc);
			p.SourceColumn = ColumnNames.Poliza_venc;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Instalacion_fechahora);
			p.SourceColumn = ColumnNames.Instalacion_fechahora;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Desinstalacion_fechahora);
			p.SourceColumn = ColumnNames.Desinstalacion_fechahora;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Marca);
			p.SourceColumn = ColumnNames.Marca;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Modelo);
			p.SourceColumn = ColumnNames.Modelo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Tipo_vehiculo);
			p.SourceColumn = ColumnNames.Tipo_vehiculo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Anho);
			p.SourceColumn = ColumnNames.Anho;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Chasis);
			p.SourceColumn = ColumnNames.Chasis;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Color);
			p.SourceColumn = ColumnNames.Color;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Motor);
			p.SourceColumn = ColumnNames.Motor;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Matricula);
			p.SourceColumn = ColumnNames.Matricula;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Kilometraje);
			p.SourceColumn = ColumnNames.Kilometraje;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Activo);
			p.SourceColumn = ColumnNames.Activo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Activo_fecha);
			p.SourceColumn = ColumnNames.Activo_fecha;
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

			p = cmd.Parameters.Add(Parameters.Consumo_aprox);
			p.SourceColumn = ColumnNames.Consumo_aprox;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Chofer);
			p.SourceColumn = ColumnNames.Chofer;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Chofer_contacto);
			p.SourceColumn = ColumnNames.Chofer_contacto;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Observacion);
			p.SourceColumn = ColumnNames.Observacion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Sucursal_instalacion);
			p.SourceColumn = ColumnNames.Sucursal_instalacion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Demo);
			p.SourceColumn = ColumnNames.Demo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Sucursal);
			p.SourceColumn = ColumnNames.Sucursal;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_vendedor);
			p.SourceColumn = ColumnNames.Id_vendedor;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nroordeninstal);
			p.SourceColumn = ColumnNames.Nroordeninstal;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Reinstalacion_fechahora);
			p.SourceColumn = ColumnNames.Reinstalacion_fechahora;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Activo_ra);
			p.SourceColumn = ColumnNames.Activo_ra;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}


