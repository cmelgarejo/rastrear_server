/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rsview_vehiculos_asignados_a_usuarios para la vista rsview_vehiculos_asignados_a_usuarios.
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
	public class rsview_vehiculos_asignados_a_usuarios : PostgreSqlEntity
	{
		public rsview_vehiculos_asignados_a_usuarios(String laCadenaDeConexion)
		{
			this.QuerySource = "rsview_vehiculos_asignados_a_usuarios";
			this.MappingName = "rsview_vehiculos_asignados_a_usuarios";
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
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Identificador_rastreo = "identificador_rastreo";
            public const string Id_usuarios = "id_usuarios";
            public const string Id_cliente = "id_cliente";
            public const string Id_vehiculo = "id_vehiculo";
            public const string Visible = "visible";
            public const string Usuario = "usuario";
            public const string Cliente = "cliente";
            public const string Anho = "anho";
            public const string Chasis = "chasis";
            public const string Color = "color";
            public const string Matricula = "matricula";
            public const string Kilometraje = "kilometraje";
            public const string Activo = "activo";
            public const string Marca = "marca";
            public const string Modelo = "modelo";
            public const string Idequipogps = "idequipogps";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Identificador_rastreo] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Identificador_rastreo;
					ht[Id_usuarios] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Id_usuarios;
					ht[Id_cliente] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Id_cliente;
					ht[Id_vehiculo] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Id_vehiculo;
					ht[Visible] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Visible;
					ht[Usuario] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Usuario;
					ht[Cliente] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Cliente;
					ht[Anho] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Anho;
					ht[Chasis] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Chasis;
					ht[Color] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Color;
					ht[Matricula] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Matricula;
					ht[Kilometraje] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Kilometraje;
					ht[Activo] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Activo;
					ht[Marca] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Marca;
					ht[Modelo] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Modelo;
					ht[Idequipogps] = rsview_vehiculos_asignados_a_usuarios.PropertyNames.Idequipogps;

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
            public const string Id_usuarios = "Id_usuarios";
            public const string Id_cliente = "Id_cliente";
            public const string Id_vehiculo = "Id_vehiculo";
            public const string Visible = "Visible";
            public const string Usuario = "Usuario";
            public const string Cliente = "Cliente";
            public const string Anho = "Anho";
            public const string Chasis = "Chasis";
            public const string Color = "Color";
            public const string Matricula = "Matricula";
            public const string Kilometraje = "Kilometraje";
            public const string Activo = "Activo";
            public const string Marca = "Marca";
            public const string Modelo = "Modelo";
            public const string Idequipogps = "Idequipogps";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Identificador_rastreo] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Identificador_rastreo;
					ht[Id_usuarios] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Id_usuarios;
					ht[Id_cliente] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Id_cliente;
					ht[Id_vehiculo] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Id_vehiculo;
					ht[Visible] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Visible;
					ht[Usuario] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Usuario;
					ht[Cliente] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Cliente;
					ht[Anho] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Anho;
					ht[Chasis] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Chasis;
					ht[Color] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Color;
					ht[Matricula] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Matricula;
					ht[Kilometraje] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Kilometraje;
					ht[Activo] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Activo;
					ht[Marca] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Marca;
					ht[Modelo] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Modelo;
					ht[Idequipogps] = rsview_vehiculos_asignados_a_usuarios.ColumnNames.Idequipogps;

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
            public const string Id_usuarios = "s_Id_usuarios";
            public const string Id_cliente = "s_Id_cliente";
            public const string Id_vehiculo = "s_Id_vehiculo";
            public const string Visible = "s_Visible";
            public const string Usuario = "s_Usuario";
            public const string Cliente = "s_Cliente";
            public const string Anho = "s_Anho";
            public const string Chasis = "s_Chasis";
            public const string Color = "s_Color";
            public const string Matricula = "s_Matricula";
            public const string Kilometraje = "s_Kilometraje";
            public const string Activo = "s_Activo";
            public const string Marca = "s_Marca";
            public const string Modelo = "s_Modelo";
            public const string Idequipogps = "s_Idequipogps";

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

			private WhereParameter _Identificador_rastreo_W = null;
			private WhereParameter _Id_usuarios_W = null;
			private WhereParameter _Id_cliente_W = null;
			private WhereParameter _Id_vehiculo_W = null;
			private WhereParameter _Visible_W = null;
			private WhereParameter _Usuario_W = null;
			private WhereParameter _Cliente_W = null;
			private WhereParameter _Anho_W = null;
			private WhereParameter _Chasis_W = null;
			private WhereParameter _Color_W = null;
			private WhereParameter _Matricula_W = null;
			private WhereParameter _Kilometraje_W = null;
			private WhereParameter _Activo_W = null;
			private WhereParameter _Marca_W = null;
			private WhereParameter _Modelo_W = null;
			private WhereParameter _Idequipogps_W = null;

			public void WhereClauseReset()
			{
				_Identificador_rastreo_W = null;
				_Id_usuarios_W = null;
				_Id_cliente_W = null;
				_Id_vehiculo_W = null;
				_Visible_W = null;
				_Usuario_W = null;
				_Cliente_W = null;
				_Anho_W = null;
				_Chasis_W = null;
				_Color_W = null;
				_Matricula_W = null;
				_Kilometraje_W = null;
				_Activo_W = null;
				_Marca_W = null;
				_Modelo_W = null;
				_Idequipogps_W = null;

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

			private AggregateParameter _Identificador_rastreo_W = null;
			private AggregateParameter _Id_usuarios_W = null;
			private AggregateParameter _Id_cliente_W = null;
			private AggregateParameter _Id_vehiculo_W = null;
			private AggregateParameter _Visible_W = null;
			private AggregateParameter _Usuario_W = null;
			private AggregateParameter _Cliente_W = null;
			private AggregateParameter _Anho_W = null;
			private AggregateParameter _Chasis_W = null;
			private AggregateParameter _Color_W = null;
			private AggregateParameter _Matricula_W = null;
			private AggregateParameter _Kilometraje_W = null;
			private AggregateParameter _Activo_W = null;
			private AggregateParameter _Marca_W = null;
			private AggregateParameter _Modelo_W = null;
			private AggregateParameter _Idequipogps_W = null;

			public void AggregateClauseReset()
			{
				_Identificador_rastreo_W = null;
				_Id_usuarios_W = null;
				_Id_cliente_W = null;
				_Id_vehiculo_W = null;
				_Visible_W = null;
				_Usuario_W = null;
				_Cliente_W = null;
				_Anho_W = null;
				_Chasis_W = null;
				_Color_W = null;
				_Matricula_W = null;
				_Kilometraje_W = null;
				_Activo_W = null;
				_Marca_W = null;
				_Modelo_W = null;
				_Idequipogps_W = null;

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
