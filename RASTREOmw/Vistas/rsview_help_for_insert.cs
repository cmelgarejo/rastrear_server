/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rsview_help_for_insert para la vista rsview_help_for_insert.
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
	public class rsview_help_for_insert : PostgreSqlEntity
	{
		public rsview_help_for_insert(String laCadenaDeConexion)
		{
			this.QuerySource = "rsview_help_for_insert";
			this.MappingName = "rsview_help_for_insert";
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
			
			public static NpgsqlParameter Idrastreo_vehiculo
			{
				get
				{
					return new NpgsqlParameter("Idrastreo_vehiculo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Idrastreogps_equipogps
			{
				get
				{
					return new NpgsqlParameter("Idrastreogps_equipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_equipo_gps
			{
				get
				{
					return new NpgsqlParameter("Id_equipo_gps", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Tipo_de_reporte
			{
				get
				{
					return new NpgsqlParameter("Tipo_de_reporte", NpgsqlTypes.NpgsqlDbType.Varchar, 64);
				}
			}
			
			public static NpgsqlParameter Tipo_equipo
			{
				get
				{
					return new NpgsqlParameter("Tipo_equipo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Identificador_rastreo = "identificador_rastreo";
            public const string Idrastreo_vehiculo = "idrastreo_vehiculo";
            public const string Idrastreogps_equipogps = "idrastreogps_equipogps";
            public const string Id_equipo_gps = "id_equipo_gps";
            public const string Tipo_de_reporte = "tipo_de_reporte";
            public const string Tipo_equipo = "tipo_equipo";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Identificador_rastreo] = rsview_help_for_insert.PropertyNames.Identificador_rastreo;
					ht[Idrastreo_vehiculo] = rsview_help_for_insert.PropertyNames.Idrastreo_vehiculo;
					ht[Idrastreogps_equipogps] = rsview_help_for_insert.PropertyNames.Idrastreogps_equipogps;
					ht[Id_equipo_gps] = rsview_help_for_insert.PropertyNames.Id_equipo_gps;
					ht[Tipo_de_reporte] = rsview_help_for_insert.PropertyNames.Tipo_de_reporte;
					ht[Tipo_equipo] = rsview_help_for_insert.PropertyNames.Tipo_equipo;

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
            public const string Idrastreo_vehiculo = "Idrastreo_vehiculo";
            public const string Idrastreogps_equipogps = "Idrastreogps_equipogps";
            public const string Id_equipo_gps = "Id_equipo_gps";
            public const string Tipo_de_reporte = "Tipo_de_reporte";
            public const string Tipo_equipo = "Tipo_equipo";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Identificador_rastreo] = rsview_help_for_insert.ColumnNames.Identificador_rastreo;
					ht[Idrastreo_vehiculo] = rsview_help_for_insert.ColumnNames.Idrastreo_vehiculo;
					ht[Idrastreogps_equipogps] = rsview_help_for_insert.ColumnNames.Idrastreogps_equipogps;
					ht[Id_equipo_gps] = rsview_help_for_insert.ColumnNames.Id_equipo_gps;
					ht[Tipo_de_reporte] = rsview_help_for_insert.ColumnNames.Tipo_de_reporte;
					ht[Tipo_equipo] = rsview_help_for_insert.ColumnNames.Tipo_equipo;

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
            public const string Idrastreo_vehiculo = "s_Idrastreo_vehiculo";
            public const string Idrastreogps_equipogps = "s_Idrastreogps_equipogps";
            public const string Id_equipo_gps = "s_Id_equipo_gps";
            public const string Tipo_de_reporte = "s_Tipo_de_reporte";
            public const string Tipo_equipo = "s_Tipo_equipo";

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

		public virtual int Idrastreo_vehiculo
	    {
			get
	        {
				return base.Getint(ColumnNames.Idrastreo_vehiculo);
			}
			set
	        {
				base.Setint(ColumnNames.Idrastreo_vehiculo, value);
			}
		}

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

		public virtual string s_Idrastreo_vehiculo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Idrastreo_vehiculo) ? string.Empty : base.GetintAsString(ColumnNames.Idrastreo_vehiculo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Idrastreo_vehiculo);
				else
					this.Idrastreo_vehiculo = base.SetintAsString(ColumnNames.Idrastreo_vehiculo, value);
			}
		}

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

				public WhereParameter Idrastreo_vehiculo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Idrastreo_vehiculo, Parameters.Idrastreo_vehiculo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
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

				public WhereParameter Id_equipo_gps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_equipo_gps, Parameters.Id_equipo_gps);
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

				public WhereParameter Tipo_equipo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipo_equipo, Parameters.Tipo_equipo);
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

			public WhereParameter Idrastreo_vehiculo
		    {
				get
		        {
					if(_Idrastreo_vehiculo_W == null)
	        	    {
						_Idrastreo_vehiculo_W = TearOff.Idrastreo_vehiculo;
					}
					return _Idrastreo_vehiculo_W;
				}
			}

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

			private WhereParameter _Identificador_rastreo_W = null;
			private WhereParameter _Idrastreo_vehiculo_W = null;
			private WhereParameter _Idrastreogps_equipogps_W = null;
			private WhereParameter _Id_equipo_gps_W = null;
			private WhereParameter _Tipo_de_reporte_W = null;
			private WhereParameter _Tipo_equipo_W = null;

			public void WhereClauseReset()
			{
				_Identificador_rastreo_W = null;
				_Idrastreo_vehiculo_W = null;
				_Idrastreogps_equipogps_W = null;
				_Id_equipo_gps_W = null;
				_Tipo_de_reporte_W = null;
				_Tipo_equipo_W = null;

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

				public AggregateParameter Idrastreo_vehiculo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Idrastreo_vehiculo, Parameters.Idrastreo_vehiculo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
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

				public AggregateParameter Id_equipo_gps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_equipo_gps, Parameters.Id_equipo_gps);
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

				public AggregateParameter Tipo_equipo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_equipo, Parameters.Tipo_equipo);
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

			public AggregateParameter Idrastreo_vehiculo
		    {
				get
		        {
					if(_Idrastreo_vehiculo_W == null)
	        	    {
						_Idrastreo_vehiculo_W = TearOff.Idrastreo_vehiculo;
					}
					return _Idrastreo_vehiculo_W;
				}
			}

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

			private AggregateParameter _Identificador_rastreo_W = null;
			private AggregateParameter _Idrastreo_vehiculo_W = null;
			private AggregateParameter _Idrastreogps_equipogps_W = null;
			private AggregateParameter _Id_equipo_gps_W = null;
			private AggregateParameter _Tipo_de_reporte_W = null;
			private AggregateParameter _Tipo_equipo_W = null;

			public void AggregateClauseReset()
			{
				_Identificador_rastreo_W = null;
				_Idrastreo_vehiculo_W = null;
				_Idrastreogps_equipogps_W = null;
				_Id_equipo_gps_W = null;
				_Tipo_de_reporte_W = null;
				_Tipo_equipo_W = null;

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
