
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_empleados.
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
	public abstract class _rastreo_empleados : PostgreSqlEntity
	{
		public _rastreo_empleados()
		{
			this.QuerySource = "rastreo_empleados";
			this.MappingName = "rastreo_empleados";

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

			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_empleados_load_all", parameters);
		}

		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Id_empleado)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Id_empleado, Id_empleado);


			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_empleados_load_by_primarykey", parameters);
		}

		#region Parameters
		protected class Parameters
		{

			public static NpgsqlParameter Id_empleado
			{
				get
				{
					return new NpgsqlParameter("Id_empleado", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}

			public static NpgsqlParameter Instalador
			{
				get
				{
					return new NpgsqlParameter("Instalador", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}

			public static NpgsqlParameter Acceso_sistema
			{
				get
				{
					return new NpgsqlParameter("Acceso_sistema", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}

			public static NpgsqlParameter Estado_empleado
			{
				get
				{
					return new NpgsqlParameter("Estado_empleado", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}

			public static NpgsqlParameter Estado_fecha
			{
				get
				{
					return new NpgsqlParameter("Estado_fecha", NpgsqlTypes.NpgsqlDbType.Timestamp, 0);
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
			public static NpgsqlParameter Vendedor
			{
				get
				{
					return new NpgsqlParameter("Vendedor", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}

		}

		#endregion

		#region ColumnNames
		public class ColumnNames
		{
			public const string Id_empleado = "id_empleado";
			public const string Instalador = "instalador";
			public const string Acceso_sistema = "acceso_sistema";
			public const string Estado_empleado = "estado_empleado";
			public const string Estado_fecha = "estado_fecha";
			public const string User_ins = "user_ins";
			public const string Fech_ins = "fech_ins";
			public const string User_upd = "user_upd";
			public const string Fech_upd = "fech_upd";
			public const string Vendedor = "vendedor";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();

					ht[Id_empleado] = _rastreo_empleados.PropertyNames.Id_empleado;
					ht[Instalador] = _rastreo_empleados.PropertyNames.Instalador;
					ht[Acceso_sistema] = _rastreo_empleados.PropertyNames.Acceso_sistema;
					ht[Estado_empleado] = _rastreo_empleados.PropertyNames.Estado_empleado;
					ht[Estado_fecha] = _rastreo_empleados.PropertyNames.Estado_fecha;
					ht[User_ins] = _rastreo_empleados.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_empleados.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_empleados.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_empleados.PropertyNames.Fech_upd;
					ht[Vendedor] = _rastreo_empleados.PropertyNames.Vendedor;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string Id_empleado = "Id_empleado";
			public const string Instalador = "Instalador";
			public const string Acceso_sistema = "Acceso_sistema";
			public const string Estado_empleado = "Estado_empleado";
			public const string Estado_fecha = "Estado_fecha";
			public const string User_ins = "User_ins";
			public const string Fech_ins = "Fech_ins";
			public const string User_upd = "User_upd";
			public const string Fech_upd = "Fech_upd";
			public const string Vendedor = "vendedor";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();

					ht[Id_empleado] = _rastreo_empleados.ColumnNames.Id_empleado;
					ht[Instalador] = _rastreo_empleados.ColumnNames.Instalador;
					ht[Acceso_sistema] = _rastreo_empleados.ColumnNames.Acceso_sistema;
					ht[Estado_empleado] = _rastreo_empleados.ColumnNames.Estado_empleado;
					ht[Estado_fecha] = _rastreo_empleados.ColumnNames.Estado_fecha;
					ht[User_ins] = _rastreo_empleados.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_empleados.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_empleados.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_empleados.ColumnNames.Fech_upd;
					ht[Vendedor] = _rastreo_empleados.ColumnNames.Vendedor;
				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;
		}
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{
			public const string Id_empleado = "s_Id_empleado";
			public const string Instalador = "s_Instalador";
			public const string Acceso_sistema = "s_Acceso_sistema";
			public const string Estado_empleado = "s_Estado_empleado";
			public const string Estado_fecha = "s_Estado_fecha";
			public const string User_ins = "s_User_ins";
			public const string Fech_ins = "s_Fech_ins";
			public const string User_upd = "s_User_upd";
			public const string Fech_upd = "s_Fech_upd";
			public const string Vendedor = "s_Vendedor";
		}
		#endregion

		#region Properties

		public virtual int Id_empleado
		{
			get
			{
				return base.Getint(ColumnNames.Id_empleado);
			}
			set
			{
				base.Setint(ColumnNames.Id_empleado, value);
			}
		}

		public virtual bool Instalador
		{
			get
			{
				return base.Getbool(ColumnNames.Instalador);
			}
			set
			{
				base.Setbool(ColumnNames.Instalador, value);
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

		public virtual bool Estado_empleado
		{
			get
			{
				return base.Getbool(ColumnNames.Estado_empleado);
			}
			set
			{
				base.Setbool(ColumnNames.Estado_empleado, value);
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
		public virtual bool Vendedor
		{
			get
			{
				return base.Getbool(ColumnNames.Vendedor);
			}
			set
			{
				base.Setbool(ColumnNames.Vendedor, value);
			}
		}

		#endregion

		#region String Properties

		public virtual string s_Id_empleado
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Id_empleado) ? string.Empty : base.GetintAsString(ColumnNames.Id_empleado);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_empleado);
				else
					this.Id_empleado = base.SetintAsString(ColumnNames.Id_empleado, value);
			}
		}

		public virtual string s_Instalador
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Instalador) ? string.Empty : base.GetboolAsString(ColumnNames.Instalador);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Instalador);
				else
					this.Instalador = base.SetboolAsString(ColumnNames.Instalador, value);
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

		public virtual string s_Estado_empleado
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Estado_empleado) ? string.Empty : base.GetboolAsString(ColumnNames.Estado_empleado);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Estado_empleado);
				else
					this.Estado_empleado = base.SetboolAsString(ColumnNames.Estado_empleado, value);
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
		public virtual string s_Vendedor
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Vendedor) ? string.Empty : base.GetboolAsString(ColumnNames.Vendedor);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Vendedor);
				else
					this.Vendedor = base.SetboolAsString(ColumnNames.Vendedor, value);
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


				public WhereParameter Id_empleado
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Id_empleado, Parameters.Id_empleado);
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

				public WhereParameter Acceso_sistema
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Acceso_sistema, Parameters.Acceso_sistema);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Estado_empleado
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Estado_empleado, Parameters.Estado_empleado);
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
				public WhereParameter Vendedor
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Vendedor, Parameters.Vendedor);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				private WhereClause _clause;
			}
			#endregion

			public WhereParameter Id_empleado
			{
				get
				{
					if(_Id_empleado_W == null)
					{
						_Id_empleado_W = TearOff.Id_empleado;
					}
					return _Id_empleado_W;
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

			public WhereParameter Estado_empleado
			{
				get
				{
					if(_Estado_empleado_W == null)
					{
						_Estado_empleado_W = TearOff.Estado_empleado;
					}
					return _Estado_empleado_W;
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

			public WhereParameter Vendedor
			{
				get
				{
					if(_Vendedor_W == null)
					{
						_Vendedor_W = TearOff.Vendedor;
					}
					return _Vendedor_W;
				}
			}

			private WhereParameter _Id_empleado_W = null;
			private WhereParameter _Instalador_W = null;
			private WhereParameter _Acceso_sistema_W = null;
			private WhereParameter _Estado_empleado_W = null;
			private WhereParameter _Estado_fecha_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;
			private WhereParameter _Vendedor_W = null;


			public void WhereClauseReset()
			{
				_Id_empleado_W = null;
				_Instalador_W = null;
				_Acceso_sistema_W = null;
				_Estado_empleado_W = null;
				_Estado_fecha_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Vendedor_W = null;


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


				public AggregateParameter Id_empleado
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_empleado, Parameters.Id_empleado);
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

				public AggregateParameter Acceso_sistema
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Acceso_sistema, Parameters.Acceso_sistema);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Estado_empleado
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Estado_empleado, Parameters.Estado_empleado);
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
				public AggregateParameter Vendedor
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Vendedor, Parameters.Vendedor);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}



				private AggregateClause _clause;
			}
			#endregion

			public AggregateParameter Id_empleado
			{
				get
				{
					if(_Id_empleado_W == null)
					{
						_Id_empleado_W = TearOff.Id_empleado;
					}
					return _Id_empleado_W;
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

			public AggregateParameter Estado_empleado
			{
				get
				{
					if(_Estado_empleado_W == null)
					{
						_Estado_empleado_W = TearOff.Estado_empleado;
					}
					return _Estado_empleado_W;
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
			public AggregateParameter Vendedor
			{
				get
				{
					if(_Vendedor_W == null)
					{
						_Vendedor_W = TearOff.Vendedor;
					}
					return _Vendedor_W;
				}
			}

			private AggregateParameter _Id_empleado_W = null;
			private AggregateParameter _Instalador_W = null;
			private AggregateParameter _Acceso_sistema_W = null;
			private AggregateParameter _Estado_empleado_W = null;
			private AggregateParameter _Estado_fecha_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;
			private AggregateParameter _Vendedor_W = null;
			public void AggregateClauseReset()
			{
				_Id_empleado_W = null;
				_Instalador_W = null;
				_Acceso_sistema_W = null;
				_Estado_empleado_W = null;
				_Estado_fecha_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_empleados_insert";

			CreateParameters(cmd);

			return cmd;
		}

		protected override IDbCommand GetUpdateCommand()
		{

			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_empleados_update";

			CreateParameters(cmd);

			return cmd;
		}

		protected override IDbCommand GetDeleteCommand()
		{

			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_empleados_delete";

			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Id_empleado);
			p.SourceColumn = ColumnNames.Id_empleado;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}

		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;

			p = cmd.Parameters.Add(Parameters.Id_empleado);
			p.SourceColumn = ColumnNames.Id_empleado;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Instalador);
			p.SourceColumn = ColumnNames.Instalador;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Acceso_sistema);
			p.SourceColumn = ColumnNames.Acceso_sistema;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Estado_empleado);
			p.SourceColumn = ColumnNames.Estado_empleado;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Estado_fecha);
			p.SourceColumn = ColumnNames.Estado_fecha;
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

			p = cmd.Parameters.Add(Parameters.Vendedor);
			p.SourceColumn = ColumnNames.Vendedor;
			p.SourceVersion = DataRowVersion.Current;

			return cmd;
		}
	}
}
