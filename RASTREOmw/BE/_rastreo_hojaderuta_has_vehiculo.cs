
/*
'===============================================================================
'  Autor: CLrSoft de Christian Melgarejo
'  Clase que implementa una business entity para la tabla rastreo_hojaderuta_has_vehiculo.
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
	public abstract class _rastreo_hojaderuta_has_vehiculo : PostgreSqlEntity
	{
		public _rastreo_hojaderuta_has_vehiculo()
		{
			this.QuerySource = "rastreo_hojaderuta_has_vehiculo";
			this.MappingName = "rastreo_hojaderuta_has_vehiculo";

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
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_hojaderuta_has_vehiculo_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Id_cliente, int Id_vehiculo, int Idhoja_de_ruta)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Id_cliente, Id_cliente);

parameters.Add(Parameters.Id_vehiculo, Id_vehiculo);

parameters.Add(Parameters.Idhoja_de_ruta, Idhoja_de_ruta);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "rastreo_hojaderuta_has_vehiculo_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
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
			
			public static NpgsqlParameter Idhoja_de_ruta
			{
				get
				{
					return new NpgsqlParameter("Idhoja_de_ruta", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Id_cliente = "id_cliente";
            public const string Id_vehiculo = "id_vehiculo";
            public const string Idhoja_de_ruta = "idhoja_de_ruta";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_cliente] = _rastreo_hojaderuta_has_vehiculo.PropertyNames.Id_cliente;
					ht[Id_vehiculo] = _rastreo_hojaderuta_has_vehiculo.PropertyNames.Id_vehiculo;
					ht[Idhoja_de_ruta] = _rastreo_hojaderuta_has_vehiculo.PropertyNames.Idhoja_de_ruta;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Id_cliente = "Id_cliente";
            public const string Id_vehiculo = "Id_vehiculo";
            public const string Idhoja_de_ruta = "Idhoja_de_ruta";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_cliente] = _rastreo_hojaderuta_has_vehiculo.ColumnNames.Id_cliente;
					ht[Id_vehiculo] = _rastreo_hojaderuta_has_vehiculo.ColumnNames.Id_vehiculo;
					ht[Idhoja_de_ruta] = _rastreo_hojaderuta_has_vehiculo.ColumnNames.Idhoja_de_ruta;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Id_cliente = "s_Id_cliente";
            public const string Id_vehiculo = "s_Id_vehiculo";
            public const string Idhoja_de_ruta = "s_Idhoja_de_ruta";

		}
		#endregion		
		
		#region Properties
	
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

		public virtual int Idhoja_de_ruta
	    {
			get
	        {
				return base.Getint(ColumnNames.Idhoja_de_ruta);
			}
			set
	        {
				base.Setint(ColumnNames.Idhoja_de_ruta, value);
			}
		}


		#endregion
		
		#region String Properties
	
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

		public virtual string s_Idhoja_de_ruta
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idhoja_de_ruta) ? string.Empty : base.GetintAsString(ColumnNames.Idhoja_de_ruta);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idhoja_de_ruta);
				else
					this.Idhoja_de_ruta = base.SetintAsString(ColumnNames.Idhoja_de_ruta, value);
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

				public WhereParameter Idhoja_de_ruta
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idhoja_de_ruta, Parameters.Idhoja_de_ruta);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
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

			public WhereParameter Idhoja_de_ruta
		    {
				get
		        {
					if(_Idhoja_de_ruta_W == null)
	        	    {
						_Idhoja_de_ruta_W = TearOff.Idhoja_de_ruta;
					}
					return _Idhoja_de_ruta_W;
				}
			}

			private WhereParameter _Id_cliente_W = null;
			private WhereParameter _Id_vehiculo_W = null;
			private WhereParameter _Idhoja_de_ruta_W = null;

			public void WhereClauseReset()
			{
				_Id_cliente_W = null;
				_Id_vehiculo_W = null;
				_Idhoja_de_ruta_W = null;

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

				public AggregateParameter Idhoja_de_ruta
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idhoja_de_ruta, Parameters.Idhoja_de_ruta);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
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

			public AggregateParameter Idhoja_de_ruta
		    {
				get
		        {
					if(_Idhoja_de_ruta_W == null)
	        	    {
						_Idhoja_de_ruta_W = TearOff.Idhoja_de_ruta;
					}
					return _Idhoja_de_ruta_W;
				}
			}

			private AggregateParameter _Id_cliente_W = null;
			private AggregateParameter _Id_vehiculo_W = null;
			private AggregateParameter _Idhoja_de_ruta_W = null;

			public void AggregateClauseReset()
			{
				_Id_cliente_W = null;
				_Id_vehiculo_W = null;
				_Idhoja_de_ruta_W = null;

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
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_hojaderuta_has_vehiculo_insert";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_hojaderuta_has_vehiculo_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "rastreo_hojaderuta_has_vehiculo_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.Id_cliente);
			p.SourceColumn = ColumnNames.Id_cliente;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_vehiculo);
			p.SourceColumn = ColumnNames.Id_vehiculo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Idhoja_de_ruta);
			p.SourceColumn = ColumnNames.Idhoja_de_ruta;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Id_cliente);
			p.SourceColumn = ColumnNames.Id_cliente;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_vehiculo);
			p.SourceColumn = ColumnNames.Id_vehiculo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Idhoja_de_ruta);
			p.SourceColumn = ColumnNames.Idhoja_de_ruta;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
