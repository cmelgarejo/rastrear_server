
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreogps_tipoevento.
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
	public abstract class _rastreogps_tipoevento : PostgreSqlEntity
	{
		public _rastreogps_tipoevento()
		{
			this.QuerySource = "rastreogps_tipoevento";
			this.MappingName = "rastreogps_tipoevento";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_tipoevento_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreogps_tipo_evento)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreogps_tipo_evento, Idrastreogps_tipo_evento);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_tipoevento_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreogps_tipo_evento
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_tipo_evento", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_tipoequipo
			{
				get
				{
					return new NpgsqlParameter("Id_tipoequipo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Evento
			{
				get
				{
					return new NpgsqlParameter("Evento", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
				}
			}
			
			public static NpgsqlParameter Descripcion
			{
				get
				{
					return new NpgsqlParameter("Descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
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
			
			public static NpgsqlParameter Color
			{
				get
				{
					return new NpgsqlParameter("Color", NpgsqlTypes.NpgsqlDbType.Varchar, 16);
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
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Idrastreogps_tipo_evento = "idrastreogps_tipo_evento";
            public const string Id_tipoequipo = "id_tipoequipo";
            public const string Evento = "evento";
            public const string Descripcion = "descripcion";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";
            public const string Color = "color";
            public const string Sonoro = "sonoro";
            public const string Arch_sonido = "arch_sonido";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_tipo_evento] = _rastreogps_tipoevento.PropertyNames.Idrastreogps_tipo_evento;
					ht[Id_tipoequipo] = _rastreogps_tipoevento.PropertyNames.Id_tipoequipo;
					ht[Evento] = _rastreogps_tipoevento.PropertyNames.Evento;
					ht[Descripcion] = _rastreogps_tipoevento.PropertyNames.Descripcion;
					ht[User_ins] = _rastreogps_tipoevento.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreogps_tipoevento.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreogps_tipoevento.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreogps_tipoevento.PropertyNames.Fech_upd;
					ht[Color] = _rastreogps_tipoevento.PropertyNames.Color;
					ht[Sonoro] = _rastreogps_tipoevento.PropertyNames.Sonoro;
					ht[Arch_sonido] = _rastreogps_tipoevento.PropertyNames.Arch_sonido;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreogps_tipo_evento = "Idrastreogps_tipo_evento";
            public const string Id_tipoequipo = "Id_tipoequipo";
            public const string Evento = "Evento";
            public const string Descripcion = "Descripcion";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";
            public const string Color = "Color";
            public const string Sonoro = "Sonoro";
            public const string Arch_sonido = "Arch_sonido";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_tipo_evento] = _rastreogps_tipoevento.ColumnNames.Idrastreogps_tipo_evento;
					ht[Id_tipoequipo] = _rastreogps_tipoevento.ColumnNames.Id_tipoequipo;
					ht[Evento] = _rastreogps_tipoevento.ColumnNames.Evento;
					ht[Descripcion] = _rastreogps_tipoevento.ColumnNames.Descripcion;
					ht[User_ins] = _rastreogps_tipoevento.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreogps_tipoevento.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreogps_tipoevento.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreogps_tipoevento.ColumnNames.Fech_upd;
					ht[Color] = _rastreogps_tipoevento.ColumnNames.Color;
					ht[Sonoro] = _rastreogps_tipoevento.ColumnNames.Sonoro;
					ht[Arch_sonido] = _rastreogps_tipoevento.ColumnNames.Arch_sonido;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreogps_tipo_evento = "s_Idrastreogps_tipo_evento";
            public const string Id_tipoequipo = "s_Id_tipoequipo";
            public const string Evento = "s_Evento";
            public const string Descripcion = "s_Descripcion";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";
            public const string Color = "s_Color";
            public const string Sonoro = "s_Sonoro";
            public const string Arch_sonido = "s_Arch_sonido";

		}
		#endregion		
		
		#region Properties
	
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

		public virtual int Id_tipoequipo
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_tipoequipo);
			}
			set
	        {
				base.Setint(ColumnNames.Id_tipoequipo, value);
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


		#endregion
		
		#region String Properties
	
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

		public virtual string s_Id_tipoequipo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_tipoequipo) ? string.Empty : base.GetintAsString(ColumnNames.Id_tipoequipo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_tipoequipo);
				else
					this.Id_tipoequipo = base.SetintAsString(ColumnNames.Id_tipoequipo, value);
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
				
				
				public WhereParameter Idrastreogps_tipo_evento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_tipo_evento, Parameters.Idrastreogps_tipo_evento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_tipoequipo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_tipoequipo, Parameters.Id_tipoequipo);
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

				public WhereParameter Descripcion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Descripcion, Parameters.Descripcion);
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

				public WhereParameter Color
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Color, Parameters.Color);
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


				private WhereClause _clause;
			}
			#endregion
		
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

			public WhereParameter Id_tipoequipo
		    {
				get
		        {
					if(_Id_tipoequipo_W == null)
	        	    {
						_Id_tipoequipo_W = TearOff.Id_tipoequipo;
					}
					return _Id_tipoequipo_W;
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

			private WhereParameter _Idrastreogps_tipo_evento_W = null;
			private WhereParameter _Id_tipoequipo_W = null;
			private WhereParameter _Evento_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;
			private WhereParameter _Color_W = null;
			private WhereParameter _Sonoro_W = null;
			private WhereParameter _Arch_sonido_W = null;

			public void WhereClauseReset()
			{
				_Idrastreogps_tipo_evento_W = null;
				_Id_tipoequipo_W = null;
				_Evento_W = null;
				_Descripcion_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Color_W = null;
				_Sonoro_W = null;
				_Arch_sonido_W = null;

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
				
				
				public AggregateParameter Idrastreogps_tipo_evento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_tipo_evento, Parameters.Idrastreogps_tipo_evento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_tipoequipo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_tipoequipo, Parameters.Id_tipoequipo);
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

				public AggregateParameter Descripcion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Descripcion, Parameters.Descripcion);
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

				public AggregateParameter Color
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Color, Parameters.Color);
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


				private AggregateClause _clause;
			}
			#endregion
		
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

			public AggregateParameter Id_tipoequipo
		    {
				get
		        {
					if(_Id_tipoequipo_W == null)
	        	    {
						_Id_tipoequipo_W = TearOff.Id_tipoequipo;
					}
					return _Id_tipoequipo_W;
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

			private AggregateParameter _Idrastreogps_tipo_evento_W = null;
			private AggregateParameter _Id_tipoequipo_W = null;
			private AggregateParameter _Evento_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;
			private AggregateParameter _Color_W = null;
			private AggregateParameter _Sonoro_W = null;
			private AggregateParameter _Arch_sonido_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreogps_tipo_evento_W = null;
				_Id_tipoequipo_W = null;
				_Evento_W = null;
				_Descripcion_W = null;
				_User_ins_W = null;
				_Fech_ins_W = null;
				_User_upd_W = null;
				_Fech_upd_W = null;
				_Color_W = null;
				_Sonoro_W = null;
				_Arch_sonido_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_tipoevento_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreogps_tipo_evento.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_tipoevento_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_tipoevento_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreogps_tipo_evento);
			p.SourceColumn = ColumnNames.Idrastreogps_tipo_evento;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreogps_tipo_evento);
			p.SourceColumn = ColumnNames.Idrastreogps_tipo_evento;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_tipoequipo);
			p.SourceColumn = ColumnNames.Id_tipoequipo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Evento);
			p.SourceColumn = ColumnNames.Evento;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Descripcion);
			p.SourceColumn = ColumnNames.Descripcion;
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

			p = cmd.Parameters.Add(Parameters.Color);
			p.SourceColumn = ColumnNames.Color;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Sonoro);
			p.SourceColumn = ColumnNames.Sonoro;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Arch_sonido);
			p.SourceColumn = ColumnNames.Arch_sonido;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
