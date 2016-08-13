
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_check.
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
	public abstract class _rastreo_check : PostgreSqlEntity
	{
		public _rastreo_check()
		{
			this.QuerySource = "rastreo_check";
			this.MappingName = "rastreo_check";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_check_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(string Idrastrear)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Idrastrear, Idrastrear);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_check_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter Idrastrear
			{
				get
				{
					return new NpgsqlParameter("Idrastrear", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Cur_km
			{
				get
				{
					return new NpgsqlParameter("Cur_km", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Check_km
			{
				get
				{
					return new NpgsqlParameter("Check_km", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Checked
			{
				get
				{
					return new NpgsqlParameter("Checked", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Idrastrear = "idrastrear";
            public const string Cur_km = "cur_km";
            public const string Check_km = "check_km";
            public const string Checked = "checked";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastrear] = _rastreo_check.PropertyNames.Idrastrear;
					ht[Cur_km] = _rastreo_check.PropertyNames.Cur_km;
					ht[Check_km] = _rastreo_check.PropertyNames.Check_km;
					ht[Checked] = _rastreo_check.PropertyNames.Checked;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Idrastrear = "Idrastrear";
            public const string Cur_km = "Cur_km";
            public const string Check_km = "Check_km";
            public const string Checked = "Checked";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Idrastrear] = _rastreo_check.ColumnNames.Idrastrear;
					ht[Cur_km] = _rastreo_check.ColumnNames.Cur_km;
					ht[Check_km] = _rastreo_check.ColumnNames.Check_km;
					ht[Checked] = _rastreo_check.ColumnNames.Checked;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Idrastrear = "s_Idrastrear";
            public const string Cur_km = "s_Cur_km";
            public const string Check_km = "s_Check_km";
            public const string Checked = "s_Checked";

		}
		#endregion		
		
		#region Properties
	
		public virtual string Idrastrear
	    {
			get
	        {
				return base.Getstring(ColumnNames.Idrastrear);
			}
			set
	        {
				base.Setstring(ColumnNames.Idrastrear, value);
			}
		}

		public virtual int Cur_km
	    {
			get
	        {
				return base.Getint(ColumnNames.Cur_km);
			}
			set
	        {
				base.Setint(ColumnNames.Cur_km, value);
			}
		}

		public virtual int Check_km
	    {
			get
	        {
				return base.Getint(ColumnNames.Check_km);
			}
			set
	        {
				base.Setint(ColumnNames.Check_km, value);
			}
		}

		public virtual bool Checked
	    {
			get
	        {
				return base.Getbool(ColumnNames.Checked);
			}
			set
	        {
				base.Setbool(ColumnNames.Checked, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Idrastrear
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastrear) ? string.Empty : base.GetstringAsString(ColumnNames.Idrastrear);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastrear);
				else
					this.Idrastrear = base.SetstringAsString(ColumnNames.Idrastrear, value);
			}
		}

		public virtual string s_Cur_km
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Cur_km) ? string.Empty : base.GetintAsString(ColumnNames.Cur_km);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Cur_km);
				else
					this.Cur_km = base.SetintAsString(ColumnNames.Cur_km, value);
			}
		}

		public virtual string s_Check_km
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Check_km) ? string.Empty : base.GetintAsString(ColumnNames.Check_km);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Check_km);
				else
					this.Check_km = base.SetintAsString(ColumnNames.Check_km, value);
			}
		}

		public virtual string s_Checked
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Checked) ? string.Empty : base.GetboolAsString(ColumnNames.Checked);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Checked);
				else
					this.Checked = base.SetboolAsString(ColumnNames.Checked, value);
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
				
				
				public WhereParameter Idrastrear
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastrear, Parameters.Idrastrear);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Cur_km
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Cur_km, Parameters.Cur_km);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Check_km
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Check_km, Parameters.Check_km);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Checked
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Checked, Parameters.Checked);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Idrastrear
		    {
				get
		        {
					if(_Idrastrear_W == null)
	        	    {
						_Idrastrear_W = TearOff.Idrastrear;
					}
					return _Idrastrear_W;
				}
			}

			public WhereParameter Cur_km
		    {
				get
		        {
					if(_Cur_km_W == null)
	        	    {
						_Cur_km_W = TearOff.Cur_km;
					}
					return _Cur_km_W;
				}
			}

			public WhereParameter Check_km
		    {
				get
		        {
					if(_Check_km_W == null)
	        	    {
						_Check_km_W = TearOff.Check_km;
					}
					return _Check_km_W;
				}
			}

			public WhereParameter Checked
		    {
				get
		        {
					if(_Checked_W == null)
	        	    {
						_Checked_W = TearOff.Checked;
					}
					return _Checked_W;
				}
			}

			private WhereParameter _Idrastrear_W = null;
			private WhereParameter _Cur_km_W = null;
			private WhereParameter _Check_km_W = null;
			private WhereParameter _Checked_W = null;

			public void WhereClauseReset()
			{
				_Idrastrear_W = null;
				_Cur_km_W = null;
				_Check_km_W = null;
				_Checked_W = null;

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
				
				
				public AggregateParameter Idrastrear
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastrear, Parameters.Idrastrear);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Cur_km
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Cur_km, Parameters.Cur_km);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Check_km
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Check_km, Parameters.Check_km);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Checked
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Checked, Parameters.Checked);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Idrastrear
		    {
				get
		        {
					if(_Idrastrear_W == null)
	        	    {
						_Idrastrear_W = TearOff.Idrastrear;
					}
					return _Idrastrear_W;
				}
			}

			public AggregateParameter Cur_km
		    {
				get
		        {
					if(_Cur_km_W == null)
	        	    {
						_Cur_km_W = TearOff.Cur_km;
					}
					return _Cur_km_W;
				}
			}

			public AggregateParameter Check_km
		    {
				get
		        {
					if(_Check_km_W == null)
	        	    {
						_Check_km_W = TearOff.Check_km;
					}
					return _Check_km_W;
				}
			}

			public AggregateParameter Checked
		    {
				get
		        {
					if(_Checked_W == null)
	        	    {
						_Checked_W = TearOff.Checked;
					}
					return _Checked_W;
				}
			}

			private AggregateParameter _Idrastrear_W = null;
			private AggregateParameter _Cur_km_W = null;
			private AggregateParameter _Check_km_W = null;
			private AggregateParameter _Checked_W = null;

			public void AggregateClauseReset()
			{
				_Idrastrear_W = null;
				_Cur_km_W = null;
				_Check_km_W = null;
				_Checked_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_check_insert";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_check_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_check_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Idrastrear);
			p.SourceColumn = ColumnNames.Idrastrear;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Idrastrear);
			p.SourceColumn = ColumnNames.Idrastrear;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Cur_km);
			p.SourceColumn = ColumnNames.Cur_km;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Check_km);
			p.SourceColumn = ColumnNames.Check_km;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Checked);
			p.SourceColumn = ColumnNames.Checked;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
