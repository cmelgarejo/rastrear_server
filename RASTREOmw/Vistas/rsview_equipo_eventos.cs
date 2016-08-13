/*
'==============================================================================================================
'  Autor: CLrSoft de Christian Melgarejo.
'  Clase c# rsview_equipo_eventos para la vista rsview_equipo_eventos.
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
	public class rsview_equipo_eventos : PostgreSqlEntity
	{
		public rsview_equipo_eventos(String laCadenaDeConexion)
		{
			this.QuerySource = "rsview_equipo_eventos";
			this.MappingName = "rsview_equipo_eventos";
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
			
			public static NpgsqlParameter Id_rastreoequipogps
			{
				get
				{
					return new NpgsqlParameter("Id_rastreoequipogps", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Id_equipo_gps
			{
				get
				{
					return new NpgsqlParameter("Id_equipo_gps", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Id_tipoequipo
			{
				get
				{
					return new NpgsqlParameter("Id_tipoequipo", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Tipo_de_equipo
			{
				get
				{
					return new NpgsqlParameter("Tipo_de_equipo", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Id_tipoevento
			{
				get
				{
					return new NpgsqlParameter("Id_tipoevento", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter Evento
			{
				get
				{
					return new NpgsqlParameter("Evento", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
			public static NpgsqlParameter Tipoevento_evento
			{
				get
				{
					return new NpgsqlParameter("Tipoevento_evento", NpgsqlTypes.NpgsqlDbType.Varchar, 1024);
				}
			}
			
			public static NpgsqlParameter Evento_raw
			{
				get
				{
					return new NpgsqlParameter("Evento_raw", NpgsqlTypes.NpgsqlDbType.Varchar, 32);
				}
			}
			
			public static NpgsqlParameter Color_evento
			{
				get
				{
					return new NpgsqlParameter("Color_evento", NpgsqlTypes.NpgsqlDbType.Varchar, 16);
				}
			}
			
			public static NpgsqlParameter Habilitado
			{
				get
				{
					return new NpgsqlParameter("Habilitado", NpgsqlTypes.NpgsqlDbType.Boolean, 0);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Id_rastreoequipogps = "id_rastreoequipogps";
            public const string Id_equipo_gps = "id_equipo_gps";
            public const string Id_tipoequipo = "id_tipoequipo";
            public const string Tipo_de_equipo = "tipo_de_equipo";
            public const string Id_tipoevento = "id_tipoevento";
            public const string Evento = "evento";
            public const string Tipoevento_evento = "tipoevento_evento";
            public const string Evento_raw = "evento_raw";
            public const string Color_evento = "color_evento";
            public const string Habilitado = "habilitado";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_rastreoequipogps] = rsview_equipo_eventos.PropertyNames.Id_rastreoequipogps;
					ht[Id_equipo_gps] = rsview_equipo_eventos.PropertyNames.Id_equipo_gps;
					ht[Id_tipoequipo] = rsview_equipo_eventos.PropertyNames.Id_tipoequipo;
					ht[Tipo_de_equipo] = rsview_equipo_eventos.PropertyNames.Tipo_de_equipo;
					ht[Id_tipoevento] = rsview_equipo_eventos.PropertyNames.Id_tipoevento;
					ht[Evento] = rsview_equipo_eventos.PropertyNames.Evento;
					ht[Tipoevento_evento] = rsview_equipo_eventos.PropertyNames.Tipoevento_evento;
					ht[Evento_raw] = rsview_equipo_eventos.PropertyNames.Evento_raw;
					ht[Color_evento] = rsview_equipo_eventos.PropertyNames.Color_evento;
					ht[Habilitado] = rsview_equipo_eventos.PropertyNames.Habilitado;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Id_rastreoequipogps = "Id_rastreoequipogps";
            public const string Id_equipo_gps = "Id_equipo_gps";
            public const string Id_tipoequipo = "Id_tipoequipo";
            public const string Tipo_de_equipo = "Tipo_de_equipo";
            public const string Id_tipoevento = "Id_tipoevento";
            public const string Evento = "Evento";
            public const string Tipoevento_evento = "Tipoevento_evento";
            public const string Evento_raw = "Evento_raw";
            public const string Color_evento = "Color_evento";
            public const string Habilitado = "Habilitado";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_rastreoequipogps] = rsview_equipo_eventos.ColumnNames.Id_rastreoequipogps;
					ht[Id_equipo_gps] = rsview_equipo_eventos.ColumnNames.Id_equipo_gps;
					ht[Id_tipoequipo] = rsview_equipo_eventos.ColumnNames.Id_tipoequipo;
					ht[Tipo_de_equipo] = rsview_equipo_eventos.ColumnNames.Tipo_de_equipo;
					ht[Id_tipoevento] = rsview_equipo_eventos.ColumnNames.Id_tipoevento;
					ht[Evento] = rsview_equipo_eventos.ColumnNames.Evento;
					ht[Tipoevento_evento] = rsview_equipo_eventos.ColumnNames.Tipoevento_evento;
					ht[Evento_raw] = rsview_equipo_eventos.ColumnNames.Evento_raw;
					ht[Color_evento] = rsview_equipo_eventos.ColumnNames.Color_evento;
					ht[Habilitado] = rsview_equipo_eventos.ColumnNames.Habilitado;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Id_rastreoequipogps = "s_Id_rastreoequipogps";
            public const string Id_equipo_gps = "s_Id_equipo_gps";
            public const string Id_tipoequipo = "s_Id_tipoequipo";
            public const string Tipo_de_equipo = "s_Tipo_de_equipo";
            public const string Id_tipoevento = "s_Id_tipoevento";
            public const string Evento = "s_Evento";
            public const string Tipoevento_evento = "s_Tipoevento_evento";
            public const string Evento_raw = "s_Evento_raw";
            public const string Color_evento = "s_Color_evento";
            public const string Habilitado = "s_Habilitado";

		}
		#endregion	
		
		#region Properties
			public virtual int Id_rastreoequipogps
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_rastreoequipogps);
			}
			set
	        {
				base.Setint(ColumnNames.Id_rastreoequipogps, value);
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

		public virtual int Id_tipoevento
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_tipoevento);
			}
			set
	        {
				base.Setint(ColumnNames.Id_tipoevento, value);
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

		public virtual string Tipoevento_evento
	    {
			get
	        {
				return base.Getstring(ColumnNames.Tipoevento_evento);
			}
			set
	        {
				base.Setstring(ColumnNames.Tipoevento_evento, value);
			}
		}

		public virtual string Evento_raw
	    {
			get
	        {
				return base.Getstring(ColumnNames.Evento_raw);
			}
			set
	        {
				base.Setstring(ColumnNames.Evento_raw, value);
			}
		}

		public virtual string Color_evento
	    {
			get
	        {
				return base.Getstring(ColumnNames.Color_evento);
			}
			set
	        {
				base.Setstring(ColumnNames.Color_evento, value);
			}
		}

		public virtual bool Habilitado
	    {
			get
	        {
				return base.Getbool(ColumnNames.Habilitado);
			}
			set
	        {
				base.Setbool(ColumnNames.Habilitado, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Id_rastreoequipogps
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_rastreoequipogps) ? string.Empty : base.GetintAsString(ColumnNames.Id_rastreoequipogps);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_rastreoequipogps);
				else
					this.Id_rastreoequipogps = base.SetintAsString(ColumnNames.Id_rastreoequipogps, value);
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

		public virtual string s_Id_tipoevento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_tipoevento) ? string.Empty : base.GetintAsString(ColumnNames.Id_tipoevento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_tipoevento);
				else
					this.Id_tipoevento = base.SetintAsString(ColumnNames.Id_tipoevento, value);
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

		public virtual string s_Tipoevento_evento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Tipoevento_evento) ? string.Empty : base.GetstringAsString(ColumnNames.Tipoevento_evento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Tipoevento_evento);
				else
					this.Tipoevento_evento = base.SetstringAsString(ColumnNames.Tipoevento_evento, value);
			}
		}

		public virtual string s_Evento_raw
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Evento_raw) ? string.Empty : base.GetstringAsString(ColumnNames.Evento_raw);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Evento_raw);
				else
					this.Evento_raw = base.SetstringAsString(ColumnNames.Evento_raw, value);
			}
		}

		public virtual string s_Color_evento
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Color_evento) ? string.Empty : base.GetstringAsString(ColumnNames.Color_evento);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Color_evento);
				else
					this.Color_evento = base.SetstringAsString(ColumnNames.Color_evento, value);
			}
		}

		public virtual string s_Habilitado
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Habilitado) ? string.Empty : base.GetboolAsString(ColumnNames.Habilitado);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Habilitado);
				else
					this.Habilitado = base.SetboolAsString(ColumnNames.Habilitado, value);
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
				
				
				public WhereParameter Id_rastreoequipogps
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_rastreoequipogps, Parameters.Id_rastreoequipogps);
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

				public WhereParameter Id_tipoequipo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_tipoequipo, Parameters.Id_tipoequipo);
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

				public WhereParameter Id_tipoevento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_tipoevento, Parameters.Id_tipoevento);
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

				public WhereParameter Tipoevento_evento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Tipoevento_evento, Parameters.Tipoevento_evento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Evento_raw
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Evento_raw, Parameters.Evento_raw);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Color_evento
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Color_evento, Parameters.Color_evento);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Habilitado
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Habilitado, Parameters.Habilitado);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Id_rastreoequipogps
		    {
				get
		        {
					if(_Id_rastreoequipogps_W == null)
	        	    {
						_Id_rastreoequipogps_W = TearOff.Id_rastreoequipogps;
					}
					return _Id_rastreoequipogps_W;
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

			public WhereParameter Id_tipoevento
		    {
				get
		        {
					if(_Id_tipoevento_W == null)
	        	    {
						_Id_tipoevento_W = TearOff.Id_tipoevento;
					}
					return _Id_tipoevento_W;
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

			public WhereParameter Tipoevento_evento
		    {
				get
		        {
					if(_Tipoevento_evento_W == null)
	        	    {
						_Tipoevento_evento_W = TearOff.Tipoevento_evento;
					}
					return _Tipoevento_evento_W;
				}
			}

			public WhereParameter Evento_raw
		    {
				get
		        {
					if(_Evento_raw_W == null)
	        	    {
						_Evento_raw_W = TearOff.Evento_raw;
					}
					return _Evento_raw_W;
				}
			}

			public WhereParameter Color_evento
		    {
				get
		        {
					if(_Color_evento_W == null)
	        	    {
						_Color_evento_W = TearOff.Color_evento;
					}
					return _Color_evento_W;
				}
			}

			public WhereParameter Habilitado
		    {
				get
		        {
					if(_Habilitado_W == null)
	        	    {
						_Habilitado_W = TearOff.Habilitado;
					}
					return _Habilitado_W;
				}
			}

			private WhereParameter _Id_rastreoequipogps_W = null;
			private WhereParameter _Id_equipo_gps_W = null;
			private WhereParameter _Id_tipoequipo_W = null;
			private WhereParameter _Tipo_de_equipo_W = null;
			private WhereParameter _Id_tipoevento_W = null;
			private WhereParameter _Evento_W = null;
			private WhereParameter _Tipoevento_evento_W = null;
			private WhereParameter _Evento_raw_W = null;
			private WhereParameter _Color_evento_W = null;
			private WhereParameter _Habilitado_W = null;

			public void WhereClauseReset()
			{
				_Id_rastreoequipogps_W = null;
				_Id_equipo_gps_W = null;
				_Id_tipoequipo_W = null;
				_Tipo_de_equipo_W = null;
				_Id_tipoevento_W = null;
				_Evento_W = null;
				_Tipoevento_evento_W = null;
				_Evento_raw_W = null;
				_Color_evento_W = null;
				_Habilitado_W = null;

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
				
				
				public AggregateParameter Id_rastreoequipogps
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_rastreoequipogps, Parameters.Id_rastreoequipogps);
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

				public AggregateParameter Id_tipoequipo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_tipoequipo, Parameters.Id_tipoequipo);
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

				public AggregateParameter Id_tipoevento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_tipoevento, Parameters.Id_tipoevento);
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

				public AggregateParameter Tipoevento_evento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Tipoevento_evento, Parameters.Tipoevento_evento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Evento_raw
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Evento_raw, Parameters.Evento_raw);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Color_evento
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Color_evento, Parameters.Color_evento);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Habilitado
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Habilitado, Parameters.Habilitado);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Id_rastreoequipogps
		    {
				get
		        {
					if(_Id_rastreoequipogps_W == null)
	        	    {
						_Id_rastreoequipogps_W = TearOff.Id_rastreoequipogps;
					}
					return _Id_rastreoequipogps_W;
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

			public AggregateParameter Id_tipoevento
		    {
				get
		        {
					if(_Id_tipoevento_W == null)
	        	    {
						_Id_tipoevento_W = TearOff.Id_tipoevento;
					}
					return _Id_tipoevento_W;
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

			public AggregateParameter Tipoevento_evento
		    {
				get
		        {
					if(_Tipoevento_evento_W == null)
	        	    {
						_Tipoevento_evento_W = TearOff.Tipoevento_evento;
					}
					return _Tipoevento_evento_W;
				}
			}

			public AggregateParameter Evento_raw
		    {
				get
		        {
					if(_Evento_raw_W == null)
	        	    {
						_Evento_raw_W = TearOff.Evento_raw;
					}
					return _Evento_raw_W;
				}
			}

			public AggregateParameter Color_evento
		    {
				get
		        {
					if(_Color_evento_W == null)
	        	    {
						_Color_evento_W = TearOff.Color_evento;
					}
					return _Color_evento_W;
				}
			}

			public AggregateParameter Habilitado
		    {
				get
		        {
					if(_Habilitado_W == null)
	        	    {
						_Habilitado_W = TearOff.Habilitado;
					}
					return _Habilitado_W;
				}
			}

			private AggregateParameter _Id_rastreoequipogps_W = null;
			private AggregateParameter _Id_equipo_gps_W = null;
			private AggregateParameter _Id_tipoequipo_W = null;
			private AggregateParameter _Tipo_de_equipo_W = null;
			private AggregateParameter _Id_tipoevento_W = null;
			private AggregateParameter _Evento_W = null;
			private AggregateParameter _Tipoevento_evento_W = null;
			private AggregateParameter _Evento_raw_W = null;
			private AggregateParameter _Color_evento_W = null;
			private AggregateParameter _Habilitado_W = null;

			public void AggregateClauseReset()
			{
				_Id_rastreoequipogps_W = null;
				_Id_equipo_gps_W = null;
				_Id_tipoequipo_W = null;
				_Tipo_de_equipo_W = null;
				_Id_tipoevento_W = null;
				_Evento_W = null;
				_Tipoevento_evento_W = null;
				_Evento_raw_W = null;
				_Color_evento_W = null;
				_Habilitado_W = null;

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
