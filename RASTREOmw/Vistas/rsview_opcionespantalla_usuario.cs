/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rsview_opcionespantalla_usuario para la vista rsview_opcionespantalla_usuario.
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
	public class rsview_opcionespantalla_usuario : PostgreSqlEntity
	{
		public rsview_opcionespantalla_usuario(String laCadenaDeConexion)
		{
			this.QuerySource = "rsview_opcionespantalla_usuario";
			this.MappingName = "rsview_opcionespantalla_usuario";
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
			
			public static NpgsqlParameter Opcion_de_pantalla
			{
				get
				{
					return new NpgsqlParameter("Opcion_de_pantalla", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_usuario
			{
				get
				{
					return new NpgsqlParameter("Id_usuario", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Descripcion
			{
				get
				{
					return new NpgsqlParameter("Descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Opcion_de_pantalla = "opcion_de_pantalla";
            public const string Id_usuario = "id_usuario";
            public const string Descripcion = "descripcion";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Opcion_de_pantalla] = rsview_opcionespantalla_usuario.PropertyNames.Opcion_de_pantalla;
					ht[Id_usuario] = rsview_opcionespantalla_usuario.PropertyNames.Id_usuario;
					ht[Descripcion] = rsview_opcionespantalla_usuario.PropertyNames.Descripcion;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Opcion_de_pantalla = "Opcion_de_pantalla";
            public const string Id_usuario = "Id_usuario";
            public const string Descripcion = "Descripcion";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Opcion_de_pantalla] = rsview_opcionespantalla_usuario.ColumnNames.Opcion_de_pantalla;
					ht[Id_usuario] = rsview_opcionespantalla_usuario.ColumnNames.Id_usuario;
					ht[Descripcion] = rsview_opcionespantalla_usuario.ColumnNames.Descripcion;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Opcion_de_pantalla = "s_Opcion_de_pantalla";
            public const string Id_usuario = "s_Id_usuario";
            public const string Descripcion = "s_Descripcion";

		}
		#endregion	
		
		#region Properties
			public virtual int Opcion_de_pantalla
	    {
			get
	        {
				return base.Getint(ColumnNames.Opcion_de_pantalla);
			}
			set
	        {
				base.Setint(ColumnNames.Opcion_de_pantalla, value);
			}
		}

		public virtual int Id_usuario
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_usuario);
			}
			set
	        {
				base.Setint(ColumnNames.Id_usuario, value);
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


		#endregion
		
		#region String Properties
	
		public virtual string s_Opcion_de_pantalla
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Opcion_de_pantalla) ? string.Empty : base.GetintAsString(ColumnNames.Opcion_de_pantalla);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Opcion_de_pantalla);
				else
					this.Opcion_de_pantalla = base.SetintAsString(ColumnNames.Opcion_de_pantalla, value);
			}
		}

		public virtual string s_Id_usuario
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_usuario) ? string.Empty : base.GetintAsString(ColumnNames.Id_usuario);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_usuario);
				else
					this.Id_usuario = base.SetintAsString(ColumnNames.Id_usuario, value);
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
				
				
				public WhereParameter Opcion_de_pantalla
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Opcion_de_pantalla, Parameters.Opcion_de_pantalla);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_usuario
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_usuario, Parameters.Id_usuario);
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


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Opcion_de_pantalla
		    {
				get
		        {
					if(_Opcion_de_pantalla_W == null)
	        	    {
						_Opcion_de_pantalla_W = TearOff.Opcion_de_pantalla;
					}
					return _Opcion_de_pantalla_W;
				}
			}

			public WhereParameter Id_usuario
		    {
				get
		        {
					if(_Id_usuario_W == null)
	        	    {
						_Id_usuario_W = TearOff.Id_usuario;
					}
					return _Id_usuario_W;
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

			private WhereParameter _Opcion_de_pantalla_W = null;
			private WhereParameter _Id_usuario_W = null;
			private WhereParameter _Descripcion_W = null;

			public void WhereClauseReset()
			{
				_Opcion_de_pantalla_W = null;
				_Id_usuario_W = null;
				_Descripcion_W = null;

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
				
				
				public AggregateParameter Opcion_de_pantalla
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Opcion_de_pantalla, Parameters.Opcion_de_pantalla);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_usuario
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_usuario, Parameters.Id_usuario);
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


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Opcion_de_pantalla
		    {
				get
		        {
					if(_Opcion_de_pantalla_W == null)
	        	    {
						_Opcion_de_pantalla_W = TearOff.Opcion_de_pantalla;
					}
					return _Opcion_de_pantalla_W;
				}
			}

			public AggregateParameter Id_usuario
		    {
				get
		        {
					if(_Id_usuario_W == null)
	        	    {
						_Id_usuario_W = TearOff.Id_usuario;
					}
					return _Id_usuario_W;
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

			private AggregateParameter _Opcion_de_pantalla_W = null;
			private AggregateParameter _Id_usuario_W = null;
			private AggregateParameter _Descripcion_W = null;

			public void AggregateClauseReset()
			{
				_Opcion_de_pantalla_W = null;
				_Id_usuario_W = null;
				_Descripcion_W = null;

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
