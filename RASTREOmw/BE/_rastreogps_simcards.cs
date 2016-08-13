
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreogps_simcards.
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
	public abstract class _rastreogps_simcards : PostgreSqlEntity
	{
		public _rastreogps_simcards()
		{
			this.QuerySource = "rastreogps_simcards";
			this.MappingName = "rastreogps_simcards";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_simcards_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreogps_simcards)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreogps_simcards, Idrastreogps_simcards);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_simcards_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreogps_simcards
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_simcards", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Sim_nro
			{
				get
				{
					return new NpgsqlParameter("Sim_nro", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Sim_pin
			{
				get
				{
					return new NpgsqlParameter("Sim_pin", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Sim_pin2
			{
				get
				{
					return new NpgsqlParameter("Sim_pin2", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Sim_puk
			{
				get
				{
					return new NpgsqlParameter("Sim_puk", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Sim_puk2
			{
				get
				{
					return new NpgsqlParameter("Sim_puk2", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
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
            public const string Idrastreogps_simcards = "idrastreogps_simcards";
            public const string Sim_nro = "sim_nro";
            public const string Sim_pin = "sim_pin";
            public const string Sim_pin2 = "sim_pin2";
            public const string Sim_puk = "sim_puk";
            public const string Sim_puk2 = "sim_puk2";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_simcards] = _rastreogps_simcards.PropertyNames.Idrastreogps_simcards;
					ht[Sim_nro] = _rastreogps_simcards.PropertyNames.Sim_nro;
					ht[Sim_pin] = _rastreogps_simcards.PropertyNames.Sim_pin;
					ht[Sim_pin2] = _rastreogps_simcards.PropertyNames.Sim_pin2;
					ht[Sim_puk] = _rastreogps_simcards.PropertyNames.Sim_puk;
					ht[Sim_puk2] = _rastreogps_simcards.PropertyNames.Sim_puk2;
					ht[User_ins] = _rastreogps_simcards.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreogps_simcards.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreogps_simcards.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreogps_simcards.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreogps_simcards = "Idrastreogps_simcards";
            public const string Sim_nro = "Sim_nro";
            public const string Sim_pin = "Sim_pin";
            public const string Sim_pin2 = "Sim_pin2";
            public const string Sim_puk = "Sim_puk";
            public const string Sim_puk2 = "Sim_puk2";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_simcards] = _rastreogps_simcards.ColumnNames.Idrastreogps_simcards;
					ht[Sim_nro] = _rastreogps_simcards.ColumnNames.Sim_nro;
					ht[Sim_pin] = _rastreogps_simcards.ColumnNames.Sim_pin;
					ht[Sim_pin2] = _rastreogps_simcards.ColumnNames.Sim_pin2;
					ht[Sim_puk] = _rastreogps_simcards.ColumnNames.Sim_puk;
					ht[Sim_puk2] = _rastreogps_simcards.ColumnNames.Sim_puk2;
					ht[User_ins] = _rastreogps_simcards.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreogps_simcards.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreogps_simcards.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreogps_simcards.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreogps_simcards = "s_Idrastreogps_simcards";
            public const string Sim_nro = "s_Sim_nro";
            public const string Sim_pin = "s_Sim_pin";
            public const string Sim_pin2 = "s_Sim_pin2";
            public const string Sim_puk = "s_Sim_puk";
            public const string Sim_puk2 = "s_Sim_puk2";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreogps_simcards
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_simcards);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_simcards, value);
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

		public virtual string Sim_pin
	    {
			get
	        {
				return base.Getstring(ColumnNames.Sim_pin);
			}
			set
	        {
				base.Setstring(ColumnNames.Sim_pin, value);
			}
		}

		public virtual string Sim_pin2
	    {
			get
	        {
				return base.Getstring(ColumnNames.Sim_pin2);
			}
			set
	        {
				base.Setstring(ColumnNames.Sim_pin2, value);
			}
		}

		public virtual string Sim_puk
	    {
			get
	        {
				return base.Getstring(ColumnNames.Sim_puk);
			}
			set
	        {
				base.Setstring(ColumnNames.Sim_puk, value);
			}
		}

		public virtual string Sim_puk2
	    {
			get
	        {
				return base.Getstring(ColumnNames.Sim_puk2);
			}
			set
	        {
				base.Setstring(ColumnNames.Sim_puk2, value);
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
	
		public virtual string s_Idrastreogps_simcards
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_simcards) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_simcards);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_simcards);
				else
					this.Idrastreogps_simcards = base.SetintAsString(ColumnNames.Idrastreogps_simcards, value);
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

		public virtual string s_Sim_pin
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sim_pin) ? string.Empty : base.GetstringAsString(ColumnNames.Sim_pin);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sim_pin);
				else
					this.Sim_pin = base.SetstringAsString(ColumnNames.Sim_pin, value);
			}
		}

		public virtual string s_Sim_pin2
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sim_pin2) ? string.Empty : base.GetstringAsString(ColumnNames.Sim_pin2);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sim_pin2);
				else
					this.Sim_pin2 = base.SetstringAsString(ColumnNames.Sim_pin2, value);
			}
		}

		public virtual string s_Sim_puk
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sim_puk) ? string.Empty : base.GetstringAsString(ColumnNames.Sim_puk);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sim_puk);
				else
					this.Sim_puk = base.SetstringAsString(ColumnNames.Sim_puk, value);
			}
		}

		public virtual string s_Sim_puk2
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sim_puk2) ? string.Empty : base.GetstringAsString(ColumnNames.Sim_puk2);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sim_puk2);
				else
					this.Sim_puk2 = base.SetstringAsString(ColumnNames.Sim_puk2, value);
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
				
				
				public WhereParameter Idrastreogps_simcards
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_simcards, Parameters.Idrastreogps_simcards);
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

				public WhereParameter Sim_pin
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sim_pin, Parameters.Sim_pin);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sim_pin2
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sim_pin2, Parameters.Sim_pin2);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sim_puk
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sim_puk, Parameters.Sim_puk);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sim_puk2
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sim_puk2, Parameters.Sim_puk2);
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
		
			public WhereParameter Idrastreogps_simcards
		    {
				get
		        {
					if(_Idrastreogps_simcards_W == null)
	        	    {
						_Idrastreogps_simcards_W = TearOff.Idrastreogps_simcards;
					}
					return _Idrastreogps_simcards_W;
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

			public WhereParameter Sim_pin
		    {
				get
		        {
					if(_Sim_pin_W == null)
	        	    {
						_Sim_pin_W = TearOff.Sim_pin;
					}
					return _Sim_pin_W;
				}
			}

			public WhereParameter Sim_pin2
		    {
				get
		        {
					if(_Sim_pin2_W == null)
	        	    {
						_Sim_pin2_W = TearOff.Sim_pin2;
					}
					return _Sim_pin2_W;
				}
			}

			public WhereParameter Sim_puk
		    {
				get
		        {
					if(_Sim_puk_W == null)
	        	    {
						_Sim_puk_W = TearOff.Sim_puk;
					}
					return _Sim_puk_W;
				}
			}

			public WhereParameter Sim_puk2
		    {
				get
		        {
					if(_Sim_puk2_W == null)
	        	    {
						_Sim_puk2_W = TearOff.Sim_puk2;
					}
					return _Sim_puk2_W;
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

			private WhereParameter _Idrastreogps_simcards_W = null;
			private WhereParameter _Sim_nro_W = null;
			private WhereParameter _Sim_pin_W = null;
			private WhereParameter _Sim_pin2_W = null;
			private WhereParameter _Sim_puk_W = null;
			private WhereParameter _Sim_puk2_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idrastreogps_simcards_W = null;
				_Sim_nro_W = null;
				_Sim_pin_W = null;
				_Sim_pin2_W = null;
				_Sim_puk_W = null;
				_Sim_puk2_W = null;
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
				
				
				public AggregateParameter Idrastreogps_simcards
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_simcards, Parameters.Idrastreogps_simcards);
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

				public AggregateParameter Sim_pin
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sim_pin, Parameters.Sim_pin);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sim_pin2
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sim_pin2, Parameters.Sim_pin2);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sim_puk
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sim_puk, Parameters.Sim_puk);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sim_puk2
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sim_puk2, Parameters.Sim_puk2);
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
		
			public AggregateParameter Idrastreogps_simcards
		    {
				get
		        {
					if(_Idrastreogps_simcards_W == null)
	        	    {
						_Idrastreogps_simcards_W = TearOff.Idrastreogps_simcards;
					}
					return _Idrastreogps_simcards_W;
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

			public AggregateParameter Sim_pin
		    {
				get
		        {
					if(_Sim_pin_W == null)
	        	    {
						_Sim_pin_W = TearOff.Sim_pin;
					}
					return _Sim_pin_W;
				}
			}

			public AggregateParameter Sim_pin2
		    {
				get
		        {
					if(_Sim_pin2_W == null)
	        	    {
						_Sim_pin2_W = TearOff.Sim_pin2;
					}
					return _Sim_pin2_W;
				}
			}

			public AggregateParameter Sim_puk
		    {
				get
		        {
					if(_Sim_puk_W == null)
	        	    {
						_Sim_puk_W = TearOff.Sim_puk;
					}
					return _Sim_puk_W;
				}
			}

			public AggregateParameter Sim_puk2
		    {
				get
		        {
					if(_Sim_puk2_W == null)
	        	    {
						_Sim_puk2_W = TearOff.Sim_puk2;
					}
					return _Sim_puk2_W;
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

			private AggregateParameter _Idrastreogps_simcards_W = null;
			private AggregateParameter _Sim_nro_W = null;
			private AggregateParameter _Sim_pin_W = null;
			private AggregateParameter _Sim_pin2_W = null;
			private AggregateParameter _Sim_puk_W = null;
			private AggregateParameter _Sim_puk2_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreogps_simcards_W = null;
				_Sim_nro_W = null;
				_Sim_pin_W = null;
				_Sim_pin2_W = null;
				_Sim_puk_W = null;
				_Sim_puk2_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_simcards_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreogps_simcards.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_simcards_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_simcards_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreogps_simcards);
			p.SourceColumn = ColumnNames.Idrastreogps_simcards;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreogps_simcards);
			p.SourceColumn = ColumnNames.Idrastreogps_simcards;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Sim_nro);
			p.SourceColumn = ColumnNames.Sim_nro;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Sim_pin);
			p.SourceColumn = ColumnNames.Sim_pin;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Sim_pin2);
			p.SourceColumn = ColumnNames.Sim_pin2;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Sim_puk);
			p.SourceColumn = ColumnNames.Sim_puk;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Sim_puk2);
			p.SourceColumn = ColumnNames.Sim_puk2;
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
