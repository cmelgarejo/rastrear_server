
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreogps_tipoequipo.
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
	public abstract class _rastreogps_tipoequipo : PostgreSqlEntity
	{
		public _rastreogps_tipoequipo()
		{
			this.QuerySource = "rastreogps_tipoequipo";
			this.MappingName = "rastreogps_tipoequipo";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_tipoequipo_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Idrastreogps_tipoequipo)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastreogps_tipoequipo, Idrastreogps_tipoequipo);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreogps_tipoequipo_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastreogps_tipoequipo
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_tipoequipo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Tipo_equipo
			{
				get
				{
					return new NpgsqlParameter("Tipo_equipo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Tipo_de_reporte
			{
				get
				{
					return new NpgsqlParameter("Tipo_de_reporte", NpgsqlTypes.NpgsqlDbType.Varchar, 64);
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
            public const string Idrastreogps_tipoequipo = "idrastreogps_tipoequipo";
            public const string Tipo_equipo = "tipo_equipo";
            public const string Tipo_de_reporte = "tipo_de_reporte";
            public const string User_ins = "user_ins";
            public const string Fech_ins = "fech_ins";
            public const string User_upd = "user_upd";
            public const string Fech_upd = "fech_upd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_tipoequipo] = _rastreogps_tipoequipo.PropertyNames.Idrastreogps_tipoequipo;
					ht[Tipo_equipo] = _rastreogps_tipoequipo.PropertyNames.Tipo_equipo;
					ht[Tipo_de_reporte] = _rastreogps_tipoequipo.PropertyNames.Tipo_de_reporte;
					ht[User_ins] = _rastreogps_tipoequipo.PropertyNames.User_ins;
					ht[Fech_ins] = _rastreogps_tipoequipo.PropertyNames.Fech_ins;
					ht[User_upd] = _rastreogps_tipoequipo.PropertyNames.User_upd;
					ht[Fech_upd] = _rastreogps_tipoequipo.PropertyNames.Fech_upd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastreogps_tipoequipo = "Idrastreogps_tipoequipo";
            public const string Tipo_equipo = "Tipo_equipo";
            public const string Tipo_de_reporte = "Tipo_de_reporte";
            public const string User_ins = "User_ins";
            public const string Fech_ins = "Fech_ins";
            public const string User_upd = "User_upd";
            public const string Fech_upd = "Fech_upd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastreogps_tipoequipo] = _rastreogps_tipoequipo.ColumnNames.Idrastreogps_tipoequipo;
					ht[Tipo_equipo] = _rastreogps_tipoequipo.ColumnNames.Tipo_equipo;
					ht[Tipo_de_reporte] = _rastreogps_tipoequipo.ColumnNames.Tipo_de_reporte;
					ht[User_ins] = _rastreogps_tipoequipo.ColumnNames.User_ins;
					ht[Fech_ins] = _rastreogps_tipoequipo.ColumnNames.Fech_ins;
					ht[User_upd] = _rastreogps_tipoequipo.ColumnNames.User_upd;
					ht[Fech_upd] = _rastreogps_tipoequipo.ColumnNames.Fech_upd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastreogps_tipoequipo = "s_Idrastreogps_tipoequipo";
            public const string Tipo_equipo = "s_Tipo_equipo";
            public const string Tipo_de_reporte = "s_Tipo_de_reporte";
            public const string User_ins = "s_User_ins";
            public const string Fech_ins = "s_Fech_ins";
            public const string User_upd = "s_User_upd";
            public const string Fech_upd = "s_Fech_upd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Idrastreogps_tipoequipo
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreogps_tipoequipo);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreogps_tipoequipo, value);
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

		public virtual string Tipo_de_reporte
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tipo_de_reporte);
			}
			set
	        {
				base.Setstring(ColumnNames.Tipo_de_reporte, value);
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
	
		public virtual string s_Idrastreogps_tipoequipo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreogps_tipoequipo) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreogps_tipoequipo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreogps_tipoequipo);
				else
					this.Idrastreogps_tipoequipo = base.SetintAsString(ColumnNames.Idrastreogps_tipoequipo, value);
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

		public virtual string s_Tipo_de_reporte
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipo_de_reporte) ? string.Empty : base.GetstringAsString(ColumnNames.Tipo_de_reporte);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipo_de_reporte);
				else
					this.Tipo_de_reporte = base.SetstringAsString(ColumnNames.Tipo_de_reporte, value);
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
				
				
				public WhereParameter Idrastreogps_tipoequipo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreogps_tipoequipo, Parameters.Idrastreogps_tipoequipo);
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

				public WhereParameter Tipo_de_reporte
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipo_de_reporte, Parameters.Tipo_de_reporte);
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
		
			public WhereParameter Idrastreogps_tipoequipo
		    {
				get
		        {
					if(_Idrastreogps_tipoequipo_W == null)
	        	    {
						_Idrastreogps_tipoequipo_W = TearOff.Idrastreogps_tipoequipo;
					}
					return _Idrastreogps_tipoequipo_W;
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

			public WhereParameter Tipo_de_reporte
		    {
				get
		        {
					if(_Tipo_de_reporte_W == null)
	        	    {
						_Tipo_de_reporte_W = TearOff.Tipo_de_reporte;
					}
					return _Tipo_de_reporte_W;
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

			private WhereParameter _Idrastreogps_tipoequipo_W = null;
			private WhereParameter _Tipo_equipo_W = null;
			private WhereParameter _Tipo_de_reporte_W = null;
			private WhereParameter _User_ins_W = null;
			private WhereParameter _Fech_ins_W = null;
			private WhereParameter _User_upd_W = null;
			private WhereParameter _Fech_upd_W = null;

			public void WhereClauseReset()
			{
				_Idrastreogps_tipoequipo_W = null;
				_Tipo_equipo_W = null;
				_Tipo_de_reporte_W = null;
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
				
				
				public AggregateParameter Idrastreogps_tipoequipo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreogps_tipoequipo, Parameters.Idrastreogps_tipoequipo);
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

				public AggregateParameter Tipo_de_reporte
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_de_reporte, Parameters.Tipo_de_reporte);
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
		
			public AggregateParameter Idrastreogps_tipoequipo
		    {
				get
		        {
					if(_Idrastreogps_tipoequipo_W == null)
	        	    {
						_Idrastreogps_tipoequipo_W = TearOff.Idrastreogps_tipoequipo;
					}
					return _Idrastreogps_tipoequipo_W;
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

			public AggregateParameter Tipo_de_reporte
		    {
				get
		        {
					if(_Tipo_de_reporte_W == null)
	        	    {
						_Tipo_de_reporte_W = TearOff.Tipo_de_reporte;
					}
					return _Tipo_de_reporte_W;
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

			private AggregateParameter _Idrastreogps_tipoequipo_W = null;
			private AggregateParameter _Tipo_equipo_W = null;
			private AggregateParameter _Tipo_de_reporte_W = null;
			private AggregateParameter _User_ins_W = null;
			private AggregateParameter _Fech_ins_W = null;
			private AggregateParameter _User_upd_W = null;
			private AggregateParameter _Fech_upd_W = null;

			public void AggregateClauseReset()
			{
				_Idrastreogps_tipoequipo_W = null;
				_Tipo_equipo_W = null;
				_Tipo_de_reporte_W = null;
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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_tipoequipo_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.Idrastreogps_tipoequipo.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_tipoequipo_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreogps_tipoequipo_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastreogps_tipoequipo);
			p.SourceColumn = ColumnNames.Idrastreogps_tipoequipo;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastreogps_tipoequipo);
			p.SourceColumn = ColumnNames.Idrastreogps_tipoequipo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Tipo_equipo);
			p.SourceColumn = ColumnNames.Tipo_equipo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Tipo_de_reporte);
			p.SourceColumn = ColumnNames.Tipo_de_reporte;
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
