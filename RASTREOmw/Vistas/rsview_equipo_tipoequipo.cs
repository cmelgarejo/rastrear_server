/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rsview_equipo_tipoequipo para la vista rsview_equipo_tipoequipo.
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
	public class rsview_equipo_tipoequipo : PostgreSqlEntity
	{
		public rsview_equipo_tipoequipo(String laCadenaDeConexion)
		{
			this.QuerySource = "rsview_equipo_tipoequipo";
			this.MappingName = "rsview_equipo_tipoequipo";
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
			
			public static NpgsqlParameter Tipo_de_equipo
			{
				get
				{
					return new NpgsqlParameter("Tipo_de_equipo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Id_simcard
			{
				get
				{
					return new NpgsqlParameter("Id_simcard", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Sim_nro
			{
				get
				{
					return new NpgsqlParameter("Sim_nro", NpgsqlTypes.NpgsqlDbType.Varchar, 512);
				}
			}
			
			public static NpgsqlParameter Nro_serie_gps
			{
				get
				{
					return new NpgsqlParameter("Nro_serie_gps", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Identificador_rastreo = "identificador_rastreo";
            public const string Idrastreogps_equipogps = "idrastreogps_equipogps";
            public const string Id_equipo_gps = "id_equipo_gps";
            public const string Tipo_de_equipo = "tipo_de_equipo";
            public const string Id_simcard = "id_simcard";
            public const string Sim_nro = "sim_nro";
            public const string Nro_serie_gps = "nro_serie_gps";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Identificador_rastreo] = rsview_equipo_tipoequipo.PropertyNames.Identificador_rastreo;
					ht[Idrastreogps_equipogps] = rsview_equipo_tipoequipo.PropertyNames.Idrastreogps_equipogps;
					ht[Id_equipo_gps] = rsview_equipo_tipoequipo.PropertyNames.Id_equipo_gps;
					ht[Tipo_de_equipo] = rsview_equipo_tipoequipo.PropertyNames.Tipo_de_equipo;
					ht[Id_simcard] = rsview_equipo_tipoequipo.PropertyNames.Id_simcard;
					ht[Sim_nro] = rsview_equipo_tipoequipo.PropertyNames.Sim_nro;
					ht[Nro_serie_gps] = rsview_equipo_tipoequipo.PropertyNames.Nro_serie_gps;

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
            public const string Idrastreogps_equipogps = "Idrastreogps_equipogps";
            public const string Id_equipo_gps = "Id_equipo_gps";
            public const string Tipo_de_equipo = "Tipo_de_equipo";
            public const string Id_simcard = "Id_simcard";
            public const string Sim_nro = "Sim_nro";
            public const string Nro_serie_gps = "Nro_serie_gps";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Identificador_rastreo] = rsview_equipo_tipoequipo.ColumnNames.Identificador_rastreo;
					ht[Idrastreogps_equipogps] = rsview_equipo_tipoequipo.ColumnNames.Idrastreogps_equipogps;
					ht[Id_equipo_gps] = rsview_equipo_tipoequipo.ColumnNames.Id_equipo_gps;
					ht[Tipo_de_equipo] = rsview_equipo_tipoequipo.ColumnNames.Tipo_de_equipo;
					ht[Id_simcard] = rsview_equipo_tipoequipo.ColumnNames.Id_simcard;
					ht[Sim_nro] = rsview_equipo_tipoequipo.ColumnNames.Sim_nro;
					ht[Nro_serie_gps] = rsview_equipo_tipoequipo.ColumnNames.Nro_serie_gps;

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
            public const string Idrastreogps_equipogps = "s_Idrastreogps_equipogps";
            public const string Id_equipo_gps = "s_Id_equipo_gps";
            public const string Tipo_de_equipo = "s_Tipo_de_equipo";
            public const string Id_simcard = "s_Id_simcard";
            public const string Sim_nro = "s_Sim_nro";
            public const string Nro_serie_gps = "s_Nro_serie_gps";

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

		public virtual string Tipo_de_equipo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tipo_de_equipo);
			}
			set
	        {
				base.Setstring(ColumnNames.Tipo_de_equipo, value);
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

		public virtual string s_Tipo_de_equipo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipo_de_equipo) ? string.Empty : base.GetstringAsString(ColumnNames.Tipo_de_equipo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipo_de_equipo);
				else
					this.Tipo_de_equipo = base.SetstringAsString(ColumnNames.Tipo_de_equipo, value);
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

				public WhereParameter Tipo_de_equipo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipo_de_equipo, Parameters.Tipo_de_equipo);
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

				public WhereParameter Sim_nro
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sim_nro, Parameters.Sim_nro);
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

			public WhereParameter Tipo_de_equipo
		    {
				get
		        {
					if(_Tipo_de_equipo_W == null)
	        	    {
						_Tipo_de_equipo_W = TearOff.Tipo_de_equipo;
					}
					return _Tipo_de_equipo_W;
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

			private WhereParameter _Identificador_rastreo_W = null;
			private WhereParameter _Idrastreogps_equipogps_W = null;
			private WhereParameter _Id_equipo_gps_W = null;
			private WhereParameter _Tipo_de_equipo_W = null;
			private WhereParameter _Id_simcard_W = null;
			private WhereParameter _Sim_nro_W = null;
			private WhereParameter _Nro_serie_gps_W = null;

			public void WhereClauseReset()
			{
				_Identificador_rastreo_W = null;
				_Idrastreogps_equipogps_W = null;
				_Id_equipo_gps_W = null;
				_Tipo_de_equipo_W = null;
				_Id_simcard_W = null;
				_Sim_nro_W = null;
				_Nro_serie_gps_W = null;

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

				public AggregateParameter Tipo_de_equipo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipo_de_equipo, Parameters.Tipo_de_equipo);
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

				public AggregateParameter Sim_nro
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sim_nro, Parameters.Sim_nro);
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

			public AggregateParameter Tipo_de_equipo
		    {
				get
		        {
					if(_Tipo_de_equipo_W == null)
	        	    {
						_Tipo_de_equipo_W = TearOff.Tipo_de_equipo;
					}
					return _Tipo_de_equipo_W;
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

			private AggregateParameter _Identificador_rastreo_W = null;
			private AggregateParameter _Idrastreogps_equipogps_W = null;
			private AggregateParameter _Id_equipo_gps_W = null;
			private AggregateParameter _Tipo_de_equipo_W = null;
			private AggregateParameter _Id_simcard_W = null;
			private AggregateParameter _Sim_nro_W = null;
			private AggregateParameter _Nro_serie_gps_W = null;

			public void AggregateClauseReset()
			{
				_Identificador_rastreo_W = null;
				_Idrastreogps_equipogps_W = null;
				_Id_equipo_gps_W = null;
				_Tipo_de_equipo_W = null;
				_Id_simcard_W = null;
				_Sim_nro_W = null;
				_Nro_serie_gps_W = null;

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
