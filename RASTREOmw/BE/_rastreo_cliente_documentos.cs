
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_cliente_documentos.
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
	public abstract class _rastreo_cliente_documentos : PostgreSqlEntity
	{
		public _rastreo_cliente_documentos()
		{
			this.QuerySource = "rastreo_cliente_documentos";
			this.MappingName = "rastreo_cliente_documentos";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_cliente_documentos_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreo_cliente_documentos)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreo_cliente_documentos, Idrastreo_cliente_documentos);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_cliente_documentos_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreo_cliente_documentos
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_cliente_documentos", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Idcliente
			{
				get
				{
					return new NpgsqlParameter("Idcliente", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Descripcion
			{
				get
				{
					return new NpgsqlParameter("Descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Tipo_archivo
			{
				get
				{
					return new NpgsqlParameter("Tipo_archivo", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Nombre_archivo
			{
				get
				{
					return new NpgsqlParameter("Nombre_archivo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Documento
			{
				get
				{
					return new NpgsqlParameter("Documento", NpgsqlTypes.NpgsqlDbType.Bytea, 0);
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
            public const string Idrastreo_cliente_documentos = "idrastreo_cliente_documentos";
            public const string Idcliente = "idcliente";
            public const string Descripcion = "descripcion";
            public const string Tipo_archivo = "tipo_archivo";
            public const string Nombre_archivo = "nombre_archivo";
            public const string Documento = "documento";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_cliente_documentos] = _rastreo_cliente_documentos.PropertyNames.Idrastreo_cliente_documentos;
					ht[Idcliente] = _rastreo_cliente_documentos.PropertyNames.Idcliente;
					ht[Descripcion] = _rastreo_cliente_documentos.PropertyNames.Descripcion;
					ht[Tipo_archivo] = _rastreo_cliente_documentos.PropertyNames.Tipo_archivo;
					ht[Nombre_archivo] = _rastreo_cliente_documentos.PropertyNames.Nombre_archivo;
					ht[Documento] = _rastreo_cliente_documentos.PropertyNames.Documento;
					ht[User_ins] = _rastreo_cliente_documentos.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreo_cliente_documentos.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreo_cliente_documentos.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreo_cliente_documentos.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreo_cliente_documentos = "Idrastreo_cliente_documentos";
            public const string Idcliente = "Idcliente";
            public const string Descripcion = "Descripcion";
            public const string Tipo_archivo = "Tipo_archivo";
            public const string Nombre_archivo = "Nombre_archivo";
            public const string Documento = "Documento";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreo_cliente_documentos] = _rastreo_cliente_documentos.ColumnNames.Idrastreo_cliente_documentos;
					ht[Idcliente] = _rastreo_cliente_documentos.ColumnNames.Idcliente;
					ht[Descripcion] = _rastreo_cliente_documentos.ColumnNames.Descripcion;
					ht[Tipo_archivo] = _rastreo_cliente_documentos.ColumnNames.Tipo_archivo;
					ht[Nombre_archivo] = _rastreo_cliente_documentos.ColumnNames.Nombre_archivo;
					ht[Documento] = _rastreo_cliente_documentos.ColumnNames.Documento;
					ht[User_ins] = _rastreo_cliente_documentos.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreo_cliente_documentos.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreo_cliente_documentos.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreo_cliente_documentos.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreo_cliente_documentos = "s_Idrastreo_cliente_documentos";
            public const string Idcliente = "s_Idcliente";
            public const string Descripcion = "s_Descripcion";
            public const string Tipo_archivo = "s_Tipo_archivo";
            public const string Nombre_archivo = "s_Nombre_archivo";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreo_cliente_documentos
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_cliente_documentos);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_cliente_documentos, value);
			}
		}

		public virtual int Idcliente
	    {
			get
	        {
				return base.Getint(ColumnNames.Idcliente);
			}
			set
	        {
				base.Setint(ColumnNames.Idcliente, value);
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

		public virtual string Tipo_archivo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tipo_archivo);
			}
			set
	        {
				base.Setstring(ColumnNames.Tipo_archivo, value);
			}
		}

		public virtual string Nombre_archivo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Nombre_archivo);
			}
			set
	        {
				base.Setstring(ColumnNames.Nombre_archivo, value);
			}
		}

		public virtual byte[] Documento
	    {
			get
	        {
				return base.GetByteArray(ColumnNames.Documento);
			}
			set
	        {
				base.SetByteArray(ColumnNames.Documento, value);
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
	
		public virtual string s_Idrastreo_cliente_documentos
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_cliente_documentos) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_cliente_documentos);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_cliente_documentos);
				else
					this.Idrastreo_cliente_documentos = base.SetintAsString(ColumnNames.Idrastreo_cliente_documentos, value);
			}
		}

		public virtual string s_Idcliente
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idcliente) ? string.Empty : base.GetintAsString(ColumnNames.Idcliente);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idcliente);
				else
					this.Idcliente = base.SetintAsString(ColumnNames.Idcliente, value);
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

		public virtual string s_Tipo_archivo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipo_archivo) ? string.Empty : base.GetstringAsString(ColumnNames.Tipo_archivo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipo_archivo);
				else
					this.Tipo_archivo = base.SetstringAsString(ColumnNames.Tipo_archivo, value);
			}
		}

		public virtual string s_Nombre_archivo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Nombre_archivo) ? string.Empty : base.GetstringAsString(ColumnNames.Nombre_archivo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nombre_archivo);
				else
					this.Nombre_archivo = base.SetstringAsString(ColumnNames.Nombre_archivo, value);
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
				
				
				public WhereParameter Idrastreo_cliente_documentos
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_cliente_documentos, Parameters.Idrastreo_cliente_documentos);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Idcliente
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idcliente, Parameters.Idcliente);
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

				public WhereParameter Tipo_archivo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipo_archivo, Parameters.Tipo_archivo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Nombre_archivo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nombre_archivo, Parameters.Nombre_archivo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Documento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Documento, Parameters.Documento);
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
		
			public WhereParameter Idrastreo_cliente_documentos
		    {
				get
		        {
					if(_Idrastreo_cliente_documentos_W == null)
	        	    {
						_Idrastreo_cliente_documentos_W = TearOff.Idrastreo_cliente_documentos;
					}
					return _Idrastreo_cliente_documentos_W;
				}
			}

			public WhereParameter Idcliente
		    {
				get
		        {
					if(_Idcliente_W == null)
	        	    {
						_Idcliente_W = TearOff.Idcliente;
					}
					return _Idcliente_W;
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

			public WhereParameter Tipo_archivo
		    {
				get
		        {
					if(_Tipo_archivo_W == null)
	        	    {
						_Tipo_archivo_W = TearOff.Tipo_archivo;
					}
					return _Tipo_archivo_W;
				}
			}

			public WhereParameter Nombre_archivo
		    {
				get
		        {
					if(_Nombre_archivo_W == null)
	        	    {
						_Nombre_archivo_W = TearOff.Nombre_archivo;
					}
					return _Nombre_archivo_W;
				}
			}

			public WhereParameter Documento
		    {
				get
		        {
					if(_Documento_W == null)
	        	    {
						_Documento_W = TearOff.Documento;
					}
					return _Documento_W;
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

			private WhereParameter _Idrastreo_cliente_documentos_W = null;
			private WhereParameter _Idcliente_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _Tipo_archivo_W = null;
			private WhereParameter _Nombre_archivo_W = null;
			private WhereParameter _Documento_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idrastreo_cliente_documentos_W = null;
				_Idcliente_W = null;
				_Descripcion_W = null;
				_Tipo_archivo_W = null;
				_Nombre_archivo_W = null;
				_Documento_W = null;
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
				
				
				public AggregateParameter Idrastreo_cliente_documentos
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_cliente_documentos, Parameters.Idrastreo_cliente_documentos);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Idcliente
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idcliente, Parameters.Idcliente);
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

				public AggregateParameter Tipo_archivo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_archivo, Parameters.Tipo_archivo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Nombre_archivo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nombre_archivo, Parameters.Nombre_archivo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Documento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Documento, Parameters.Documento);
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
		
			public AggregateParameter Idrastreo_cliente_documentos
		    {
				get
		        {
					if(_Idrastreo_cliente_documentos_W == null)
	        	    {
						_Idrastreo_cliente_documentos_W = TearOff.Idrastreo_cliente_documentos;
					}
					return _Idrastreo_cliente_documentos_W;
				}
			}

			public AggregateParameter Idcliente
		    {
				get
		        {
					if(_Idcliente_W == null)
	        	    {
						_Idcliente_W = TearOff.Idcliente;
					}
					return _Idcliente_W;
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

			public AggregateParameter Tipo_archivo
		    {
				get
		        {
					if(_Tipo_archivo_W == null)
	        	    {
						_Tipo_archivo_W = TearOff.Tipo_archivo;
					}
					return _Tipo_archivo_W;
				}
			}

			public AggregateParameter Nombre_archivo
		    {
				get
		        {
					if(_Nombre_archivo_W == null)
	        	    {
						_Nombre_archivo_W = TearOff.Nombre_archivo;
					}
					return _Nombre_archivo_W;
				}
			}

			public AggregateParameter Documento
		    {
				get
		        {
					if(_Documento_W == null)
	        	    {
						_Documento_W = TearOff.Documento;
					}
					return _Documento_W;
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

			private AggregateParameter _Idrastreo_cliente_documentos_W = null;
			private AggregateParameter _Idcliente_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _Tipo_archivo_W = null;
			private AggregateParameter _Nombre_archivo_W = null;
			private AggregateParameter _Documento_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreo_cliente_documentos_W = null;
				_Idcliente_W = null;
				_Descripcion_W = null;
				_Tipo_archivo_W = null;
				_Nombre_archivo_W = null;
				_Documento_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_cliente_documentos_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreo_cliente_documentos.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_cliente_documentos_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_cliente_documentos_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreo_cliente_documentos);
			p.SourceColumn = ColumnNames.Idrastreo_cliente_documentos;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreo_cliente_documentos);
			p.SourceColumn = ColumnNames.Idrastreo_cliente_documentos;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Idcliente);
			p.SourceColumn = ColumnNames.Idcliente;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Descripcion);
			p.SourceColumn = ColumnNames.Descripcion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Tipo_archivo);
			p.SourceColumn = ColumnNames.Tipo_archivo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nombre_archivo);
			p.SourceColumn = ColumnNames.Nombre_archivo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Documento);
			p.SourceColumn = ColumnNames.Documento;
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
