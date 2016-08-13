
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreogps_equipogps.
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
	public abstract class _rastreogps_equipogps : PostgreSqlEntity
	{
		public _rastreogps_equipogps()
		{
			this.QuerySource = "rastreogps_equipogps";
			this.MappingName = "rastreogps_equipogps";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_equipogps_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreogps_equipogps)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreogps_equipogps, Idrastreogps_equipogps);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_equipogps_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreogps_equipogps
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
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
            public const string Idrastreogps_equipogps = "idrastreogps_equipogps";
            public const string Id_simcard = "id_simcard";
            public const string Tipoequipo = "tipoequipo";
            public const string Id_equipo_gps = "id_equipo_gps";
            public const string Nro_serie_gps = "nro_serie_gps";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_equipogps] = _rastreogps_equipogps.PropertyNames.Idrastreogps_equipogps;
					ht[Id_simcard] = _rastreogps_equipogps.PropertyNames.Id_simcard;
					ht[Tipoequipo] = _rastreogps_equipogps.PropertyNames.Tipoequipo;
					ht[Id_equipo_gps] = _rastreogps_equipogps.PropertyNames.Id_equipo_gps;
					ht[Nro_serie_gps] = _rastreogps_equipogps.PropertyNames.Nro_serie_gps;
					ht[User_ins] = _rastreogps_equipogps.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreogps_equipogps.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreogps_equipogps.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreogps_equipogps.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreogps_equipogps = "Idrastreogps_equipogps";
            public const string Id_simcard = "Id_simcard";
            public const string Tipoequipo = "Tipoequipo";
            public const string Id_equipo_gps = "Id_equipo_gps";
            public const string Nro_serie_gps = "Nro_serie_gps";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_equipogps] = _rastreogps_equipogps.ColumnNames.Idrastreogps_equipogps;
					ht[Id_simcard] = _rastreogps_equipogps.ColumnNames.Id_simcard;
					ht[Tipoequipo] = _rastreogps_equipogps.ColumnNames.Tipoequipo;
					ht[Id_equipo_gps] = _rastreogps_equipogps.ColumnNames.Id_equipo_gps;
					ht[Nro_serie_gps] = _rastreogps_equipogps.ColumnNames.Nro_serie_gps;
					ht[User_ins] = _rastreogps_equipogps.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreogps_equipogps.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreogps_equipogps.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreogps_equipogps.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreogps_equipogps = "s_Idrastreogps_equipogps";
            public const string Id_simcard = "s_Id_simcard";
            public const string Tipoequipo = "s_Tipoequipo";
            public const string Id_equipo_gps = "s_Id_equipo_gps";
            public const string Nro_serie_gps = "s_Nro_serie_gps";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
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
				
				
				public WhereParameter Idrastreogps_equipogps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_equipogps, Parameters.Idrastreogps_equipogps);
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

			private WhereParameter _Idrastreogps_equipogps_W = null;
			private WhereParameter _Id_simcard_W = null;
			private WhereParameter _Tipoequipo_W = null;
			private WhereParameter _Id_equipo_gps_W = null;
			private WhereParameter _Nro_serie_gps_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idrastreogps_equipogps_W = null;
				_Id_simcard_W = null;
				_Tipoequipo_W = null;
				_Id_equipo_gps_W = null;
				_Nro_serie_gps_W = null;
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
				
				
				public AggregateParameter Idrastreogps_equipogps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_equipogps, Parameters.Idrastreogps_equipogps);
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

			private AggregateParameter _Idrastreogps_equipogps_W = null;
			private AggregateParameter _Id_simcard_W = null;
			private AggregateParameter _Tipoequipo_W = null;
			private AggregateParameter _Id_equipo_gps_W = null;
			private AggregateParameter _Nro_serie_gps_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreogps_equipogps_W = null;
				_Id_simcard_W = null;
				_Tipoequipo_W = null;
				_Id_equipo_gps_W = null;
				_Nro_serie_gps_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_equipogps_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreogps_equipogps.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_equipogps_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_equipogps_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreogps_equipogps);
			p.SourceColumn = ColumnNames.Idrastreogps_equipogps;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreogps_equipogps);
			p.SourceColumn = ColumnNames.Idrastreogps_equipogps;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_simcard);
			p.SourceColumn = ColumnNames.Id_simcard;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Tipoequipo);
			p.SourceColumn = ColumnNames.Tipoequipo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_equipo_gps);
			p.SourceColumn = ColumnNames.Id_equipo_gps;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nro_serie_gps);
			p.SourceColumn = ColumnNames.Nro_serie_gps;
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
